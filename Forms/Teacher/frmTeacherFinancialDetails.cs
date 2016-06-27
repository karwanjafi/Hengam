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

namespace Hengam.Forms.Teacher
{
    public partial class frmTeacherFinancialDetails : HengamWidgets.FormBaseTableEditor, IFloatable
    {
        public frmTeacherFinancialDetails()
        {
            InitializeComponent();
        }

        private void ActionPay(object sender, EventArgs e)
        {
            if (txtClassID.Accepted && txtTeacherID.Accepted)
            {
                Form f = FormRequester.TeacherPayForClass();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    return;
                }
                else
                {
                    frmTeacherPayForClass fPay = (frmTeacherPayForClass)f;
                    fPay.Set(ClassBO.Find(UtilityTxt.GetInt(txtClassID.Text)), TeacherBO.Find(txtTeacherID.Text));
                    floaterContainer.LoadPanel(fPay);
                    floaterContainer.Show();
                }
            }
        }

        private void ActionBalance(object sender, EventArgs e)
        {
            if (txtClassID.Accepted && txtTeacherID.Accepted)
            {
                Form f = FormRequester.TeacherBalance();
                if (f == null)
                {
                    MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                    return;
                }
                else
                {
                    frmTeacherClassBalance fPay = (frmTeacherClassBalance)f;
                    fPay.Set(ClassBO.Find(UtilityTxt.GetInt(txtClassID.Text)), TeacherBO.Find(txtTeacherID.Text));
                    floaterContainer.LoadPanel(fPay);
                    floaterContainer.Show();
                }
            }
        }

        private void txtTeacherName_Click(object sender, EventArgs e)
        {
            floaterTeacherPicker.Show();
        }

        private void txtClassName_Click(object sender, EventArgs e)
        {
            //hanieh
            

            //if (txtTeacherID.Accepted) fClassPicker.Set(TeacherBO.Find(txtTeacherID.Text));//hanieh
            floaterClassPicker.Show();

           
            //if (txtTeacherID.Text != null)
            //    fClassPicker.RefreshDatagrid(); //hanieh
           
        }

        frmClassPicker fClassPicker = new frmClassPicker();

        private void frmTeacherFinancialDetails_LoadForm(object sender, EventArgs e)
        {
            if (Program.User.CanTeacherPayForClass)
            {
                AddButton("پرداخت حقوق", "Money", "پرداخت حقوق بابت این کلاس", ActionPay, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            }

            if (Program.User.CanTeacherClassBalance)
            {
                AddButton("تسویه‌حساب", "MoneyBack", "تسویه حساب با استاد بابت این کلاس", ActionBalance, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            }
            frmClassPicker.TeacherAccepted = true;
            frmClassPicker.StudentAccepted = false;
            fClassPicker.SetListFunction(GetClassListOfTeacher);//hanieh
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);
            //fClassPicker.SetListFunction(GetClassListOfTeacher);

            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtTeacherID, txtTeacherName);

            dataGridSection.RefreshDataGrid();
            GotoAddMode();
        }
        //unmark by hanieh
        public List<ClassBO> GetClassListOfTeacher()
        {
            if (!txtTeacherID.Accepted)
            {
                //hanieh
                if (DataAccessNamespace.ClassDA.allclasses.Count == 0)
                    DataAccessNamespace.ClassDA.allclasses = ClassBO.List();
                return DataAccessNamespace.ClassDA.allclasses;
                //
            }
            else
                return ClassBO.ListClassesOfTeacher(txtTeacherID.Text, null);
        }
        //

        bool setting = false;
        public void Set(TeacherBO teacher, ClassBO cls)
        {
            setting = true;
            if (teacher != null)
            {
                txtTeacherID.Text = teacher.TeacherID;
                txtTeacherName.Text = teacher.FullName;
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
            if (txtTeacherID.Accepted /*&& txtClassID.Accepted*/)
            {
                string teacherID = txtTeacherID.Text;
                int classID = UtilityTxt.GetInt(txtClassID.Text);

                ////RegistrationBO reg = RegistrationBO.Find(classID, teacherID);
                ////if (reg == null)
                ////{
                ////    MessageBoxEx.Show("این هنرجو در این کلاس ثبت نام نکرده است.");
                ////}
                ////else
                ////{
                ViwTeacherFinancialStatusBO status = ViwTeacherFinancialStatusBO.Find(classID, teacherID);

                //    if (status != null)
                //    {
                //        lblClassTotalFee.Text = UtilityTxt.ToFarsiCurrency(status.ClassTotalPrice.ToString());
                //        lblPayed.Text = UtilityTxt.ToFarsiCurrency(status.StudentPayedAmount.ToString());
                //        if (status.StudentMustPay == 0)
                //            lblMustPay.Text = "بی حساب";
                //        else
                //            lblMustPay.Text = "هنرجو " + UtilityTxt.ToFarsiCurrency(Math.Abs(status.StudentMustPay).ToString()) + " "
                //                + (status.StudentMustPay>0?"بدهکار":"طلبکار") + " است.";
                //        lblBalancedAmount.Text = UtilityTxt.ToFarsiCurrency(status.BalancedAmount.ToString());
                //        lblReturnedForTeacherAmount.Text = UtilityTxt.ToFarsiCurrency(status.ReturnMoneyForTeacherAbsentAmount.ToString());
                //    }
                //    if (reg.IsBalancedFinalWithStudent) lblMustPay.Text += " - " + "تسویه شده";
                
                if (status == null)
                {
                    MessageBoxEx.Show("این استاد اطلاعات مالی خاصی در این کلاس ندارد.");
                    return;
                }
                
                lblClassTotalFee.Text = UtilityTxt.ToFarsiCurrency(status.ClassTotalPrice.ToString());
                lblHavePaid.Text = UtilityTxt.ToFarsiCurrency(status.PaidToTeacher.ToString());
                lblEachSessionAmount.Text = UtilityTxt.ToFarsiCurrency(status.TeacherEachSessionPortion.ToString());
                lblTeacherPortion.Text = UtilityTxt.ToFarsiCurrency(status.TeacherTotalPortion.ToString());
                lblHeldSessionsAmount.Text = UtilityTxt.ToFarsiCurrency((status.MustPaySessionCount * status.TeacherEachSessionPortion).ToString());

                int mustPay = status.MustPayToTeacherAmount;
                string statusMsg = "";
                if (mustPay == 0) statusMsg = "استاد بی‌حساب است.";
                else
                    statusMsg = "استاد " + UtilityTxt.ToFarsiCurrency(Math.Abs(mustPay).ToString()) + " " + (mustPay < 0 ? "بدهکار" : "طلبکار") + " است.";
                lblMustPay.Text = statusMsg;


                ViwTeacherSessionStatusBO sessions = ViwTeacherSessionStatusBO.Find(classID);

                if (sessions != null)
                {
                    lblContinuousAbsence.Text = UtilityTxt.GetString(sessions.ContinuousAbseneceCount ?? 0);
                    lblHeld.Text = UtilityTxt.GetString(sessions.HeldCount ?? 0);
                    lblStudentAbsence.Text = UtilityTxt.GetString(sessions.StudentAbseneceCount ?? 0);
                    lblTeacherAbsence.Text = UtilityTxt.GetString(sessions.TeacherAbsenceCount ?? 0);
                    lblTotalSessions.Text = UtilityTxt.GetString(sessions.TotalDedicatedSessions ?? 0);
                    lblNotHeld.Text = UtilityTxt.GetString(sessions.WillHeldCount ?? 0);
                }
                
                DataGridFiller<ViwTeacherFinancialDetailsBO>.FillDataGrid(dataGridSection, ViwTeacherFinancialDetailsBO.List(null, null, null, null, classID, teacherID), new List<DatabaseSchemaNamespace.ColumnDefinition>
                {
                    DatabaseSchema.ViwTeacherFinancialDetails.IsIncome,
                    DatabaseSchema.ViwTeacherFinancialDetails.Fee,
                    DatabaseSchema.ViwTeacherFinancialDetails.PayDate,
                    DatabaseSchema.ViwTeacherFinancialDetails.PayTypeName,
                    DatabaseSchema.ViwTeacherFinancialDetails.Description
                });


                //}
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

       /* private void txtStudentID_TextAccepted(object sender, EventArgs e)
        {
            if(!setting) dataGridSection.RefreshDataGrid(); //hanieh
        }

        private void txtClassID_TextAccepted(object sender, EventArgs e)
        {
            //if (!setting) dataGridSection.RefreshDataGrid(); //hanieh
        }
        */
        private void txtClassName_TextChanged(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid(); 
        }
        
        private void txtTeacherName_TextChanged(object sender, EventArgs e)
        {
            if (txtTeacherID.Accepted) fClassPicker.Set(TeacherBO.Find(txtTeacherID.Text));
            if (txtTeacherID.Text != null)
                fClassPicker.RefreshDatagrid(); //hanieh
        }

    }
}
