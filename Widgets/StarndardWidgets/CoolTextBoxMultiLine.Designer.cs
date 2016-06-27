namespace StandardWidgets
{
    partial class CoolTextBoxMultiLine
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
            this.picOK = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).BeginInit();
            this.SuspendLayout();
            // 
            // picOK
            // 
            this.picOK.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picOK.BackColor = System.Drawing.Color.Transparent;
            this.picOK.Image = global::StandardWidgets.Properties.Resources.ok;
            this.picOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picOK.Location = new System.Drawing.Point(0, 14);
            this.picOK.Name = "picOK";
            this.picOK.Size = new System.Drawing.Size(18, 17);
            this.picOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOK.TabIndex = 2;
            this.picOK.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(24, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(164, 43);
            this.textBox1.TabIndex = 3;
            // 
            // CoolTextBoxMultiLine
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picOK);
            this.Name = "CoolTextBoxMultiLine";
            this.Size = new System.Drawing.Size(188, 43);
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOK;
        private System.Windows.Forms.TextBox textBox1;

    }
}
