namespace StandardWidgets
{
    partial class PanelFloater
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblLabel = new System.Windows.Forms.Label();
            this.pnlButtomBar = new System.Windows.Forms.Panel();
            this.pnlButtomLeft = new System.Windows.Forms.Panel();
            this.pnlButtomRight = new System.Windows.Forms.Panel();
            this.pnlBackground.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlButtomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BackColor = System.Drawing.Color.DimGray;
            this.pnlContainer.Location = new System.Drawing.Point(5, 20);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(394, 301);
            this.pnlContainer.TabIndex = 0;
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.BackgroundImage = global::StandardWidgets.Properties.Resources.Delete;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Location = new System.Drawing.Point(379, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(22, 19);
            this.btnHide.TabIndex = 2;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.BackColor = System.Drawing.Color.DimGray;
            this.pnlBackground.Controls.Add(this.btnHide);
            this.pnlBackground.Controls.Add(this.pnlTitleBar);
            this.pnlBackground.Controls.Add(this.pnlContainer);
            this.pnlBackground.Controls.Add(this.pnlButtomBar);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlBackground.Size = new System.Drawing.Size(404, 332);
            this.pnlBackground.TabIndex = 0;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitleBar.BackColor = System.Drawing.Color.Yellow;
            this.pnlTitleBar.Controls.Add(this.lblLabel);
            this.pnlTitleBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlTitleBar.Location = new System.Drawing.Point(3, 4);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(374, 13);
            this.pnlTitleBar.TabIndex = 4;
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseHover += new System.EventHandler(this.pnlTitleBar_MouseHover);
            // 
            // lblLabel
            // 
            this.lblLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabel.BackColor = System.Drawing.Color.Orange;
            this.lblLabel.ForeColor = System.Drawing.Color.Blue;
            this.lblLabel.Location = new System.Drawing.Point(3, -2);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(371, 15);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.lblLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.lblLabel.MouseHover += new System.EventHandler(this.pnlTitleBar_MouseHover);
            // 
            // pnlButtomBar
            // 
            this.pnlButtomBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtomBar.BackColor = System.Drawing.Color.Orange;
            this.pnlButtomBar.Controls.Add(this.pnlButtomLeft);
            this.pnlButtomBar.Controls.Add(this.pnlButtomRight);
            this.pnlButtomBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlButtomBar.Location = new System.Drawing.Point(1, 20);
            this.pnlButtomBar.Name = "pnlButtomBar";
            this.pnlButtomBar.Size = new System.Drawing.Size(403, 309);
            this.pnlButtomBar.TabIndex = 5;
            // 
            // pnlButtomLeft
            // 
            this.pnlButtomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtomLeft.BackColor = System.Drawing.Color.Orange;
            this.pnlButtomLeft.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pnlButtomLeft.Location = new System.Drawing.Point(0, 300);
            this.pnlButtomLeft.Name = "pnlButtomLeft";
            this.pnlButtomLeft.Size = new System.Drawing.Size(25, 11);
            this.pnlButtomLeft.TabIndex = 6;
            // 
            // pnlButtomRight
            // 
            this.pnlButtomRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlButtomRight.BackColor = System.Drawing.Color.Orange;
            this.pnlButtomRight.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.pnlButtomRight.Location = new System.Drawing.Point(378, 300);
            this.pnlButtomRight.Name = "pnlButtomRight";
            this.pnlButtomRight.Size = new System.Drawing.Size(25, 11);
            this.pnlButtomRight.TabIndex = 6;
            this.pnlButtomRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlButtomRight_MouseMove);
            this.pnlButtomRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlButtomRight_MouseDown);
            this.pnlButtomRight.MouseHover += new System.EventHandler(this.pnlButtomRight_MouseHover);
            // 
            // PanelFloater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.pnlBackground);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "PanelFloater";
            this.Size = new System.Drawing.Size(404, 332);
            this.pnlBackground.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlButtomBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlButtomBar;
        private System.Windows.Forms.Panel pnlButtomRight;
        private System.Windows.Forms.Panel pnlButtomLeft;
        private System.Windows.Forms.Label lblLabel;
    }
}
