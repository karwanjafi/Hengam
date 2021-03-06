using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExtendedPictureBoxLib;

namespace StandardWidgets
{
    public partial class CoolBaseFormTableEditorLarge : Form, IPaneled
    {
        public CoolBaseFormTableEditorLarge()
        {
            FormState = FormEditingState.Viewing;
            InitializeComponent();
        }

        private static bool allowedToAdd = true;
        public static bool AllowedToAdd
        {
            get { return allowedToAdd; }
            set { allowedToAdd = value; }
        }

        private static bool allowedToUpdate = true;
        public static bool AllowedToUpdate
        {
            get { return allowedToUpdate; }
            set { allowedToUpdate = value; }
        }

        private static bool allowedToRemove = true;
        public static bool AllowedToRemove
        {
            get { return allowedToRemove; }
            set { allowedToRemove = value; }
        }

        //public virtual void OnFormLoad()
        //{
        //}

        public enum FormEditingState
        {
            Adding,
            Updating,
            Viewing
        }

        /// <summary>
        /// Shows FormState
        /// </summary>
        [Browsable(true)]
        public FormEditingState FormState { get; set; }


        /// <summary>
        /// Indicates that the form is currently setting. You can use it when
        /// you are to update some fileds without causing to refresh.
        /// </summary>
        public bool Setting { get; set; }

        /// <summary>
        /// Changes the form mode to AddMode. If you should to add some functionality
        /// to it, you should override it and call base(), then add your code.
        /// </summary>
        public virtual void GotoAddMode()
        {
            toolTipForm.Show("اضافه کردن", groupButtons, 0, 0, 2000);
            groupButtons.Width = buttonWidth*buttonCountAdd+10;
            btnShowSugestions.Visible = false;
            pnlAdd.BringToFront();
            FormState = FormEditingState.Adding;
            ShowDetails();
        }

        /// <summary>
        /// Changes the form mode to EditMode. If you should to add some functionality
        /// to it, you should override it and call base(), then add your code.
        /// </summary>
        public virtual void GotoUpdateMode()
        {
            ShowDetails();
            toolTipForm.Show("به‌روز کردن", groupButtons, 0, 0, 2000);
            groupButtons.Width = buttonWidth*buttonCountUpdate+10;
            btnShowSugestions.Visible = true;
            pnlUpdate.BringToFront();
            FormState = FormEditingState.Updating;
        }

        //public delegate void ButtonClickedDelegate(object sender, EventArgs e);
        
        /// <summary>
        /// Adds a button to the form.
        /// </summary>
        /// <param name="shortName"></param>
        /// <param name="imageName"></param>
        /// <param name="toolTipText"></param>
        /// <param name="function"></param>
        /// <param name="showMode">Inidicates when show the button</param>
        /// <param name="IsPrimaryButton">If a button is primary shows in main buttons, otherwise it shows in other addtional buttons.</param>
        public virtual AnimatedPictureButton AddButton(string shortName, string imageName, string toolTipText, EventHandler function, CoolBaseFormReport.ButtonShowMode showMode, bool IsPrimaryButton)
        {
            AnimatedPictureButton btn = new AnimatedPictureButton();

            Color backColor = Color.FromArgb(66, 69, 60);
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
            btn.BorderColor = backColor;
            btn.EndState = new ExtendedPictureBoxLib.PictureBoxState(((byte)(255)), 0F, 70F, 0F, 0F, backColor, backColor, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), 1F, 0F, 130F, new System.Drawing.Point(2, -6), new System.Drawing.Point(0, -8), new System.Drawing.Point(0, 3));
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
            btn.StartState = new ExtendedPictureBoxLib.PictureBoxState(((byte)(255)), 0F, 50F, 0F, 90F, backColor, backColor, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), 1F, 0F, 110F, new System.Drawing.Point(2, -6), new System.Drawing.Point(0, -8), new System.Drawing.Point(0, 3));
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
                    pnlButtonsSugesstions.Height = btn.Height;
                    btn.Left = (buttonCountSuggestion++) * btn.Width;
                    pnlButtonsSugesstions.Controls.Add(btn);
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
        private void btnSampleButton_Click(object sender, EventArgs e)
        {

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
                    RunLoadForm();
                }
                return pnlMain; 
            }
        }

        private void RunLoadForm()
        {
            AddButton("انصراف", "CancelSuggestion", "انصراف از ذخیره سازی", ActionClose, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("جدید", "Add", "اضافه نمودن سطر جدید", ActionGotoAddMode, CoolBaseFormReport.ButtonShowMode.ShowInSuggestionMode, true);
            
            if (AllowedToAdd )
                AddButton("جدید", "Add", "اضافه نمودن سطر جدید", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);

            if (AllowedToRemove)
                AddButton("حذف", "Remove", "حذف سطر", ActionRemove, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            if (AllowedToUpdate)
                AddButton("ذخیره", "Update", "به روز رسانی نمودن سطر", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            ShowGrid();

            if (LoadForm != null)
            {
                LoadForm(null, null);
            }
            loaded = true;
        }

        private void ActionUpdate(object sender, EventArgs e)
        {
            UpdateBO();
        }

        private void ActionRemove(object sender, EventArgs e)
        {
            RemoveBO();
        }

       

        private void ActionGotoAddMode(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            AddBO();
        }

        #endregion

        private void CoolBaseFormTableEditor_Load(object sender, EventArgs e)
        {
            if (!loaded)
            {
                RunLoadForm();
            }
        }

        public virtual void ActionClose(object sender, EventArgs e)
        {
            ShowGrid();
            //GotoAddMode();
        }

        public void ShowSuggestions()
        {
            pnlSuggestions.Visible = true;
            pnlSuggestions.BringToFront();
        }

        public void HideSuggestions()
        {
            pnlSuggestions.Visible = false;
        }


        private void btnShowSuggestions_Clicked(object sender, EventArgs e)
        {
            ShowSuggestions();
        }

        public virtual void ShowGrid()
        {
            FormState = FormEditingState.Viewing;
            SuspendLayout();
            pnlGridPart.Visible = true;
            pnlGridPart.Dock = DockStyle.Fill;
            pnlDetailPart.Visible = false;
            ResumeLayout();
        }

        public virtual void ShowDetails()
        {
            SuspendLayout();
            pnlGridPart.Visible = false;
            pnlDetailPart.Visible = true;
            pnlDetailPart.Dock = DockStyle.Fill;
            ResumeLayout();
        }

        public virtual bool AddBO()
        {
            throw new NotImplementedException("You should override the AddBO method.");
        }

        public virtual void RemoveBO()
        {
            throw new NotImplementedException("You should override the RemoveBO method.");
        }

        public virtual void UpdateBO()
        {
            throw new NotImplementedException("You should override the UpdateBO method.");
        }
    }

}