namespace Hengam.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imgListLinks = new System.Windows.Forms.ImageList(this.components);
            this.imageListGroups = new System.Windows.Forms.ImageList(this.components);
            this.lnkChangePassword = new System.Windows.Forms.LinkLabel();
            this.floaterChangePassword = new HengamWidgets.PanelFloater();
            this.coolLabel1 = new HengamWidgets.CoolLabel();
            this.coolLabel2 = new HengamWidgets.CoolLabel();
            this.lblUsername = new HengamWidgets.CoolLabel();
            this.lblLoginTime = new HengamWidgets.CoolLabel();
            this.coolLabel3 = new HengamWidgets.CoolLabel();
            this.lblbirthday = new HengamWidgets.CoolLabel();
            this.datagridBday = new StandardWidgets.CoolDataGrid();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabStrip)).BeginInit();
            this.tabStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.coolLabel2);
            this.pnlHeader.Controls.Add(this.lblLoginTime);
            this.pnlHeader.Controls.Add(this.lblUsername);
            this.pnlHeader.Controls.Add(this.coolLabel1);
            this.pnlHeader.Controls.Add(this.lnkChangePassword);
            // 
            // coolMenu1
            // 
            this.coolMenu1.ImageList = this.imgListLinks;
            this.coolMenu1.LogoImage = ((System.Drawing.Image)(resources.GetObject("coolMenu1.LogoImage")));
            this.coolMenu1.Size = new System.Drawing.Size(241, 401);
            this.coolMenu1.TabStop = false;
            // 
            // imgListLinks
            // 
            this.imgListLinks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListLinks.ImageStream")));
            this.imgListLinks.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListLinks.Images.SetKeyName(0, "Music");
            // 
            // imageListGroups
            // 
            this.imageListGroups.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListGroups.ImageStream")));
            this.imageListGroups.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListGroups.Images.SetKeyName(0, "Misc");
            this.imageListGroups.Images.SetKeyName(1, "Class");
            this.imageListGroups.Images.SetKeyName(2, "Student");
            this.imageListGroups.Images.SetKeyName(3, "Report");
            this.imageListGroups.Images.SetKeyName(4, "Teacher");
            this.imageListGroups.Images.SetKeyName(5, "System");
            // 
            // lnkChangePassword
            // 
            this.lnkChangePassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkChangePassword.Location = new System.Drawing.Point(12, 3);
            this.lnkChangePassword.Name = "lnkChangePassword";
            this.lnkChangePassword.Size = new System.Drawing.Size(47, 15);
            this.lnkChangePassword.TabIndex = 0;
            this.lnkChangePassword.TabStop = true;
            this.lnkChangePassword.Text = "تغییر رمز";
            this.lnkChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChangePassword_LinkClicked);
            // 
            // floaterChangePassword
            // 
            this.floaterChangePassword.BackColor = System.Drawing.Color.DimGray;
            this.floaterChangePassword.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.floaterChangePassword.Location = new System.Drawing.Point(4, 55);
            this.floaterChangePassword.Name = "floaterChangePassword";
            this.floaterChangePassword.Size = new System.Drawing.Size(314, 341);
            this.floaterChangePassword.TabIndex = 19;
            this.floaterChangePassword.TitleColor = System.Drawing.Color.Orange;
            this.floaterChangePassword.TitleText = "";
            this.floaterChangePassword.Visible = false;
            // 
            // coolLabel1
            // 
            this.coolLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel1.Location = new System.Drawing.Point(637, 4);
            this.coolLabel1.Name = "coolLabel1";
            this.coolLabel1.Size = new System.Drawing.Size(33, 15);
            this.coolLabel1.TabIndex = 1;
            this.coolLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel1.TextToSet = "کاربر:";
            // 
            // coolLabel2
            // 
            this.coolLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel2.Location = new System.Drawing.Point(436, 4);
            this.coolLabel2.Name = "coolLabel2";
            this.coolLabel2.Size = new System.Drawing.Size(57, 15);
            this.coolLabel2.TabIndex = 1;
            this.coolLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel2.TextToSet = "زمان ورود:";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Location = new System.Drawing.Point(499, 4);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.TextToSet = "-";
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginTime.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginTime.Location = new System.Drawing.Point(127, 4);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(305, 15);
            this.lblLoginTime.TabIndex = 1;
            this.lblLoginTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLoginTime.TextToSet = "-";
            // 
            // coolLabel3
            // 
            this.coolLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.coolLabel3.Location = new System.Drawing.Point(338, 374);
            this.coolLabel3.Name = "coolLabel3";
            this.coolLabel3.Size = new System.Drawing.Size(88, 21);
            this.coolLabel3.TabIndex = 20;
            this.coolLabel3.TabStop = false;
            this.coolLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.coolLabel3.TextToSet = "امروز زادروز :";
            // 
            // lblbirthday
            // 
            this.lblbirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblbirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblbirthday.Location = new System.Drawing.Point(249, 374);
            this.lblbirthday.Name = "lblbirthday";
            this.lblbirthday.Size = new System.Drawing.Size(88, 21);
            this.lblbirthday.TabIndex = 21;
            this.lblbirthday.TabStop = false;
            this.lblbirthday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblbirthday.TextToSet = "";
            // 
            // datagridBday
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridBday.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridBday.ForeColor = System.Drawing.SystemColors.ControlText;
            this.datagridBday.Location = new System.Drawing.Point(0, 0);
            this.datagridBday.MultiSelect = false;
            this.datagridBday.Name = "datagridBday";
            this.datagridBday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datagridBday.Searchable = true;
            this.datagridBday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridBday.Size = new System.Drawing.Size(391, 239);
            this.datagridBday.TabIndex = 20;
            this.datagridBday.OnLoadDataGrid += new System.EventHandler(this.datagridBday_OnLoadDataGrid);
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(673, 471);
            this.Controls.Add(this.floaterChangePassword);
            this.Name = "frmMain";
            this.Text = "به سیستم جامع مدیریت آموزشگاه هنگام خوش آمدید.";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Controls.SetChildIndex(this.pnlHeader, 0);
            this.Controls.SetChildIndex(this.coolMenu1, 0);
            this.Controls.SetChildIndex(this.tabStrip, 0);
            this.Controls.SetChildIndex(this.floaterChangePassword, 0);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabStrip)).EndInit();
            this.tabStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgListLinks;
        private System.Windows.Forms.ImageList imageListGroups;
        private System.Windows.Forms.LinkLabel lnkChangePassword;
        private HengamWidgets.PanelFloater floaterChangePassword;
        private HengamWidgets.CoolLabel coolLabel2;
        private HengamWidgets.CoolLabel lblLoginTime;
        private HengamWidgets.CoolLabel lblUsername;
        private HengamWidgets.CoolLabel coolLabel1;
        private HengamWidgets.CoolLabel coolLabel3;
        private HengamWidgets.CoolLabel lblbirthday;
        private StandardWidgets.CoolDataGrid datagridBday;
    }
}
