using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Tools
{
    public class PanelModifier : IDisposable
    {
        public Panel panel;
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
        public PanelModifier(Panel p)
        {
            panel = p;
            InitialSize = p.Size;
            //panel.Height = 100;
            panel.BringToFront();
            t.Interval = 10;
            t.Tick += Expand;
        }

        bool ExpandOpen = true;
        private void Expand(object sender, EventArgs e)
        {
            switch (ExpandOpen)
            {
                
                case true:
                    panel.BringToFront();
                    panel.Visible = true;
                    int newHeight = panel.Height + openStepHeight;
                    if (newHeight > InitialSize.Height)
                    {
                        newHeight = InitialSize.Height;
                        t.Enabled = false;
                    }
                    panel.Height = newHeight;
                
                    /*
                    t.Enabled = false;
                    panel.Visible = true;
                    panel.BringToFront();
                    panel.Height = InitialSize.Height;
                    */
                    break;
                case false:
                    t.Enabled = false;
                    panel.Visible = false;
                    if (InitialSize.Width <= panel.Width && InitialSize.Height <= panel.Height)
                        InitialSize = new Size(panel.Width, panel.Height);
                    panel.Height = 10;
                    break;
                
            }
            Application.DoEvents();

            /*
            bool needToUpdate = true;
            int newHeight = 0;
            int newWidth = 0;
            switch (ExpandOpen)
            {
                case true:
                    panel.Visible = true;
                    newHeight = panel.Size.Height + openStepHeight;
                    if (newHeight > InitialSize.Height)
                    {
                        panel.Size= new Size(panel.Size.Width, InitialSize.Height);
                        needToUpdate = false;
                    }
                    else
                    {
                        panel.Size = new Size(panel.Size.Width, newHeight);
                    }
                    newWidth = panel.Size.Width + openStepWidth;
                    if (newWidth > InitialSize.Width)
                    {
                        panel.Size = new Size( InitialSize.Width, panel.Size.Height);
                        if (!needToUpdate) t.Enabled = false;
                    }
                    else
                    {
                        panel.Size = new Size( newWidth, panel.Size.Height);
                    }
                    break;
                
                case false:
                    newHeight = panel.Size.Height - closeStepHeight;
                    if (newHeight < MinSize.Height)
                    {
                        panel.Size = new Size(panel.Size.Width, MinSize.Height);
                        needToUpdate = false;
                    }
                    else
                    {
                        panel.Size = new Size(panel.Size.Width, newHeight);
                    }
                    newWidth = panel.Size.Width - closeStepWidth;
                    if (newWidth < MinSize.Width)
                    {
                        panel.Size = new Size( MinSize.Width, panel.Size.Height);
                        if (!needToUpdate)
                        {
                            t.Enabled = false;
                            panel.Visible = false;
                        }
                    }
                    else
                    {
                        panel.Size = new Size( newWidth, panel.Size.Height);
                    }
                    break;

                    break;
            }
            */
        }
        
        public void Hide()
        {
            t.Interval = closeSpeed;
            ExpandOpen = false;
            t.Enabled = true;
            if ( Closed != null )
            Closed();
            //panel.Visible = false;
        }

        public void Show()
        {
            if (panel.Height > InitialSize.Height && panel.Width > InitialSize.Width)
                InitialSize = new Size(panel.Width, panel.Height);
            t.Interval = openSpeed;
            ExpandOpen = true;
            panel.Height = 10;
            t.Enabled = true;
            //panel.Visible = true;
        }

        public delegate void ClosedDelegate();

        public event ClosedDelegate Closed;

        #region IDisposable Members

        public void Dispose()
        {
            t.Dispose();
        }

        #endregion
    }

    class FormFacilator
    {
        public static void SelectNextControl(Form form)
        {
            form.SelectNextControl(form.ActiveControl, true, true, true, false);
        }

        public static void SelectPrevControl(Form form)
        {
            form.SelectNextControl(form.ActiveControl, false, true, true, false);
        }

        Form form;
        public FormFacilator(Form f)
        {
            form = f;
        }

        public void NextSelector(object sender, EventArgs e)
        {
            /*Control c = this.ActiveControl;
            c.Focus();
            m(c.ToString());
            Control cc = this.GetNextControl(c, true);
            m(cc.ToString());
            cc.Focus();*/

            Control actControl = form.ActiveControl;

            while (actControl != actControl.GetContainerControl().ActiveControl)
            {
                actControl = actControl.GetContainerControl().ActiveControl;
            }

            Control nextControl = form.GetNextControl(actControl, true);
            if (nextControl is FarsiLibrary.Win.FATabStripItem)
            {

                IContainerControl cc = nextControl.GetContainerControl();
                if (cc is FarsiLibrary.Win.FATabStrip)
                {
                    ((FarsiLibrary.Win.FATabStrip)cc).SelectedItem = (FarsiLibrary.Win.FATabStripItem)nextControl;
                }
                nextControl = nextControl.Controls[0];
                nextControl.GetContainerControl().ActivateControl(nextControl);
                nextControl.Focus();
                return;
            }

            form.SelectNextControl(actControl, true, true, true, false);
        }

    }
}
