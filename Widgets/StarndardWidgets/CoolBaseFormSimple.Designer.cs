namespace StandardWidgets
{
    partial class CoolBaseFormSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolBaseFormSimple));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.coolMessage = new StandardWidgets.CoolMessage();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.coolMessage);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(571, 397);
            this.pnlMain.TabIndex = 0;
            // 
            // coolMessage
            // 
            this.coolMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coolMessage.BorderColor = System.Drawing.Color.Bisque;
            this.coolMessage.Image = ((System.Drawing.Image)(resources.GetObject("coolMessage.Image")));
            this.coolMessage.Location = new System.Drawing.Point(144, 174);
            this.coolMessage.Name = "coolMessage";
            this.coolMessage.Size = new System.Drawing.Size(282, 49);
            this.coolMessage.TabIndex = 1;
            this.coolMessage.Visible = false;
            // 
            // CoolBaseFormSimple
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(595, 421);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "CoolBaseFormSimple";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "ÝÑã ÓÇÏå";
            this.Load += new System.EventHandler(this.CoolBaseFormSimple_Load);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlMain;
        public CoolMessage coolMessage;

    }
}