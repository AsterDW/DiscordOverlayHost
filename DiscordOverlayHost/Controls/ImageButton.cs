using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiscordOverlayHost.Controls
{
    public partial class ImageButton : Button
    {
        private Image _normalImage;
        public Image NormalImage
        {
            get
            {
                return _normalImage;
            }
            set
            {
                _normalImage = value;
                this.Invalidate();
            }
        }

        private Image _mouseOverImage;
        public Image MouseOverImage
        {
            get
            {
                return _mouseOverImage;
            }
            set
            {
                _mouseOverImage = value;
                this.Invalidate();
            }
        }

        private Image _mouseDownImage;
        public Image MouseDownImage
        {
            get
            {
                return _mouseDownImage;
            }
            set
            {
                _mouseDownImage = value;
                this.Invalidate();
            }
        }

        private enum ButtonState
        {
            Normal = 0,
            MouseOver = 1,
            MouseDown = 2
        }

        private ButtonState _buttonState = ButtonState.Normal;

        public ImageButton()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.Opaque, false);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _buttonState = ButtonState.MouseOver;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _buttonState = ButtonState.Normal;
            this.Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            _buttonState = ButtonState.MouseDown;
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            if (ClientRectangle.Contains(PointToClient(MousePosition)))
            {
                _buttonState = ButtonState.MouseOver;
            }
            else
            {
                _buttonState = ButtonState.Normal;
            }
            this.Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            base.OnPaintBackground(pevent);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            try
            {
                pevent.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                pevent.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                pevent.Graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    pevent.Graphics.FillRectangle(brush, pevent.ClipRectangle);
                }

                Image img = null;
                switch(_buttonState)
                {
                    case ButtonState.Normal:
                        img = NormalImage;
                        break;
                    case ButtonState.MouseOver:
                        img = MouseOverImage;
                        break;
                    case ButtonState.MouseDown:
                        img = MouseDownImage;
                        break;
                }

                if (img != null)
                {
                    Rectangle rect = new Rectangle(0, 0, Width, Height);
                    rect.Inflate(-2, -2);
                    pevent.Graphics.DrawImage(img, 0, 0, Width, Height);
                }
            }
            catch
            {
                //
            }
        }
    }
}
