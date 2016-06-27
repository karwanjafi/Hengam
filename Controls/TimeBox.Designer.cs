namespace Hengam.Controls
{
    partial class TimeBox
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
            this.cboTimes = new HengamWidgets.CoolComboBox();
            this.cboIntervals = new HengamWidgets.CoolComboBox();
            this.SuspendLayout();
            // 
            // cboTimes
            // 
            this.cboTimes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTimes.BackColor = System.Drawing.Color.Transparent;
            this.cboTimes.DisplayMember = "";
            this.cboTimes.Location = new System.Drawing.Point(0, 0);
            this.cboTimes.Name = "cboTimes";
            this.cboTimes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboTimes.SelectedItem = null;
            this.cboTimes.Size = new System.Drawing.Size(99, 21);
            this.cboTimes.TabIndex = 0;
            this.cboTimes.MouseLeave += new System.EventHandler(this.cboTimes_MouseLeave);
            this.cboTimes.SelectedValueChanged += new System.EventHandler(this.cboTimes_SelectedValueChanged);
            this.cboTimes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cboTimes_MouseMove);
            this.cboTimes.MouseEnter += new System.EventHandler(this.cboTimes_MouseEnter);
            // 
            // cboIntervals
            // 
            this.cboIntervals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboIntervals.BackColor = System.Drawing.Color.Transparent;
            this.cboIntervals.DisplayMember = "";
            this.cboIntervals.Location = new System.Drawing.Point(77, 0);
            this.cboIntervals.Name = "cboIntervals";
            this.cboIntervals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboIntervals.SelectedItem = null;
            this.cboIntervals.Size = new System.Drawing.Size(68, 21);
            this.cboIntervals.TabIndex = 1;
            this.cboIntervals.SelectedValueChanged += new System.EventHandler(this.cboIntervals_SelectedValueChanged);
            // 
            // TimeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cboTimes);
            this.Controls.Add(this.cboIntervals);
            this.Name = "TimeBox";
            this.Size = new System.Drawing.Size(145, 21);
            this.MouseLeave += new System.EventHandler(this.TimeBox_MouseLeave);
            this.MouseHover += new System.EventHandler(this.TimeBox_MouseHover);
            this.MouseEnter += new System.EventHandler(this.TimeBox_MouseEnter);
            this.ResumeLayout(false);

        }

        #endregion

        private HengamWidgets.CoolComboBox cboTimes;
        private HengamWidgets.CoolComboBox cboIntervals;
    }
}
