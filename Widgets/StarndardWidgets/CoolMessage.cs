using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolMessage : UserControl
    {
        public CoolMessage()
        {
            InitializeComponent();
            t.Tick += Hide;
            t.Enabled = false;
        }

        /// <summary>
        /// Shows the message specified.
        /// </summary>
        /// <param name="message">The message to be shown.</param>
        public void Show(string message)
        {
            btnMsg.Text = message;
            Show();
        }

        /// <summary>
        /// Show the message.
        /// </summary>
        public new void Show()
        {
            this.Visible = true;
            this.BringToFront();
            Application.DoEvents();
            //this.Refresh();
            //Application.DoEvents();
        }

        Timer t = new Timer();
        /// <summary>
        /// Shows the message for duration
        /// </summary>
        /// <param name="message">The message to be shown.</param>
        /// <param name="duration">in milliseconds</param>
        public void Show(string message, int duration)
        {
            Show(message);
            t.Interval = duration;
            t.Enabled = true;
        }

        /// <summary>
        /// Hides the message after TickTime happened. It's just
        /// an EventHandler and shouldn't be used directly.
        /// Use Hide() instead.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hide(object sender, EventArgs e)
        {
            Hide();
            t.Enabled = false;
        }

        /// <summary>
        /// Hides the message.
        /// </summary>
        public new void Hide()
        {
            this.Visible = false;
            btnMsg.Text = "";
            Application.DoEvents();
        }

        /// <summary>
        /// Gets or sets the Image shown beside the message.
        /// </summary>
        [Browsable(true)]
        public Image Image
        {
            get { return picBox.Image; }
            set { picBox.Image = value; }
        }

        /// <summary>
        /// Gets or sets the BorderColor of the message.
        /// </summary>
        [Browsable(true)]
        public Color BorderColor
        {
            get { return pnlMsg.BackColor; }
            set { pnlMsg.BackColor = value; }
        }

        /// <summary>
        /// Gets or sets the ForeColor of the message.
        /// </summary>
        [Browsable(true)]
        public new Color ForeColor
        {
            get { return btnMsg.ForeColor; }
            set { btnMsg.ForeColor = value; }
        }

        /// <summary>
        /// Gets or sets the ForeColor of the message.
        /// </summary>
        [Browsable(true)]
        public Color ForeColorToSet
        {
            get { return btnMsg.ForeColor; }
            set { btnMsg.ForeColor = value; }
        }

        /// <summary>
        /// Gets or sets the BackColor of the message.
        /// </summary>
        [Browsable(true)]
        public new Color BackColor
        {
            get { return btnMsg.BackColor; }
            set
            {
                btnMsg.BackColor = value;
                picBox.BackColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the BackColor of the message.
        /// </summary>
        [Browsable(true)]
        public Color BackColorToSet
        {
            get { return btnMsg.BackColor; }
            set
            {
                btnMsg.BackColor = value;
                picBox.BackColor = value;
            }
        }

        private void btnMsg_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
