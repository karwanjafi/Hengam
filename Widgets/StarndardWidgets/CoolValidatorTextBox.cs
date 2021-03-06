using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;

namespace StandardWidgets
{
    public partial class CoolValidatorTextBox : UserControl
    {
        public CoolValidatorTextBox()
        {
            InitializeComponent();
        }

        private bool mAccepted = false;
        [Bindable(true)]
        public bool Accepted
        {
            get { return mAccepted; }
            set
            { 
                mAccepted = value;
                if (mAccepted)
                {
                    picOK.Visible = true;
                    picError.Visible = false;
                    if (TextAccepted != null)
                        TextAccepted(null, null);
                }
                else
                {
                    picError.Visible = true;
                    picOK.Visible = false;
                }
            }
        }

        private bool mIsEmpty = false;
        [Bindable(true)]
        public bool IsEmpty
        {
            get { return mIsEmpty; }
            set
            {
                mIsEmpty = value;
            }
        }

        private bool mMustFill = true;
        [Bindable(true)]
        public bool MustFill
        {
            get { return mMustFill; }
            set
            {
                mMustFill = value;
            }
        }

        public delegate bool CanAcceptDelegate(string str);
        public CanAcceptDelegate CanAccept;

        private void txtValidatorBox_TextChanged(object sender, EventArgs e)
        {
            HideMsg();
            if (CanAccept != null)
            {
                if (CanAccept(txtValidatorBox.Text))
                {
                    Accepted = true;
                }
                else
                {
                    Accepted = false;
                }
            }
            if (TextChanged != null)
                TextChanged(sender, e);
        }

        [Browsable(true), Category("Misc"), Description("The text which appears in the box.")]
        public new virtual string Text
        {
            get { return txtValidatorBox.Text; }
            set { txtValidatorBox.Text = value; }
        }

        [Browsable(true), Category("Misc"), Description("The text which appears in the box.")]
        public virtual string TextToSet
        {
            get { return txtValidatorBox.Text; }
            set { txtValidatorBox.Text = value; }
        }

        [Browsable(true)]
        [Editor("System.Windows.Forms.Design.MaskPropertyEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string Mask
        {
            get { return txtValidatorBox.Mask; }
            set { txtValidatorBox.Mask = value; }
        }

        //[Browsable(true), Category("Misc")]
        //public new RightToLeft RightToLeft
        //{
        //    get { return txtValidatorBox.RightToLeft; }
        //    set { txtValidatorBox.RightToLeft = value; }
        //}

        private string mMessage = "خالی";
        [Browsable(true)]
        public string Message
        {
            get { return mMessage; }
            set
            { 
                //lblMsg.Text = value;
                mMessage = value;
                toolTipMsg.SetToolTip(this, value);
            }
        }

        [Browsable(true), Category("Misc")]
        public bool ReadOnly
        {
            get { return txtValidatorBox.ReadOnly; }
            set { txtValidatorBox.ReadOnly = value; }
        }

        [Browsable(true)]
        public HorizontalAlignment TextAlign
        {
            get { return txtValidatorBox.TextAlign; }
            set
            { 
                txtValidatorBox.TextAlign = value;
                //if (txtValidatorBox.TextAlign == HorizontalAlignment.Right)
                //{
                //    lblMsg.TextAlign = ContentAlignment.MiddleRight;
                //    lblMsg.Left = txtValidatorBox.Right - lblMsg.Width - 5;
                //    lblMsg.Anchor = AnchorStyles.Right;
                //}
                //else
                //{
                //    lblMsg.TextAlign = ContentAlignment.MiddleLeft;
                //    lblMsg.Left = txtValidatorBox.Left + 5;
                //    lblMsg.Anchor = AnchorStyles.Left;
                    

                //}
            }
        }

        private void lblMsg_MouseHover(object sender, EventArgs e)
        {
            HideMsg();
        }

        private void HideMsg()
        {
            //lblMsg.Visible = false;
            toolTipMsg.Hide(this);
        }

        private void ShowMsg()
        {
            //lblMsg.Visible = true;
            toolTipMsg.Show(Message, this,0, 0, 3000);
        }

        private void txtValidatorBox_Click(object sender, EventArgs e)
        {
            HideMsg();
            this.OnClick(e);
        }

        private void txtValidatorBox_Enter(object sender, EventArgs e)
        {
            HideMsg();
        }

        private void txtValidatorBox_Leave(object sender, EventArgs e)
        {
            if (!Accepted)
                ShowMsg();
        }

        [Browsable(true), Category("Action"), Description("Occurs when text changed.")]
        public new event EventHandler TextChanged = null;

        [Browsable(true), Category("Action"), Description("Occurs when text changed.")]
        public event EventHandler TextAccepted = null;

        private void txtValidatorBox_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Delete)
            //    Text = "";
        }

        public int CursorLocation
        {
            get
            {
                return txtValidatorBox.SelectionStart;
            }
            set
            {
                txtValidatorBox.SelectionStart = value;
            }
        }



        //private bool mSizable = false;
        //[Browsable(true), Category("Misc")]
        //public bool Sizable
        //{
        //    get { return mSizable; }
        //    set
        //    {
        //        mSizable = value;
        //    }
        //}

    }
}
