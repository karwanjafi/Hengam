namespace Hengam.Controls
{
    partial class HengamAnimatedButtonSmall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HengamAnimatedButtonSmall));
            this.btnAnimatedButton = new ExtendedPictureBoxLib.AnimatedPictureButton();
            this.SuspendLayout();
            // 
            // btnAnimatedButton
            // 
            this.btnAnimatedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnimatedButton.AnimationIntervall = 8;
            this.btnAnimatedButton.AnimationStepSize = 20;
            this.btnAnimatedButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60)))));
            this.btnAnimatedButton.EndState = new ExtendedPictureBoxLib.PictureBoxState(((byte)(255)), 0F, 90F, 0F, 0F, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))), 2F, 0F, 90F, new System.Drawing.Point(2, 2), new System.Drawing.Point(0, -5), new System.Drawing.Point(0, 20));
            this.btnAnimatedButton.Font = new System.Drawing.Font("B Kamran", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAnimatedButton.ForeColor = System.Drawing.Color.Black;
            this.btnAnimatedButton.Image = ((System.Drawing.Image)(resources.GetObject("btnAnimatedButton.Image")));
            this.btnAnimatedButton.Location = new System.Drawing.Point(-1, -2);
            this.btnAnimatedButton.Name = "btnAnimatedButton";
            this.btnAnimatedButton.PushedProperties = ((ExtendedPictureBoxLib.PictureBoxStateProperties)((((((ExtendedPictureBoxLib.PictureBoxStateProperties.Alpha | ExtendedPictureBoxLib.PictureBoxStateProperties.RotationAngle)
                        | ExtendedPictureBoxLib.PictureBoxStateProperties.Zoom)
                        | ExtendedPictureBoxLib.PictureBoxStateProperties.ExtraImageRotationAngle)
                        | ExtendedPictureBoxLib.PictureBoxStateProperties.ShadowOffset)
                        | ExtendedPictureBoxLib.PictureBoxStateProperties.ImageOffset)));
            this.btnAnimatedButton.ShadowMode = ExtendedPictureBoxLib.ShadowMode.OffsetFromImagePercent;
            this.btnAnimatedButton.Size = new System.Drawing.Size(61, 76);
            this.btnAnimatedButton.StartState = new ExtendedPictureBoxLib.PictureBoxState(((byte)(255)), 0F, 70F, -180F, 90F, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))), 2F, 0F, 150F, new System.Drawing.Point(2, -3), new System.Drawing.Point(0, -10), new System.Drawing.Point(0, 20));
            this.btnAnimatedButton.TabIndex = 1;
            this.btnAnimatedButton.Text = "فروش";
            this.btnAnimatedButton.Click += new System.EventHandler(this.btnAnimatedButton_Click);
            // 
            // HengamAnimatedButtonSmall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnAnimatedButton);
            this.Name = "HengamAnimatedButtonSmall";
            this.Size = new System.Drawing.Size(59, 73);
            this.ResumeLayout(false);

        }

        #endregion

        private ExtendedPictureBoxLib.AnimatedPictureButton btnAnimatedButton;
    }
}
