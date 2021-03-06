using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiMessageBox;
using Tools;
using BusinessObjectNamespace;
using Hengam.Tools;
using StandardWidgets;



namespace Hengam.Forms
{
    public partial class frmChangePassword : Form, IFloatable, IPaneled
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void pnlMain_Enter(object sender, EventArgs e)
        {
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != txtRepeatPassword.Text)
            {
                MsgRed("رمزهای ورودی باید یکسان باشند.");
                return;
            }

            MsgBlue("در حال بررسی اطلاعات کاربری...");
            bool changed = ChangePassword(txtUsername.Text, txtRepeatPassword.Text);
            if (!changed)
                MsgRed("اطلاعات نادرست است. لطفا دوباره وارد کنید.");
            else
                MsgRed("رمز عبور با موفقیت تغییر پیدا کرد.");
        }

        private bool ChangePassword(string User, string Pass)
        {
            bool changed = DesktopUsersBO.ChagePassword(User, txtLastPassword.Text, txtNewPassword.Text);
            if ( changed == true )
            {
                return true;
            }
            return false;
        }

        private void MsgBlue(string msg)
        {
            lblMsg.Text = msg;
            lblMsg.ForeColor = Color.Blue;
        }

        private void MsgRed(string msg)
        {
            lblMsg.Text = msg;
            lblMsg.ForeColor = Color.Yellow;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //MsgBlue("اطلاعات کاربری را وارد کنید.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ContainerFloater.Hide();
        }

        internal void Set(string Username)
        {
            txtUsername.Text = Username;
            txtLastPassword.Text = "";
            txtNewPassword.Text = "";
            txtRepeatPassword.Text = "";
        }

        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion

        #region IPaneled Members

        public Panel MainPanel
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region IPaneled Members

        Panel IPaneled.MainPanel
        {
            get { return pnlMain; }
        }

        #endregion
    }
}