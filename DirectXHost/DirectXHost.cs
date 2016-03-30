using System;
using System.Windows.Forms;
using SharpDX.Windows;
using System.Drawing;

namespace DirectXHost
{
    public class DirectXHost : IDisposable
    {
        private RenderForm _dxForm;
        private GraphicsD3D11 _graphics;
        private bool UserResized { get; set; }
        private Size ClientSize { get; set; }

        public bool IsDisposed { get; private set; }

        #region Events
        public event EventHandler HostWindowClosed;
        public event EventHandler HostWindowCreated;
        protected void OnHostWindowCreated()
        {
            if (HostWindowCreated != null)
            {
                HostWindowCreated(this._dxForm, new EventArgs());
            }
        }

        protected void OnHostWindowClosed()
        {
            if (HostWindowClosed != null)
            {
                HostWindowClosed(this._dxForm, new EventArgs());
            }
        }
        #endregion

        public DirectXHost()
        {
            try
            {
                InitializeRenderForm();
                _graphics = new GraphicsD3D11();
                _graphics.Initialise(_dxForm, true);
                _dxForm.UserResized += (sender, args) =>
                {
                    var renderForm = sender as RenderForm;
                    ClientSize = new Size(renderForm.ClientSize.Width, renderForm.ClientSize.Height);
                    UserResized = true;
                };
                LoadContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Exception loading DirectX host window.\r\n{0}", ex.Message), "DirectX Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Exit()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            try
            {
                RenderLoop.Run(_dxForm, RenderCallback);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Exception running DirectX host window.\r\n{0}", ex.Message), "DirectX Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RenderCallback()
        {
            Update();
            Draw();
        }

        private void InitializeRenderForm()
        {
            _dxForm = new RenderForm(Constants.WindowTitle);
            _dxForm.HandleCreated += WindowHandleCreated;
            _dxForm.HandleDestroyed += WindowHandleDestroyed;
            _dxForm.ClientSize = new System.Drawing.Size(Constants.StartWidth, Constants.StartHeight);
            _dxForm.StartPosition = FormStartPosition.CenterScreen;
        }

        private void WindowHandleDestroyed(object sender, EventArgs e)
        {
            this.Dispose();
            this.IsDisposed = true;
            OnHostWindowClosed();
        }

        private void WindowHandleCreated(object sender, EventArgs e)
        {
            OnHostWindowCreated();
        }

        private void LoadContent()
        {
            //To add content to the form if we want to
        }

        public void Update()
        {
            if (UserResized)
            {
                _graphics.ResizeGraphics(ClientSize.Width, ClientSize.Height);
                UserResized = false;
            }
        }

        public void Draw()
        {
            _graphics.ClearRenderTargetView();

            _graphics.PresentSwapChain();
        }

        #region IDisposable Support

        protected virtual void Dispose(bool disposing)
        {
            if (!IsDisposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    _dxForm.Dispose();
                }

                _graphics.Dispose();
                IsDisposed = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~DirectXHost() {
           // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
           Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
