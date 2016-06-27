namespace StandardWidgets
{
    partial class CoolComboBox
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
            this.cbo = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picOK = new System.Windows.Forms.PictureBox();
            this.picError = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo
            // 
            this.cbo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(22, 0);
            this.cbo.MaxDropDownItems = 15;
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(128, 21);
            this.cbo.TabIndex = 0;
            this.cbo.SelectedValueChanged += new System.EventHandler(this.cbo_SelectedValueChanged);
            this.cbo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbo_KeyDown);
            // 
            // picOK
            // 
            this.picOK.BackColor = System.Drawing.Color.Transparent;
            this.picOK.Image = global::StandardWidgets.Properties.Resources.ok;
            this.picOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picOK.Location = new System.Drawing.Point(3, 2);
            this.picOK.Name = "picOK";
            this.picOK.Size = new System.Drawing.Size(18, 17);
            this.picOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOK.TabIndex = 2;
            this.picOK.TabStop = false;
            this.picOK.Visible = false;
            // 
            // picError
            // 
            this.picError.BackColor = System.Drawing.Color.Transparent;
            this.picError.Image = global::StandardWidgets.Properties.Resources.Delete;
            this.picError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picError.Location = new System.Drawing.Point(3, 2);
            this.picError.Name = "picError";
            this.picError.Size = new System.Drawing.Size(17, 16);
            this.picError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picError.TabIndex = 3;
            this.picError.TabStop = false;
            // 
            // CoolComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picOK);
            this.Controls.Add(this.cbo);
            this.Controls.Add(this.picError);
            this.Name = "CoolComboBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(150, 21);
            ((System.ComponentModel.ISupportInitialize)(this.picOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picOK;
        private System.Windows.Forms.PictureBox picError;
    }
}
