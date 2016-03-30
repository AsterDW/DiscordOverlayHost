using System;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace OpenGlHost
{
    public class OpenGlHost : IDisposable
    {
        private class TextureInfo
        {
            public int TextureID { get; private set; }
            public int Width { get; private set; }
            public int Height { get; private set; }

            public TextureInfo(int id, int width, int height)
            {
                TextureID = id;
                Width = width;
                Height = height;
            }
        }
        private const string windowTitle = "Discord Overlay Host: OpenGL";
        private const int Width = 350;
        private const int Height = 450;
        //Duration in seconds to show logo on start.
        private const int LogoDuration = 8;


        public bool IsDisposed { get; private set; }

        private GameWindow glHostWindow;
        private bool GlLoaded { get; set; }
        private Stopwatch clock;

        private TextureInfo logoTexture;
        private bool DrawLogo { get; set; }

        #region events
        public event EventHandler HostWindowCreated;
        public event EventHandler HostWindowClosed;

        protected void OnHostWindowCreated()
        {
            if (HostWindowCreated != null)
            {
                HostWindowCreated(this, new EventArgs());
            }
        }

        protected void OnHostWindowClosed()
        {
            if (HostWindowClosed != null)
            {
                HostWindowClosed(this, new EventArgs());
            }
        }
        #endregion

        public OpenGlHost()
        {
            
        }

        private void GlHostWindow_Closed(object sender, EventArgs e)
        {
            this.Dispose();
            OnHostWindowClosed();
        }

        public void Run()
        {
            try
            {
                clock = new Stopwatch();

                GraphicsMode gMode = new GraphicsMode(
                    new ColorFormat(8, 8, 8, 8)
                    );

                glHostWindow = new GameWindow(Width, Height, gMode, windowTitle);
                glHostWindow.Icon = Properties.Resources.AppIcon;
                //glHostWindow.TargetRenderFrequency = 60;
                glHostWindow.Load += GlHostWindow_Load;
                glHostWindow.Closed += GlHostWindow_Closed;

                glHostWindow.RenderFrame += GlHostWindow_RenderFrame;

                glHostWindow.Run();
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Exception loading OpenGL host window.\r\n{0}", ex.Message), "OpenGL Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Exit()
        {
            if (glHostWindow != null && glHostWindow.Exists)
            {
                glHostWindow.Exit();
            }
        }

        private void GlHostWindow_Load(object sender, EventArgs e)
        {
            OnHostWindowCreated();

            GlLoaded = true;
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

            GL.Enable(EnableCap.Texture2D);

            logoTexture = LoadLogoTexture();
            if (logoTexture != null)
            {
                DrawLogo = true;
            }

            clock.Start();
        }

        private void GlHostWindow_RenderFrame(object sender, FrameEventArgs e)
        {
            GL.ClearColor(Color.FromArgb(10, 46, 49, 54));
            GL.Clear(ClearBufferMask.ColorBufferBit);

            if (clock.IsRunning && DrawLogo)
            {
                if (clock.Elapsed.TotalSeconds < LogoDuration)
                {
                    DrawLogoQuad();
                }
                else
                {
                    clock.Stop();
                }
            }
            glHostWindow.SwapBuffers();
        }

        private void DrawLogoQuad()
        {
            float absX = (logoTexture.Width / 2f) / (glHostWindow.ClientSize.Width / 2f);
            float absY = (logoTexture.Height / 2f) / (glHostWindow.ClientSize.Height / 2f);

            GL.BindTexture(TextureTarget.Texture2D, logoTexture.TextureID);

            GL.Begin(PrimitiveType.Quads);

            GL.TexCoord2(0.0f, 0.0f);
            GL.Vertex2(0-absX, absY);

            GL.TexCoord2(1.0f, 0.0f);
            GL.Vertex2(absX, absY);

            GL.TexCoord2(1.0f, 1.0f);
            GL.Vertex2(absX, 0-absY);

            GL.TexCoord2(0.0f, 1.0f);
            GL.Vertex2(0-absX, 0-absY);

            GL.End();
        }

        private TextureInfo LoadLogoTexture()
        {
            try
            {
                int textureID = 0;

                Bitmap bmpLogo = Properties.Resources.DiscordHost;

                GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest);

                GL.GenTextures(1, out textureID);
                GL.BindTexture(TextureTarget.Texture2D, textureID);

                BitmapData data = bmpLogo.LockBits(new System.Drawing.Rectangle(0, 0, bmpLogo.Width, bmpLogo.Height),
                    ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0,
                    OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);

                bmpLogo.UnlockBits(data);

                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Clamp);
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Clamp);
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
                GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

                return new TextureInfo(textureID, bmpLogo.Width, bmpLogo.Height);
            }
            catch
            {
                //
            }
            //Error loading texture
            return null;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    
                }

                try
                {
                    if (glHostWindow != null)
                    {
                        if (glHostWindow.Exists)
                        {
                            glHostWindow.Exit();
                        }
                        glHostWindow.Dispose();
                        glHostWindow = null;
                    }
                }
                catch
                {
                    //
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
