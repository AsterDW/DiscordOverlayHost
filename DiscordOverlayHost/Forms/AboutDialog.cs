using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordOverlayHost
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        private void VisitWebPage(string url)
        {
            try
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = url;
                proc.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, string.Format("There was an error opening the web page.\r\n{0}", ex.Message), "Web Page", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "mailto:christopher.aster@gmail.com?subject=Discord Overlay Host";
                proc.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, string.Format("There was an error opening your email client.\r\n{0}", ex.Message), "eMail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitWebPage("https://discordapp.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelOpenTk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitWebPage("http://www.opentk.com/");
        }

        private void linkLabelSharpDx_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitWebPage("http://sharpdx.org/");
        }
    }
}
