using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hengam.Forms.ItemPickers;
using Tools;
using BusinessObjectNamespace;
using DatabaseSchemaNamespace;
using FarsiMessageBox;
using DataGridFiller;
using StandardWidgets;
using Hengam.Tools;


namespace Hengam.Forms.Student
{
    public partial class frmStudentSessionDetails : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmStudentSessionDetails()
        {
            InitializeComponent();
        }

        private void ActionPay(object sender, EventArgs e)
        {
            if (txtClassID.Accepted && txtStudentID.Accepted)
            {
                Form f = FormRequester.StudentPayForClass();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    return;
                }
                else
                {
                    frmStudentPayForClass fPay = (frmStudentPayForClass)f;
                    fPay.Set(ClassBO.Find(UtilityTxt.GetInt(txtClassID.Text)), StudentBO.Find(txtStudentID.Text));
                    floaterContainer.LoadPanel(fPay);
                    floaterContainer.Show();
                }
            }
        }

        private void ActionStatusSetter(object sender, EventArgs e)
        {

            if (dataGridSection.DataGrid.SelectedRows.Count >0)
            {
                ViwStudentSessionDetailsBO detail = (ViwStudentSessionDetailsBO)(dataGridSection.DataGrid.SelectedRows[0].Tag);
                Form f = FormRequester.ClassSessionStatusSetter();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    return;
                }
                else
                {
                    frmClassSessionStatusSetter frmStatusSetterPublic = (frmClassSessionStatusSetter)f;
                    //frmStatusSetterPublic.Set(ClasssessionBO.Find(detail.ClassID, detail.ClassDate, detail.TimeID));//hanieh
                    floaterContainer.LoadPanel(frmStatusSetterPublic);
                    frmStatusSetterPublic.Set(ClasssessionBO.Find(detail.ClassID, detail.ClassDate, detail.TimeID));//hanieh
                    floaterContainer.Show();
                }
            }
        }

        frmClassPicker fClassPicker = new frmClassPicker();

        private void frmStudentSessionDetails_LoadForm(object sender, EventArgs e)
        {
            if (Program.User.CanStudentPayForClass)
                AddButton("دریافت شهریه", "Money", "دریافت شهریه از هنرجو بابت این کلاس", ActionPay, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            if (Program.User.CanClassSessionStatusSetter)
                AddButton("وضعیت جلسه", "Session", "تنظیم وضعیت تشکیل جلسه", ActionStatusSetter, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);

            //hanieh
            frmClassPicker.StudentAccepted = true; //hanie
            fClassPicker.SetListFunction(GetClassListOfStudent); //hanieh
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);

            frmStudentPicker fStudentPicker = new frmStudentPicker();
            floaterStudentPicker.LoadPanel(fStudentPicker);
            fStudentPicker.HookTo(txtStudentID, txtStudentName);
             
        }
        bool setting = false;
        private void txtStudentID_TextAccepted(object sender, EventArgs e)
        {
            if (setting) return;
            dataGridSection.RefreshDataGrid();
        }

        private void txtClassID_TextAccepted(object sender, EventArgs e)
        {
            if (setting) return;
            if (txtStudentID.Accepted) fClassPicker.Set(StudentBO.Find(txtStudentID.Text));
            dataGridSection.RefreshDataGrid();
        }

        public List<ClassBO> GetClassListOfStudent()
        {
            if (!txtStudentID.Accepted)
            {
                //hanieh
                if (DataAccessNamespace.ClassDA.allclasses.Count == 0)
                    DataAccessNamespace.ClassDA.allclasses = ClassBO.List();
                return DataAccessNamespace.ClassDA.allclasses;
                //
            }
            else
                return ClassBO.ListClassesOfStudent(txtStudentID.Text, null);
        }

        public void Set(StudentBO student, ClassBO cls)
        {
            setting = true;
            if (student != null)
            {
                txtStudentID.Text = student.StudentID;
                txtStudentName.Text = student.FullName;
            }

            if (cls != null)
            {
                txtClassID.Text = cls.ClassID.ToString();
                txtClassName.Text = cls.ClassName;
            }
            setting = false;
            dataGridSection.RefreshDataGrid();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            if (txtStudentID.Accepted && txtClassID.Accepted)
            {
                string studentID = txtStudentID.Text;
                int classID = UtilityTxt.GetInt(txtClassID.Text);

                RegistrationBO reg = RegistrationBO.Find(classID, studentID);
                if (reg == null)
                {
                    MessageBoxEx.Show("این هنرجو در این کلاس ثبت نام نکرده است.");
                }
                else
                {
                    ViwStudentFinancialStatusBO status = ViwStudentFinancialStatusBO.Find(classID, studentID);

                    if (status != null)
                    {
                        lblClassPrice.Text = UtilityTxt.ToFarsiCurrency(status.ClassTotalPrice.ToString());
                        lblPayed.Text = UtilityTxt.ToFarsiCurrency(status.StudentFinalPay.ToString());
                        lblMustPay.Text = UtilityTxt.ToFarsiCurrency(status.StudentMustPay.ToString());
                    }

                    ViwStudentSessionStatusBO sessions = ViwStudentSessionStatusBO.Find(studentID, classID);

                    if (sessions != null)
                    {
                        lblContinuousAbsence.Text = UtilityTxt.GetString(sessions.ContinuousAbseneceCount ?? 0);
                        lblHeld.Text = UtilityTxt.GetString(sessions.HeldCount ?? 0);
                        lblStudentAbsence.Text = UtilityTxt.GetString(sessions.StudentAbseneceCount ?? 0);
                        lblTeacherAbsence.Text = UtilityTxt.GetString(sessions.TeacherAbsenceCount ?? 0);
                        lblTotalSessions.Text = UtilityTxt.GetString(sessions.TotalDedicatedSessions ?? 0);
                        lblNotHeld.Text = UtilityTxt.GetString(sessions.WillHeldCount ?? 0);
                    }

                    DataGridFiller<ViwStudentSessionDetailsBO>.FillDataGrid(dataGridSection, ViwStudentSessionDetailsBO.List(classID, studentID, null, null, null, null, null, null, null, null, null), new List<DatabaseSchemaNamespace.ColumnDefinition>
                    {
                        DatabaseSchema.ViwStudentSessionDetails.ClassDate,
                        DatabaseSchema.ViwStudentSessionDetails.TimeID,
                        DatabaseSchema.ViwStudentSessionDetails.SessionStatus,
                        DatabaseSchema.ViwStudentSessionDetails.StudentAbsence,
                        DatabaseSchema.ViwStudentSessionDetails.TeacherAbsence,
                        DatabaseSchema.ViwStudentSessionDetails.SuccessorTeacher,
                        DatabaseSchema.ViwStudentSessionDetails.ContinuousAbsence
                    });

                    ClassBO cls = ClassBO.Find(status.ClassID);
                    int totalSessions = cls.Price - cls.SchoolPrice;
                    int eachSession = (cls.Price - cls.SchoolPrice) / cls.SessionCount;
                    int studentPayed = status.StudentFinalPay;
                    int remaindMoney = studentPayed - cls.SchoolPrice;
                    foreach (DataGridViewRow row in dataGridSection.DataGrid.Rows)
                    {
                        ViwStudentSessionDetailsBO det = (ViwStudentSessionDetailsBO)(row.Tag);
                        if (!det.StudentAbsence && det.SessionStatus == (int)SessionStatus.SessionStatusType.NotHeld)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightGray;
                            continue;
                        }
                        remaindMoney -= eachSession;
                        if (remaindMoney >= 0)
                        {
                            row.DefaultCellStyle.BackColor = Color.YellowGreen;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.Plum;
                        }

                    }

                }
            }
        }

        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion

        private void floaterContainer_Closed()
        {
            dataGridSection.RefreshDataGrid();
        }

        private void frmStudentSessionDetails_Shown(object sender, EventArgs e)
        {
            frmClassPicker.StudentAccepted = true; //hanie
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);

            frmStudentPicker fStudentPicker = new frmStudentPicker();
            floaterStudentPicker.LoadPanel(fStudentPicker);
            fStudentPicker.HookTo(txtStudentID, txtStudentName);
        }
    }
}
