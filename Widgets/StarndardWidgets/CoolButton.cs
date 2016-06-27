using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace StandardWidgets
{
    public partial class CoolButton : UserControl
    {
        public CoolButton()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Occurs when button is clicked.")]
        public event EventHandler Clicked = null;

        private void btnButton_Click(object sender, EventArgs e)
        {
            if (Clicked != null)
                Clicked(sender, e);
        }

        /// <summary>
        /// Gets or sets the text of button.
        /// </summary>
        [Browsable(true), Category("Misc")]
        public new string Text
        {
            get { return btnButton.Text; }
            set { btnButton.Text = value; }
        }

        /// <summary>
        /// Gets or sets the text of button.
        /// </summary>
        [Browsable(true), Category("Misc")]
        public string TextToSet
        {
            get { return btnButton.Text; }
            set { btnButton.Text = value; }
        }

        /// <summary>
        /// Gets inner button.
        /// </summary>
        [Browsable(true)]
        public Button Button
        {
            get { return btnButton; }
        }
    }
}
