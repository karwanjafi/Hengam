namespace StandardWidgets
{
    partial class CoolDayTimePicker
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
            this.pnlSlotContainter = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlSlotContainter
            // 
            this.pnlSlotContainter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSlotContainter.Location = new System.Drawing.Point(0, 3);
            this.pnlSlotContainter.Name = "pnlSlotContainter";
            this.pnlSlotContainter.Size = new System.Drawing.Size(362, 20);
            this.pnlSlotContainter.TabIndex = 0;
            this.pnlSlotContainter.Click += new System.EventHandler(this.pnlSlotContainter_Click);
            // 
            // CoolDayTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSlotContainter);
            this.Name = "CoolDayTimePicker";
            this.Size = new System.Drawing.Size(362, 26);
            this.Resize += new System.EventHandler(this.CoolDayTimePicker_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSlotContainter;
    }
}
