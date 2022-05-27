using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace QuanLyVatTu
{
    public partial class FormNhanVien : Form
    {
        int vitri = 0;
        string macn = "";
        bool dangThem = false;
        Stack phucHoiList = new Stack();
        string cauTruyVan = "";
        string luong = "";
        string ho = "";
        string ten = "";
        bool trangThaiXoa = true;
        string diaChi = "";
        DateTime ngaySinh;
        public FormNhanVien()
        {
            InitializeComponent();
        }

 //       private void cbbChiNhanh_SelectedIndexChanged

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThem = true;
            vitri = bdsNV.Position;
            panelControl2.Enabled = true;
            bdsNV.AddNew();
            txtMACN.Text = macn;
            deNgaySinh.EditValue = DateTime.Now;
            cbTTX.Checked = false;
            txtMANV.Enabled = true;
            btnHieuChinh.Enabled = btnThoat.Enabled = btnthem.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            gcNhanVien.Enabled = false;
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            /*không kiểm tra khóa ngoại nữa*/
            dS.EnforceConstraints = false;
            nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.datHangTableAdapter.Fill(this.dS.DatHang);

            nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);

            nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            cbbChiNhanh.DataSource = Program.bindingSource;
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CN;
            cbbChiNhanh.Enabled = false;
            if (Program.role == "CONGTY")
            {
                cbbChiNhanh.Enabled = true;
                btnLamLai.Enabled = btnHieuChinh.Enabled = btnthem.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnPhucHoi.Enabled = false;
            }
            
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnHieuChinh.Enabled == true)
            {
                try
                {
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi reset: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            { 
                if(dangThem == true)
                {
                    txtMANV.Text = txtDC.Text = txtHO.Text = txtTEN.Text = "";
                    txtMACN.Text = macn;
                    cbTTX.Checked = false;
                    teLuong.Text = "0";
                }
                else
                {
                    txtHO.Text = ho;
                    txtTEN.Text = ten;
                    txtDC.Text = diaChi;
                    teLuong.Text = luong;
                    deNgaySinh.EditValue = ngaySinh;
                    cbTTX.Checked = trangThaiXoa;
                }
            }    

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        /*
         * B1: Kiểm tra xem có đang thêm, hiệu chỉnh hay không?
         * B2: Nếu đang thêm thì bật tắt nút lệnh tương ứng
         * B3: với nút phục hồi kiểm tra xem trong stack phục hồi có phần tử ko có thì enabled = true ngược lại false;
         * B4: 
         * 
         */
        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if(btnthem.Enabled == true && phucHoiList)
            if(btnthem.Enabled == false)
            {
                bdsNV.CancelEdit();
                bdsNV.Position = vitri;
                gcNhanVien.Enabled = true;
                panelControl2.Enabled = false;
                btnHieuChinh.Enabled = btnThoat.Enabled = btnthem.Enabled = btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                dangThem = false;
                //btnPhucHoi.Enabled = true;
                if (phucHoiList.Count == 0)
                    btnPhucHoi.Enabled = false;
                return;
            }    
            
            string cauTruyVan = phucHoiList.Pop().ToString();
            Console.WriteLine(cauTruyVan);
            int status = Program.ExecSqlNonQuery(cauTruyVan);
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            if (phucHoiList.Count == 0)
                btnPhucHoi.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            gcNhanVien.Enabled = false;
            panelControl2.Enabled = true;
            btnHieuChinh.Enabled = btnThoat.Enabled = btnthem.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            txtMANV.Enabled = false;
            trangThaiXoa = cbTTX.Checked;
            //manv = txtMANV.Text;
            ho = txtHO.Text;
            ten = txtTEN.Text;
            diaChi = txtDC.Text;
            
            int ttx = (cbTTX.Checked == true) ? 1 : 0;
            ngaySinh = (DateTime)((DataRowView)bdsNV[bdsNV.Position])["NGAYSINH"];
            luong = ((DataRowView)bdsNV[bdsNV.Position])["LUONG"].ToString();
            cauTruyVan = $"Update NhanVien " +
                                            $"set HO = N'{txtHO.Text}', TEN = N'{txtTEN.Text}', DIACHI = N'{txtDC.Text}', " +
                                            $"NGAYSINH = '{ngaySinh.ToString("yyyy-MM-dd")}', LUONG = {luong}, TrangThaiXoa = {ttx} " +
                                            $"where MANV = '{txtMANV.Text}'";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            if (bdsNV.Count == 0)
            {
                btnXoa.Enabled = false;
                return;
            }
            string manvkt = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
            Console.WriteLine(manvkt);
            if(manvkt == Program.userName)
            {
                MessageBox.Show("Bạn đang đăng nhập bằng tài khoản này, bạn không thể xóa nó!", "", MessageBoxButtons.OK);
                return;
            }    
            if(bdsDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì nhân viên đã lập đơn đặt hàng!", ""
                    , MessageBoxButtons.OK);
                return;
            }
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì nhân viên đã lập phiếu nhập!", ""
                    , MessageBoxButtons.OK);
                return;
            }
            if(bdsPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì nhân viên đã lập phiếu xuất!", ""
                    , MessageBoxButtons.OK);
                return;
            }    
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này?", "Xác Nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                /*
                 * B1: lấy mã nv để nếu có lỗi thì còn tìm được vị trí của nhân viên đó trên gc
                 * B2: xóa nhân viên trên giao diện và bds
                 * B3: mở chuỗi kết nối về Sql
                 * B4: update lại dữ liệu trong sql
                 */
                try
                {
                    int ttx = (cbTTX.Checked == true) ? 1 : 0; 
                    ngaySinh = (DateTime)((DataRowView)bdsNV[bdsNV.Position])["NGAYSINH"];
                    luong = ((DataRowView)bdsNV[bdsNV.Position])["LUONG"].ToString();
                    cauTruyVan = $"insert NhanVien(MANV,HO,TEN,DIACHI,NGAYSINH,LUONG,MACN,TrangThaiXoa) " +
                        $"values({txtMANV.Text}, N'{txtHO.Text}', N'{txtTEN.Text}', " 
                        +$"N'{txtDC.Text}', '{ngaySinh.ToString("yyyy-MM-dd")}',{luong}, '{txtMACN.Text.Trim()}', {ttx})";
                    Console.WriteLine(cauTruyVan);
                    bdsNV.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                    phucHoiList.Push(cauTruyVan);
                    btnPhucHoi.Enabled = true;
                    MessageBox.Show("Xóa nhân viên thành công!", "", MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message,
                        "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    bdsNV.Position = vitri;
                    return;
                }
            }
            
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được bỏ trống!", "", MessageBoxButtons.OK);
                //Đưa con trỏ về vị trí textbox mã nhân viên
                txtMANV.Focus();
                return;
            }
            if(txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được bỏ trống!", "", MessageBoxButtons.OK);
                //Đưa con trỏ về vị trí textbox mã nhân viên
                txtHO.Focus();
                return;
            }
            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được bỏ trống!", "", MessageBoxButtons.OK);
                //Đưa con trỏ về vị trí textbox mã nhân viên
                txtTEN.Focus();
                return;
            }
            if (txtDC.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được bỏ trống!", "", MessageBoxButtons.OK);
                //Đưa con trỏ về vị trí textbox mã nhân viên
                txtDC.Focus();
                return;
            }
            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được bỏ trống!", "", MessageBoxButtons.OK);
                //Đưa con trỏ về vị trí textbox mã nhân viên
                txtMANV.Focus();
                return;
            }
            if(deNgaySinh.EditValue.ToString() == "")
            {
                MessageBox.Show("Ngày sinh nhân viên không được bỏ trống!", "", MessageBoxButtons.OK);
                //Đưa con trỏ về vị trí textbox mã nhân viên
                deNgaySinh.Focus();
                return;
            }
            // Viết sp kiểm tra mã trùng trên các phân mảnh
            // Luong thỏa miềm giá trị
            /*
            * Thực thi sp_TimNhanVien
            * declare @status int
            * exec @status = SP_TimNhanVien 3
            * select @status
            */
            string strlenh = "declare @status int "
                            + "exec @status = SP_KiemTraMaNV " +
                            txtMANV.Text
                            + " select @status";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            Program.myReader.Read();
            int status = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            //if(lUONGTextEdit. > 0)
            // Viết sp kiểm tra mã trùng trên các phân mảnh
            // Luong thỏa miềm giá trị
            if(dangThem == true)
            {
                if (status == 1)
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại!", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn lưu nhân viên này?", "Xác Nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        try
                        {
                            // kết thúc quá trình hiệu chỉnh
                            cauTruyVan = $"delete from NhanVien where MANV = {txtMANV.Text.Trim()}";
                            bdsNV.EndEdit();
                            bdsNV.ResetCurrentItem();
                            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                            this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                            MessageBox.Show("Thêm nhân viên thành công!", "", MessageBoxButtons.OK);
                            dangThem = false;
                            phucHoiList.Push(cauTruyVan);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi nhân viên!" + ex.Message, "", MessageBoxButtons.OK);
                            //bdsNV.ResetCurrentItem();
                            //this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }    
                }
                
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn lưu nhân viên này?", "Xác Nhận",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {

                        // kết thúc quá trình hiệu chỉnh
                        //string 
                        bdsNV.EndEdit();
                        bdsNV.ResetCurrentItem();
                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                        MessageBox.Show("Hiệu chỉnh nhân viên thành công!", "", MessageBoxButtons.OK);
                        phucHoiList.Push(cauTruyVan);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi ghi nhân viên!" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }

                }
                else
                    return;
            }
            gcNhanVien.Enabled = true;
            btnthem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = true;
            btnLuu.Enabled = false;
            panelControl2.Enabled = false;
            //btnPhucHoi.Enabled = true;
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.serverName = cbbChiNhanh.SelectedValue.ToString();

            if(cbbChiNhanh.SelectedIndex != Program.CN)
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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                this.datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.datHangTableAdapter.Fill(this.dS.DatHang);
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
                //macn = ((DataRowView)bdsNV[0])["MANV"].ToString();
            }
        }
    }
}
