using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyVatTu
{
    public partial class ReportInDanhSanhNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportInDanhSanhNhanVien()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectionString;
            this.sqlDataSource1.Fill();
        }

    }
}
