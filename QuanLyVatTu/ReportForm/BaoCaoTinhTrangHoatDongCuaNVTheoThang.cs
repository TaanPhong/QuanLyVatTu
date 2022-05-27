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
    public partial class FormBaoCaoTinhTrangHoatDongCuaNVTheoThang : Form
    {
        public FormBaoCaoTinhTrangHoatDongCuaNVTheoThang()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void BaoCaoTinhTrangHoatDongCuaNVTheoThang_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.HoTenNV' table. You can move, or remove it, as needed.
            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.hoTenNVTableAdapter.Fill(this.dS.HoTenNV);
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            cbbLoaiPhieu.SelectedIndex = 0;
            deTN.EditValue = DateTime.Now;
            deDN.EditValue = DateTime.Now;

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hOTENComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbHoTenNV.SelectedValue != null)
                    teMANV.Text = cbbHoTenNV.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy mã nhân viên " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXemTruoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int manv = int.Parse(teMANV.Text);
                int vitri = bdsNV.Find("MANV", manv);
                string dc = ((DataRowView)bdsNV[bdsNV.Position])["DIACHI"].ToString();
                DateTime ngs = (DateTime)((DataRowView)bdsNV[bdsNV.Position])["NGAYSINH"];
                string luong = ((DataRowView)bdsNV[bdsNV.Position])["LUONG"].ToString();
                string hoTen = ((DataRowView)bdsHoTen[cbbHoTenNV.SelectedIndex])["HOTEN"].ToString();
                DateTime tn = deTN.DateTime;
                DateTime dn = deDN.DateTime;
                ReportHoatDongCua1NhanVien report = new ReportHoatDongCua1NhanVien(cbbLoaiPhieu.SelectedIndex, manv, tn, dn);
                report.lbMANV.Text = "Mã Nhân Viên: " + teMANV.Text;
                report.lbHoTen.Text = "Họ Và Tên: " + hoTen;
                report.lbDiaChi.Text = "Địa Chỉ: " + dc;
                report.lbNgaySinh.Text = "Ngày Sinh: " + ngs.ToString("dd-MM-yyyy");
                report.lbLuong.Text = "Lương: " + luong;
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
            }
            catch(Exception)
            {
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
