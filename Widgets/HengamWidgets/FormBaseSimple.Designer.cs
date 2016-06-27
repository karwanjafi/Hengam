namespace HengamWidgets
{
    partial class FormBaseSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseSimple));
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.pnlMain.Size = new System.Drawing.Size(393, 288);
            // 
            // coolMessage
            // 
            this.coolMessage.BackColorToSet = System.Drawing.Color.DimGray;
            this.coolMessage.BorderColor = System.Drawing.Color.Orange;
            this.coolMessage.ForeColorToSet = System.Drawing.Color.Orange;
            this.coolMessage.Image = ((System.Drawing.Image)(resources.GetObject("coolMessage.Image")));
            this.coolMessage.Location = new System.Drawing.Point(55, 120);
            // 
            // FormBaseSimple
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(417, 312);
            this.Name = "FormBaseSimple";
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
