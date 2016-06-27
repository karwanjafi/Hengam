using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ExtendedPictureBoxLib;

namespace StandardWidgets
{
    public partial class ButtonKeeper : UserControl
    {
        public ButtonKeeper()
        {
            InitializeComponent();
            AddButton("", "Add", "", null, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("", "Add", "", null, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("", "Add", "", null, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("", "Add", "", null, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("", "Add", "", null, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("", "Add", "", null, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("", "Add", "", null, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("", "Add", "", null, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
        }

        public virtual AnimatedPictureButton AddButton(string shortName, string imageName, string toolTipText, EventHandler function, CoolBaseFormReport.ButtonShowMode showMode, bool IsPrimaryButton)
        {
            AnimatedPictureButton btn = new AnimatedPictureButton();

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

            btn.AnimationStepSize = 50;
            btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139)))));
            btn.EndState = new ExtendedPictureBoxLib.PictureBoxState(((byte)(255)), 0F, 70F, 0F, 0F, System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139))))), System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139))))), System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), 1F, 0F, 130F, new System.Drawing.Point(2, -6), new System.Drawing.Point(0, -8), new System.Drawing.Point(0, 3));
            btn.Font = new System.Drawing.Font("B Kamran", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            //btn.Image = global::StarndardWidgets.Properties.Resources.Add;
            btn.Location = new System.Drawing.Point(181, 49);
            btn.Name = "btnSampleButton";
            btn.PushedProperties = ((ExtendedPictureBoxLib.PictureBoxStateProperties)((((((ExtendedPictureBoxLib.PictureBoxStateProperties.Alpha | ExtendedPictureBoxLib.PictureBoxStateProperties.RotationAngle)
                        | ExtendedPictureBoxLib.PictureBoxStateProperties.Zoom)
                        | ExtendedPictureBoxLib.PictureBoxStateProperties.ExtraImageRotationAngle)
                        | ExtendedPictureBoxLib.PictureBoxStateProperties.ShadowOffset)
                        | ExtendedPictureBoxLib.PictureBoxStateProperties.ImageOffset)));
            btn.Size = new System.Drawing.Size(64, 58);
            btn.StartState = new ExtendedPictureBoxLib.PictureBoxState(((byte)(255)), 0F, 50F, 0F, 90F, System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139))))), System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(188)))), ((int)(((byte)(139))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), 1F, 0F, 110F, new System.Drawing.Point(2, -6), new System.Drawing.Point(0, -8), new System.Drawing.Point(0, 3));
            btn.TabIndex = 0;
            btn.Text = "اضافه کردن";
            btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            //this.toolTipButtons.SetToolTip(btn, "اضافه کردن");
            //btn.Click += new System.EventHandler(btn_Click);

            btn.PushedState = btn.StartState;
            btn.Image = imgButtons.Images[imageName];
            btn.Text = shortName;
            btn.Click += function;
            //btn.Dock = DockStyle.Left;

            btn.Top = 0;
            toolTipButtons.SetToolTip(btn, toolTipText);
            buttonWidth = btn.Width;

            switch (showMode)
            {
                case CoolBaseFormReport.ButtonShowMode.ShowInAddMode:
                    btn.Left = (buttonCountAdd++) * btn.Width;
                    pnlAdd.Height = btn.Height;
                    pnlAdd.Controls.Add(btn);
                    break;

                case CoolBaseFormReport.ButtonShowMode.ShowInEditMode:
                    pnlUpdate.Height = btn.Height;
                    btn.Left = (buttonCountUpdate++) * btn.Width;
                    pnlUpdate.Controls.Add(btn);
                    break;

                case CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode:
                    break;
            }

            groupButtons.Width = buttonWidth * buttonCountAdd + 10;
            //groupButtons.Width = Math.Max(pnlUpdate.Width, groupButtons.Width) + 30;
            //int diff = (pnlUpdate.PreferredSize.Height + btnShowSugestions.Height + 18) - groupButtons.Height;
            //groupItemDetails.SuspendLayout();
            //groupButtons.Height += diff;
            ///groupButtons.Top -= diff;
            //groupItemDetails.ResumeLayout();

            //MessageBox.Show(btn.Left.ToString() + ", " + btn.Width.ToString());
            //groupButtons.Refresh();
            return btn;
        }
        int buttonCountAdd = 0;
        int buttonCountUpdate = 0;
        int buttonCountSuggestion = 0;
        int buttonWidth = 50;
    }
}
