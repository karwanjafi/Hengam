namespace Hengam.Forms.Store.ObjectPanel
{
    partial class StuffPanel
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
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.txtStuffID = new HengamWidgets.CoolTextBox();
            this.txtStuffName = new HengamWidgets.CoolTextBox();
            this.SuspendLayout();
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(200, 0);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(48, 21);
            this.coolLabel1.TabIndex = 1;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "نام کالا:";
            // 
            // txtStuffID
            // 
            this.txtStuffID.Accepted = false;
            this.txtStuffID.BackColor = System.Drawing.Color.Transparent;
            this.txtStuffID.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStuffID.IsEmpty = false;
            this.txtStuffID.LengthMax = 1000000;
            this.txtStuffID.LengthMin = 0;
            this.txtStuffID.Location = new System.Drawing.Point(0, 0);
            this.txtStuffID.Mask = "";
            this.txtStuffID.Message = "خالی";
            this.txtStuffID.MustFill = true;
            this.txtStuffID.Name = "txtStuffID";
            this.txtStuffID.ReadOnly = false;
            this.txtStuffID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffID.Size = new System.Drawing.Size(37, 21);
            this.txtStuffID.TabIndex = 0;
            this.txtStuffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStuffID.TextToSet = "";
            this.txtStuffID.Visible = false;
            // 
            // txtStuffName
            // 
            this.txtStuffName.Accepted = false;
            this.txtStuffName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStuffName.BackColor = System.Drawing.Color.Transparent;
            this.txtStuffName.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtStuffName.IsEmpty = false;
            this.txtStuffName.LengthMax = 1000000;
            this.txtStuffName.LengthMin = 0;
            this.txtStuffName.Location = new System.Drawing.Point(3, 0);
            this.txtStuffName.Mask = "";
            this.txtStuffName.Message = "خالی";
            this.txtStuffName.MustFill = true;
            this.txtStuffName.Name = "txtStuffName";
            this.txtStuffName.ReadOnly = false;
            this.txtStuffName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStuffName.Size = new System.Drawing.Size(191, 21);
            this.txtStuffName.TabIndex = 0;
            this.txtStuffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStuffName.TextToSet = "";
            // 
            // StuffPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.coolLabel1);
            this.Controls.Add(this.txtStuffID);
            this.Controls.Add(this.txtStuffName);
            this.Name = "StuffPanel";
            this.Size = new System.Drawing.Size(250, 22);
            this.ResumeLayout(false);

        }

        #endregion

        public HengamWidgets.CoolTextBox txtStuffName;
        public HengamWidgets.CoolTextBox txtStuffID;
        public HengamWidgets.CoolLabel coolLabel1;

    }
}
