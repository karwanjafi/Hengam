namespace StandardWidgets
{
    partial class CoolTimeSlot
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnTime = new System.Windows.Forms.Button();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5000;
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 1000;
            this.toolTip1.ShowAlways = true;
            // 
            // btnTime
            // 
            this.btnTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTime.Location = new System.Drawing.Point(0, 0);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(65, 24);
            this.btnTime.TabIndex = 0;
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Visible = false;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            this.btnTime.MouseEnter += new System.EventHandler(this.btnTime_MouseEnter);
            // 
            // lblLink
            // 
            this.lblLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLink.BackColor = System.Drawing.Color.Transparent;
            this.lblLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLink.Location = new System.Drawing.Point(0, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLink.Size = new System.Drawing.Size(65, 24);
            this.lblLink.TabIndex = 1;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "123546";
            this.lblLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLink.Click += new System.EventHandler(this.btnTime_Click);
            this.lblLink.MouseEnter += new System.EventHandler(this.btnTime_MouseEnter);
            // 
            // CoolTimeSlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.btnTime);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "CoolTimeSlot";
            this.Size = new System.Drawing.Size(65, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.LinkLabel lblLink;
    }
}
