using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tools;
using Hengam.Tools.DbSynch;
using BusinessObjectNamespace;
using FarsiMessageBox;
using System.Data.SqlClient;
using DataGridFiller;
using DatabaseSchemaNamespace;


namespace Hengam.Forms
{
    public partial class frmInternetUpdater : HengamWidgets.FormBaseTableEditor
    {
        public frmInternetUpdater()
        {
            InitializeComponent();
        }

        private void AcitonUpdateServer(object sender, EventArgs e)
        {
            SynchDb();
        }

        private bool SynchDb()
        {
            string dateFrom = null;
            string dateTo = null;

            if (txtDateFrom.Accepted) dateFrom = txtDateFrom.Text;
            if (txtDateFrom.Accepted) dateTo = txtDateTo.Text;

            List<DatabaseSynchBO> dbProfiles = DatabaseSynchBO.List(null, "WebSite");
            DatabaseSynchBO dbProfile = null;
            
            if (dbProfiles.Count > 0 )
                dbProfile = dbProfiles[0];

            if (dbProfile == null)
            {
                MessageBoxEx.Show("هیچ سروری برای به روزرسانی وجود ندارد.");
                return false; ;
            }


            Syncher syncher = new Syncher();
            syncher.SourceConnectionString = DataAccessNamespace.DataAccess.connectionString;
            syncher.DateFrom = dateFrom;
            syncher.DateTo = dateTo;

            bool res = false;
            SqlConnection connection = new SqlConnection(dbProfile.HerDbAddress);
            try
            {
                connection.Open();
                res = syncher.Synch(connection);
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Number.ToString() + ",\n" + sqlEx.Message);
            }
            finally
            {
                connection.Close();
            }
            return res;
            
            
        }

        private void frmInternetUpdater_LoadForm(object sender, EventArgs e)
        {
            AddButton("به‌روز رسانی", "Update", "به‌روز رسانی اطلاعات اینترنت", AcitonUpdateServer, StandardWidgets.CoolBaseFormReport.ButtonShowMode.ShowInEditMode, true);
            txtDateFrom.Text = FaDate.CurrentFaDateString;
            txtDateTo.Text = FaDate.CurrentFaDateString;


            dataGridSection.RefreshDataGrid();
            GotoUpdateMode();
        }

        private void dataGridSection_OnLoadDataGrid(object sender, EventArgs e)
        {
            DataGridFiller<DatabaseSynchBO>.FillDataGrid(dataGridSection, DatabaseSynchBO.List(), new List<DatabaseSchemaNamespace.ColumnDefinition>
            {
                DatabaseSchema.DatabaseSynch.TargetDeviceNameFarsi,
                DatabaseSchema.DatabaseSynch.HerDbAddress
            });
        }
    }
}
