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
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // bắt sự kiện người dùng bấm 2 lần vào 1 form.
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        public void HienThiMenu()
        {
            MANV.Text = "Mã Nhân Viên: " + Program.userName;
            HoTen.Text = "Họ và tên: " + Program.nameNV;
            NHOM.Text = "Nhóm: " + Program.role;
            // Phân quyền
            if(Program.role == "CONGTY")
            {
                bntLapPhieu.Enabled = false;             
            }
            else if (Program.role == "CHINHANH")
            {
                bntLapPhieu.Enabled = true;
            }  
            else
            {
                bntLapPhieu.Enabled = true;
            }    
        }

        public void enabledBnt()
        {
            bntDangNhap.Enabled = false;
            bntDangXuat.Enabled = true;
            bntTaoTK.Enabled = true;
            pageNhanVien.Visible = pageBaoCao.Visible = true;
            if (Program.role == "USER")
                bntTaoTK.Enabled = false;
        }

        private void bnt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormInDanhSanhNhanVien));
            if (f != null)
                f.Activate();
            else
            {
                FormInDanhSanhNhanVien form = new FormInDanhSanhNhanVien();
                form.MdiParent = this;
                form.Show();
            }    
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void bntDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormDn));
            if (f != null)
                f.Activate();
            else
            {
                FormDn form = new FormDn();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void bntThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        // Dispose đóng form con, thu gon rác
        private void bntDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Dispose();
            } 
            Program.formMain.MANV.Text = "Mã Nhân Viên";
            Program.formMain.HoTen.Text = "Họ Và Tên";
            Program.formMain.NHOM.Text = "Nhóm";
            Program.formMain.bntDangNhap.Enabled = true;
        }

        private void bntTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormTaoLogin));
            if (f != null)
                f.Activate();
            else
            {
                Form from = new FormTaoLogin();
                from.MdiParent = this;
                from.Show();
            }
        }

        private void bntNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormNhanVien));
            if (f != null)
                f.Activate();
            else
            { 
                Form from = new FormNhanVien();
                from.MdiParent = this;
                from.Show(); 
            }
        }

        private void bntKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormKho));
            if (f != null)
                f.Activate();
            else
            {
                Form form = new FormKho();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void bntLapPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void bntVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormVatTu));
            if (f != null)
                f.Activate();
            else
            {
                Form form = new FormVatTu();
                form.MdiParent = this;
                form.Show();
            }    
        }

        private void btnPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormPhieuNhap));
            if (f != null)
                f.Activate();
            else
            {
                Form form = new FormPhieuNhap();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormDatHang));
            if (f != null)
                f.Activate();
            else
            {
                Form form = new FormDatHang();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormPhieuXuat));
            if (f != null)
                f.Activate();
            else
            {
                Form form = new FormPhieuXuat();
                form.MdiParent = this;
                form.Show();
            }
        }


        private void bntCTPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormInBangKeChiTietSL_TriGiaNhapXuat));
            if (f != null)
                f.Activate();
            else
            {
                Form form = new FormInBangKeChiTietSL_TriGiaNhapXuat();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void bntHDNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormBaoCaoTinhTrangHoatDongCuaNVTheoThang));
            if (f != null)
                f.Activate();
            else
            {
                Form form = new FormBaoCaoTinhTrangHoatDongCuaNVTheoThang();
                form.MdiParent = this;
                form.Show();
            }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(ReportForm.BaoCaoDonHangThieuPN));
            if (form != null) form.Activate();
            else
            {
                Form form1 = new ReportForm.BaoCaoDonHangThieuPN();
                form1.MdiParent = this;
                form1.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(ReportForm.BaoCaoVatuTu));
            if (form != null) form.Activate();
            else
            {
                Form report = new ReportForm.BaoCaoVatuTu();
                report.MdiParent = this;
                report.Show();
            }
        }
    }
}
