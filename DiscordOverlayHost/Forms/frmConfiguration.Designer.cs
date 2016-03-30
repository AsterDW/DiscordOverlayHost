namespace DiscordOverlayHost
{
    partial class frmConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguration));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOpenGL = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAutoRunOpenGL = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAutoRunDirectX = new System.Windows.Forms.CheckBox();
            this.btnDirectX = new System.Windows.Forms.Button();
            this.cbAutoClose = new System.Windows.Forms.CheckBox();
            this.cbAutoShowMgr = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "App.ico");
            this.imageList1.Images.SetKeyName(1, "directx-11-logo.png");
            // 
            // btnOpenGL
            // 
            this.btnOpenGL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenGL.ImageIndex = 0;
            this.btnOpenGL.ImageList = this.imageList1;
            this.btnOpenGL.Location = new System.Drawing.Point(146, 19);
            this.btnOpenGL.Name = "btnOpenGL";
            this.btnOpenGL.Size = new System.Drawing.Size(149, 45);
            this.btnOpenGL.TabIndex = 0;
            this.btnOpenGL.Text = "Start OpenGL Host";
            this.btnOpenGL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenGL.UseVisualStyleBackColor = true;
            this.btnOpenGL.Click += new System.EventHandler(this.btnOpenGL_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbAutoRunOpenGL);
            this.groupBox1.Controls.Add(this.btnOpenGL);
            this.groupBox1.Location = new System.Drawing.Point(8, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OpenGL";
            // 
            // cbAutoRunOpenGL
            // 
            this.cbAutoRunOpenGL.AutoSize = true;
            this.cbAutoRunOpenGL.Location = new System.Drawing.Point(146, 70);
            this.cbAutoRunOpenGL.Name = "cbAutoRunOpenGL";
            this.cbAutoRunOpenGL.Size = new System.Drawing.Size(149, 17);
            this.cbAutoRunOpenGL.TabIndex = 3;
            this.cbAutoRunOpenGL.Text = "Auto launch OpenGL host";
            this.cbAutoRunOpenGL.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbAutoRunDirectX);
            this.groupBox2.Controls.Add(this.btnDirectX);
            this.groupBox2.Location = new System.Drawing.Point(8, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DirectX";
            // 
            // cbAutoRunDirectX
            // 
            this.cbAutoRunDirectX.AutoSize = true;
            this.cbAutoRunDirectX.Checked = true;
            this.cbAutoRunDirectX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoRunDirectX.Location = new System.Drawing.Point(146, 70);
            this.cbAutoRunDirectX.Name = "cbAutoRunDirectX";
            this.cbAutoRunDirectX.Size = new System.Drawing.Size(144, 17);
            this.cbAutoRunDirectX.TabIndex = 3;
            this.cbAutoRunDirectX.Text = "Auto launch DirectX host";
            this.cbAutoRunDirectX.UseVisualStyleBackColor = true;
            // 
            // btnDirectX
            // 
            this.btnDirectX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectX.ImageIndex = 1;
            this.btnDirectX.ImageList = this.imageList1;
            this.btnDirectX.Location = new System.Drawing.Point(146, 19);
            this.btnDirectX.Name = "btnDirectX";
            this.btnDirectX.Size = new System.Drawing.Size(149, 45);
            this.btnDirectX.TabIndex = 0;
            this.btnDirectX.Text = "Start DirectX Host";
            this.btnDirectX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDirectX.UseVisualStyleBackColor = true;
            this.btnDirectX.Click += new System.EventHandler(this.btnDirectX_Click);
            // 
            // cbAutoClose
            // 
            this.cbAutoClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoClose.AutoSize = true;
            this.cbAutoClose.Location = new System.Drawing.Point(154, 55);
            this.cbAutoClose.Name = "cbAutoClose";
            this.cbAutoClose.Size = new System.Drawing.Size(163, 17);
            this.cbAutoClose.TabIndex = 1;
            this.cbAutoClose.Text = "Close manager with last form.";
            this.cbAutoClose.UseVisualStyleBackColor = true;
            // 
            // cbAutoShowMgr
            // 
            this.cbAutoShowMgr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoShowMgr.AutoSize = true;
            this.cbAutoShowMgr.Location = new System.Drawing.Point(154, 32);
            this.cbAutoShowMgr.Name = "cbAutoShowMgr";
            this.cbAutoShowMgr.Size = new System.Drawing.Size(148, 17);
            this.cbAutoShowMgr.TabIndex = 1;
            this.cbAutoShowMgr.Text = "Show this form on startup.";
            this.cbAutoShowMgr.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // frmConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbAutoClose);
            this.Controls.Add(this.cbAutoShowMgr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmConfiguration";
            this.Text = "Discord Overlay Host Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGlHost_FormClosing);
            this.Load += new System.EventHandler(this.frmConfiguration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenGL;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox cbAutoShowMgr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbAutoRunOpenGL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDirectX;
        private System.Windows.Forms.CheckBox cbAutoRunDirectX;
        private System.Windows.Forms.CheckBox cbAutoClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

