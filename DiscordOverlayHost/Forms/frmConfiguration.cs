using System;
using System.Windows.Forms;

namespace DiscordOverlayHost
{
    public partial class frmConfiguration : Form
    {
        private HostApplicationContext _context;

        public frmConfiguration(HostApplicationContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void btnOpenGL_Click(object sender, EventArgs e)
        {
            _context.RunOpenGLHost();
        }

        private void btnDirectX_Click(object sender, EventArgs e)
        {
            _context.RunDirectXHost();
        }

        private void frmGlHost_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ShowSettingsOnStart = cbAutoShowMgr.Checked;
            Properties.Settings.Default.AutoStartOpenGL = cbAutoRunOpenGL.Checked;
            Properties.Settings.Default.AutoStartDirectX = cbAutoRunDirectX.Checked;
            Properties.Settings.Default.AutoCloseManager = cbAutoClose.Checked;
            Properties.Settings.Default.Save();
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            cbAutoShowMgr.Checked = Properties.Settings.Default.ShowSettingsOnStart;
            cbAutoRunOpenGL.Checked = Properties.Settings.Default.AutoStartOpenGL;
            cbAutoRunDirectX.Checked = Properties.Settings.Default.AutoStartDirectX;
            cbAutoClose.Checked = Properties.Settings.Default.AutoCloseManager;
        }

    }
}
