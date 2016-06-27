using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExtendedPictureBoxLib;

namespace HengamWidgets
{
    public partial class FormBaseReport : StandardWidgets.CoolBaseFormReport
    {
        public FormBaseReport()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adds a button to the form.
        /// </summary>
        /// <param name="shortName"></param>
        /// <param name="imageName"></param>
        /// <param name="toolTipText"></param>
        /// <param name="function"></param>
        /// <param name="showMode">Inidicates when show the button</param>
        /// <param name="IsPrimaryButton">If a button is primary shows in main buttons, otherwise it shows in other addtional buttons.</param>
        public new AnimatedPictureButton AddButton(string shortName, string imageName, string toolTipText, EventHandler function, ButtonShowMode showMode, bool IsPrimaryButton)
        {
            AnimatedPictureButton btn = base.AddButton(shortName, imageName, toolTipText, function, showMode, IsPrimaryButton);

            //btn.AnimationStepSize = btnSampleButton.AnimationStepSize;
            //btn.BorderColor = btnSampleButton.BorderColor;
            ////btn.EndState = new ExtendedPictureBoxLib.PictureBoxState(((byte)(255)), 0F, 80F, 0F, 0F, System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139))))), System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139))))), System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), 1F, 0F, 130F, new System.Drawing.Point(2, -3), new System.Drawing.Point(0, -5), new System.Drawing.Point(0, 3));
            //btn.EndState = btnSampleButton.EndState;
            //btn.Font = btn.Font;
            //btn.ForeColor = btnSampleButton.ForeColor;
            ////btn.Image = imgButtons.Images[imageName];
            ////btn.Location = new System.Drawing.Point(181, 37);
            //btn.Name = "btnSampleButton";
            //btn.PushedProperties = btnSampleButton.PushedProperties;
            //btn.Size = new Size( btnSampleButton.Size.Width, btnSampleButton.Size.Height);
            //btn.StartState = btnSampleButton.StartState;//new ExtendedPictureBoxLib.PictureBoxState(((byte)(255)), 0F, 70F, 0F, 90F, System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139))))), System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), 1F, 0F, 110F, new System.Drawing.Point(2, -3), new System.Drawing.Point(0, -5), new System.Drawing.Point(0, 3));
            //btn.TabIndex = 0;
            ////btn.Text = "اضافه کردن";
            //btn.TextAlign = btnSampleButton.TextAlign;
            ////this.toolTipButtons.SetToolTip(btn, toolTipText);

            Color haloColor = Color.Yellow;
            Color ForeColor = Color.Khaki;

            btn.BorderColor = Color.FromArgb(66, 69, 60);
            btn.StartState = new ExtendedPictureBoxLib.PictureBoxState(((byte)(255)), 0F, 50F, 0F, 90F, System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60))))), System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60))))), ForeColor, haloColor, 1F, 0F, 110F, new System.Drawing.Point(2, -6), new System.Drawing.Point(0, -8), new System.Drawing.Point(0, 3));
            btn.EndState = new ExtendedPictureBoxLib.PictureBoxState(((byte)(255)), 0F, 80F, 0F, 0F, System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60))))), System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(60))))), ForeColor, haloColor, 1F, 0F, 130F, new System.Drawing.Point(2, -3), new System.Drawing.Point(0, -5), new System.Drawing.Point(0, 3));

            return btn;
        }
    }
}
