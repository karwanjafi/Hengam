﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessObjectNamespace;
using DataGridFiller;
using DatabaseSchemaNamespace;
using Hengam.Forms.ItemPickers;
using Tools;
using Hengam.Tools;
using Hengam.ComboManager;
using FarsiMessageBox;
using StandardWidgets;

namespace Hengam.Forms.Store
{
    public partial class frmShopSellItem : HengamWidgets.FormBaseTableEditor
    {
        public frmShopSellItem()
        {
            InitializeComponent();
        }

        private void ActionAdd(object sender, EventArgs e)
        {
            StoreShopBO shop = GetGUIShop();
            if (shop == null) return;

            IncomeStoreSellBO income = GetGUIPay();
            if (income == null) return;

            try
            {
                SetMsg("در حال ثبت اطلاعات فروش");
                if (shop.Add() && income.Add())
                {
                    Program.SetStatus(MessageCreator.Added("مشخصات فروش کالا "));
                    GotoAddMode();
                }
                else
                {
                    MessageBoxEx.Show(MessageCreator.ErrorInAdding());
                }
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                switch (se.Number)
                {
                    case 2627:
                        MessageBoxEx.Show(MessageCreator.IsDuplicate("مشخصات کالا "));
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

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            string filterDate = null;
            if (txtFilterDate.Accepted) filterDate = txtFilterDate.Text;
            DataGridFiller<ViwShopSalesPersonBO>.FillDataGrid(dataGridSection, ViwShopSalesPersonBO.List(null, null, null, filterDate, true, null, null, null, null, null, null),
                new List<DatabaseSchemaNamespace.ColumnDefinition>
            {
                DatabaseSchema.ViwShopSalesPerson.CustomerName,
                DatabaseSchema.ViwShopSalesPerson.StuffName,
                DatabaseSchema.ViwShopSalesPerson.ShopCount,
                DatabaseSchema.ViwShopSalesPerson.PaidAmount,
                DatabaseSchema.ViwShopSalesPerson.ShopDate
            });
        }

        private void frmShopSellItem_LoadForm(object sender, EventArgs e)
        {
            SetMsg("در حال بازیابی اطلاعات...");
            AddButton("فروش", "Add", "ثبت اطلاعات فروش کالا", ActionAdd, CoolBaseFormReport.ButtonShowMode.ShowInAddMode, true);

            frmStuffPicker fStuffPicker = new frmStuffPicker();
            floaterStuffPicker.LoadPanel(fStuffPicker);
            fStuffPicker.HookTo(txtStuffID, txtStuffName);

            frmStudentPicker fStudentPicker = new frmStudentPicker();
            floaterStudentPicker.LoadPanel(fStudentPicker);
            fStudentPicker.HookTo(txtCustomerID, txtStudentName);

            ComboFiller<PayTypeBO>.FillCombo(cboPayTypeID, PayTypeBO.List());

            txtFilterDate.Text = FaDate.CurrentFaDateString;
            dataGridSection.RefreshDataGrid();
            GotoAddMode();
            HideMsg();
        }

        private void txtStuffName_Click(object sender, EventArgs e)
        {
            floaterStuffPicker.Show();
        }

        private void txtStuffID_TextAccepted(object sender, EventArgs e)
        {
            SetPrice();
            txtShopID.Text = StoreShopBO.GenerateKey(txtStuffID.Text);
        }

        private void SetPrice()
        {
            if (FormState == FormEditingState.Adding)
            {
                if (!txtDiscount.Accepted || !txtStuffID.Accepted || !txtShopCount.Accepted)
                {
                    txtFee.Text = "";
                    return;
                }
                int discount = 0;
                int count = 1;
                string stuffID = "";

                stuffID = txtStuffID.Text;
                int unitPrice = StoreStuffBO.Find(stuffID).StuffPrice; ;

                discount = UtilityTxt.GetInt(txtDiscount.Text);

                count = UtilityTxt.GetInt(txtShopCount.Text);

                txtFee.Text = (unitPrice * count - discount).ToString();
            }
        }

        private void txtShopCount_TextAccepted(object sender, EventArgs e)
        {
            SetPrice();
        }

        private void txtDiscount_TextAccepted(object sender, EventArgs e)
        {
            SetPrice();
        }

        private void chkMiscCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMiscCustomer.Checked == true)
                SetCustomerUnknown();
            else
                SetCustomerStudent();
        }

        private void SetCustomerUnknown()
        {
            txtStudentName.Enabled = false;
            txtCustomerName.Enabled = true;
        }

        private void SetCustomerStudent()
        {
            txtCustomerName.Enabled = false;
            txtStudentName.Enabled = true;
        }




        void DoNothing()
        {
        }

        StoreShopBO guiItemShop = new StoreShopBO();
        private StoreShopBO GetGUIShop()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtShopID.Accepted)
                    err.Add("کد فروش");
                else
                    guiItemShop.ShopID = UtilityTxt.GetString(txtShopID.Text);

                if (!txtStuffID.Accepted)
                    err.Add("نام کالا");
                else
                    guiItemShop.StuffID = UtilityTxt.GetString(txtStuffID.Text);


                switch (chkMiscCustomer.Checked)
                {

                    case false:
                        if (!txtCustomerID.Accepted)
                            err.Add("نام مشتری");
                        else
                            guiItemShop.CustomerID = UtilityTxt.GetString(txtCustomerID.Text);
                        guiItemShop.CustomerName = null;
                        break;
                    default:
                        if (!txtCustomerName.Accepted)
                            err.Add("نام خریدار");
                        else
                            guiItemShop.CustomerName = UtilityTxt.GetString(txtCustomerName.Text);
                        guiItemShop.CustomerID = null;
                        break;
                }

                if (!txtShopCount.Accepted)
                    err.Add("تعداد");
                else
                    guiItemShop.ShopCount = UtilityTxt.GetInt(txtShopCount.Text);

                if (!txtShopDescription.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItemShop.ShopDescription = UtilityTxt.GetString(txtShopDescription.Text);

                if (!txtShopDate.Accepted)
                    err.Add("تاریخ فروش");
                else
                    guiItemShop.ShopDate = UtilityTxt.GetString(txtShopDate.Text);


                guiItemShop.ActivityStatus = true;
                guiItemShop.IsManagerAware = false;

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
            return guiItemShop;
        }
        private StoreShopBO GetGUIKeyShop()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtShopID.Accepted)
                    err.Add("کد فروش");
                else
                    guiItemShop.ShopID = UtilityTxt.GetString(txtShopID.Text);

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
            return guiItemShop;
        }
        private void SetGUIShop(StoreShopBO guiItem)
        {
            this.guiItemShop = guiItem;

            txtShopID.Text = guiItem.ShopID;

            txtStuffID.Text = guiItem.StuffID;

            txtCustomerID.Text = guiItem.CustomerID;

            txtCustomerName.Text = guiItem.CustomerName;

            txtShopCount.Text = UtilityTxt.GetString(guiItem.ShopCount);

            txtShopDescription.Text = guiItem.ShopDescription;

            txtShopDate.Text = guiItem.ShopDate;

        }




        public override void GotoAddMode()
        {
            base.GotoAddMode();
            guiItemPay = new IncomeStoreSellBO();
            guiItemShop = new StoreShopBO();

            txtShopID.Text = "";
            txtStuffID.Text = "";
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtShopCount.Text = "1";
            txtShopDescription.Text = "";

            string curDate = FaDate.CurrentFaDateString;
            txtShopDate.Text = curDate;
            txtPayDate.Text = curDate;


            txtShopID.Text = "";
            txtFee.Text = "";
            txtDiscount.Text = "0";
            cboPayTypeID.SelectedItem = null;
            txtDescription.Text = "";
            txtCheckNumber.Text = "";

            //EditingState = FormState.Adding;
        }
        public override void GotoUpdateMode()
        {
            base.GotoUpdateMode();
            txtShopID.Enabled = false;

            //EditingState = FormState.Updating;
        }



        IncomeStoreSellBO guiItemPay = new IncomeStoreSellBO();
        private IncomeStoreSellBO GetGUIPay()
        {
            ErrorCollector err = new ErrorCollector();
            try
            {
                if (!txtShopID.Accepted)
                    err.Add("کد خرید");
                else
                    guiItemPay.ShopID = UtilityTxt.GetString(txtShopID.Text);

                if (!txtFee.Accepted)
                    err.Add("ملبغ");
                else
                    guiItemPay.Fee = UtilityTxt.GetInt(txtFee.Text);

                if (!txtDiscount.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItemPay.Discount = UtilityTxt.GetInt(txtDiscount.Text);

                if (!txtPayDate.Accepted)
                    err.Add("تاریخ پرداخت");
                else
                    guiItemPay.PayDate = UtilityTxt.GetString(txtPayDate.Text);

                if (!cboPayTypeID.Accepted)
                    err.Add("نحوه‌ی پرداخت");
                else
                    guiItemPay.PayTypeID = ComboFiller<PayTypeBO>.GetFromCombo(cboPayTypeID).PayTypeID;

                if (!txtCheckDate.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItemPay.CheckDate = UtilityTxt.GetString(txtCheckDate.Text);

                if (!txtDescription.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItemPay.Description = UtilityTxt.GetString(txtDescription.Text);

                if (!txtCheckNumber.Accepted)
                    DoNothing();//Do Nothing...
                else
                    guiItemPay.CheckNumber = UtilityTxt.GetString(txtCheckNumber.Text);

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
            return guiItemPay;
        }
        //private IncomeStoreSellBO GetGUIKeyPay()
        //{
        //    ErrorCollector err = new ErrorCollector();
        //    try
        //    {
        //        if (!txtPayID.Accepted)
        //            err.Add("کد پرداخت");
        //        else
        //            guiItem.PayID = UtilityTxt.GetString(txtPayID.Text);

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    if (err.HasError)
        //    {
        //        err.ShowErrMsg();
        //        return null;
        //    }
        //    return guiItem;
        //}
        private void SetGUIPay(IncomeStoreSellBO guiItem)
        {
            //txtPayID.Text = guiItem.PayID;
            this.guiItemPay = guiItem;

            txtShopID.Text = guiItem.ShopID;

            txtFee.Text = UtilityTxt.GetString(guiItem.Fee);

            txtDiscount.Text = UtilityTxt.GetString(guiItem.Discount);

            txtPayDate.Text = guiItem.PayDate;

            ComboFiller<PayTypeBO>.SetCombo(cboPayTypeID, Utility.GetObject<PayTypeBO>(guiItem.PayTypeID));

            txtCheckDate.Text = guiItem.CheckDate;

            txtDescription.Text = guiItem.Description;

            txtCheckNumber.Text = guiItem.CheckNumber;

        }

        private void txtShopDate_TextAccepted(object sender, EventArgs e)
        {
            txtPayDate.Text = txtShopDate.Text;
        }

        private void txtFilterDate_TextAccepted(object sender, EventArgs e)
        {
            dataGridSection.RefreshDataGrid();
        }

        private void txtStudentName_Click(object sender, EventArgs e)
        {
            floaterStudentPicker.Show();
        }

    }
}
