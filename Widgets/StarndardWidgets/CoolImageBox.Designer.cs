namespace StandardWidgets
{
    partial class CoolImageBox
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnRemovePic = new System.Windows.Forms.Button();
            this.btnSelectPic = new System.Windows.Forms.Button();
            this.dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(150, 150);
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            this.picImage.Click += new System.EventHandler(this.picImage_Click);
            // 
            // btnRemovePic
            // 
            this.btnRemovePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemovePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemovePic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRemovePic.ForeColor = System.Drawing.Color.Blue;
            this.btnRemovePic.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemovePic.Location = new System.Drawing.Point(10, 80);
            this.btnRemovePic.Name = "btnRemovePic";
            this.btnRemovePic.Size = new System.Drawing.Size(131, 24);
            this.btnRemovePic.TabIndex = 1;
            this.btnRemovePic.Text = "حذف عکس";
            this.btnRemovePic.UseVisualStyleBackColor = true;
            this.btnRemovePic.Visible = false;
            this.btnRemovePic.Click += new System.EventHandler(this.btnRemovePic_Click);
            // 
            // btnSelectPic
            // 
            this.btnSelectPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelectPic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectPic.ForeColor = System.Drawing.Color.Blue;
            this.btnSelectPic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectPic.Location = new System.Drawing.Point(10, 50);
            this.btnSelectPic.Name = "btnSelectPic";
            this.btnSelectPic.Size = new System.Drawing.Size(131, 24);
            this.btnSelectPic.TabIndex = 1;
            this.btnSelectPic.Text = "انتخاب عکس";
            this.btnSelectPic.UseVisualStyleBackColor = true;
            this.btnSelectPic.Visible = false;
            this.btnSelectPic.Click += new System.EventHandler(this.btnSelectPic_Click);
            // 
            // dlgOpenImage
            // 
            this.dlgOpenImage.Title = "انتخاب عکس";
            // 
            // CoolImageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRemovePic);
            this.Controls.Add(this.btnSelectPic);
            this.Controls.Add(this.picImage);
            this.Name = "CoolImageBox";
            this.Leave += new System.EventHandler(this.CoolImageBox_Leave);
            this.Enter += new System.EventHandler(this.CoolImageBox_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnRemovePic;
        private System.Windows.Forms.Button btnSelectPic;
        private System.Windows.Forms.OpenFileDialog dlgOpenImage;
    }
}
