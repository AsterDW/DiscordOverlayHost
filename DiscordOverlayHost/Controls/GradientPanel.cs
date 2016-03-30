using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System;

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
                CreateBackgroundBrush();
            }
        }

        public Color BackgroundColor2
        {
            get { return _bgc2; }
            set
            {
                _bgc2 = value;
                CreateBackgroundBrush();
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
                CreateBackgroundBrush();
            }
        }

        private LinearGradientBrush _backgroundBrush;

        public GradientPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            CreateBackgroundBrush();
        }

        private void CreateBackgroundBrush()
        {
            //Do not create new brush with 0 width or height.
            if (Width == 0 || Height == 0)
            {
                return;
            }

            if (_backgroundBrush != null)
            {
                _backgroundBrush.Dispose();
            }
            _backgroundBrush = new LinearGradientBrush(this.ClientRectangle, BackgroundColor1, BackgroundColor2, GradientMode);
            if (this.Visible)
            {
                this.Invalidate();
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);

            CreateBackgroundBrush();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Width != 0 && Height != 0)
            {
                e.Graphics.FillRectangle(_backgroundBrush, this.ClientRectangle);
            }
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                _backgroundBrush.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
