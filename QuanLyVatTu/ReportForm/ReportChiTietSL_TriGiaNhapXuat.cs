using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyVatTu
{
    public partial class ReportChiTietSL_TriGiaNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportChiTietSL_TriGiaNhapXuat(int role, int loaiPhieu, DateTime tn, DateTime dn)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectionString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = role;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = loaiPhieu;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = tn;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = dn;
            this.sqlDataSource1.Fill();
        }

    }
}
