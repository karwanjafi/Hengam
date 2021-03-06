namespace StandardWidgets
{
    partial class CoolValidatorTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolValidatorTextBox));
            this.txtValidatorBox = new System.Windows.Forms.MaskedTextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.toolTipMsg = new System.Windows.Forms.ToolTip(this.components);
            this.picOK = new System.Windows.Forms.PictureBox();
            this.picError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtValidatorBox
            // 
            this.txtValidatorBox.AccessibleDescription = null;
            this.txtValidatorBox.AccessibleName = null;
            resources.ApplyResources(this.txtValidatorBox, "txtValidatorBox");
            this.txtValidatorBox.BackgroundImage = null;
            this.txtValidatorBox.Name = "txtValidatorBox";
            this.txtValidatorBox.RejectInputOnFirstFailure = true;
            this.toolTipMsg.SetToolTip(this.txtValidatorBox, resources.GetString("txtValidatorBox.ToolTip"));
            this.txtValidatorBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValidatorBox_KeyDown);
            this.txtValidatorBox.Leave += new System.EventHandler(this.txtValidatorBox_Leave);
            this.txtValidatorBox.Enter += new System.EventHandler(this.txtValidatorBox_Enter);
            this.txtValidatorBox.TextChanged += new System.EventHandler(this.txtValidatorBox_TextChanged);
            this.txtValidatorBox.Click += new System.EventHandler(this.txtValidatorBox_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AccessibleDescription = null;
            this.lblMsg.AccessibleName = null;
            resources.ApplyResources(this.lblMsg, "lblMsg");
            this.lblMsg.BackColor = System.Drawing.Color.White;
            this.lblMsg.ForeColor = System.Drawing.Color.Gray;
            this.lblMsg.Name = "lblMsg";
            this.toolTipMsg.SetToolTip(this.lblMsg, resources.GetString("lblMsg.ToolTip"));
            this.lblMsg.MouseHover += new System.EventHandler(this.lblMsg_MouseHover);
            // 
            // toolTipMsg
            // 
            this.toolTipMsg.AutoPopDelay = 5000;
            this.toolTipMsg.InitialDelay = 0;
            this.toolTipMsg.ReshowDelay = 100;
            // 
            // picOK
            // 
            this.picOK.AccessibleDescription = null;
            this.picOK.AccessibleName = null;
            resources.ApplyResources(this.picOK, "picOK");
            this.picOK.BackColor = System.Drawing.Color.Transparent;
            this.picOK.BackgroundImage = null;
            this.picOK.Font = null;
            this.picOK.Image = global::StandardWidgets.Properties.Resources.ok;
            this.picOK.ImageLocation = null;
            this.picOK.Name = "picOK";
            this.picOK.TabStop = false;
            this.toolTipMsg.SetToolTip(this.picOK, resources.GetString("picOK.ToolTip"));
            // 
            // picError
            // 
            this.picError.AccessibleDescription = null;
            this.picError.AccessibleName = null;
            resources.ApplyResources(this.picError, "picError");
            this.picError.BackgroundImage = null;
            this.picError.Font = null;
            this.picError.Image = global::StandardWidgets.Properties.Resources.Delete;
            this.picError.ImageLocation = null;
            this.picError.Name = "picError";
            this.picError.TabStop = false;
            this.toolTipMsg.SetToolTip(this.picError, resources.GetString("picError.ToolTip"));
            // 
            // CoolValidatorTextBox
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = null;
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtValidatorBox);
            this.Controls.Add(this.picOK);
            this.Controls.Add(this.picError);
            this.Name = "CoolValidatorTextBox";
            this.toolTipMsg.SetToolTip(this, resources.GetString("$this.ToolTip"));
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtValidatorBox;
        private System.Windows.Forms.PictureBox picOK;
        private System.Windows.Forms.PictureBox picError;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ToolTip toolTipMsg;
    }
}
