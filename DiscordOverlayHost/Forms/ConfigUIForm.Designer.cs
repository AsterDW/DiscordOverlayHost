namespace DiscordOverlayHost
{
    partial class ConfigUIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigUIForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new DiscordOverlayHost.Controls.GradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgBtnConfig = new DiscordOverlayHost.Controls.ImageButton();
            this.imgBtnAbout = new DiscordOverlayHost.Controls.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbAutoShowMgr = new System.Windows.Forms.CheckBox();
            this.cbAutoClose = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbAutoRunOpenGL = new System.Windows.Forms.CheckBox();
            this.cbAutoRunDirectX = new System.Windows.Forms.CheckBox();
            this.panel3 = new DiscordOverlayHost.Controls.GradientPanel();
            this.btnDirectX = new System.Windows.Forms.Button();
            this.btnOpenGL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DiscordHost_48.png");
            this.imageList1.Images.SetKeyName(1, "OpenGLHost_256.png");
            this.imageList1.Images.SetKeyName(2, "DirectXHost_256.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(45)))));
            this.panel1.BackgroundColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(45)))));
            this.panel1.BackgroundColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 260);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DiscordOverlayHost.Properties.Resources.Discord_Wordmark_White;
            this.pictureBox3.Location = new System.Drawing.Point(62, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.imgBtnConfig);
            this.panel2.Controls.Add(this.imgBtnAbout);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 207);
            this.panel2.TabIndex = 0;
            // 
            // imgBtnConfig
            // 
            this.imgBtnConfig.Location = new System.Drawing.Point(15, 8);
            this.imgBtnConfig.MouseDownImage = global::DiscordOverlayHost.Properties.Resources.gear_32xLG_Dark;
            this.imgBtnConfig.MouseOverImage = ((System.Drawing.Image)(resources.GetObject("imgBtnConfig.MouseOverImage")));
            this.imgBtnConfig.Name = "imgBtnConfig";
            this.imgBtnConfig.NormalImage = global::DiscordOverlayHost.Properties.Resources.gear_32xLG;
            this.imgBtnConfig.Size = new System.Drawing.Size(20, 20);
            this.imgBtnConfig.TabIndex = 3;
            this.imgBtnConfig.Text = "imageButton2";
            this.imgBtnConfig.UseVisualStyleBackColor = true;
            this.imgBtnConfig.Click += new System.EventHandler(this.imageButton2_Click);
            // 
            // imgBtnAbout
            // 
            this.imgBtnAbout.Location = new System.Drawing.Point(12, 181);
            this.imgBtnAbout.MouseDownImage = global::DiscordOverlayHost.Properties.Resources._109_AllAnnotations_Help_24x24_72_Dark;
            this.imgBtnAbout.MouseOverImage = global::DiscordOverlayHost.Properties.Resources._109_AllAnnotations_Help_24x24_72;
            this.imgBtnAbout.Name = "imgBtnAbout";
            this.imgBtnAbout.NormalImage = global::DiscordOverlayHost.Properties.Resources._109_AllAnnotations_Help_24x24_72_Dim;
            this.imgBtnAbout.Size = new System.Drawing.Size(20, 20);
            this.imgBtnAbout.TabIndex = 1;
            this.imgBtnAbout.UseVisualStyleBackColor = true;
            this.imgBtnAbout.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(41, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configuration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.cbAutoShowMgr);
            this.flowLayoutPanel1.Controls.Add(this.cbAutoClose);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.cbAutoRunOpenGL);
            this.flowLayoutPanel1.Controls.Add(this.cbAutoRunDirectX);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 8, 3, 3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(194, 140);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbAutoShowMgr
            // 
            this.cbAutoShowMgr.AutoSize = true;
            this.cbAutoShowMgr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutoShowMgr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbAutoShowMgr.Location = new System.Drawing.Point(18, 11);
            this.cbAutoShowMgr.Name = "cbAutoShowMgr";
            this.cbAutoShowMgr.Size = new System.Drawing.Size(112, 19);
            this.cbAutoShowMgr.TabIndex = 0;
            this.cbAutoShowMgr.Text = "Show on startup";
            this.cbAutoShowMgr.UseVisualStyleBackColor = true;
            // 
            // cbAutoClose
            // 
            this.cbAutoClose.AutoSize = true;
            this.cbAutoClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutoClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbAutoClose.Location = new System.Drawing.Point(18, 36);
            this.cbAutoClose.Name = "cbAutoClose";
            this.cbAutoClose.Size = new System.Drawing.Size(134, 19);
            this.cbAutoClose.TabIndex = 1;
            this.cbAutoClose.Text = "Auto Close Manager";
            this.cbAutoClose.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(18, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 3);
            this.panel4.TabIndex = 1;
            // 
            // cbAutoRunOpenGL
            // 
            this.cbAutoRunOpenGL.AutoSize = true;
            this.cbAutoRunOpenGL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutoRunOpenGL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbAutoRunOpenGL.Location = new System.Drawing.Point(18, 70);
            this.cbAutoRunOpenGL.Name = "cbAutoRunOpenGL";
            this.cbAutoRunOpenGL.Size = new System.Drawing.Size(168, 19);
            this.cbAutoRunOpenGL.TabIndex = 2;
            this.cbAutoRunOpenGL.Text = "Auto Launch OpenGL Host";
            this.cbAutoRunOpenGL.UseVisualStyleBackColor = true;
            // 
            // cbAutoRunDirectX
            // 
            this.cbAutoRunDirectX.AutoSize = true;
            this.cbAutoRunDirectX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAutoRunDirectX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbAutoRunDirectX.Location = new System.Drawing.Point(18, 95);
            this.cbAutoRunDirectX.Name = "cbAutoRunDirectX";
            this.cbAutoRunDirectX.Size = new System.Drawing.Size(163, 19);
            this.cbAutoRunDirectX.TabIndex = 3;
            this.cbAutoRunDirectX.Text = "Auto Launch DirectX Host";
            this.cbAutoRunDirectX.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panel3.BackgroundColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.btnDirectX);
            this.panel3.Controls.Add(this.btnOpenGL);
            this.panel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.panel3.Location = new System.Drawing.Point(202, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 207);
            this.panel3.TabIndex = 2;
            // 
            // btnDirectX
            // 
            this.btnDirectX.BackColor = System.Drawing.Color.Transparent;
            this.btnDirectX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.btnDirectX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnDirectX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(145)))));
            this.btnDirectX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectX.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectX.ImageIndex = 2;
            this.btnDirectX.ImageList = this.imageList1;
            this.btnDirectX.Location = new System.Drawing.Point(33, 105);
            this.btnDirectX.Name = "btnDirectX";
            this.btnDirectX.Size = new System.Drawing.Size(165, 64);
            this.btnDirectX.TabIndex = 2;
            this.btnDirectX.Text = "Start DirectX Host";
            this.btnDirectX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDirectX.UseVisualStyleBackColor = false;
            this.btnDirectX.Click += new System.EventHandler(this.btnDirectX_Click);
            // 
            // btnOpenGL
            // 
            this.btnOpenGL.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenGL.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.btnOpenGL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.btnOpenGL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(145)))));
            this.btnOpenGL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenGL.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenGL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenGL.ImageIndex = 1;
            this.btnOpenGL.ImageList = this.imageList1;
            this.btnOpenGL.Location = new System.Drawing.Point(33, 26);
            this.btnOpenGL.Name = "btnOpenGL";
            this.btnOpenGL.Size = new System.Drawing.Size(165, 64);
            this.btnOpenGL.TabIndex = 1;
            this.btnOpenGL.Text = "Start OpenGL Host";
            this.btnOpenGL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenGL.UseVisualStyleBackColor = false;
            this.btnOpenGL.Click += new System.EventHandler(this.btnOpenGL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(165, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Overlay Host Manager";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DiscordOverlayHost.Properties.Resources.DiscordHost_48;
            this.pictureBox2.Location = new System.Drawing.Point(5, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // ConfigUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 260);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigUIForm";
            this.Text = "Host Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigUIForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigUIForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DiscordOverlayHost.Controls.GradientPanel panel1;
        private System.Windows.Forms.Panel panel2;
        private DiscordOverlayHost.Controls.GradientPanel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnOpenGL;
        private System.Windows.Forms.CheckBox cbAutoShowMgr;
        private System.Windows.Forms.Button btnDirectX;
        private System.Windows.Forms.CheckBox cbAutoClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox cbAutoRunOpenGL;
        private System.Windows.Forms.CheckBox cbAutoRunDirectX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Controls.ImageButton imgBtnAbout;
        private Controls.ImageButton imgBtnConfig;
    }
}