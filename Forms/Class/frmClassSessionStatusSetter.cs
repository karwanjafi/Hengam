using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using Hengam.Tools;
using Tools;
using Hengam.ComboManager;
using Hengam.Forms.ItemPickers;
using StandardWidgets;
using FarsiMessageBox;
using Hengam.Forms.Student;

namespace Hengam.Forms
{
    public partial class frmClassSessionStatusSetter : HengamWidgets.FormBaseSimple, IFloatable
    {
        public frmClassSessionStatusSetter()
        {
            InitializeComponent();
        }

        private void ActionUpdate(object sender, EventArgs e)
        {
            ClasssessionBO item = GetGUI();
            if (item == null) return;
            try
            {
                SetMsg("در حال به‌روز رسانی...");
                if (!item.Update())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Updated("مشخصات جلسه‌ای به نام " + item.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
            SetMsg("اطلاعات ثبت شد.", 1000);
        }
        ClasssessionBO guiItem = new ClasssessionBO();
        private ClasssessionBO GetGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtClassID.Accepted)
                    err.Add("جلسه‌");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassID.Text);

                if (!txtClassDate.Accepted)
                    err.Add("تاریخ تشکیل");
                else
                    guiItem.ClassDate = UtilityTxt.GetString(txtClassDate.Text);

                if (!cboTimeID.Accepted)
                    err.Add("ساعت تشکیل");
                else
                    guiItem.TimeID = ComboFiller<TimeBO>.GetFromCombo(cboTimeID).TimeID;

                guiItem.StudentAbsence = chkStudentAbsence.Checked;

                guiItem.TeacherAbsence = chkTeacherAbsence.Checked;

                guiItem.ContinuousAbsence = chkContinuousAbsenece.Checked;

                //if (!cboDayID.Accepted)
                //    err.Add("روز");
                //else
                //    guiItem.DayID = ComboFiller<DayBO>.GetFromCombo(cboDayID).DayID;

                if (!cboSessionStatus.Accepted)
                    err.Add("وضعیت جلسه‌");
                else
                    guiItem.SessionStatus = (int)ComboFiller<SessionStatus>.GetFromCombo(cboSessionStatus).SessionStatusValue;

                if (!cboRoomNo.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.RoomNo = ComboFiller<RoomsBO>.GetFromCombo(cboRoomNo).RoomNo;

                if (!txtSuccessorTeacher.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.SuccessorTeacher = UtilityTxt.GetString(txtSuccessorTeacher.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (err.HasError)
            {
                err.ShowErrMsg();
                return null;
            }
            return guiItem;
        }

        private void DoNothing()
        {
        }

        public void Set(ClasssessionBO guiItem)
        {
            this.guiItem = guiItem;
            txtClassID.Text = UtilityTxt.GetString(guiItem.ClassID);
            txtClassName.Text = ClassBO.Find(guiItem.ClassID).ClassName;

            if (guiItem.RelClass.GroupFlag)
            {
                chkStudentAbsence.Text = "غیبت هنرجویان";
                btnPresenceManager.Visible = canShowPresence && true;
                btnFinancial.Visible = false;
            }
            else
            {
                List<RegistrationBO> regs = RegistrationBO.List(guiItem.ClassID, null, null, null);
                chkStudentAbsence.Text = "غیبت هنرجو";
                btnPresenceManager.Visible = false;
                btnFinancial.Visible = canShowFinancial && true;
                if (regs.Count > 0)
                {
                    chkStudentAbsence.Text += ": " + regs[0].RelStudent.FullName;
                }
            }

            ComboFiller<TimeBO>.SetCombo(cboTimeID, Utility.GetObject<TimeBO>(guiItem.TimeID));

            chkStudentAbsence.Checked = guiItem.StudentAbsence;

            chkTeacherAbsence.Checked = guiItem.TeacherAbsence;

            chkContinuousAbsenece.Checked = guiItem.ContinuousAbsence;

            //ComboFiller<DayBO>.SetCombo(cboDayID, Utility.GetObject<DayBO>(guiItem.DayID));

            ComboFiller<SessionStatus>.SetCombo(cboSessionStatus, Utility.GetObject<SessionStatus>(guiItem.SessionStatus));

            ComboFiller<RoomsBO>.SetCombo(cboRoomNo, Utility.GetObject<RoomsBO>(guiItem.RoomNo));

            txtSuccessorTeacher.Text = guiItem.SuccessorTeacher;
            txtSuccesorTeacherName.Text = guiItem.RelSuccessorTeacher.FullName;

            txtClassDate.Text = guiItem.ClassDate;

            //lblTeacherName.Text = guiItem.RelClass.RelTeacher.FullName;
            chkTeacherAbsence.Text = "غیبت استاد: " + guiItem.RelClass.RelTeacher.FullName;
        }

        private bool canShowFinancial = false;
        private bool canShowPresence = false;
        private void frmClassSessionPresenceOneManager_LoadForm(object sender, EventArgs e)
        {
            btnFinancial.Visible = canShowFinancial = Program.User.CanStudentFinancialStatus;
            btnPresenceManager.Visible = canShowPresence = Program.User.CanPresenceManager;
            ComboFiller<TimeBO>.FillCombo(cboTimeID, TimeBO.List());
            ComboFiller<RoomsBO>.FillCombo(cboRoomNo, RoomsBO.List());

            ComboFiller<SessionStatus>.FillCombo(cboSessionStatus, SessionStatus.List());

            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtSuccessorTeacher, txtSuccesorTeacherName);
        }

        private void txtSuccesorTeacherName_Click(object sender, EventArgs e)
        {
            floaterTeacherPicker.Show();
        }

        #region IFloatable Members
        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion

        private void btnSetPresenceInfo_Click(object sender, EventArgs e)
        {
            ActionUpdate(sender, e);
        }

        private void btnPresence_Clicked(object sender, EventArgs e)
        {
            ClasssessionBO item = GetGUI();
            if (item == null) return;
            frmPresenceManager f = (frmPresenceManager)FormRequester.PresenceManager();
            //Program.MainForm.RunForm(f);
            floaterPresenceManager.LoadPanel(f);
            f.Set(item);
            floaterPresenceManager.Show();
        }

        bool settig = false;
        private void chkStudentAbsence_CheckedChanged(object sender, EventArgs e)
        {
            if (settig) return;
            settig = true;
            if (chkStudentAbsence.Checked)
            {
                chkContinuousAbsenece.Enabled = true;
                pnlSuccessor.Enabled = false;
                txtSuccesorTeacherName.Text = "";
                txtSuccessorTeacher.Text = "";
            }
            else
            {
                chkContinuousAbsenece.Enabled = false;
                chkContinuousAbsenece.Checked = false;
                if (chkTeacherAbsence.Checked)
                    pnlSuccessor.Enabled = true;
            }
            SetSessionStatus();
            settig = false;
        }

        private void chkTeacherAbsence_CheckedChanged(object sender, EventArgs e)
        {
            if (settig) return;
            settig = true;
            if (chkTeacherAbsence.Checked)
            {
                if (chkStudentAbsence.Checked)
                    pnlSuccessor.Enabled = false;
                else
                    pnlSuccessor.Enabled = true;
            }
            else
            {
                pnlSuccessor.Enabled = false;
            }
            SetSessionStatus();
            settig = false;
        }

        private void SetSessionStatus()
        {
            if ( chkStudentAbsence.Checked || (chkTeacherAbsence.Checked && !txtSuccessorTeacher.Accepted))
            {
                ComboFiller<SessionStatus>.SetCombo(cboSessionStatus, new SessionStatus(SessionStatus.SessionStatusType.NotHeld));
            }
            else
            {
                ComboFiller<SessionStatus>.SetCombo(cboSessionStatus, new SessionStatus(SessionStatus.SessionStatusType.Held));
            }
        }

        private void cboSessionStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ComboFiller<SessionStatus>.GetFromCombo(cboSessionStatus).SessionStatusValue == (int)SessionStatus.SessionStatusType.WillHold)
            {
                settig = true;
                chkContinuousAbsenece.Checked = false;
                chkStudentAbsence.Checked = false;
                chkTeacherAbsence.Checked = false;
                txtSuccesorTeacherName.Text = "";
                txtSuccessorTeacher.Text = "";
                settig = false;
            }
            else if (ComboFiller<SessionStatus>.GetFromCombo(cboSessionStatus).SessionStatusValue == SessionStatus.SessionStatusType.Held || ComboFiller<SessionStatus>.GetFromCombo(cboSessionStatus).SessionStatusValue == SessionStatus.SessionStatusType.HeldByPrint)
            {
                settig = true;
                chkContinuousAbsenece.Checked = false;
                chkStudentAbsence.Checked = false;
                settig = false;
            }
        }

        private void btnFinancialStatus_Clicked(object sender, EventArgs e)
        {
            frmStudentFinancialDetails fStudFinancial = new frmStudentFinancialDetails();
            List<RegistrationBO> regs = RegistrationBO.List(guiItem.ClassID, null, null, null);
            if (regs.Count > 0)
            {
                fStudFinancial.Set(regs[0].RelStudent, regs[0].RelClass);
                floaterFinancialStatus.LoadPanel(fStudFinancial);
                floaterFinancialStatus.Show();
            }

        }

        private void txtSuccesorTeacherName_TextChanged(object sender, EventArgs e)
        {
            if (settig) return;
            settig = true;
            SetSessionStatus();
            settig = false;
        }


        private void ActionSessionDetails(object sender, EventArgs e)
        {
        }


        private void btnClassStatus_Clicked(object sender, EventArgs e)
        {
            //frmStudentFinancialDetails fStudFinancial = new frmStudentFinancialDetails();
            List<RegistrationBO> regs = RegistrationBO.List(guiItem.ClassID, null, null, null);
            var studentId = "";
            var classId = 0;
            if (regs.Count > 0)
            {
                studentId = regs[0].StudentID;
                classId = guiItem.ClassID;
                //fStudFinancial.Set(regs[0].RelStudent, regs[0].RelClass);
                //floaterFinancialStatus.LoadPanel(fStudFinancial);
                //floaterFinancialStatus.Show();
            }




            //if (dataGridSection.DataGrid.SelectedRows.Count == 0) return;
            //ViwStudentFinancialStatusBO status = (ViwStudentFinancialStatusBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
            //int classID = status.ClassID;

            if (!guiItem.RelClass.GroupFlag)
            {
                SetMsg("در حال بازیابی اطلاعات...");
                Form f = FormRequester.StudentSessionDetails();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    HideMsg();
                    return;
                }
                else
                {
                    frmStudentSessionDetails fDetails = (frmStudentSessionDetails)f;
                    fDetails.Set(StudentBO.Find(studentId), ClassBO.Find(classId));
                    floaterFinancialStatus.LoadPanel(fDetails);
                    floaterFinancialStatus.Show();
                }
                HideMsg();
            }

        }
    }
}
