using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StandardWidgets;

namespace StandardWidgets
{
    public partial class CoolBaseFormSimple : Form, IPaneled
    {
        public CoolBaseFormSimple()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows a message on the form.
        /// </summary>
        /// <param name="msg">Message to be shown.</param>
        public void SetMsg(string msg)
        {
            coolMessage.Show(msg);
        }

        /// <summary>
        /// Shows a message for specified duration.
        /// </summary>
        /// <param name="msg">Message to be shown.</param>
        /// <param name="duration">duration of showing in milliseconds</param>
        public void SetMsg(string msg, int duration)
        {
            coolMessage.Show(msg, duration);
        }

        /// <summary>
        /// Hides the message.
        /// </summary>
        public void HideMsg()
        {
            coolMessage.Hide();
        }

        [Browsable(true), Category("Action"), Description("Occurs whenever form loads, even when panel used.")]
        public event EventHandler LoadForm;

        bool loaded = false;
        #region IPaneled Members

        public Panel MainPanel
        {
            get
            {
                if (!loaded)
                {
                    if (LoadForm != null)
                        LoadForm(null, null);
                    loaded = true;
                }
                return pnlMain;
            }
        }

        #endregion

        private void CoolBaseFormSimple_Load(object sender, EventArgs e)
        {
            if (!loaded)
            {
                if (LoadForm != null)
                    LoadForm(null, null);
                loaded = true;
            }
        }

        //[Browsable(true), Category("Action"), Description("Occurs whenever form closed, even when panel used.")]
        //public EventHandler Closed;

        //public void Close()
        //{
        //    this.Hide();
        //    if (Closed != null) Closed(this, null);
        //}
    }
}