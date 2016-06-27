using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class PanelFloater : UserControl
    {
        public PanelFloater()
        {
            InitializeComponent();
            
            Init();
        }

        private void Init()
        {
            this.Visible = false;
            this.BringToFront();
            t.Interval = 10;
            t.Tick += Expand;
            InitialSize = this.Size;
        }

        // ToDo: Uncomment this
        //public PanelFloater(Panel panel)
        //{
        //    Init();
        //    LoadPanel(panel);
        //}

        public PanelFloater(IFloatable floater)
        {
            Init();
            LoadPanel(floater);
        }

        Size InitialSize;
        Size MinSize = new Size(40, 40);

        int openSpeed = 5;
        int openStepHeight = 50;
        //int openStepWidth = 1000;

        int closeSpeed = 10;
        //int closeStepHeight = 1000;
        //int closeStepWidth = 1000;

        Timer t = new Timer();

        public void SetInitialSize(Size size)
        {
            InitialSize = size;
        }

        bool ExpandOpen = true;
        private void Expand(object sender, EventArgs e)
        {
            switch (ExpandOpen)
            {
                case true:
                    this.BringToFront();
                    this.Visible = true;
                    int newHeight = this.Height + openStepHeight;
                    if (newHeight > InitialSize.Height)
                    {
                        newHeight = InitialSize.Height;
                        t.Enabled = false;
                    }
                    this.Height = newHeight;
                
                    break;
                case false:
                    t.Enabled = false;
                    this.Visible = false;
                    if (InitialSize.Width <= this.Width && InitialSize.Height <= this.Height)
                        InitialSize = new Size(this.Width, this.Height);
                    this.Height = 10;
                    break;
                
            }
            Application.DoEvents();
        }
        
        /// <summary>
        /// Hides the PanelFloater.
        /// </summary>
        public new void Hide()
        {
            t.Interval = closeSpeed;
            ExpandOpen = false;
            t.Enabled = true;
            if ( Closed != null )
            Closed();
            //panel.Visible = false;
        }

        /// <summary>
        /// Shows the PanelFloater
        /// </summary>
        public new void Show()
        {
            if (this.Height > InitialSize.Height && this.Width > InitialSize.Width)
                InitialSize = new Size(this.Width, this.Height);
            t.Interval = openSpeed;
            ExpandOpen = true;
            this.Height = 10;
            t.Enabled = true;
            //panel.Visible = true;
        }

        public delegate void ClosedDelegate();

        /// <summary>
        /// Occurs when PanelFloater closed by user. (May be selected or unselected.)
        /// </summary>
        [Browsable(true)]
        [Category("Action")]
        public event ClosedDelegate Closed;

        //#region IDisposable Members

        //public void Dispose()
        //{
        //    t.Dispose();
        //}

        //#endregion
        
        ///// <summary>
        ///// Loads a panel to PanelFloater.
        ///// </summary>
        ///// <param name="panel"></param>
        //public void LoadPanel(Panel panel)
        //{
        //    pnlContainer.Controls.Clear();
        //    pnlContainer.Controls.Add(panel);
        //    panel.Dock = DockStyle.Fill;

        //    if (panel.Parent.Parent.Parent is CoolBaseFormSimple)
        //    {
        //        CoolBaseFormSimple frm = panel.Parent as CoolBaseFormSimple;
        //        frm.Closed += btnHide_Click;
        //    }
        //}

        /// <summary>
        /// Loads a panel to PanelFloater.
        /// </summary>
        /// <param name="panel"></param>
        public void LoadPanel(IFloatable floater)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(floater.MainPanel);
            floater.MainPanel.BackColor = BackColor;
            floater.MainPanel.Dock = DockStyle.Fill;
            TitleText = ((Form)floater).Text;
            floater.ContainerFloater = this;
        }

        public void LoadPanel(IFloatable floater, string titleText)
        {
            LoadPanel(floater);
            TitleText = titleText;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            Hide();
        }

        [Browsable(true), Category("Misc")]
        public override Color BackColor
        {
            get
            {
                return pnlBackground.BackColor;
            }
            set
            {
                base.BackColor = value;
                pnlBackground.BackColor = pnlContainer.BackColor = value;
            }
        }
        
        
        /*{
            get { return pnlBackground.BackColor; }
            set
            {
                pnlBackground.BackColor = pnlContainer.BackColor = value;
            }
        }*/

        [Browsable(true), Category("Misc")]
        public Color TitleColor
        {
            get { return pnlTitleBar.BackColor; }
            set
            {
                pnlTitleBar.BackColor = pnlButtomBar.BackColor = pnlButtomLeft.BackColor = pnlButtomRight.BackColor = value;
            }
        }

        public string TitleText
        {
            get
            {
                return lblLabel.Text;
            }
            set
            {
                lblLabel.Text = value;
            }
        }

        Point LastMousePosition;
        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Here = MousePosition;
                Point Offset = new Point(Here.X - LastMousePosition.X, Here.Y - LastMousePosition.Y);
                //Point Offset = new Point( - LastMousePosition.X,  - LastMousePosition.Y);
                Point newLocation = new Point(Location.X + Offset.X, Location.Y + Offset.Y);
                //Point newLocation = new Point(Offset.X,  Offset.Y);
                LastMousePosition = Here;
                Location = newLocation;
            }
        }

        private void pnlTitleBar_MouseHover(object sender, EventArgs e)
        {
            LastMousePosition = MousePosition;
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            LastMousePosition = MousePosition;
        }

        private void pnlButtomRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point Here = MousePosition;
                Point Offset = new Point(Here.X - LastMousePosition.X, Here.Y - LastMousePosition.Y);
                Size = new Size(Size.Width + Offset.X, Size.Height + Offset.Y);
                if (Parent != null) Parent.Refresh();
                LastMousePosition = Here;
            }
        }

        private void pnlButtomRight_MouseDown(object sender, MouseEventArgs e)
        {
            LastMousePosition = MousePosition;
        }

        private void pnlButtomRight_MouseHover(object sender, EventArgs e)
        {
            LastMousePosition = MousePosition;
        }

        //[Browsable(true), Category("Misc")]
        //public Color BackColorToSet
        //{
        //    get { return pnlBackground.BackColor; }
        //    set
        //    {
        //        pnlBackground.BackColor = pnlContainer.BackColor = value;
        //    }
        //}


    }
}
