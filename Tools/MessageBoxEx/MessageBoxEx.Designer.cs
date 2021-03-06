namespace FarsiMessageBox
{
    partial class MessageBoxEx
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblMsg);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(361, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پيغام";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsg.ForeColor = System.Drawing.Color.Khaki;
            this.lblMsg.Location = new System.Drawing.Point(5, 16);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(350, 71);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "اين من هستم.\r\nاين هم پيغام من است كه مي خواهم شما آن را بدانيد.";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.Khaki;
            this.btnOK.Location = new System.Drawing.Point(12, 108);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "تائید";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.ForeColor = System.Drawing.Color.Khaki;
            this.btnNo.Location = new System.Drawing.Point(275, 108);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(98, 23);
            this.btnNo.TabIndex = 17;
            this.btnNo.Text = "خیر";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // MessageBoxEx
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnNo;
            this.ClientSize = new System.Drawing.Size(385, 143);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxEx";
            this.Opacity = 0.9;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "جهت اطلاع";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnNo;
    }
}