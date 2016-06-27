namespace Hengam.Forms.Student
{
    partial class frmStudentAffairs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentAffairs));
            this.groupStudentAffairs = new System.Windows.Forms.GroupBox();
            this.btnStudentRegisteration = new Hengam.Controls.HengamAnimatedButton();
            this.btnStudentManager = new Hengam.Controls.HengamAnimatedButton();
            this.btnStudentBalance = new Hengam.Controls.HengamAnimatedButton();
            this.btnStudentPayForClass = new Hengam.Controls.HengamAnimatedButton();
            this.pnlMain.SuspendLayout();
            this.groupStudentAffairs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.groupStudentAffairs);
            this.pnlMain.Size = new System.Drawing.Size(814, 526);
            this.pnlMain.Controls.SetChildIndex(this.coolMessage, 0);
            this.pnlMain.Controls.SetChildIndex(this.groupStudentAffairs, 0);
            // 
            // coolMessage
            // 
            this.coolMessage.Location = new System.Drawing.Point(266, 239);
            // 
            // groupStudentAffairs
            // 
            this.groupStudentAffairs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupStudentAffairs.Controls.Add(this.btnStudentRegisteration);
            this.groupStudentAffairs.Controls.Add(this.btnStudentManager);
            this.groupStudentAffairs.Controls.Add(this.btnStudentBalance);
            this.groupStudentAffairs.Controls.Add(this.btnStudentPayForClass);
            this.groupStudentAffairs.Location = new System.Drawing.Point(83, 56);
            this.groupStudentAffairs.Name = "groupStudentAffairs";
            this.groupStudentAffairs.Size = new System.Drawing.Size(631, 413);
            this.groupStudentAffairs.TabIndex = 2;
            this.groupStudentAffairs.TabStop = false;
            this.groupStudentAffairs.Text = "امور هنرجو";
            // 
            // btnStudentRegisteration
            // 
            this.btnStudentRegisteration.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentRegisteration.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentRegisteration.Image")));
            this.btnStudentRegisteration.Location = new System.Drawing.Point(41, 183);
            this.btnStudentRegisteration.Name = "btnStudentRegisteration";
            this.btnStudentRegisteration.Size = new System.Drawing.Size(218, 92);
            this.btnStudentRegisteration.TabIndex = 0;
            this.btnStudentRegisteration.TextToSet = "ثبت نام هنرجو در کلاس";
            this.btnStudentRegisteration.Clicked += new System.EventHandler(this.btnStudentRegisteration_Clicked);
            // 
            // btnStudentManager
            // 
            this.btnStudentManager.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentManager.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentManager.Image")));
            this.btnStudentManager.Location = new System.Drawing.Point(236, 302);
            this.btnStudentManager.Name = "btnStudentManager";
            this.btnStudentManager.Size = new System.Drawing.Size(182, 92);
            this.btnStudentManager.TabIndex = 0;
            this.btnStudentManager.TextToSet = "مدیریت دانشجویان";
            this.btnStudentManager.Clicked += new System.EventHandler(this.btnStudentManager_Clicked);
            // 
            // btnStudentBalance
            // 
            this.btnStudentBalance.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentBalance.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentBalance.Image")));
            this.btnStudentBalance.Location = new System.Drawing.Point(427, 183);
            this.btnStudentBalance.Name = "btnStudentBalance";
            this.btnStudentBalance.Size = new System.Drawing.Size(182, 92);
            this.btnStudentBalance.TabIndex = 0;
            this.btnStudentBalance.TextToSet = "تسویه حساب";
            this.btnStudentBalance.Clicked += new System.EventHandler(this.btnStudentBalance_Clicked);
            // 
            // btnStudentPayForClass
            // 
            this.btnStudentPayForClass.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentPayForClass.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentPayForClass.Image")));
            this.btnStudentPayForClass.Location = new System.Drawing.Point(236, 40);
            this.btnStudentPayForClass.Name = "btnStudentPayForClass";
            this.btnStudentPayForClass.Size = new System.Drawing.Size(182, 92);
            this.btnStudentPayForClass.TabIndex = 0;
            this.btnStudentPayForClass.TextToSet = "پرداخت شهریه";
            this.btnStudentPayForClass.Clicked += new System.EventHandler(this.btnStudentPayForClass_Clicked);
            // 
            // frmStudentAffairs
            // 
            this.ClientSize = new System.Drawing.Size(838, 550);
            this.Name = "frmStudentAffairs";
            this.Text = "امور هنرجویان";
            this.pnlMain.ResumeLayout(false);
            this.groupStudentAffairs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupStudentAffairs;
        private Hengam.Controls.HengamAnimatedButton btnStudentPayForClass;
        private Hengam.Controls.HengamAnimatedButton btnStudentRegisteration;
        private Hengam.Controls.HengamAnimatedButton btnStudentManager;
        private Hengam.Controls.HengamAnimatedButton btnStudentBalance;
    }
}
