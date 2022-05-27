using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyVatTu
{
    public partial class ReportHoatDongCua1NhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHoatDongCua1NhanVien(int loaiPhieu, int maNV, DateTime tn, DateTime dn)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectionString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = loaiPhieu;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = maNV;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = tn;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = dn;
            this.sqlDataSource1.Fill();
        }

    }
}
