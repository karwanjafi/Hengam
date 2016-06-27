using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hengam.Forms.ItemViewers;
using Hengam.Forms.ItemPickers;
using BusinessObjectNamespace;
using Tools;
using FarsiMessageBox;
using DataGridFiller;
using DatabaseSchemaNamespace;
using StandardWidgets;
using Hengam.Tools;

namespace Hengam.Forms.Student
{
    public partial class frmStudentFinancialDetails : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmStudentFinancialDetails()
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

        private void ActionBalance(object sender, EventArgs e)
        {
            if (txtClassID.Accepted && txtStudentID.Accepted)
            {
                Form f = FormRequester.StudentClassBalance();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    return;
                }
                else
                {
                    frmStudentClassBalance fPay = (frmStudentClassBalance)f;
                    fPay.Set(ClassBO.Find(UtilityTxt.GetInt(txtClassID.Text)), StudentBO.Find(txtStudentID.Text));
                    floaterContainer.LoadPanel(fPay);
                    floaterContainer.Show();
                }
            }
        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            floaterStudentPicker.Show();
        }

        private void txtClassName_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Accepted) fClassPicker.Set(StudentBO.Find(txtStudentID.Text));
            floaterClassPicker.Show();
        }

        frmClassPicker fClassPicker = new frmClassPicker();

        private void frmStudentFinancialDetails_LoadForm(object sender, EventArgs e)
        {
            if (Program.User.CanStudentPayForClass)
            {
                AddButton("دریافت شهریه", "Money", "دریافت شهریه از هنرجو بابت این کلاس", ActionPay, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            }

            if (Program.User.CanStudentClassBalance)
            {
                AddButton("تسویه‌حساب", "MoneyBack", "تسویه حساب با هنرجو بابت این کلاس", ActionBalance, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            }
            frmClassPicker.StudentAccepted = true; //hanieh
            fClassPicker.SetListFunction(GetClassListOfStudent); //hanieh
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);
            //fClassPicker.SetListFunction(GetClassListOfStudent);//hanieh
            
            frmStudentPicker fStudentPicker = new frmStudentPicker();
            floaterStudentPicker.LoadPanel(fStudentPicker);
            fStudentPicker.HookTo(txtStudentID, txtStudentName);
            
            dataGridSection.RefreshDataGrid();
            GotoAddMode();
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

        bool setting = false;
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
                        lblPayed.Text = UtilityTxt.ToFarsiCurrency(status.StudentPayedAmount.ToString());
                        if (status.StudentMustPay == 0)
                            lblMustPay.Text = "بی حساب";
                        else
                            lblMustPay.Text = "هنرجو " + UtilityTxt.ToFarsiCurrency(Math.Abs(status.StudentMustPay).ToString()) + " "
                                + (status.StudentMustPay>0?"بدهکار":"طلبکار") + " است.";
                        lblBalancedAmount.Text = UtilityTxt.ToFarsiCurrency(status.BalancedAmount.ToString());
                        lblReturnedForTeacherAmount.Text = UtilityTxt.ToFarsiCurrency(status.ReturnMoneyForTeacherAbsentAmount.ToString());
                    }
                    if (reg.IsBalancedFinalWithStudent) lblMustPay.Text += " - " + "تسویه شده";

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

                    DataGridFiller<ViwStudentFinancialDetailsBO>.FillDataGrid(dataGridSection, ViwStudentFinancialDetailsBO.List(classID, studentID, null, null), new List<DatabaseSchemaNamespace.ColumnDefinition>
                    {
                        DatabaseSchema.ViwStudentFinancialDetails.IsIncome,
                        DatabaseSchema.ViwStudentFinancialDetails.Fee,
                        DatabaseSchema.ViwStudentFinancialDetails.PayDate,
                        DatabaseSchema.ViwStudentFinancialDetails.PayTypeName,
                        DatabaseSchema.ViwStudentFinancialDetails.Description
                    });


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

        private void txtStudentID_TextAccepted(object sender, EventArgs e)
        {
            
        }

    }
}
