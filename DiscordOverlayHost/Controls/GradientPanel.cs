using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DiscordOverlayHost.Controls
{
    public partial class GradientPanel : Panel
    {
        private Color _bgc1 = Color.FromKnownColor(KnownColor.Control);
        private Color _bgc2 = Color.FromKnownColor(KnownColor.Control);

        public Color BackgroundColor1
        {
            get { return _bgc1; }
            set
            {
                _bgc1 = value;
                this.Invalidate();
            }
        }

        public Color BackgroundColor2
        {
            get { return _bgc2; }
            set
            {
                _bgc2 = value;
                this.Invalidate();
            }
        }

        private LinearGradientMode _gradientMode = LinearGradientMode.Vertical;
        public LinearGradientMode GradientMode
        {
            get
            {
                return _gradientMode;
            }
            set
            {
                _gradientMode = value;
                this.Invalidate();
            }
        }

        public GradientPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            BackgroundColor2 = Color.FromKnownColor(KnownColor.Control);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, BackgroundColor1, BackgroundColor2, GradientMode))
            {
                e.Graphics.FillRectangle(lgb, this.ClientRectangle);
            }
        }
    }
}
