using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiMessageBox;
using Hengam;
using BusinessObjectNamespace;
using Hengam.Tools;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmLogin : Form, IPaneled
    {
        public frmLogin()
        {
            InitializeComponent();
            LoggedIn = false;
            DesktopUsersBO.FillCombo(cboUsername);
            foreach ( object obj in cboUsername.Items )
            {
                cboUsername.AutoCompleteCustomSource.Add(obj.ToString().TrimEnd(' '));
            }
        }
        
        public DesktopUsersBO UserBO;
        public bool LoggedIn = false;
        
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
            UserBO = DesktopUsersBO.Find(User, Pass);
            if (UserBO != null)
            {
                return true;
            }
            else
            {
                return false;
            }
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
    }
}