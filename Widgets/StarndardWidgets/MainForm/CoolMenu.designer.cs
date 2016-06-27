namespace StandardWidgets
{
    partial class CoolMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            XPExplorerBar.Expando expando1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolMenu));
            this.taskItem1 = new XPExplorerBar.TaskItem();
            this.taskItem2 = new XPExplorerBar.TaskItem();
            this.taskPane = new XPExplorerBar.TaskPane();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnCascade = new System.Windows.Forms.Button();
            expando1 = new XPExplorerBar.Expando();
            ((System.ComponentModel.ISupportInitialize)(expando1)).BeginInit();
            expando1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskPane)).BeginInit();
            this.taskPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // expando1
            // 
            expando1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            expando1.Animate = true;
            expando1.AutoLayout = true;
            expando1.CustomHeaderSettings.GradientOffset = 0.2F;
            expando1.CustomHeaderSettings.Margin = 30;
            expando1.CustomHeaderSettings.NormalBackColor = System.Drawing.Color.Gray;
            expando1.CustomHeaderSettings.NormalBackImage = ((System.Drawing.Image)(resources.GetObject("expando1.CustomHeaderSettings.NormalBackImage")));
            expando1.CustomHeaderSettings.NormalBorderColor = System.Drawing.Color.Black;
            expando1.CustomHeaderSettings.NormalGradientEndColor = System.Drawing.Color.Black;
            expando1.CustomHeaderSettings.NormalGradientStartColor = System.Drawing.Color.Silver;
            expando1.CustomHeaderSettings.NormalTitleColor = System.Drawing.Color.Gold;
            expando1.CustomHeaderSettings.NormalTitleHotColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            expando1.CustomHeaderSettings.SpecialBackColor = System.Drawing.Color.Gray;
            expando1.CustomHeaderSettings.SpecialBorderColor = System.Drawing.Color.Black;
            expando1.CustomHeaderSettings.TitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expando1.CustomHeaderSettings.TitleRadius = 10;
            expando1.CustomSettings.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            expando1.CustomSettings.NormalBorderColor = System.Drawing.Color.Black;
            expando1.CustomSettings.SpecialBorderColor = System.Drawing.Color.Black;
            expando1.ExpandedHeight = 88;
            expando1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expando1.ForeColor = System.Drawing.Color.Peru;
            expando1.Items.AddRange(new System.Windows.Forms.Control[] {
            this.taskItem1,
            this.taskItem2});
            expando1.Location = new System.Drawing.Point(12, 12);
            expando1.Name = "expando1";
            expando1.Size = new System.Drawing.Size(197, 88);
            expando1.TabIndex = 0;
            expando1.Text = "گروه اول";
            expando1.Visible = false;
            // 
            // taskItem1
            // 
            this.taskItem1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem1.BackColor = System.Drawing.Color.Transparent;
            this.taskItem1.CustomSettings.FontDecoration = System.Drawing.FontStyle.Regular;
            this.taskItem1.CustomSettings.HotLinkColor = System.Drawing.Color.Blue;
            this.taskItem1.CustomSettings.LinkColor = System.Drawing.Color.Orange;
            this.taskItem1.Image = null;
            this.taskItem1.Location = new System.Drawing.Point(12, 33);
            this.taskItem1.Name = "taskItem1";
            this.taskItem1.Size = new System.Drawing.Size(171, 20);
            this.taskItem1.TabIndex = 0;
            this.taskItem1.Text = "taskItem1";
            this.taskItem1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem1.UseVisualStyleBackColor = false;
            // 
            // taskItem2
            // 
            this.taskItem2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskItem2.BackColor = System.Drawing.Color.Transparent;
            this.taskItem2.CustomSettings.HotLinkColor = System.Drawing.Color.Blue;
            this.taskItem2.CustomSettings.LinkColor = System.Drawing.Color.Orange;
            this.taskItem2.Image = null;
            this.taskItem2.Location = new System.Drawing.Point(12, 57);
            this.taskItem2.Name = "taskItem2";
            this.taskItem2.Size = new System.Drawing.Size(171, 20);
            this.taskItem2.TabIndex = 1;
            this.taskItem2.Text = "taskItem2";
            this.taskItem2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem2.UseVisualStyleBackColor = false;
            // 
            // taskPane
            // 
            this.taskPane.AllowExpandoDragging = true;
            this.taskPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskPane.AutoScroll = true;
            this.taskPane.AutoScrollMargin = new System.Drawing.Size(12, 12);
            this.taskPane.CustomSettings.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.taskPane.CustomSettings.GradientEndColor = System.Drawing.Color.DimGray;
            this.taskPane.CustomSettings.GradientStartColor = System.Drawing.Color.Silver;
            this.taskPane.Expandos.AddRange(new XPExplorerBar.Expando[] {
            expando1});
            this.taskPane.Location = new System.Drawing.Point(10, 184);
            this.taskPane.Name = "taskPane";
            this.taskPane.Size = new System.Drawing.Size(221, 337);
            this.taskPane.TabIndex = 0;
            this.taskPane.Text = "taskPane";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(234, 159);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // btnCascade
            // 
            this.btnCascade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCascade.BackColor = System.Drawing.Color.Transparent;
            this.btnCascade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCascade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCascade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCascade.ForeColor = System.Drawing.Color.White;
            this.btnCascade.Location = new System.Drawing.Point(2, 295);
            this.btnCascade.Margin = new System.Windows.Forms.Padding(1);
            this.btnCascade.Name = "btnCascade";
            this.btnCascade.Size = new System.Drawing.Size(16, 135);
            this.btnCascade.TabIndex = 2;
            this.btnCascade.Text = "<";
            this.btnCascade.UseVisualStyleBackColor = false;
            this.btnCascade.Click += new System.EventHandler(this.btnCascade_Click);
            // 
            // CoolMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btnCascade);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.taskPane);
            this.Name = "CoolMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(241, 524);
            ((System.ComponentModel.ISupportInitialize)(expando1)).EndInit();
            expando1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskPane)).EndInit();
            this.taskPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private XPExplorerBar.TaskItem taskItem1;
        private XPExplorerBar.TaskItem taskItem2;
        private System.Windows.Forms.Button btnCascade;
        public XPExplorerBar.TaskPane taskPane;
    }
}
