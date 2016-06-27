namespace Hengam.Forms
{
    partial class frmInternetUpdater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternetUpdater));
            this.prgrTable = new System.Windows.Forms.ProgressBar();
            this.prgrOveral = new System.Windows.Forms.ProgressBar();
            this.txtDateFrom = new HengamWidgets.CoolDateBox();
            this.coolLabel18 = new HengamWidgets.CoolLabel();
            this.coolLabel19 = new HengamWidgets.CoolLabel();
            this.txtDateTo = new HengamWidgets.CoolDateBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupItemDetails.SuspendLayout();
            this.groupButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.groupDatagrid.SuspendLayout();
            this.groupSuggestions.SuspendLayout();
            this.pnlSuggestions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupItemDetails
            // 
            this.groupItemDetails.Controls.Add(this.groupBox1);
            this.groupItemDetails.Controls.Add(this.txtDateFrom);
            this.groupItemDetails.Controls.Add(this.coolLabel18);
            this.groupItemDetails.Controls.Add(this.coolLabel19);
            this.groupItemDetails.Controls.Add(this.txtDateTo);
            this.groupItemDetails.Size = new System.Drawing.Size(499, 160);
            this.groupItemDetails.Text = "جزئیات به روز رسانی";
            this.groupItemDetails.Controls.SetChildIndex(this.groupButtons, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtDateTo, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel19, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.coolLabel18, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.txtDateFrom, 0);
            this.groupItemDetails.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // groupButtons
            // 
            this.groupButtons.Location = new System.Drawing.Point(6, 69);
            // 
            // groupDatagrid
            // 
            this.groupDatagrid.Location = new System.Drawing.Point(3, 169);
            this.groupDatagrid.Size = new System.Drawing.Size(499, 126);
            // 
            // imgButtons
            // 
            this.imgButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgButtons.ImageStream")));
            this.imgButtons.Images.SetKeyName(0, "Add");
            this.imgButtons.Images.SetKeyName(1, "Cancel");
            this.imgButtons.Images.SetKeyName(2, "Delete");
            this.imgButtons.Images.SetKeyName(3, "Update");
            this.imgButtons.Images.SetKeyName(4, "CancelSuggestion");
            // 
            // dataGridSection
            // 
            this.dataGridSection.Size = new System.Drawing.Size(487, 100);
            this.dataGridSection.OnLoadDataGrid += new System.EventHandler(this.dataGridSection_OnLoadDataGrid);
            // 
            // btnSampleButton
            // 
            this.toolTipButtons.SetToolTip(this.btnSampleButton, "اضافه کردن");
            // 
            // btnShowSugestions
            // 
            this.btnShowSugestions.Size = new System.Drawing.Size(4, 8);
            // 
            // prgrTable
            // 
            this.prgrTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.prgrTable.Location = new System.Drawing.Point(3, 29);
            this.prgrTable.Name = "prgrTable";
            this.prgrTable.Size = new System.Drawing.Size(313, 23);
            this.prgrTable.TabIndex = 1;
            // 
            // prgrOveral
            // 
            this.prgrOveral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.prgrOveral.Location = new System.Drawing.Point(3, 58);
            this.prgrOveral.Name = "prgrOveral";
            this.prgrOveral.Size = new System.Drawing.Size(313, 23);
            this.prgrOveral.TabIndex = 1;
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Accepted = false;
            this.txtDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateFrom.BackColor = System.Drawing.Color.Transparent;
            this.txtDateFrom.CursorLocation = 8;
            this.txtDateFrom.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDateFrom.IsEmpty = false;
            this.txtDateFrom.Location = new System.Drawing.Point(332, 20);
            this.txtDateFrom.Mask = "0000/00/00";
            this.txtDateFrom.Message = "طول کم";
            this.txtDateFrom.MustFill = true;
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.ReadOnly = false;
            this.txtDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateFrom.Size = new System.Drawing.Size(101, 21);
            this.txtDateFrom.TabIndex = 16;
            this.txtDateFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDateFrom.TextToSet = "    /  /";
            // 
            // coolLabel18
            // 
            this.coolLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel18.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel18.Location = new System.Drawing.Point(439, 20);
            this.coolLabel18.Name = "coolLabel18";
            this.coolLabel18.Size = new System.Drawing.Size(43, 21);
            this.coolLabel18.TabIndex = 15;
            this.coolLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel18.TextToSet = "از تاریخ:";
            // 
            // coolLabel19
            // 
            this.coolLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel19.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel19.Location = new System.Drawing.Point(307, 20);
            this.coolLabel19.Name = "coolLabel19";
            this.coolLabel19.Size = new System.Drawing.Size(19, 21);
            this.coolLabel19.TabIndex = 14;
            this.coolLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel19.TextToSet = "تا:";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Accepted = false;
            this.txtDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDateTo.BackColor = System.Drawing.Color.Transparent;
            this.txtDateTo.CursorLocation = 8;
            this.txtDateTo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtDateTo.IsEmpty = false;
            this.txtDateTo.Location = new System.Drawing.Point(200, 20);
            this.txtDateTo.Mask = "0000/00/00";
            this.txtDateTo.Message = "طول کم";
            this.txtDateTo.MustFill = true;
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.ReadOnly = false;
            this.txtDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDateTo.Size = new System.Drawing.Size(101, 21);
            this.txtDateTo.TabIndex = 17;
            this.txtDateTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDateTo.TextToSet = "    /  /";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(168, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 104);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "در حال به روز رسانی";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.prgrTable);
            this.panel1.Controls.Add(this.prgrOveral);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 84);
            this.panel1.TabIndex = 0;
            // 
            // frmInternetUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(521, 326);
            this.Name = "frmInternetUpdater";
            this.Text = "به روزرسانی اینترنت";
            this.LoadForm += new System.EventHandler(this.frmInternetUpdater_LoadForm);
            this.groupItemDetails.ResumeLayout(false);
            this.groupButtons.ResumeLayout(false);
            this.groupButtons.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.groupDatagrid.ResumeLayout(false);
            this.groupDatagrid.PerformLayout();
            this.groupSuggestions.ResumeLayout(false);
            this.groupSuggestions.PerformLayout();
            this.pnlSuggestions.ResumeLayout(false);
            this.pnlSuggestions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgrTable;
        private System.Windows.Forms.ProgressBar prgrOveral;
        private HengamWidgets.CoolDateBox txtDateFrom;
        private HengamWidgets.CoolLabel coolLabel18;
        private HengamWidgets.CoolLabel coolLabel19;
        private HengamWidgets.CoolDateBox txtDateTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
    }
}
