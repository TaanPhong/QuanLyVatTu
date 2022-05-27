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

namespace QuanLyVatTu
{
    public partial class FormInBangKeChiTietSL_TriGiaNhapXuat : Form
    {
        public FormInBangKeChiTietSL_TriGiaNhapXuat()
        {
            InitializeComponent();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FormInBangKeChiTietSL_TriGiaNhapXuat_Load(object sender, EventArgs e)
        {
            this.cbbLoaiPhieu.SelectedIndex = 0;
            this.deTN.EditValue = DateTime.Now;
            this.deDN.EditValue = DateTime.Now;
        }

        private void btnXemTruoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int loaiPhieu = cbbLoaiPhieu.SelectedIndex;
                int role = 1;
                if (Program.role == "CHINHANH")
                    role = 0;
                DateTime tn = deTN.DateTime;
                DateTime dn = deDN.DateTime;
                ReportChiTietSL_TriGiaNhapXuat report = new ReportChiTietSL_TriGiaNhapXuat(role, loaiPhieu, tn, dn);
                if(cbbLoaiPhieu.SelectedIndex == 0)
                {
                    report.lbLP.Text = "Loại Phiếu: Phiếu Nhập";
                    report.lbTieuDe.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ " + "PHIẾU NHẬP";
                }
                else
                {
                    report.lbTieuDe.Text = "BẢNG KÊ CHI TIẾT SỐ LƯỢNG - TRỊ GIÁ " + "PHIẾU XUẤT";
                    report.lbLP.Text = "Loại Phiếu: Phiếu Xuất";
                }
                //    report.lbLP.Text = "Loại Phiếu: Phiếu Xuất";
                report.lbTN.Text ="Từ ngày: " + tn.ToString("dd-MM-yyyy");
                report.lbDN.Text ="Đến ngày: " + dn.ToString("dd-MM-yyyy");
                
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi xem báo trước báo cáo " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
