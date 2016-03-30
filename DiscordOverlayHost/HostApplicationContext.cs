using System;
using System.Windows.Forms;
using DiscordOverlayHost.TrayNotification;
using System.Diagnostics;
using System.Drawing;

namespace DiscordOverlayHost
{
    public class HostApplicationContext : ApplicationContext
    {
        private ConfigUIForm configForm;

        private Process glProcess;
        private Process dxProcess;
        
        private TrayNotificationManager trayNotification;

        public bool IsClosing { get; private set; }

        public HostApplicationContext()
        {
            trayNotification = new TrayNotificationManager();
            trayNotification.ConfigurationClick += TrayNotification_ConfigurationClick;
            trayNotification.OpenGLClick += TrayNotification_OpenGLClick;
            trayNotification.DirectXClick += TrayNotification_DirectXClick;
            trayNotification.QuitClick += TrayNotification_QuitClick;

            if (Properties.Settings.Default.ShowSettingsOnStart)
            {
                RunConfigurationForm();
            }
            if (Properties.Settings.Default.AutoStartOpenGL)
            {
                RunOpenGLHost();
            }
            if (Properties.Settings.Default.AutoStartDirectX)
            {
                RunDirectXHost();
            }
        }

        private void TrayNotification_ConfigurationClick(object sender, EventArgs e)
        {
            RunConfigurationForm();
        }

        private void TrayNotification_OpenGLClick(object sender, EventArgs e)
        {
            RunOpenGLHost();
        }

        private void TrayNotification_DirectXClick(object sender, EventArgs e)
        {
            RunDirectXHost();
        }

        private void TrayNotification_QuitClick(object sender, EventArgs e)
        {
            CloseContext();
        }

        internal void RunConfigurationForm()
        {
            if (configForm != null && !configForm.IsDisposed)
            {
                configForm.Show();
                configForm.BringToFront();
            }
            else
            {
                configForm = new ConfigUIForm(this);
                configForm.FormClosed += ConfigForm_FormClosed;
                configForm.Disposed += ConfigForm_Disposed;
                configForm.Show();
            }
        }

        internal void RunOpenGLHost()
        {
            try
            {
                //If already running bring to front
                if (glProcess != null && !glProcess.HasExited)
                {
                    Win32.NativeMethods.SetForegroundWindow(glProcess.MainWindowHandle);
                    Win32.NativeMethods.ShowWindow(glProcess.MainWindowHandle, Win32.NativeMethods.ShowWindowOptions.SW_RESTORE);
                    return;
                }

                //Create new process
                glProcess = Process.Start(@".\Hosts\OpenGlHost.exe");
                glProcess.EnableRaisingEvents = true;
                glProcess.Exited += Process_Exited;
                glProcess.WaitForInputIdle();
                Rectangle screenBounds = Screen.FromHandle(glProcess.MainWindowHandle).Bounds;
                Win32.NativeMethods.SetWindowPos(glProcess.MainWindowHandle,
                                            (configForm != null && configForm.Visible) ? configForm.Handle : (IntPtr)Win32.NativeMethods.SpecialWindowHandles.HWND_TOP,
                                            (screenBounds.Width / 2) - 350, //Place window left of center screen;
                                            (screenBounds.Height - 450) / 2, //Place window center height of screen;
                                            0,
                                            0,
                                            Win32.NativeMethods.SetWindowPosFlags.SWP_NOSIZE);
                trayNotification.SetOpenGlStatus(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("There was an error opening the OpenGL Host window:\r\n{0}", ex.Message), "Discord Overlay Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void RunDirectXHost()
        {
            try
            {
                //If already running bring to front
                if (dxProcess != null && !dxProcess.HasExited)
                {
                    Win32.NativeMethods.SetForegroundWindow(dxProcess.MainWindowHandle);
                    Win32.NativeMethods.ShowWindow(dxProcess.MainWindowHandle, Win32.NativeMethods.ShowWindowOptions.SW_RESTORE);
                    return;
                }

                //Create new process
                dxProcess = Process.Start(@".\Hosts\DirectXHost.exe");
                dxProcess.EnableRaisingEvents = true;
                dxProcess.Exited += Process_Exited;
                dxProcess.WaitForInputIdle();
                Rectangle screenBounds = Screen.FromHandle(dxProcess.MainWindowHandle).Bounds;
                Win32.NativeMethods.SetWindowPos(dxProcess.MainWindowHandle,
                                            (configForm != null && configForm.Visible) ? configForm.Handle : (IntPtr)Win32.NativeMethods.SpecialWindowHandles.HWND_TOP,
                                            (screenBounds.Width / 2), //Place window right of center screen;
                                            (screenBounds.Height - 450) / 2, //Place window center height of screen;
                                            0,
                                            0,
                                            Win32.NativeMethods.SetWindowPosFlags.SWP_NOSIZE);
                Win32.NativeMethods.SetForegroundWindow(dxProcess.MainWindowHandle);
                trayNotification.SetDirectXStatus(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("There was an error opening the DirectX Host window:\r\n{0}", ex.Message), "Discord Overlay Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            Process process = sender as Process;
            if (process != null)
                process.Exited -= Process_Exited;

            if (glProcess == null || glProcess.HasExited)
                trayNotification.SetOpenGlStatus(false);
            if (dxProcess == null || dxProcess.HasExited)
                trayNotification.SetDirectXStatus(false);

            CheckCloseContext();
        }

        private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = sender as Form;
            form.Dispose();
        }
        private void ConfigForm_Disposed(object sender, EventArgs e)
        {
            CheckCloseContext();
        }

        private void CheckCloseContext()
        {
            if (IsClosing) return;

            if (!Properties.Settings.Default.AutoCloseManager)
            {
                return;
            }

            if (configForm != null && configForm.Created && configForm.Visible) return;

            if (glProcess != null && !glProcess.HasExited) return;

            if (dxProcess != null && !dxProcess.HasExited) return;

            CloseContext();
        }

        internal void CloseContext()
        {
            IsClosing = true;
            try
            {
                if (configForm != null && !configForm.IsDisposed)
                {
                    if (configForm.IsHandleCreated)
                        configForm.Close();
                }

                if (glProcess != null && !glProcess.HasExited)
                {
                    glProcess.CloseMainWindow();
                    if (!glProcess.WaitForExit(3000))
                    {
                        glProcess.Close();
                    }
                }

                if (dxProcess != null && !dxProcess.HasExited)
                {
                    dxProcess.CloseMainWindow();
                    if (!dxProcess.WaitForExit(3000))
                    {
                        dxProcess.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
            ExitThread();
        }

        protected override void Dispose(bool disposing)
        {
            trayNotification.Dispose();
            if (configForm != null && !configForm.IsDisposed)
            {
                configForm.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
