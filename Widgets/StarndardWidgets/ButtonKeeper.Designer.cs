namespace StandardWidgets
{
    partial class ButtonKeeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonKeeper));
            this.groupButtons = new System.Windows.Forms.GroupBox();
            this.btnShowSugestions = new StandardWidgets.CoolButton();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.imgButtons = new System.Windows.Forms.ImageList(this.components);
            this.toolTipButtons = new System.Windows.Forms.ToolTip(this.components);
            this.groupButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupButtons
            // 
            this.groupButtons.Controls.Add(this.btnShowSugestions);
            this.groupButtons.Controls.Add(this.pnlAdd);
            this.groupButtons.Controls.Add(this.pnlUpdate);
            this.groupButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupButtons.Location = new System.Drawing.Point(0, 0);
            this.groupButtons.Name = "groupButtons";
            this.groupButtons.Size = new System.Drawing.Size(157, 107);
            this.groupButtons.TabIndex = 1;
            this.groupButtons.TabStop = false;
            this.groupButtons.Text = "کارها";
            // 
            // btnShowSugestions
            // 
            this.btnShowSugestions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShowSugestions.Location = new System.Drawing.Point(3, 96);
            this.btnShowSugestions.Name = "btnShowSugestions";
            this.btnShowSugestions.Size = new System.Drawing.Size(151, 8);
            this.btnShowSugestions.TabIndex = 2;
            this.btnShowSugestions.TabStop = false;
            this.btnShowSugestions.TextToSet = "";
            this.btnShowSugestions.Visible = false;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.AutoSize = true;
            this.pnlUpdate.BackColor = System.Drawing.Color.Transparent;
            this.pnlUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdate.Location = new System.Drawing.Point(3, 17);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(151, 87);
            this.pnlUpdate.TabIndex = 1;
            // 
            // pnlAdd
            // 
            this.pnlAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdd.Location = new System.Drawing.Point(3, 17);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(151, 87);
            this.pnlAdd.TabIndex = 0;
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgButtons.Images.SetKeyName(0, "Add");
            this.imgButtons.Images.SetKeyName(1, "Cancel");
            this.imgButtons.Images.SetKeyName(2, "Delete");
            this.imgButtons.Images.SetKeyName(3, "Update");
            this.imgButtons.Images.SetKeyName(4, "CancelSuggestion");
            // 
            // toolTipButtons
            // 
            this.toolTipButtons.AutomaticDelay = 0;
            this.toolTipButtons.IsBalloon = true;
            // 
            // ButtonKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupButtons);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ButtonKeeper";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(157, 107);
            this.groupButtons.ResumeLayout(false);
            this.groupButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupButtons;
        public CoolButton btnShowSugestions;
        public System.Windows.Forms.Panel pnlAdd;
        public System.Windows.Forms.Panel pnlUpdate;
        public System.Windows.Forms.ImageList imgButtons;
        public System.Windows.Forms.ToolTip toolTipButtons;
    }
}
