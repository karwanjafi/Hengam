namespace StandardWidgets
{
    partial class CoolMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolMainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.imageListTaskPane = new System.Windows.Forms.ImageList(this.components);
            this.imageListGroupIcons = new System.Windows.Forms.ImageList(this.components);
            this.tabStrip = new FarsiLibrary.Win.FATabStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.coolMenu1 = new StandardWidgets.CoolMenu();
            this.coolTiteBar1 = new StandardWidgets.CoolTiteBar();
            this.coolMessage = new StandardWidgets.CoolMessage();
            ((System.ComponentModel.ISupportInitialize)(this.tabStrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageListTaskPane
            // 
            this.imageListTaskPane.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTaskPane.ImageStream")));
            this.imageListTaskPane.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTaskPane.Images.SetKeyName(0, "pic");
            this.imageListTaskPane.Images.SetKeyName(1, "pic2");
            this.imageListTaskPane.Images.SetKeyName(2, "pic1");
            // 
            // imageListGroupIcons
            // 
            this.imageListGroupIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListGroupIcons.ImageStream")));
            this.imageListGroupIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListGroupIcons.Images.SetKeyName(0, "adv");
            // 
            // tabStrip
            // 
            this.tabStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStrip.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tabStrip.Location = new System.Drawing.Point(0, 49);
            this.tabStrip.Name = "tabStrip";
            this.tabStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabStrip.Size = new System.Drawing.Size(432, 401);
            this.tabStrip.TabIndex = 3;
            this.tabStrip.Text = "منوی اصلی";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DimGray;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 28);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(673, 21);
            this.pnlHeader.TabIndex = 2;
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.BackColor = System.Drawing.Color.DimGray;
            this.pnlStatusBar.Controls.Add(this.lblStatus);
            this.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatusBar.Location = new System.Drawing.Point(0, 450);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlStatusBar.Size = new System.Drawing.Size(432, 21);
            this.pnlStatusBar.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStatus.Location = new System.Drawing.Point(4, 4);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(428, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "-";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // coolMenu1
            // 
            this.coolMenu1.BackColor = System.Drawing.Color.Black;
            this.coolMenu1.Dock = System.Windows.Forms.DockStyle.Right;
            this.coolMenu1.ImageList = this.imageListTaskPane;
            this.coolMenu1.Location = new System.Drawing.Point(432, 49);
            this.coolMenu1.LogoImage = ((System.Drawing.Image)(resources.GetObject("coolMenu1.LogoImage")));
            this.coolMenu1.Name = "coolMenu1";
            this.coolMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.coolMenu1.Size = new System.Drawing.Size(241, 422);
            this.coolMenu1.TabIndex = 0;
            // 
            // coolTiteBar1
            // 
            this.coolTiteBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.coolTiteBar1.BackColor = System.Drawing.Color.Transparent;
            this.coolTiteBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("coolTiteBar1.BackgroundImage")));
            this.coolTiteBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.coolTiteBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.coolTiteBar1.ForeColor = System.Drawing.Color.Black;
            this.coolTiteBar1.Location = new System.Drawing.Point(0, 0);
            this.coolTiteBar1.Name = "coolTiteBar1";
            this.coolTiteBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.coolTiteBar1.Size = new System.Drawing.Size(673, 28);
            this.coolTiteBar1.TabIndex = 2;
            this.coolTiteBar1.TabStop = false;
            this.coolTiteBar1.TitleText = "-";
            // 
            // coolMessage
            // 
            this.coolMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coolMessage.BackColorToSet = System.Drawing.Color.Black;
            this.coolMessage.BorderColor = System.Drawing.Color.Orange;
            this.coolMessage.ForeColorToSet = System.Drawing.Color.DeepSkyBlue;
            this.coolMessage.Image = ((System.Drawing.Image)(resources.GetObject("coolMessage.Image")));
            this.coolMessage.Location = new System.Drawing.Point(90, 228);
            this.coolMessage.Name = "coolMessage";
            this.coolMessage.Size = new System.Drawing.Size(282, 49);
            this.coolMessage.TabIndex = 0;
            // 
            // CoolMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(673, 471);
            this.Controls.Add(this.tabStrip);
            this.Controls.Add(this.pnlStatusBar);
            this.Controls.Add(this.coolMenu1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.coolTiteBar1);
            this.Controls.Add(this.coolMessage);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CoolMainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tabStrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlStatusBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageListTaskPane;
        private System.Windows.Forms.ImageList imageListGroupIcons;
        private StandardWidgets.CoolTiteBar coolTiteBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Panel pnlHeader;
        private CoolMessage coolMessage;
        public CoolMenu coolMenu1;
        public FarsiLibrary.Win.FATabStrip tabStrip;
    }
}

