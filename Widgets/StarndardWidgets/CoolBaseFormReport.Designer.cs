using StandardWidgets;
namespace StandardWidgets
{
    partial class CoolBaseFormReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolBaseFormReport));
            this.groupDatagrid = new System.Windows.Forms.GroupBox();
            this.pnlSuggestions = new System.Windows.Forms.Panel();
            this.groupSuggestions = new System.Windows.Forms.GroupBox();
            this.pnlButtonsSugesstions = new System.Windows.Forms.Panel();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupItemDetails = new System.Windows.Forms.GroupBox();
            this.groupButtons = new System.Windows.Forms.GroupBox();
            this.btnShowSugestions = new StandardWidgets.CoolButton();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.btnSampleButton = new ExtendedPictureBoxLib.AnimatedPictureButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.coolMessage = new StandardWidgets.CoolMessage();
            this.toolTipForm = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipButtons = new System.Windows.Forms.ToolTip(this.components);
            this.imgButtons = new System.Windows.Forms.ImageList(this.components);
            this.groupDatagrid.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDatagrid.Controls.Add(this.pnlSuggestions);
            this.groupDatagrid.Controls.Add(this.crystalReportViewer);
            this.groupDatagrid.Location = new System.Drawing.Point(3, 138);
            this.groupDatagrid.Name = "groupDatagrid";
            this.groupDatagrid.Size = new System.Drawing.Size(499, 157);
            this.groupDatagrid.TabIndex = 0;
            this.groupDatagrid.TabStop = false;
            this.groupDatagrid.Text = "گزارش";
            // 
            // pnlSuggestions
            // 
            this.pnlSuggestions.AutoSize = true;
            this.pnlSuggestions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSuggestions.Controls.Add(this.groupSuggestions);
            this.pnlSuggestions.Location = new System.Drawing.Point(5, 11);
            this.pnlSuggestions.Name = "pnlSuggestions";
            this.pnlSuggestions.Size = new System.Drawing.Size(12, 25);
            this.pnlSuggestions.TabIndex = 1;
            this.pnlSuggestions.Visible = false;
            // 
            // groupSuggestions
            // 
            this.groupSuggestions.AutoSize = true;
            this.groupSuggestions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupSuggestions.Controls.Add(this.pnlButtonsSugesstions);
            this.groupSuggestions.Location = new System.Drawing.Point(3, 2);
            this.groupSuggestions.Name = "groupSuggestions";
            this.groupSuggestions.Size = new System.Drawing.Size(6, 20);
            this.groupSuggestions.TabIndex = 2;
            this.groupSuggestions.TabStop = false;
            this.groupSuggestions.Text = "کارهای پیشنهادی";
            // 
            // pnlButtonsSugesstions
            // 
            this.pnlButtonsSugesstions.AutoSize = true;
            this.pnlButtonsSugesstions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlButtonsSugesstions.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtonsSugesstions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtonsSugesstions.Location = new System.Drawing.Point(3, 17);
            this.pnlButtonsSugesstions.Name = "pnlButtonsSugesstions";
            this.pnlButtonsSugesstions.Size = new System.Drawing.Size(0, 0);
            this.pnlButtonsSugesstions.TabIndex = 0;
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.DisplayGroupTree = false;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.EnableDrillDown = false;
            this.crystalReportViewer.Location = new System.Drawing.Point(3, 17);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.SelectionFormula = "";
            this.crystalReportViewer.Size = new System.Drawing.Size(493, 137);
            this.crystalReportViewer.TabIndex = 3;
            this.crystalReportViewer.ViewTimeSelectionFormula = "";
            this.crystalReportViewer.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crystalReportViewer_ReportRefresh);
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupItemDetails.Controls.Add(this.groupButtons);
            this.groupItemDetails.Location = new System.Drawing.Point(3, 3);
            this.groupItemDetails.Name = "groupItemDetails";
            this.groupItemDetails.Size = new System.Drawing.Size(499, 129);
            this.groupItemDetails.TabIndex = 1;
            this.groupItemDetails.TabStop = false;
            this.groupItemDetails.Text = "تنظیمات گزاش";
            // 
            // groupButtons
            // 
            this.groupButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupButtons.Controls.Add(this.btnShowSugestions);
            this.groupButtons.Controls.Add(this.pnlAdd);
            this.groupButtons.Controls.Add(this.pnlUpdate);
            this.groupButtons.Location = new System.Drawing.Point(6, 11);
            this.groupButtons.Name = "groupButtons";
            this.groupButtons.Size = new System.Drawing.Size(45, 112);
            this.groupButtons.TabIndex = 0;
            this.groupButtons.TabStop = false;
            this.groupButtons.Text = "کارها";
            // 
            // btnShowSugestions
            // 
            this.btnShowSugestions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShowSugestions.Location = new System.Drawing.Point(3, 101);
            this.btnShowSugestions.Name = "btnShowSugestions";
            this.btnShowSugestions.Size = new System.Drawing.Size(39, 8);
            this.btnShowSugestions.TabIndex = 2;
            this.btnShowSugestions.TextToSet = "";
            this.btnShowSugestions.Visible = false;
            this.btnShowSugestions.Clicked += new System.EventHandler(this.btnShowSuggestions_Clicked);
            // 
            // pnlAdd
            // 
            this.pnlAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdd.Location = new System.Drawing.Point(3, 17);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(39, 92);
            this.pnlAdd.TabIndex = 0;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.AutoSize = true;
            this.pnlUpdate.BackColor = System.Drawing.Color.Transparent;
            this.pnlUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpdate.Location = new System.Drawing.Point(3, 17);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(39, 92);
            this.pnlUpdate.TabIndex = 1;
            // 
            // btnSampleButton
            // 
            this.btnSampleButton.AnimationStepSize = 50;
            this.btnSampleButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139)))));
            this.btnSampleButton.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSampleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSampleButton.Image = global::StandardWidgets.Properties.Resources.Add;
            this.btnSampleButton.Location = new System.Drawing.Point(60, 14);
            this.btnSampleButton.Name = "btnSampleButton";
            this.btnSampleButton.PushedProperties = ((ExtendedPictureBoxLib.PictureBoxStateProperties)((((((ExtendedPictureBoxLib.PictureBoxStateProperties.Alpha | ExtendedPictureBoxLib.PictureBoxStateProperties.RotationAngle)
                        | ExtendedPictureBoxLib.PictureBoxStateProperties.Zoom)
                        | ExtendedPictureBoxLib.PictureBoxStateProperties.ExtraImageRotationAngle)
                        | ExtendedPictureBoxLib.PictureBoxStateProperties.ShadowOffset)
                        | ExtendedPictureBoxLib.PictureBoxStateProperties.ImageOffset)));
            this.btnSampleButton.Size = new System.Drawing.Size(64, 58);
            this.btnSampleButton.TabIndex = 0;
            this.btnSampleButton.Text = "اضافه کردن";
            this.btnSampleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            this.btnSampleButton.Visible = false;
            this.btnSampleButton.Click += new System.EventHandler(this.btnSampleButton_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.groupItemDetails);
            this.pnlMain.Controls.Add(this.btnSampleButton);
            this.pnlMain.Controls.Add(this.groupDatagrid);
            this.pnlMain.Controls.Add(this.coolMessage);
            this.pnlMain.Location = new System.Drawing.Point(4, 16);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(505, 298);
            this.pnlMain.TabIndex = 2;
            // 
            // coolMessage
            // 
            this.coolMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.coolMessage.BackColorToSet = System.Drawing.Color.Bisque;
            this.coolMessage.BorderColor = System.Drawing.Color.Bisque;
            this.coolMessage.ForeColorToSet = System.Drawing.Color.RoyalBlue;
            this.coolMessage.Image = ((System.Drawing.Image)(resources.GetObject("coolMessage.Image")));
            this.coolMessage.Location = new System.Drawing.Point(123, 47);
            this.coolMessage.Name = "coolMessage";
            this.coolMessage.Size = new System.Drawing.Size(259, 52);
            this.coolMessage.TabIndex = 1;
            this.coolMessage.Visible = false;
            // 
            // toolTipForm
            // 
            this.toolTipForm.AutomaticDelay = 0;
            // 
            // toolTipButtons
            // 
            this.toolTipButtons.AutomaticDelay = 0;
            this.toolTipButtons.IsBalloon = true;
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
            this.imgButtons.Images.SetKeyName(5, "Printer");
            // 
            // CoolBaseFormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(131)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(521, 326);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "CoolBaseFormReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم گزارش‌ها";
            this.Load += new System.EventHandler(this.CoolBaseFormTableEditor_Load);
            this.groupDatagrid.ResumeLayout(false);
            this.groupDatagrid.PerformLayout();
            this.pnlSuggestions.ResumeLayout(false);
            this.pnlSuggestions.PerformLayout();
            this.groupSuggestions.ResumeLayout(false);
            this.groupSuggestions.PerformLayout();
            this.groupItemDetails.ResumeLayout(false);
            this.groupButtons.ResumeLayout(false);
            this.groupButtons.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupItemDetails;
        public System.Windows.Forms.GroupBox groupButtons;
        public System.Windows.Forms.Panel pnlMain;
        public System.Windows.Forms.GroupBox groupDatagrid;
        public System.Windows.Forms.ToolTip toolTipForm;
        public System.Windows.Forms.ToolTip toolTipButtons;
        public System.Windows.Forms.ImageList imgButtons;
        public StandardWidgets.CoolMessage coolMessage;
        public System.Windows.Forms.Panel pnlAdd;
        public System.Windows.Forms.Panel pnlUpdate;
        public ExtendedPictureBoxLib.AnimatedPictureButton btnSampleButton;
        public System.Windows.Forms.GroupBox groupSuggestions;
        public System.Windows.Forms.Panel pnlButtonsSugesstions;
        public System.Windows.Forms.Panel pnlSuggestions;
        public CoolButton btnShowSugestions;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
    }
}