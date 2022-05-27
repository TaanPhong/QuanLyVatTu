using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace QuanLyVatTu
{
    public partial class FormPhieuXuat : Form
    {
        int viTri = 0;
        bool dangThemPX = false;
        bool dangThemCTPX = false;
        string cauTruyVan = "";
        DateTime ngay;
        string hoTenKH = "";
        string maKho = "";
        string manv = "";
        Stack phucHoiList = new Stack();
        public FormPhieuXuat()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPX.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.HoTenNV' table. You can move, or remove it, as needed.
            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.hoTenNVTableAdapter.Fill(this.dS.HoTenNV);
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.khoTableAdapter.Fill(this.dS.Kho);
            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            this.cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            cbbChiNhanh.DataSource = Program.bindingSource;
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CN;
            cbbChiNhanh.Enabled = false;
            if (Program.role == "CONGTY")
            {
                cbbChiNhanh.Enabled = true;
                btnHieuChinh.Enabled = btnthem.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnPhucHoi.Enabled = false;
                panelControl3.Enabled = false;
            }
        }

        private void LoadVatTu()
        {
            lkMaVaTu.DataSource = bdsVatTu;
            lkMaVaTu.DisplayMember = "TENVT";
            lkMaVaTu.ValueMember = "MAVT";
        }

        private void hOTENComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbHoTenNV.SelectedValue != null)
                {
                    txtMaNV.Text = cbbHoTenNV.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy mã nhân viên " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cbbTenKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbbTenKho.SelectedValue != null)
                {
                    txtMaKho.Text = cbbTenKho.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy mã kho " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnHieuChinh.Enabled == true)
            {
                try
                {
                    this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối về server " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                if(dangThemPX == true)
                {
                    teMaPX.Text = "";
                    txtHoTenKH.Text = "";
                    deNgay.EditValue = DateTime.Now;
                }
                else
                {
                    deNgay.EditValue = ngay;
                    cbbHoTenNV.SelectedValue = txtMaNV.Text = manv;
                    cbbTenKho.SelectedValue = txtMaKho.Text = maKho;
                    txtHoTenKH.Text = hoTenKH;
                }
            }    
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (btnthem.Enabled == false)
            {
                bdsPX.CancelEdit();
                bdsPX.Position = viTri;
                btnthem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReset.Enabled = btnThoat.Enabled = true;
                btnLuu.Enabled = false;
                gcPX.Enabled = true;
                panelControl2.Enabled = false;
                panelControl3.Enabled = true;
                dangThemPX = false;
                if (phucHoiList.Count == 0)
                    btnPhucHoi.Enabled = false;
                return;
            }
            string cauTruyVan = phucHoiList.Pop().ToString();
            int status = Program.ExecSqlNonQuery(cauTruyVan);
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            if (phucHoiList.Count == 0)
                btnPhucHoi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (bdsPX.Count == 0)
            {
                MessageBox.Show("Không có phiếu xuất nào để xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa Phiếu xuất đã lập chi tiết phiếu xuất!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn thật sự muốn xóa phiếu xuất này?", "Xác Nhận", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                try
                {
                    ngay = (DateTime)((DataRowView)bdsPX[bdsPX.Position])["NGAY"];
                    cauTruyVan = $"insert into PhieuXuat(MAPX, NGAY, HOTENKH, MAKHO, MANV) values('{teMaPX.Text}', '{ngay.ToString("yyyy-MM-dd")}', " +
                        $"N'{txtHoTenKH.Text}', '{txtMaKho.Text}', '{txtMaNV.Text}')";
                    viTri = bdsPX.Position;
                    bdsPX.RemoveCurrent();
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.phieuXuatTableAdapter.Update(this.dS.PhieuXuat);
                    phucHoiList.Push(cauTruyVan);
                    MessageBox.Show("Xóa phiếu xuất thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu xuất " + ex.Message, "", MessageBoxButtons.OK);
                    this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
                    bdsPX.Position = viTri;
                }
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ngay = (DateTime)((DataRowView)bdsPX[bdsPX.Position])["NGAY"];
            hoTenKH = txtHoTenKH.Text;
            maKho = txtMaKho.Text;
            manv = txtMaNV.Text;
            cauTruyVan = $"update PhieuXuat " +
                        $"set NGAY = '{ngay.ToString("yyyy-MM-dd")}', HOTENKH = N'{txtHoTenKH.Text}', MAKHO = '{txtMaKho.Text}', " +
                        $"MANV = {txtMaNV.Text} where MAPX = '{teMaPX.Text}'";
            viTri = bdsPX.Position;
            panelControl2.Enabled = true;
            gcPX.Enabled = false;
            btnHieuChinh.Enabled = btnthem.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            teMaPX.Enabled = false;
            deNgay.Enabled = txtHoTenKH.Enabled = cbbHoTenNV.Enabled = cbbTenKho.Enabled = true;
            cbbMaVT.Enabled = nmSoLuong.Enabled = seDonGia.Enabled = false;
            panelControl3.Enabled = false;
        }
        /*
         * Bước 1: lấy vị trí của con trỏ trên grid view
         * Bước 2: tạo 1 dòng bdsPX;
         * Bước 3: bật tắt các nút lệnh
         */
        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsPX.Position;
            panelControl2.Enabled = true;
            bdsPX.AddNew();
            dangThemPX = true;
            gcPX.Enabled = false;
            btnthem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            panelControl3.Enabled = false;
            gcCTPX.Enabled = false;
            teMaPX.Enabled = deNgay.Enabled = txtHoTenKH.Enabled = cbbHoTenNV.Enabled = cbbTenKho.Enabled = true;
            cbbMaVT.Enabled = nmSoLuong.Enabled = seDonGia.Enabled = false;
            deNgay.EditValue = DateTime.Now;
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.serverName = cbbChiNhanh.SelectedValue.ToString();
            if (cbbChiNhanh.SelectedIndex != Program.CN)
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
                // TODO: This line of code loads data into the 'dS.HoTenNV' table. You can move, or remove it, as needed.
                this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.hoTenNVTableAdapter.Fill(this.dS.HoTenNV);
                // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
                this.khoTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.khoTableAdapter.Fill(this.dS.Kho);
                // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
                this.cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.cTPXTableAdapter.Fill(this.dS.CTPX);
                // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            }
        }

        private void sbtnThem_Click(object sender, EventArgs e)
        {
            string strLenh = "declare @status int "
                              + "exec @status = SP_ChoPhepThemCTPX '"
                              + txtMaKho.Text + "', '"
                              + teMaPX.Text + "' "
                              + "select @status";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int status = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            Console.WriteLine(status);
            Console.WriteLine(teMaPX.Text);
            Console.WriteLine(txtMaKho);
            if(status == 1)
            {
                MessageBox.Show("Không thể thêm chi tiết phiếu xuất vì ở kho có mã " + txtMaKho.Text  +
                    "phiếu xuất " + txtMaPX_CTPX.Text.Trim() + "đã được lập chi tiết phiếu xuất với tất cả vật tư trong kho", "", MessageBoxButtons.OK);
                return;
            }    
            if (teMaPX == null)
                return;
            bdsCTPX.AddNew();
            txtMaPX_CTPX.Text = teMaPX.Text;
            DataTable dt = new DataTable();
            strLenh = "Select * from dbo.F_MAVTKHO('" + txtMaKho.Text + "', '" + teMaPX.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(strLenh, Program.con);
            da.Fill(dt);
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            cbbMaVT.DataSource = bds;
            cbbMaVT.DisplayMember = "MAVT";
            cbbMaVT.ValueMember = "MAVT";
            gcPX.Enabled = false;
            btnHieuChinh.Enabled = btnXoa.Enabled = btnthem.Enabled =
            btnReset.Enabled = btnLuu.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = false;
            panelControl2.Enabled = true;
            sbtnHieuChinh.Enabled = sbtnXoa.Enabled = sbtnThem.Enabled = false;
            sbtnLuu.Enabled = sbtnHoanTac.Enabled = true;
            gcCTPX.Enabled = gcPX.Enabled = false;
            teMaPX.Enabled = deNgay.Enabled = txtHoTenKH.Enabled = cbbHoTenNV.Enabled = cbbTenKho.Enabled = false;
            cbbMaVT.Enabled = nmSoLuong.Enabled = seDonGia.Enabled = true;
            nmSoLuong.Value = 0;
            seDonGia.Value = 0;
        }

        

        private void sbtnXoa_Click(object sender, EventArgs e)
        {
            int vt = bdsCTPX.Position;
            if (bdsCTPX.Count == 0)
            {
                MessageBox.Show("Không có chi tiết phiếu xuất nào để xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn thật sự muốn xóa chi tiết phiếu xuất này?", "Xác Nhận", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                try
                {
                    bdsCTPX.RemoveCurrent();
                    this.cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.cTPXTableAdapter.Update(this.dS.CTPX);
                    MessageBox.Show("Xóa chi tiết phiếu xuất thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết phiếu xuất " + ex.Message, "", MessageBoxButtons.OK);
                    this.cTPXTableAdapter.Fill(this.dS.CTPX);
                    bdsCTPX.Position = vt;
                }
            }
        }

        private void sbtnHieuChinh_Click(object sender, EventArgs e)
        {
            btnHieuChinh.Enabled = btnthem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnReset.Enabled = btnPhucHoi.Enabled = false;
            panelControl2.Enabled = true;
            gcCTPX.Enabled = gcPX.Enabled = false;
            sbtnHieuChinh.Enabled = sbtnThem.Enabled = sbtnXoa.Enabled = false;
            sbtnHoanTac.Enabled = sbtnLuu.Enabled = true;
            teMaPX.Enabled = deNgay.Enabled = txtHoTenKH.Enabled = cbbHoTenNV.Enabled = cbbTenKho.Enabled = false;
            cbbMaVT.Enabled = false;
            nmSoLuong.Enabled = seDonGia.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtHoTenKH.Text == "")
            {
                MessageBox.Show("Không thể để trống họ tên khách hàng!", "", MessageBoxButtons.OK);
                return;
            }
            if (teMaPX.Text == "")
            {
                MessageBox.Show("Không thể để trống mã phiếu nhập!", "", MessageBoxButtons.OK);
                return;
            }
            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Không thể bỏ trống mã kho!", "", MessageBoxButtons.OK);
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Không thể bỏ trống mã nhân viên!", "", MessageBoxButtons.OK);
                return;
            }
            string strLenh = "declare @status int "
                            + "exec @status = SP_KiemTraMaPX '"
                            + teMaPX.Text + "' "
                            + "select @status";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int status = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            if (dangThemPX == true)
            {
                if (status == 1)
                {
                    MessageBox.Show("Không thể lưu vì mã phiếu nhập đã được sử dụng!", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn thật sự muốn thêm phiếu xuất này?", "Xác nhận", MessageBoxButtons.OKCancel)
                        == DialogResult.OK)
                    {
                        try
                        {
                            cauTruyVan = $"delete from PhieuXuat where MAPX = '{teMaPX.Text}'";
                            bdsPX.EndEdit();
                            bdsPX.ResetCurrentItem();
                            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
                            this.phieuXuatTableAdapter.Update(this.dS.PhieuXuat);
                            MessageBox.Show("Thêm phiếu xuất thành công!", "", MessageBoxButtons.OK);
                            phucHoiList.Push(cauTruyVan);
                            dangThemPX = false;
                        }
                        catch (Exception ex)
                        {
                            bdsPX.Position = viTri;
                            MessageBox.Show("Lỗi thêm phiếu xuất " + ex.Message, "", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else
                        return;
                }
            }
            else
            {
                if (MessageBox.Show("Bạn thật sự muốn hiệu chỉnh phiếu xuất này?", "Xác nhận", MessageBoxButtons.OKCancel)
                        == DialogResult.OK)
                {
                    try
                    {
                        bdsPX.EndEdit();
                        bdsPX.ResetCurrentItem();
                        this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.phieuXuatTableAdapter.Update(this.dS.PhieuXuat);
                        MessageBox.Show("Hiệu chỉnh phiếu xuất thành công!", "", MessageBoxButtons.OK);
                        phucHoiList.Push(cauTruyVan);
                        //dangThemPX = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi lưu phiếu xuất " + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                    return;
            }
            gcPX.Enabled = true;
            btnthem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = false;
            panelControl3.Enabled = true;
            gcCTPX.Enabled = true;
            panelControl2.Enabled = false;
        }

        private void sbtnLuu_Click(object sender, EventArgs e)
        {
            if (nmSoLuong.Value == 0)
            {
                MessageBox.Show("Không thể lưu vì số lượng phải lớn hơn không", "", MessageBoxButtons.OK);
                return;
            }
            if (seDonGia.Value == 0)
            {
                MessageBox.Show("Không thể lưu vì đơn giá phải lớn hơn không", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn thật sự muốn thêm chi tiết phiếu nhập này?", "Xác nhận", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
            {
                try
                {
                    bdsCTPX.EndEdit();
                    bdsCTPX.ResetCurrentItem();
                    this.cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.cTPXTableAdapter.Update(this.dS.CTPX);
                    MessageBox.Show("Lưu chi tiết phiếu xuất thành công");
                    gcCTPX.Enabled = gcPX.Enabled = true;
                    panelControl2.Enabled = false;
                    btnthem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReset.Enabled = btnThoat.Enabled = true;
                    btnLuu.Enabled = btnPhucHoi.Enabled = false;
                    sbtnHieuChinh.Enabled = sbtnThem.Enabled = sbtnXoa.Enabled = true;
                    sbtnLuu.Enabled = sbtnHoanTac.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu chi tiết phiễu xuất " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void sbtnHoanTac_Click(object sender, EventArgs e)
        {
            bdsCTPX.CancelEdit();
            gcPX.Enabled = gcCTPX.Enabled = true;
            btnHieuChinh.Enabled = btnXoa.Enabled = btnthem.Enabled =
                btnReset.Enabled =  btnPhucHoi.Enabled = btnThoat.Enabled = true;
            panelControl2.Enabled = false;
            sbtnHieuChinh.Enabled = sbtnXoa.Enabled = sbtnThem.Enabled = true;
            dangThemCTPX = false;
        }

        
    }
}
