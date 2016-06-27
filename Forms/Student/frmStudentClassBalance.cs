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
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmStudentClassBalance : HengamWidgets.FormBaseSimple, IFloatable
    {
        public frmStudentClassBalance()
        {
            InitializeComponent();
        }

        private void datagridSection_Load(object sender, EventArgs e)
        {

        }

        frmOutcomeViewer fOutcomeViewer = new frmOutcomeViewer();
        frmClassPicker fClassPicker = new frmClassPicker();
        private void frmOutcomeViewerStudentClass_LoadForm(object sender, EventArgs e)
        {

            frmClassPicker.StudentAccepted = true; //hanieh
            fClassPicker.SetListFunction(GetClassListOfStudent);//hanieh
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);
            fClassPicker.SetListFunction(GetClassListOfStudent);//hanieh
            
            frmStudentPicker fStudentPicker = new frmStudentPicker();
            floaterStudentPicker.LoadPanel(fStudentPicker);
            fStudentPicker.HookTo(txtStudentID, txtStudentName);

            ComboFiller<PayTypeBO>.FillCombo(cboPayTypeID, PayTypeBO.List());


            floaterOutcomeDetails.LoadPanel(fOutcomeViewer);

            datagridSection.RefreshDataGrid();
            GotoAddMode();

        }

        private void datagridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            string studentID = null;
            int? classID = null;

            if (txtStudentID.Accepted) studentID = txtStudentID.Text;
            if (txtClassID.Accepted) classID = UtilityTxt.GetInt(txtClassID.Text);

            DataGridFiller<OutcomeStudentBO>.FillDataGrid(datagridSection, OutcomeStudentBO.List(studentID, null, null, null, null, classID), new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                //DatabaseSchema.Student.FirstName,
                //DatabaseSchema.Class.ClassName,
                DatabaseSchema.OutcomeStudent.Fee,
                DatabaseSchema.OutcomeStudent.PayDate,
                DatabaseSchema.PayType.PayTypeName,
                DatabaseSchema.OutcomeStudent.Description
            });

            if (studentID == null || classID == null) return;
            ViwStudentFinancialStatusBO status = ViwStudentFinancialStatusBO.Find(classID.Value, studentID);
            RegistrationBO reg = RegistrationBO.Find(classID.Value, studentID);
            if (reg == null)
            {
                MessageBoxEx.Show("هنرجو در این کلاس ثبت‌نام نکرده است.");
                return;
            }
            chkIsBalancedWithStudent.Checked = reg.IsBalancedFinalWithStudent;
            //lblClassFee.Text = UtilityTxt.ToFarsiCurrency(status.FinalClassPrice.ToString());
            //lblHavePaid.Text = UtilityTxt.ToFarsiCurrency(status.StudentFinalPay.ToString());
            int mustPay = status.StudentMustPay<0?-status.StudentMustPay:0;
            //string statusMsg = "";
            //if (mustPay == 0) statusMsg = "هنرجو بی‌حساب است.";
            //else
             //   statusMsg = "هنرجو " + UtilityTxt.ToFarsiCurrency(Math.Abs(mustPay).ToString()) + " " + (mustPay > 0 ? "بدهکار" : "طلبکار") + " است.";
            //lblMustPay.Text = statusMsg;

            if (status.StudentMustPay < 0)
            {
                txtFee.Text = mustPay.ToString();
                lblStatus.Text = "پرداخت بابت تسویه";
                //groupPay.Enabled = true;
            }
            else
            {
                lblStatus.Text = "نیاز به تسویه حساب ندارد";
                //groupPay.Enabled = false;
            }

        }

        private void datagridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            OutcomeStudentBO obj = (OutcomeStudentBO)e.Row.Tag;
            fOutcomeViewer.SetGUI(obj);
            floaterOutcomeDetails.Show();
        }

        private void txtStudentName_TextAccepted(object sender, EventArgs e)
        {
            if (!setting) datagridSection.RefreshDataGrid();
        }

        private void txtClassName_TextAccepted(object sender, EventArgs e)
        {
            if (!setting) datagridSection.RefreshDataGrid();
        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            floaterStudentPicker.Show();
        }

        private void txtClassName_Click(object sender, EventArgs e)
        {
            
            fClassPicker.RefreshDatagrid();
            //
            floaterClassPicker.Show();
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

        private void btnSetBalance_Clicked(object sender, EventArgs e)
        {
            if (!txtClassID.Accepted || !txtStudentID.Accepted) return;
            int classID = UtilityTxt.GetInt(txtClassID.Text);
            string studentID = txtStudentID.Text;
            RegistrationBO reg = RegistrationBO.Find(classID, studentID);
            if (reg == null)
            {
                MessageBoxEx.Show("هنرجو در این کلاس ثبت نام نکرده است.");
                return;
            }
            try
            {
                SetMsg("در حال به‌روز رسانی...");
                if (!reg.SetBalanced(chkIsBalancedWithStudent.Checked))
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Updated("اطلاعات تسویه حساب " + reg.RelClass.ClassName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
            if (chkIsBalancedWithStudent.Checked)
                SetMsg("تسویه حساب شد.", 1000);
            else 
                SetMsg("تسویه حساب لغو شد.", 1000);
            datagridSection.RefreshDataGrid();
        }

        private OutcomeStudentBO GetGUIOutcomeStudent()
        {
            OutcomeStudentBO guiItem = new OutcomeStudentBO();
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
            IBusinessObject item = GetGUIOutcomeStudent();

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

        bool setting = false;
        public void Set(ClassBO cls, StudentBO student)
        {
            setting = true;
            if (cls != null)
            {
                txtClassID.Text = cls.ClassID.ToString();
                txtClassName.Text = cls.ClassName;
            }
            if (student != null)
            {
                txtStudentID.Text = student.StudentID;
                txtStudentName.Text = student.FullName;
            }
            setting = false;
            datagridSection.RefreshDataGrid();
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
