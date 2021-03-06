using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiMessageBox;
using Zeitoon;
using Zeitoon.Tools;

namespace CoolFrom
{
    public partial class frmChangePassword : Form, IPaneled
    {
        PanelModifier pm;
        public frmChangePassword(PanelModifier pModifier)
        {
            InitializeComponent();
            pm = pModifier;
            txtUsername.Text = CoolForm.Username;
        }
       
        private void pnlMain_Enter(object sender, EventArgs e)
        {
        }



        #region IPaneled Members

        public Panel MainPanel
        {
            get { return pnlMain; }
        }

        #endregion

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
                MsgBlue("رمز عبور با موفقیت تغییر پیدا کرد.");
        }

        private bool ChangePassword(string User, string Pass)
        {
            bool changed = DesktopUserDetailsBO.ChagePassword(CoolForm.Username, txtLastPassword.Text, txtNewPassword.Text);
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
            pm.Hide();
        }

        internal void Set(string Username)
        {
            txtUsername.Text = Username;
            txtLastPassword.Text = "";
            txtNewPassword.Text = "";
            txtRepeatPassword.Text = "";
        }
    }
}