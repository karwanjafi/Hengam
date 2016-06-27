using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Hengam.Forms.ItemPickers;
using BusinessObjectNamespace;
using DataGridFiller;
using DatabaseSchemaNamespace;
using Tools;
using Hengam.Forms.ItemViewers;
using FarsiMessageBox;
using Hengam.Tools;
using Hengam.ComboManager;
using Hengam.Reports.ReportForms;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmStudentPayForClass : HengamWidgets.FormBaseSimple, IFloatable
    {
        public frmStudentPayForClass()
        {
            InitializeComponent();
        }

        private void datagridSection_Load(object sender, EventArgs e)
        {

        }

        frmIncomeViewer fIncomeViewer = new frmIncomeViewer();
        frmClassPicker fClassPicker = new frmClassPicker();
        private void frmOutcomeViewerStudentClass_LoadForm(object sender, EventArgs e)
        {
            fClassPicker.SetListFunction(GetClassListOfStudent); //hanieh
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);
            //fClassPicker.SetListFunction(GetClassListOfStudent);//hanieh
            
            frmStudentPicker fStudentPicker = new frmStudentPicker();
            floaterStudentPicker.LoadPanel(fStudentPicker);
            fStudentPicker.HookTo(txtStudentID, txtStudentName);

            ComboFiller<PayTypeBO>.FillCombo(cboPayTypeID, PayTypeBO.List());


            floaterOutcomeDetails.LoadPanel(fIncomeViewer);

            GotoAddMode();
            datagridSection.RefreshDataGrid();
            

        }

        private void datagridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            string studentID = null;
            int? classID = null;

            if (txtStudentID.Accepted) studentID = txtStudentID.Text;
            if (txtClassID.Accepted) classID = UtilityTxt.GetInt(txtClassID.Text);

            if (studentID == null) return;

            DataGridFiller<IncomeStudentBO>.FillDataGrid(datagridSection, IncomeStudentBO.List(null, studentID, null, null, null, null, classID), new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                DatabaseSchema.Student.FirstName,
                DatabaseSchema.Class.ClassName,
                DatabaseSchema.OutcomeStudent.Fee,
                DatabaseSchema.IncomeStudent.PayDate,
                DatabaseSchema.PayType.PayTypeName
            });

            if (studentID == null || classID == null) return;
            ViwStudentFinancialStatusBO status = ViwStudentFinancialStatusBO.Find(classID.Value, studentID);
            RegistrationBO reg = RegistrationBO.Find(classID.Value, studentID);
            if (status == null || reg == null)
            {
                MessageBoxEx.Show("هنرجو در این کلاس ثبت‌نام نکرده است.");
                return;
            }
            lblClassFee.Text = UtilityTxt.ToFarsiCurrency(status.ClassTotalPrice.ToString());
            lblHavePaid.Text = UtilityTxt.ToFarsiCurrency(status.StudentFinalPay.ToString());
            int mustPay = status.StudentMustPay;
            string statusMsg = "";
            if (mustPay == 0) statusMsg = "هنرجو بی‌حساب است.";
            else
                statusMsg = "هنرجو " + UtilityTxt.ToFarsiCurrency(Math.Abs(mustPay).ToString()) + " " + (mustPay > 0 ? "بدهکار" : "طلبکار") + " است.";
            lblMustPay.Text = statusMsg;

            if (mustPay > 0)
            {
                txtFee.Text = mustPay.ToString();
                lblStatus.Text = "پرداخت بابت شهریه";
                //groupPay.Enabled = true;
            }
            else
            {
                txtFee.Text = "";
                lblStatus.Text = "نیاز به پرداخت ندارد";
                //groupPay.Enabled = false;
            }

        }

        private void datagridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            IncomeStudentBO obj = (IncomeStudentBO)e.Row.Tag;
            fIncomeViewer.SetGUI(obj);
            floaterOutcomeDetails.Show();
        }

        private void txtStudentName_TextAccepted(object sender, EventArgs e)
        {
            if (setting) return; //hanieh
            datagridSection.RefreshDataGrid();
        }

        private void txtClassName_TextAccepted(object sender, EventArgs e)
        {
            if (setting) return; //hanieh
            datagridSection.RefreshDataGrid();
        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            floaterStudentPicker.Show();
        }

        private void txtClassName_Click(object sender, EventArgs e)
        {
            fClassPicker.RefreshDatagrid();
            floaterClassPicker.Show();
        }

        public List<ClassBO> GetClassListOfStudent()
        {
            if (!txtStudentID.Accepted)
            {
                //hanieh
                if (DataAccessNamespace.ClassDA.allclasses.Count == 0)
                    return ClassBO.List();
                else
                    return DataAccessNamespace.ClassDA.allclasses;
                //
            }
            else
                return ClassBO.ListClassesOfStudent(txtStudentID.Text, null);
        }

        private IncomeStudentBO GetGUIIncomeStudent()
        {
            IncomeStudentBO guiItem = new IncomeStudentBO();
            ErrorCollector err = new ErrorCollector();
            try
            {
                //if (!txtPayID.Accepted)
                //    err.Add("کد پرداخت");
                //else
                //    guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);

                if (!txtStudentID.Accepted)
                    err.Add("شماره‌ی هنرجو");
                else
                    guiItem.StudentID = UtilityTxt.GetString(txtStudentID.Text);

                if (!cboPayTypeID.Accepted)
                    err.Add("نحوه‌ی پرداخت");
                else
                    guiItem.PayTypeID = ComboFiller<PayTypeBO>.GetFromCombo(cboPayTypeID).PayTypeID;

                if (!txtFee.Accepted)
                    err.Add("مبلغ");
                else
                    guiItem.Fee = UtilityTxt.GetInt(txtFee.Text);

                if (!txtDiscount.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Discount = UtilityTxt.GetInt(txtDiscount.Text);

                if (!txtPayDate.Accepted)
                    err.Add("تاریخ پرداخت");
                else
                    guiItem.PayDate = UtilityTxt.GetString(txtPayDate.Text);

                if (!txtCheckDate.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.CheckDate = UtilityTxt.GetString(txtCheckDate.Text);

                if (!txtCheckNumber.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.CheckNumber = UtilityTxt.GetString(txtCheckNumber.Text);

                if (!txtDescription.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.Description = UtilityTxt.GetString(txtDescription.Text);

                if (!txtClassID.Accepted)
                    err.Add("کلاس");
                else
                    guiItem.ClassID = UtilityTxt.GetInt(txtClassID.Text);

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

        private void btnPay_Clicked(object sender, EventArgs e)
        {
            IBusinessObject item = GetGUIIncomeStudent();

            if (item == null) return;
            try
            {
                SetMsg("در حال اضافه کردن");
                if (!item.Add())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات یک هزینه "));
                    GotoAddMode();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات یک هزینه "));
                        break;
                    case 8152:// Dont Remember? 
                        MessageBoxEx.Show("اطلاعات فرم صحیح نمی‌باشد، لطفاً دوباره بررسی کنید" + ".");
                        break;

                    default:
                        MessageBox.Show(se.Number.ToString() + ", \n" + se.Message);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
            datagridSection.RefreshDataGrid();
        }

        private void GotoAddMode()
        {
            //txtFee.Text = "";
            txtDiscount.Text = "";
            txtDescription.Text = "";
            txtCheckDate.Text = "";
            txtPayDate.Text = FaDate.CurrentFaDateString;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, new PayTypeBO((int)PayTypeBO.PayType.Cash));
            txtCheckNumber.Text = "";
        }

        private void datagridSection_RowsSelected(StandardWidgets.CoolDataGrid.RowsSelectionEventArgs e)
        {
            if (e.Rows.Count == 0)
                btnPrintFactor.Enabled = false;
            else
                btnPrintFactor.Enabled = true;
        }
        bool setting = false; //hanieh
        public void Set(ClassBO classObj, StudentBO student)
        {
            setting = true; //hanieh
            if (classObj != null)
            {
                txtClassID.Text = classObj.ClassID.ToString();
                txtClassName.Text = classObj.ClassName;
            }
            if (student != null)
            {
                txtStudentID.Text = student.StudentID;
                txtStudentName.Text = student.FullName;
                picStudent.Image = student.Image;
            }
            //hanieh
            setting = false;
            datagridSection.RefreshDataGrid();
            //
        }

        private void btnPrintFactor_Clicked(object sender, EventArgs e)
        {
            if (datagridSection.DataGrid.SelectedRows.Count <= 0)
            {
                MessageBoxEx.Show("هیچ فاکتوری برای چاپ انتخاب نشده است.");
                return;
            }

            SetMsg("در حال بررسی اطلاعات...");
            IncomeStudentBO income = (IncomeStudentBO)datagridSection.DataGrid.SelectedRows[0].Tag;
            Form f = FormRequester.ReportStudentPayFactor();
            if (f == null)
            {
                MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                HideMsg();
                return;
            }
            frmReportStudentPayFactor factor = (frmReportStudentPayFactor)f;
            factor.Set(ClassBO.Find(UtilityTxt.GetInt(txtClassID.Text)), StudentBO.Find(txtStudentID.Text)); //hanieh
            //Program.MainForm.RunForm(factor);
            floaterContainer.LoadPanel(factor);
            //factor.SetFactor(income.PayID);  //hanieh
            factor.SetFactor(txtStudentID.Text, UtilityTxt.GetInt(txtClassID.Text));//hanieh
            floaterContainer.Show();
            HideMsg();
        }

        #region IFloatable Members

        public PanelFloater ContainerFloater
        {
            get;
            set;
        }

        #endregion
    }
}
