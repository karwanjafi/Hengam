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
    public partial class frmTeacherPayForClass : HengamWidgets.FormBaseSimple, IFloatable
    {
        public frmTeacherPayForClass()
        {
            InitializeComponent();
        }

        private void datagridSection_Load(object sender, EventArgs e)
        {

        }

        frmOutcomeViewer fOutcomeViewer = new frmOutcomeViewer();
        frmClassPicker fClassPicker = new frmClassPicker();
        private void frmTeacherPayForClass_LoadForm(object sender, EventArgs e)
        {
            frmClassPicker.TeacherAccepted = true;//hanieh
            frmClassPicker.StudentAccepted = false;//hanieh
            fClassPicker.SetListFunction(GetClassListOfTeacher); //hanieh
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);
            //fClassPicker.SetListFunction(GetClassListOfTeacher);//hanieh

            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtTeacherID, txtTeacherName);

            ComboFiller<PayTypeBO>.FillCombo(cboPayTypeID, PayTypeBO.List());


            floaterOutcomeDetails.LoadPanel(fOutcomeViewer);

            GotoAddMode();
            datagridSection.RefreshDataGrid();
            

        }

        private void datagridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            string teacherID = null;
            int? classID = null;

            if (txtTeacherID.Accepted) teacherID = txtTeacherID.Text;
            if (txtClassID.Accepted) classID = UtilityTxt.GetInt(txtClassID.Text);

            if (teacherID == null || classID == null) return;

            DataGridFiller<OutcomeTeacherBO>.FillDataGrid(datagridSection, OutcomeTeacherBO.List(teacherID, null, null, null, null, classID), new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                DatabaseSchema.OutcomeTeacher.Fee,
                DatabaseSchema.OutcomeTeacher.PayDate,
                DatabaseSchema.OutcomeTeacher.PayTypeID,
                DatabaseSchema.OutcomeTeacher.Description
            });

            if (teacherID == null || classID == null) return;
            ViwTeacherFinancialStatusBO status = ViwTeacherFinancialStatusBO.Find(classID.Value, teacherID);
            
            //RegistrationBO reg = RegistrationBO.Find(classID.Value, teacherID);
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

            if (mustPay > 0)
            {
                txtFee.Text = mustPay.ToString();
                lblStatus.Text = "پرداخت بابت حقوق";
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
            OutcomeTeacherBO obj = (OutcomeTeacherBO)e.Row.Tag;
            fOutcomeViewer.SetGUI(obj);
            floaterOutcomeDetails.Show();
        }

        private void txtTeacherName_TextAccepted(object sender, EventArgs e)
        {
            if (setting) return; //hanieh
            datagridSection.RefreshDataGrid();
        }

        private void txtClassName_TextAccepted(object sender, EventArgs e)
        {
            if (setting) return; //hanieh
            datagridSection.RefreshDataGrid();
        }

        private void txtTeacherName_Click(object sender, EventArgs e)
        {
            floaterTeacherPicker.Show();
        }

        private void txtClassName_Click(object sender, EventArgs e)
        {
            fClassPicker.RefreshDatagrid();
            floaterClassPicker.Show();
        }

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

        private OutcomeTeacherBO GetGUIOutcomeTeacher()
        {
            OutcomeTeacherBO guiItem = new OutcomeTeacherBO();
            ErrorCollector err = new ErrorCollector();
            try
            {
                //if (!txtPayID.Accepted)
                //    err.Add("کد پرداخت");
                //else
                //    guiItem.PayID = UtilityTxt.GetInt(txtPayID.Text);

                if (!txtTeacherID.Accepted)
                    err.Add("شماره‌ی هنرجو");
                else
                    guiItem.TeacherID = UtilityTxt.GetString(txtTeacherID.Text);

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
            IBusinessObject item = GetGUIOutcomeTeacher();

            if (item == null) return;
            try
            {
                SetMsg("در حال پرداخت حقوق");
                if (!item.Add())
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات حقوق "));
                    GotoAddMode();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات حقوق "));
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
        public void Set(ClassBO classObj, TeacherBO teacher)
        {
            setting = true; //hanieh
            if (classObj != null)
            {
                txtClassID.Text = classObj.ClassID.ToString();
                txtClassName.Text = classObj.ClassName;
            }
            if (teacher != null)
            {
                txtTeacherID.Text = teacher.TeacherID;
                txtTeacherName.Text = teacher.FullName;
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
            OutcomeTeacherBO income = (OutcomeTeacherBO)datagridSection.DataGrid.SelectedRows[0].Tag;
            Form f = FormRequester.ReportTeacherPayFactor();
            if (f == null)
            {
                MessageBoxEx.Show("شما به این قسمت دسترسی ندارید.");
                HideMsg();
                return;
            }
            frmReportTeacherPayFactor factor = (frmReportTeacherPayFactor)f;
            //Program.MainForm.RunForm(factor);
            floaterContainter.LoadPanel(factor);
            factor.SetFactor(income.GroupPayID);
            floaterContainter.Show();
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
