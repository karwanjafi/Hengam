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

namespace Hengam.Forms.Teacher
{
    public partial class frmTeacherClassBalance : HengamWidgets.FormBaseSimple, IFloatable
    {
        public frmTeacherClassBalance()
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
            frmClassPicker.StudentAccepted = false;//hanieh
            frmClassPicker.TeacherAccepted = true;//hanieh
            fClassPicker.SetListFunction(GetClassListOfTeacher); //hanieh
            floaterClassPicker.LoadPanel(fClassPicker);
            fClassPicker.HookTo(txtClassID, txtClassName);
            //fClassPicker.SetListFunction(GetClassListOfStudent);

            frmTeacherPicker fTeacherPicker = new frmTeacherPicker();
            floaterTeacherPicker.LoadPanel(fTeacherPicker);
            fTeacherPicker.HookTo(txtTeacherID, txtTeacherName);

            ComboFiller<PayTypeBO>.FillCombo(cboPayTypeID, PayTypeBO.List());


            floaterOutcomeDetails.LoadPanel(fOutcomeViewer);

            datagridSection.RefreshDataGrid();
            GotoAddMode();

        }

        private void datagridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            string teacherID = null;
            int? classID = null;

            if (txtTeacherID.Accepted) teacherID = txtTeacherID.Text;
            if (txtClassID.Accepted) classID = UtilityTxt.GetInt(txtClassID.Text);

            DataGridFiller<IncomeTeacherBO>.FillDataGrid(datagridSection, IncomeTeacherBO.List(teacherID, null ,classID), new List<DatabaseSchemaNamespace.ColumnDefinition>()
            {
                //DatabaseSchema.Student.FirstName,
                //DatabaseSchema.Class.ClassName,
                DatabaseSchema.IncomeTeacher.Fee,
                DatabaseSchema.IncomeTeacher.PayDate,
                DatabaseSchema.PayType.PayTypeName,
                DatabaseSchema.IncomeTeacher.Description
            });

            if (teacherID == null || classID == null) return;
            ViwTeacherFinancialStatusBO status = ViwTeacherFinancialStatusBO.Find(classID.Value, teacherID);

            ClassBO cls = ClassBO.Find(classID.Value);

            chkIsBalancedWithTeacher.Checked = cls.IsBalancedFinalWithTeacher;
            //lblClassFee.Text = UtilityTxt.ToFarsiCurrency(status.FinalClassPrice.ToString());
            //lblHavePaid.Text = UtilityTxt.ToFarsiCurrency(status.StudentFinalPay.ToString());
            int mustPay = status.MustPayToTeacherAmount < 0 ? -status.MustPayToTeacherAmount : 0;
            //string statusMsg = "";
            //if (mustPay == 0) statusMsg = "هنرجو بی‌حساب است.";
            //else
             //   statusMsg = "هنرجو " + UtilityTxt.ToFarsiCurrency(Math.Abs(mustPay).ToString()) + " " + (mustPay > 0 ? "بدهکار" : "طلبکار") + " است.";
            //lblMustPay.Text = statusMsg;

            if (status.MustPayToTeacherAmount < 0)
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

        private void txtTeacherName_TextAccepted(object sender, EventArgs e)
        {
            if (!setting) datagridSection.RefreshDataGrid();
        }

        private void txtClassName_TextAccepted(object sender, EventArgs e)
        {
            if (!setting) datagridSection.RefreshDataGrid();
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
        private void btnSetBalance_Clicked(object sender, EventArgs e)
        {
            if (!txtClassID.Accepted || !txtTeacherID.Accepted) return;
            int classID = UtilityTxt.GetInt(txtClassID.Text);
            //string studentID = txtTeacherID.Text;
            ClassBO cls = ClassBO.Find(classID);
            if (cls == null)
            {
                MessageBoxEx.Show("کلاس نامعتبر است.");
                return;
            }
            try
            {
                SetMsg("در حال به‌روز رسانی...");
                if (!cls.SetTeacherBalance(chkIsBalancedWithTeacher.Checked))
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInUpdating());
                }
                else
                {
                    Program.SetStatus(MessageCreator.Updated("اطلاعات تسویه حساب " + cls.ClassName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
            if (chkIsBalancedWithTeacher.Checked)
                SetMsg("تسویه حساب شد.", 1000);
            else 
                SetMsg("تسویه حساب لغو شد.", 1000);
            datagridSection.RefreshDataGrid();
        }

        private IncomeTeacherBO GetGUIIncomeTeacher()
        {
            IncomeTeacherBO guiItem = new IncomeTeacherBO();
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
            IBusinessObject item = GetGUIIncomeTeacher();

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
                    Program.SetStatus(MessageCreator.Added("مشخصات یک دریافت "));
                    GotoAddMode();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات یک دریافت "));
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
        public void Set(ClassBO cls, TeacherBO teacher)
        {
            setting = true;
            if (cls != null)
            {
                txtClassID.Text = cls.ClassID.ToString();
                txtClassName.Text = cls.ClassName;
            }
            if (teacher != null)
            {
                txtTeacherID.Text = teacher.TeacherID;
                txtTeacherName.Text = teacher.FullName;
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
