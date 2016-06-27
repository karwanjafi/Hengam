using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using XPExplorerBar;

namespace StandardWidgets
{
    public partial class CoolMenu : UserControl
    {
        public CoolMenu()
        {
            InitializeComponent();
        }

        public Image LogoImage
        {
            get { return picLogo.BackgroundImage; }
            set { picLogo.BackgroundImage = value; }
        }

        public void AddExpando(XPExplorerBar.Expando expando)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoolMenu));
            

            expando.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            expando.Animate = false;
            expando.AutoLayout = true;
            expando.CustomHeaderSettings.GradientOffset = 0.1F;
            expando.CustomHeaderSettings.Margin = 30;
            expando.CustomHeaderSettings.NormalBackColor = System.Drawing.Color.Gray;
            expando.CustomHeaderSettings.NormalBorderColor = System.Drawing.Color.Black;
            expando.CustomHeaderSettings.NormalGradientEndColor = System.Drawing.Color.Silver;
            expando.CustomHeaderSettings.NormalGradientStartColor = System.Drawing.Color.Black;
            expando.CustomHeaderSettings.NormalBackImage = ((System.Drawing.Image)(resources.GetObject("expando1.CustomHeaderSettings.NormalBackImage")));
            expando.CustomHeaderSettings.NormalTitleColor = System.Drawing.Color.Wheat;
            expando.CustomHeaderSettings.NormalTitleHotColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            expando.CustomHeaderSettings.SpecialBackColor = System.Drawing.Color.Gray;
            expando.CustomHeaderSettings.SpecialBorderColor = System.Drawing.Color.Black;
            expando.CustomHeaderSettings.TitleFont = new System.Drawing.Font("Tahoma", 10F);
            expando.CustomHeaderSettings.TitleGradient = false;
            expando.CustomHeaderSettings.TitleRadius = 5;
            expando.CustomSettings.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            expando.CustomSettings.NormalBorderColor = System.Drawing.Color.Black;
            expando.CustomSettings.SpecialBorderColor = System.Drawing.Color.Black;
            //expando.ExpandedHeight = 88;
            expando.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expando.ForeColor = System.Drawing.Color.Orange;
            //expando.Items.AddRange(new System.Windows.Forms.Control[] {
            //this.taskItem1,
            //this.taskItem2});
            //expando.Location = new System.Drawing.Point(12, 12);
            //expando.Name = "expando1";
            //expando.Size = new System.Drawing.Size(211, 88);
            expando.TabIndex = 0;
            expando.Collapsed = true;
            taskPane.Expandos.Add(expando);
        }

        public XPExplorerBar.TaskPane.ExpandoCollection Expandos
        {
            get { return taskPane.Expandos; }
        }

        public void AddToExpando(Expando expando, string linkName, string imageName, EventHandler clickHandler)
        {
            TaskItem item = new TaskItem();


            item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            item.BackColor = System.Drawing.Color.Transparent;
            item.CustomSettings.FontDecoration = System.Drawing.FontStyle.Regular;
            item.CustomSettings.HotLinkColor = System.Drawing.Color.Yellow;
            item.CustomSettings.LinkColor = System.Drawing.Color.Orange;
            //item.Image = null;
            item.Location = new System.Drawing.Point(12, 33);
            //item.Name = "taskItem1";
            item.Size = new System.Drawing.Size(185, 20);
            //item.TabIndex = 0;
            //item.Text = "taskItem1";
            item.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            item.UseVisualStyleBackColor = false;
            
            
            item.Text = linkName;
            item.Font = new Font("Tahoma", 10);
            item.Click += clickHandler;
            if (ImageList != null)
                item.Image = ImageList.Images[imageName];
            expando.Items.Add(item);
        }

        [Browsable(true)]
        public ImageList ImageList { get; set; }


        #region Expand Code
        private int lastSize = 0;
        public bool IsClosed = false;

        
        #endregion

        private void btnCascade_Click(object sender, EventArgs e)
        {
            if (IsClosed)
            {
                this.Width = lastSize;
                btnCascade.Text = "<";
            }
            else
            {
                lastSize = this.Width;
                this.Width = btnCascade.Width + 2 * btnCascade.Left;
                btnCascade.Text = ">";
            }
            IsClosed = !IsClosed;
        }
    }
}
