namespace Hengam.Controls
{
    partial class ActivitySelector
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
            this.radioActive = new System.Windows.Forms.RadioButton();
            this.radioDeactive = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioActive
            // 
            this.radioActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioActive.AutoSize = true;
            this.radioActive.Checked = true;
            this.radioActive.Location = new System.Drawing.Point(125, 3);
            this.radioActive.Name = "radioActive";
            this.radioActive.Size = new System.Drawing.Size(46, 17);
            this.radioActive.TabIndex = 0;
            this.radioActive.TabStop = true;
            this.radioActive.Text = "فعال";
            this.radioActive.UseVisualStyleBackColor = true;
            this.radioActive.CheckedChanged += new System.EventHandler(this.radioActive_CheckedChanged);
            // 
            // radioDeactive
            // 
            this.radioDeactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioDeactive.AutoSize = true;
            this.radioDeactive.Location = new System.Drawing.Point(57, 3);
            this.radioDeactive.Name = "radioDeactive";
            this.radioDeactive.Size = new System.Drawing.Size(62, 17);
            this.radioDeactive.TabIndex = 0;
            this.radioDeactive.Text = "غیرفعال";
            this.radioDeactive.UseVisualStyleBackColor = true;
            this.radioDeactive.CheckedChanged += new System.EventHandler(this.radioActive_CheckedChanged);
            // 
            // radioAll
            // 
            this.radioAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(5, 3);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(46, 17);
            this.radioAll.TabIndex = 0;
            this.radioAll.Text = "همه";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.radioActive_CheckedChanged);
            // 
            // ActivitySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.radioDeactive);
            this.Controls.Add(this.radioActive);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Orange;
            this.Name = "ActivitySelector";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(174, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioActive;
        private System.Windows.Forms.RadioButton radioDeactive;
        private System.Windows.Forms.RadioButton radioAll;
    }
}
