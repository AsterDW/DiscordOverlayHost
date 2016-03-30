using System;
using System.Windows.Forms;

namespace DiscordOverlayHost.TrayNotification
{
    public class TrayNotificationManager: IDisposable
    {
        private NotifyIcon notifyIcon;

        public bool IsDisposed { get; private set; }

        public event EventHandler ConfigurationClick;
        public event EventHandler OpenGLClick;
        public event EventHandler DirectXClick;
        public event EventHandler QuitClick;

        public TrayNotificationManager()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = Properties.Resources.AppIcon;
            notifyIcon.ContextMenuStrip = GetMenuStrip();
            notifyIcon.Text = "Discord Overlay Host";
            
            notifyIcon.Visible = true;
        }

        private ContextMenuStrip GetMenuStrip()
        {
            ContextMenuStrip notificationMenu = new ContextMenuStrip();
            ToolStripMenuItem configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem("Configuration");
            configurationToolStripMenuItem.Name = "Config";
            configurationToolStripMenuItem.Click += new EventHandler(ConfigurationClicked);

            ToolStripSeparator toolStripSeparator1 = new ToolStripSeparator();
            ToolStripMenuItem openGLtoolStripMenuItem = new ToolStripMenuItem("OpenGL Host");
            openGLtoolStripMenuItem.Name = "OpenGL";
            openGLtoolStripMenuItem.Click += OpenGLClicked;

            ToolStripMenuItem directXtoolStripMenuItem = new ToolStripMenuItem("DirectX Host");
            directXtoolStripMenuItem.Name = "DirectX";
            directXtoolStripMenuItem.Click += DirectXClicked;

            ToolStripSeparator toolStripSeparator2 = new ToolStripSeparator();
            ToolStripMenuItem closeToolStripMenuItem = new ToolStripMenuItem("Quit Overlay Host");
            closeToolStripMenuItem.Name = "Quit";
            closeToolStripMenuItem.Click += CloseClicked;

            notificationMenu.Items.AddRange( new ToolStripItem[] {
            configurationToolStripMenuItem,
            toolStripSeparator1,
            openGLtoolStripMenuItem,
            directXtoolStripMenuItem,
            toolStripSeparator2,
            closeToolStripMenuItem});

            return notificationMenu;
        }

        public void SetOpenGlStatus(bool isChecked)
        {
            if (notifyIcon.ContextMenuStrip.InvokeRequired)
            {
                notifyIcon.ContextMenuStrip.Invoke((MethodInvoker)delegate { SetOpenGlStatus(isChecked); });
                return;
            }

            ((ToolStripMenuItem)notifyIcon.ContextMenuStrip.Items["OpenGL"]).Checked = isChecked;
        }

        public void SetDirectXStatus(bool isChecked)
        {
            if (notifyIcon.ContextMenuStrip.InvokeRequired)
            {
                notifyIcon.ContextMenuStrip.Invoke((MethodInvoker)delegate { SetDirectXStatus(isChecked); });
                return;
            }

            ((ToolStripMenuItem)notifyIcon.ContextMenuStrip.Items["DirectX"]).Checked = isChecked;
        }

        private void ConfigurationClicked(object sender, EventArgs e)
        {
            if (ConfigurationClick != null)
            {
                ConfigurationClick(this, e);
            }
        }

        private void OpenGLClicked(object sender, EventArgs e)
        {
            if (OpenGLClick != null)
                OpenGLClick(this, e);
        }

        private void DirectXClicked(object sender, EventArgs e)
        {
            if (DirectXClick != null)
                DirectXClick(this, e);
        }

        private void CloseClicked(object sender, EventArgs e)
        {
            if (QuitClick != null)
                QuitClick(this, e);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    this.notifyIcon.Visible = false;
                    notifyIcon.Dispose();
                }

                IsDisposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
    }
}
