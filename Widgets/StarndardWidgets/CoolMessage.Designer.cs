namespace StandardWidgets
{
    partial class CoolMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolMessage));
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnMsg = new System.Windows.Forms.Button();
            this.pnlMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMsg
            // 
            this.pnlMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMsg.BackColor = System.Drawing.Color.Orange;
            this.pnlMsg.Controls.Add(this.picBox);
            this.pnlMsg.Controls.Add(this.btnMsg);
            this.pnlMsg.Location = new System.Drawing.Point(0, 0);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(282, 49);
            this.pnlMsg.TabIndex = 6;
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picBox.BackColor = System.Drawing.Color.DimGray;
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(3, 3);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(49, 43);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            // 
            // btnMsg
            // 
            this.btnMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMsg.BackColor = System.Drawing.Color.DimGray;
            this.btnMsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMsg.FlatAppearance.BorderSize = 0;
            this.btnMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMsg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMsg.ForeColor = System.Drawing.Color.Orange;
            this.btnMsg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMsg.Location = new System.Drawing.Point(45, 3);
            this.btnMsg.Name = "btnMsg";
            this.btnMsg.Size = new System.Drawing.Size(234, 43);
            this.btnMsg.TabIndex = 2;
            this.btnMsg.Text = "-";
            this.btnMsg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMsg.UseVisualStyleBackColor = false;
            this.btnMsg.Click += new System.EventHandler(this.btnMsg_Click);
            // 
            // CoolMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.pnlMsg);
            this.Name = "CoolMessage";
            this.Size = new System.Drawing.Size(282, 49);
            this.pnlMsg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMsg;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnMsg;
    }
}
