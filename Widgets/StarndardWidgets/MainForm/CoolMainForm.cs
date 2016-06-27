using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XPExplorerBar;

namespace StandardWidgets
{
    public partial class CoolMainForm : Form
    {
        public CoolMainForm()
        {
            InitializeComponent();
            tabStrip.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public void SetBackGroundImage(Image backgroundImage)
        {
            tabStrip.BackgroundImage = backgroundImage;
        }

        public Color HeaderColor
        {
            get { return pnlHeader.BackColor; }
            set { pnlHeader.BackColor = value; }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                coolTiteBar1.TitleText = value;
            }
        }

        public Color StatusBarBackColor
        {
            get { return pnlStatusBar.BackColor; }
            set { pnlStatusBar.BackColor = value; }
        }

        public Color StatusBarForeColor
        {
            get { return lblStatus.ForeColor; }
            set { lblStatus.ForeColor = value; }
        }

        public void SetStatus(string msg)
        {
            lblStatus.Text = msg;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="duration">duration in miliseconds.</param>
        public void SetMsg(string msg, int duration)
        {
            coolMessage.Show(msg, duration);
        }
        
        public void SetMsg(string msg)
        {
            coolMessage.Show(msg);
        }

        public void HideMsg()
        {
            coolMessage.Hide();
        }

        public void AddForm(Panel displayPanel, string caption)
        {
            //IPaneled ip = displayPanel;
            Panel backPan = new Panel();

            backPan.SuspendLayout();
            displayPanel.SuspendLayout();
            tabStrip.SuspendLayout();
            this.SuspendLayout();
            backPan.Visible = false;
            displayPanel.Visible = false;
            {
                backPan.BackColor = Color.White;
                backPan.Padding = new System.Windows.Forms.Padding(3);
                backPan.Controls.Add(displayPanel);
                backPan.Dock = DockStyle.Fill;
                displayPanel.Dock = DockStyle.Fill;

                // ToDo: Setting Nexter.

                //FATabStripItem tab = new FATabStripItem(Title, backPan);
                ////tabMain.AddTab(tab, true);
                //tabMain.Items.Insert((tabMain.Items.Count > 0 ? tabMain.Items.Count : 0), tab);
                tabStrip.AddTab(new FarsiLibrary.Win.FATabStripItem(caption, backPan), true);
                //tabMain.SelectedItem = tab;
                ////tabMain.SelectedItem = tab;
            }

            backPan.ResumeLayout();
            tabStrip.ResumeLayout();
            displayPanel.ResumeLayout();
            this.ResumeLayout();
            backPan.Visible = true;
            displayPanel.Visible = true;
            Application.DoEvents();
            
            //tabStrip.AddTab(new FarsiLibrary.Win.FATabStripItem(caption, displayPanel), true);
            //displayPanel.Dock = DockStyle.Fill;
        }

        //hanieh///////////////////
        public void AddForm(Form frm)
        {

            IPaneled displaypanel = (IPaneled)frm;
            AddForm(displaypanel.MainPanel, frm.Name);
            

        }
        /// <summary>
        /// ////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Expando exp = new Expando();
            exp.AutoLayout = true;
            exp.TitleImage = imageListGroupIcons.Images["adv"];
            coolMenu1.AddToExpando(exp, "سلام", "pic1", item_Click);
            coolMenu1.AddToExpando(exp, "مهران", "pic1", item_Click);
            coolMenu1.AddToExpando(exp, "مریم", "pic2", item_Click);
            
            coolMenu1.AddExpando(exp);

            tabStrip.AddTab(new FarsiLibrary.Win.FATabStripItem(new Panel() { BackColor = Color.Yellow}));
        }

        
        void item_Click(object sender, EventArgs e)
        {
            MessageBox.Show("کلیک شد");
        }

        
    }
}
