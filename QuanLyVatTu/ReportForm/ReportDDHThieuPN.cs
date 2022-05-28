using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyVatTu.ReportForm
{
    public partial class ReportDDHThieuPN : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDDHThieuPN()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectionString;
            this.sqlDataSource1.Fill();
        }

    }
}
