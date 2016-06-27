using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StandardWidgets;

namespace Hengam.Forms
{
    public partial class frmReportViewer : HengamWidgets.FormBaseSimple, IFloatable
    {
        public frmReportViewer(object reportSource, string caption)
        {
            InitializeComponent();

            crystalReportViewer.ReportSource = reportSource;
            this.Text = caption;
        }

        private void crystalReportViewer_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            crystalReportViewer.Refresh();
            e.Handled = true;
        }

        public void Set(object reportSource, string caption)
        {
            Set(reportSource);
            this.Text = caption;
        }

        public void Set(object reportSource)
        {
            crystalReportViewer.ReportSource = reportSource;
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
