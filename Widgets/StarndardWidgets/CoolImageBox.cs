using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolImageBox : UserControl
    {
        public CoolImageBox()
        {
            InitializeComponent();
        }

        public Image Image
        {
            get { return picImage.BackgroundImage; }
            set { picImage.BackgroundImage = value; }
        }

        private void btnRemovePic_Click(object sender, EventArgs e)
        {
            picImage.BackgroundImage = null;
        }

        public bool MustFill { get; set; }

        public bool Accepted
        {
            get
            {
                return true;
            }
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            if (dlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picImage.BackgroundImage = Image.FromFile(dlgOpenImage.FileName);
                }
                catch (Exception)
                {

                }
            }
        }

        private void HideButtons()
        {
            btnSelectPic.Visible = btnRemovePic.Visible = false;
        }

        private void ShowButtons()
        {
            btnRemovePic.Visible = btnSelectPic.Visible = true;
            btnRemovePic.BringToFront();
            btnSelectPic.BringToFront();
        }

        private void CoolImageBox_Enter(object sender, EventArgs e)
        {
            ShowButtons();
        }

        private void CoolImageBox_Leave(object sender, EventArgs e)
        {
            HideButtons();
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
