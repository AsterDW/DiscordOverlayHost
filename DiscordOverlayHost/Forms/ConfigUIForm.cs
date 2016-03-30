using System;
using System.Windows.Forms;

namespace DiscordOverlayHost
{
    public partial class ConfigUIForm : Form
    {
        private HostApplicationContext _context;
        public ConfigUIForm(HostApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            flowLayoutPanel1.Height = Properties.Settings.Default.ConfigPanelClosed ? 10 : 140;
            SetupRollupTimer();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfigUIForm_Load(object sender, EventArgs e)
        {
            cbAutoShowMgr.Checked = Properties.Settings.Default.ShowSettingsOnStart;
            cbAutoRunOpenGL.Checked = Properties.Settings.Default.AutoStartOpenGL;
            cbAutoRunDirectX.Checked = Properties.Settings.Default.AutoStartDirectX;
            cbAutoClose.Checked = Properties.Settings.Default.AutoCloseManager;
        }

        private void ConfigUIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ShowSettingsOnStart = cbAutoShowMgr.Checked;
            Properties.Settings.Default.AutoStartOpenGL = cbAutoRunOpenGL.Checked;
            Properties.Settings.Default.AutoStartDirectX = cbAutoRunDirectX.Checked;
            Properties.Settings.Default.AutoCloseManager = cbAutoClose.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnOpenGL_Click(object sender, EventArgs e)
        {
            _context.RunOpenGLHost();
        }

        private void btnDirectX_Click(object sender, EventArgs e)
        {
            _context.RunDirectXHost();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AboutDialog().ShowDialog(this);
        }

        private Timer rollupTimer;

        private void SetupRollupTimer()
        {
            rollupTimer = new Timer();
            rollupTimer.Interval = 15;
            rollupTimer.Tick += RollupTimer_Tick;
        }

        private void RollupTimer_Tick(object sender, EventArgs e)
        {
            int step = 20;
            if (Properties.Settings.Default.ConfigPanelClosed)
            {
                flowLayoutPanel1.Height = flowLayoutPanel1.Height < 10+step ? 10 : flowLayoutPanel1.Height - step;
                if (flowLayoutPanel1.Height <= 10)
                {
                    rollupTimer.Stop();
                }
            }
            else
            {
                flowLayoutPanel1.Height = flowLayoutPanel1.Height > 140 - step ? 140 : flowLayoutPanel1.Height + step;
                if (flowLayoutPanel1.Height >= 140)
                {
                    rollupTimer.Stop();
                }
            }
        }

        private void imageButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConfigPanelClosed = !Properties.Settings.Default.ConfigPanelClosed;
            Properties.Settings.Default.Save();

            if (!rollupTimer.Enabled)
                rollupTimer.Start();
        }
    }
}
