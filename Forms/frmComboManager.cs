using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using DataGridFiller;
using DatabaseSchemaNamespace;
using ComboManager;
using Hengam.Tools;
using Tools;
using FarsiMessageBox;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmComboManager : HengamWidgets.FormBaseTableEditor
    {
        public frmComboManager()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            Literal item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Added("مشخصات گزینه "));
                    GotoAddMode();
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات این گزینه "));
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
            dataGridSection.RefreshDataGrid();
        }

        private void ActionUpdate(object sender, EventArgs e)
        {
            Literal item = GetGUI();
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
                    Program.SetStatus(MessageCreator.Updated("مشخصات یک گزینه "));
                    GotoAddMode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            HideMsg();
            dataGridSection.RefreshDataGrid();
        }

        private void ActionDelete(object seneder, EventArgs e)
        {
            Literal item = GetGUIKey();
            if (item == null) return;
            if (MessageBoxEx.Show(MessageCreator.SureToRemove("مشخصات یک گزینه " ), "", "حذف  گزینه", true) == DialogResult.OK)
            {
                try
                {
                    SetMsg("در حال حذف کارمند...");
                    if (!item.Delete())
                        MessageBoxEx.Show(MessageCreator.ErrorInRemoving());
                    else
                    {
                        Program.SetStatus(MessageCreator.Removed("مشخصات این گزینه "));
                        GotoAddMode();
                    }
                }
                catch (System.Data.SqlClient.SqlException se)
                {
                    switch (se.Number)
                    {
                        case 547:
                            MessageBoxEx.Show("شما قادر به حذف این  گزینه نیستید. قبل از حذف باید تمامی اطلاعات این  گزینه از سیستم حذف شود.");
                            break;

                        default:
                            MessageBox.Show("Error " + se.Number.ToString() + ",\n" + se.Message);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                HideMsg();
                dataGridSection.RefreshDataGrid();
            }
        }

        private void ActionCancel(object sender, EventArgs e)
        {
            GotoAddMode();
        }

        public class LitKind: IComboFillable
        {
            public string FarsiName;
            public string TableName;
            public ColumnDefinition ID;
            public ColumnDefinition Name;
            public ColumnDefinition Desc;

            public LitKind(string FarsiTableName, string Table, ColumnDefinition ColID, ColumnDefinition ColName, ColumnDefinition ColDesc)
            {
                TableName = Table;
                ID = ColID;
                Name = ColName;
                Desc = ColDesc;
                FarsiName = FarsiTableName;
            }

            public override string ToString()
            {
                return FarsiName;
            }

            #region IComboFillable Members

            public string ComboDescription
            {
                get { return FarsiName; }
            }

            public string ComboText
            {
                get { return FarsiName; }
            }

            #endregion
        }

        private List<LitKind> litKinds = new List<LitKind>();

        private void AddLitKind(LitKind lit)
        {
            litKinds.Add(lit);
        }

        public void SetLiteral(string litTableName, ColumnDefinition litName, ColumnDefinition litID, ColumnDefinition litDesc)
        {
            this.Text = "تنظیم رشته‌های پیش‌فرض";
            lblLiteralID.Text = litID.Caption + ":";
            lblLiteralName.Text = litName.Caption + ":";
            groupItemDetails.Text = "تنظیمات پیش‌فرض برای " + litName.Caption;
            if (litDesc == null)
            {
                lblLiteralDescription.Visible = txtLiteralDescription.Visible = false;
            }
            else
            {
                lblLiteralDescription.Visible = txtLiteralDescription.Visible = true;
                lblLiteralDescription.Text = litDesc.Caption + ":";
            }
            Literal.SetLiteral(litTableName, litName, litID, litDesc);

            dataGridSection.RefreshDataGrid();            
        }

        public void SetLiteral(string litTableName, ColumnDefinition litName, ColumnDefinition litID)
        {
            SetLiteral(litTableName, litName, litID, null);
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            //if (Literal.HasDescription)
            //{
            //    DataGridFiller<Literal>.FillDataGrid(dataGridSection, Literal.List(), new List<DatabaseSchemaNamespace.ColumnDefinition>
            //    {
            //        DatabaseSchema.Literal.LiteralID,
            //        DatabaseSchema.Literal.LiteralName,
            //        DatabaseSchema.Literal.LiteralDescription
            //    });
            //}
            //else
            //{
            //    DataGridFiller<Literal>.FillDataGrid(dataGridSection, Literal.List(), new List<DatabaseSchemaNamespace.ColumnDefinition>
            //    {
            //        DatabaseSchema.Literal.LiteralID,
            //        DatabaseSchema.Literal.LiteralName
            //    });
            //}
            if (Literal.HasDescription)
            {
                DataGridFiller<Literal>.FillDataGrid(dataGridSection, Literal.List(), new List<DatabaseSchemaNamespace.ColumnDefinition>
                {
                    Literal.LiteralIDCol,
                    Literal.LiteralNameCol,
                    Literal.LiteralDescriptionCol
                });
            }
            else
            {
                DataGridFiller<Literal>.FillDataGrid(dataGridSection, Literal.List(), new List<DatabaseSchemaNamespace.ColumnDefinition>
                {
                    Literal.LiteralIDCol,
                    Literal.LiteralNameCol,
                });
            }
        }

        private void frmComboManager_LoadForm(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی...");
            AddButton("اضافه کردن", "Add", "اضافه کردن گزینه جدید", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);
            AddButton("ثبت", "Update", "اعمال تغییرات انجام شده در سیستم", ActionUpdate, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("حذف", "Delete", "حذف گزینه انتخاب شده از سیستم", ActionDelete, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            AddButton("انصراف", "Cancel", "انصراف از تغییر و بازگشت به حالت اضافه کردن", ActionCancel, CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);

            AddLitKind(new LitKind("سطح تحصیلات",
                DatabaseSchema.DegreeLevel.TableName,
                DatabaseSchema.DegreeLevel.DegreeLevelID,
                DatabaseSchema.DegreeLevel.DegreeLevelName,
                DatabaseSchema.DegreeLevel.DegreeLevelDescription));

            AddLitKind(new LitKind("نوع مدرک",
                DatabaseSchema.DegreeType.TableName,
                DatabaseSchema.DegreeType.DegreeTypeID,
                DatabaseSchema.DegreeType.DegreeTypeName,
                DatabaseSchema.DegreeType.DegreeTypeDescription));

            AddLitKind(new LitKind("نحوه‌ی پرداخت",
                DatabaseSchema.PayType.TableName,
                DatabaseSchema.PayType.PayTypeID,
                DatabaseSchema.PayType.PayTypeName,
                DatabaseSchema.PayType.PayTypeDescription));

            AddLitKind(new LitKind("منطقه",
                DatabaseSchema.Area.TableName,
                DatabaseSchema.Area.AreaID,
                DatabaseSchema.Area.AreaName,
                DatabaseSchema.Area.AreaDescription));

            AddLitKind(new LitKind("نحوه‌ی آشنایی",
                DatabaseSchema.HowtoFind.TableName,
                DatabaseSchema.HowtoFind.HowtoFindID,
                DatabaseSchema.HowtoFind.HowtoFindName,
                DatabaseSchema.HowtoFind.HowtoFindDescription));

            AddLitKind(new LitKind("نوع هزینه",
                DatabaseSchema.OutcomeTypicalType.TableName,
                DatabaseSchema.OutcomeTypicalType.OutcomeTypicalTypeID,
                DatabaseSchema.OutcomeTypicalType.OutcomeTypicalTypeName,
                DatabaseSchema.OutcomeTypicalType.OutcomeTypicalTypeDescription));

            AddLitKind(new LitKind("نوع درآمد",
                DatabaseSchema.IncomeTypicalType.TableName,
                DatabaseSchema.IncomeTypicalType.IncomeTypicalTypeID,
                DatabaseSchema.IncomeTypicalType.IncomeTypicalTypeName,
                DatabaseSchema.IncomeTypicalType.IncomeTypicalTypeDescription));

            AddLitKind(new LitKind("نوع کالا",
                DatabaseSchema.StuffType.TableName,
                DatabaseSchema.StuffType.StuffTypeID,
                DatabaseSchema.StuffType.StuffTypeName,
                DatabaseSchema.StuffType.StuffTypeDescription));

            AddLitKind(new LitKind("رشته",
                DatabaseSchema.Major.TableName,
                DatabaseSchema.Major.MajorID,
                DatabaseSchema.Major.MajorName,
                DatabaseSchema.Major.MajorDescription));
            
            ComboFiller<LitKind>.FillCombo(cboLiteralType, litKinds);

            HideMsg();
        }

        private void cboLiteralType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLiteralType.SelectedItem == null)
            {
            }
            else
            {
                LitKind lit = ComboFiller<LitKind>.GetFromCombo(cboLiteralType);
                SetLiteral(lit.TableName, lit.Name, lit.ID, lit.Desc);
            }
        }

        Literal guiItem = new Literal();
        private Literal GetGUI()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtLiteralID.Accepted)
                    err.Add("کد");
                else
                    guiItem.LiteralID = UtilityTxt.GetInt(txtLiteralID.Text);

                if (!txtLiteralName.Accepted)
                    err.Add("نام");
                else
                    guiItem.LiteralName = UtilityTxt.GetString(txtLiteralName.Text);

                if (!txtLiteralDescription.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItem.LiteralDescription = UtilityTxt.GetString(txtLiteralDescription.Text);
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
        private Literal GetGUIKey()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtLiteralID.Accepted)
                    err.Add("کد");
                else
                    guiItem.LiteralID = UtilityTxt.GetInt(txtLiteralID.Text);
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
        private void SetGUI(Literal guiItem)
        {
            this.guiItem = guiItem;
            txtLiteralID.Text = UtilityTxt.GetString(guiItem.LiteralID);

            txtLiteralName.Text = guiItem.LiteralName;

            txtLiteralDescription.Text = guiItem.LiteralDescription;

        }
        private new void GotoAddMode()
        {
            base.GotoAddMode();
            guiItem = new Literal();
            txtLiteralID.Text = "";
            txtLiteralName.Text = "";
            txtLiteralDescription.Text = "";
        }
        private new void GotoUpdateMode()
        {
            base.GotoUpdateMode();

        }

        private void dataGridSection_RowDoubleClick(StandardWidgets.CoolDataGrid.RowSelectionEventArgs e)
        {
            Literal lit = (Literal)(e.Row.Tag);
            SetGUI(lit);
            GotoUpdateMode();
        }
    }
}
