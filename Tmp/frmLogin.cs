using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiMessageBox;
using Zeitoon;

namespace CoolFrom
{
    public partial class frmLogin : Form, IPaneled
    {
        public frmLogin()
        {
            InitializeComponent();
            LoggedIn = false;
            DesktopUserDetailsBO.FillCombo(cboUsername);
            foreach ( object obj in cboUsername.Items )
            {
                cboUsername.AutoCompleteCustomSource.Add(obj.ToString());
            }
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
            MsgBlue("در حال بررسی اطلاعات کاربری...");
            LoggedIn = CheckUsernamePassword(cboUsername.Text, txtPassword.Text);
            if (!LoggedIn)
                MsgRed("اطلاعات نادرست است. لطفا دوباره وارد کنید.");
        }

        private bool CheckUsernamePassword(string User, string Pass)
        {
            UserBO = DesktopUserDetailsBO.Find(User, Pass);
            if ( UserBO != null )
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

        public DesktopUserDetailsBO UserBO;
        public bool LoggedIn = false;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //MsgBlue("اطلاعات کاربری را وارد کنید.");
        }
    }
}