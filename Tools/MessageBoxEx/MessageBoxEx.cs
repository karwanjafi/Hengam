using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FarsiMessageBox
{
    public partial class MessageBoxEx : Form
    {
        public MessageBoxEx(string Msg, string Solution, string Title, bool YesNo)
        {
            InitializeComponent();
            ConfigWindow(Msg, Solution, Title, YesNo);
        }

        public MessageBoxEx(string Msg, string Solution)
        {
            InitializeComponent();
            ConfigWindow(Msg, Solution, "", false);
        }

        public MessageBoxEx(string Msg)
        {
            InitializeComponent();
            ConfigWindow(Msg, "", "", false);
        }

        private void ConfigWindow(string Msg , string Solution, string Title, bool YesNo)
        {
            lblMsg.Text = Msg;
            //if ( lblMsg.Text.Substring(lblMsg.Text.Length-1, 1 ) != ".") lblMsg.Text = Msg + ".";
            this.Text = (Title != ""?Title:this.Text);
            btnNo.Visible = YesNo;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            //this.Dispose();
        }
        static public DialogResult Show(string Msg, string Solution, string Title, bool YesNo)
        {
            MessageBoxEx msg = new MessageBoxEx(Msg, Solution, Title, YesNo);
            return msg.ShowDialog();
        }

        static public DialogResult Show(string Msg, string Solution)
        {
            MessageBoxEx msg = new MessageBoxEx(Msg, Solution);
            return msg.ShowDialog();
        }

        static public DialogResult Show(string Msg)
        {
            MessageBoxEx msg = new MessageBoxEx(Msg);
            return msg.ShowDialog();
        }

        private void lblSolution_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}