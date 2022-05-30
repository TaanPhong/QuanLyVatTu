using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
namespace QuanLyVatTu.ReportForm
{
    public partial class BaoCaoDonHangThieuPN : Form
    {
        public BaoCaoDonHangThieuPN()
        {
            InitializeComponent();
        }

        private void BaoCaoDonHangThieuPN_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.sp_DonHangThieuPhieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.sp_DonHangThieuPhieuNhapTableAdapter.Fill(this.dS.sp_DonHangThieuPhieuNhap);
            cbbChiNhanh.DataSource = Program.bindingSource;
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CN;
            cbbChiNhanh.Enabled = false;
            if (Program.role == "CONGTY")
                cbbChiNhanh.Enabled = true;
        }

        private void btnXemTruoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ReportDDHThieuPN report = new ReportDDHThieuPN();
                ReportPrintTool print = new ReportPrintTool(report);
                print.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem báo cáo" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.serverName = cbbChiNhanh.SelectedValue.ToString();
            if (Program.CN != cbbChiNhanh.SelectedIndex)
            {
                Program.loginName = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.loginName = Program.loginDN;
                Program.password = Program.passworDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới!", "", MessageBoxButtons.OK);
            else
            {
                this.sp_DonHangThieuPhieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.sp_DonHangThieuPhieuNhapTableAdapter.Fill(this.dS.sp_DonHangThieuPhieuNhap);
            }
        }

    }
}
