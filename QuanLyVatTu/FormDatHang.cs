using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTu
{
    public partial class FormDatHang : Form
    {
        int vitri = 0;
        bool dangThem = false;
        bool dangThemCT = false;
        public FormDatHang()
        {
            InitializeComponent();
        }

        private void FormDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
           
            dS.EnforceConstraints = false;
            datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.datHangTableAdapter.Fill(this.dS.DatHang);
            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.hoTenNVTableAdapter.Fill(this.dS.HoTenNV);
            khoTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.khoTableAdapter.Fill(this.dS.Kho);
            cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
            vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            cbbChiNhanh.DataSource = Program.bindingSource;
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CN;
            cbbChiNhanh.Enabled = false;
            if (Program.role == "CONGTY")
            {
                cbbChiNhanh.Enabled = true;
                btnthem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnLuu.Enabled = btnPhucHoi.Enabled = false;
                panelControl3.Enabled = false;

            }
        }
        private void mANVLabel_Click(object sender, EventArgs e)
        {

        }

        private void mANVTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoTenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (HoTenComboBox.SelectedValue != null)
                {
                    MaNvTextbox.Text = HoTenComboBox.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy mã nhân viên " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void TenKhoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TenKhoComboBox.SelectedValue != null)
                {
                    MaKhoText.Text = TenKhoComboBox.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy mã kho" +
                    " " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
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
                datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.datHangTableAdapter.Fill(this.dS.DatHang);
                this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.hoTenNVTableAdapter.Fill(this.dS.HoTenNV);
                khoTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.khoTableAdapter.Fill(this.dS.Kho);
                cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MaKhoText_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnthem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           vitri = bdsDatHang.Position;
            panelControl2.Enabled = true;
            bdsDatHang.AddNew();
            dangThem = true;
            gridDatHang.Enabled = false;
            btnthem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnReset.Enabled = btnThoat.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            panelControl3.Enabled = false;
            gridDatHang.Enabled = false;
            txtMaDon.Enabled = DateNgay.Enabled = TenKhoComboBox.Enabled = HoTenComboBox.Enabled = txtNhaCungCap.Enabled = true;
            TenVtComboBox.Enabled = SoLuongEdit.Enabled = DonGiaEdit.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsDatHang.CancelEdit();
            if (btnthem.Enabled == false)
            bdsDatHang.Position = vitri;
            btnthem.Enabled = btnReset.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = bsChonCheDo.Enabled = true;
            btnPhucHoi.Enabled = btnLuu.Enabled = false;
            gridDatHang.Enabled = true;
            panelControl2.Enabled = false;
            panelControl3.Enabled = true;
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.datHangTableAdapter.Fill(this.dS.DatHang);
                this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reset: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string madh = "";
            if (bdsDatHang.Count == 0)
            {
                MessageBox.Show("Không có phiếu nhập nào để xóa", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa đơn hàng có vật tư");
                return;
            }
            if (MessageBox.Show("Bạn thật sự muốn xóa đơn hàng này?", "Xác nhận", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                try
                {
                    madh = ((DataRowView)bdsDatHang[bdsDatHang.Position])["MasoDDH"].ToString();
                    bdsDatHang.RemoveCurrent();
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.datHangTableAdapter.Update(this.dS.DatHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa đơn hàng " + ex.Message, "", MessageBoxButtons.OK);
                    this.datHangTableAdapter.Fill(this.dS.DatHang);
                    bdsDatHang.Position = bdsDatHang.Find("MasoDDH", madh);
                    return;
                }
            }
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridDatHang.Enabled = false;
            panelControl3.Enabled = false;
            panelControl2.Enabled = true;
            txtMaDon.Enabled = false;
            btnHieuChinh.Enabled = btnReset.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnthem.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            TenVtComboBox.Enabled = SoLuongEdit.Enabled = DonGiaEdit.Enabled = false;
            DateNgay.Enabled = TenKhoComboBox.Enabled = HoTenComboBox.Enabled = txtNhaCungCap.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MaNvTextbox.Text.Trim() == "")
            {
                MessageBox.Show("Không thể bỏ trống mã nhân viên!", "", MessageBoxButtons.OK);
                HoTenComboBox.Focus();
                return;
            }

            if (MaKhoText.Text.Trim() == "")
            {
                MessageBox.Show("Không thể bỏ trống mã kho!", "", MessageBoxButtons.OK);
                TenKhoComboBox.Focus();
                return;
            }
            string strLenh = "Declare @status int "
                                 + "EXEC @status = SP_KiemTraMaDonHang "
                                 + "'"
                                 + txtMaDon.Text
                                 + "' "
                                 + "select @status";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int status = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if (dangThem == true)
            {
                if (status == 1)
                {
                    MessageBox.Show("Mã đơn hàng đã tồn tại!", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn thật sự muốn thêm đơn hàng?", "Xác nhận", MessageBoxButtons.OKCancel)
                            == DialogResult.OK)
                    {
                        try
                        {
                            bdsDatHang.EndEdit();
                            bdsDatHang.ResetCurrentItem();
                            this.datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
                            this.datHangTableAdapter.Update(this.dS.DatHang);
                            btnthem.Enabled = btnReset.Enabled = btnThoat.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = true;
                            btnLuu.Enabled = btnPhucHoi.Enabled = false;
                            gridDatHang.Enabled = true;
                            gridChiTiet.Enabled = true;
                            panelControl3.Enabled = true;
                            panelControl2.Enabled = false;
                            MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK);
                            dangThem = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi lưu dơn hàng " + ex.Message, "", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn sửa đơn hàng này?", "Xác nhận", MessageBoxButtons.OKCancel)
                        == DialogResult.OK)
                {
                    try
                    {
                        bdsDatHang.EndEdit();
                        bdsDatHang.ResetCurrentItem();
                        this.datHangTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.datHangTableAdapter.Update(this.dS.DatHang);
                       
                        btnthem.Enabled = btnReset.Enabled = btnThoat.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = true;
                        btnLuu.Enabled = btnPhucHoi.Enabled = false;

                        gridDatHang.Enabled = true;
                        gridChiTiet.Enabled = true;
                        panelControl3.Enabled = true;
                        panelControl2.Enabled = false;
                        MessageBox.Show("Sửa thành công!", "", MessageBoxButtons.OK);
                        dangThem = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi lưu đơn hàng " + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

       

 
        
     
        private void TenVtComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (TenVtComboBox.SelectedValue != null)
                {
                    txtMaVt.Text = TenVtComboBox.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy mã vật tư" +
                    " " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

     

        private void sbtnThem_Click(object sender, EventArgs e)
        {
            string strLenh = "declare @status int "
                           + "exec @status = SP_ChoPhepThemCTDH'"
                           + txtMaDon.Text
                           + "' "
                           + "select @status";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int status = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if (status == 1)
            {
                MessageBox.Show("Không thể thêm chi tiết vì tất cả các vật trong trong mã đơn đặt hàng " + txtMaDon.Text + " đều đã được lập chi tiết phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            bdsCTDDH.AddNew();
            dangThemCT = true;
            btnHieuChinh.Enabled = btnLuu.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnXoa.Enabled
            = btnReset.Enabled = btnthem.Enabled = txtMaDon.Enabled=false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            sbtnThem.Enabled = sbtnHieuChinh.Enabled = sbtnXoa.Enabled = false;
            sbtnLuu.Enabled = true;
            gridDatHang.Enabled = false;
            gridChiTiet.Enabled = false;
            panelControl3.Enabled = true;
            panelControl2.Enabled = true;
            TenVtComboBox.Enabled = SoLuongEdit.Enabled = DonGiaEdit.Enabled = true;
            DateNgay.Enabled = TenKhoComboBox.Enabled = HoTenComboBox.Enabled = txtNhaCungCap.Enabled = false;
        }

        private void sbtnXoa_Click(object sender, EventArgs e)
        {
            int vt = bdsCTDDH.Position;
            if (bdsCTDDH.Count == 0)
            {
                MessageBox.Show("Không có chi tiết nào để xóa!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn thật sự muốn xóa chi tiết này?", "Xác Nhận", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                try
                {
                    bdsCTDDH.RemoveCurrent();
                    this.cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.cTDDHTableAdapter.Update(this.dS.CTDDH);
                    MessageBox.Show("Xóa chi tiết đơn hàng thành công!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết đơn hàng " + ex.Message, "", MessageBoxButtons.OK);
                    this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
                    bdsCTDDH.Position = vt;
                }
            }
        }

        private void sbtnHieuChinh_Click(object sender, EventArgs e)
        {
            gridChiTiet.Enabled = gridDatHang.Enabled = false;
            panelControl2.Enabled = true;
            btnHieuChinh.Enabled = btnLuu.Enabled = btnPhucHoi.Enabled = btnReset.Enabled = btnthem.Enabled = btnThoat.Enabled = btnXoa.Enabled = false;
            sbtnHieuChinh.Enabled = sbtnThem.Enabled = sbtnXoa.Enabled = false;
            DateNgay.Enabled = TenKhoComboBox.Enabled = HoTenComboBox.Enabled = txtNhaCungCap.Enabled = false;
            TenVtComboBox.Enabled = SoLuongEdit.Enabled = DonGiaEdit.Enabled = true;
            sbtnLuu.Enabled = true;
            txtMaDon.Enabled = false;
        }

        private void sbtnLuu_Click(object sender, EventArgs e)
        {
            if (SoLuongEdit.Value <= 0)
            {
                MessageBox.Show("Không thể lưu vì số lượng phải lớn hơn không", "", MessageBoxButtons.OK);
                return;
            }
            if (DonGiaEdit.Value <= 0)
            {
                MessageBox.Show("Không thể lưu vì đơn giá phải lớn hơn không", "", MessageBoxButtons.OK);
                return;
            }

            if (dangThemCT== true)
            {
                if (MessageBox.Show("Bạn thật sự muốn thêm chi tiết đơn hàng này?", "Xác nhận", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    try
                    {

                        vitri = bdsCTDDH.Position;
                        bdsCTDDH.EndEdit();
                        bdsCTDDH.ResetCurrentItem();
                        this.cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.cTDDHTableAdapter.Update(this.dS.CTDDH);
                        MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK);
                        gridChiTiet.Enabled = gridDatHang.Enabled = true;
                        panelControl2.Enabled = true;
                        btnHieuChinh.Enabled = btnPhucHoi.Enabled = btnthem.Enabled = btnThoat.Enabled
                        = btnXoa.Enabled = btnReset.Enabled = true;
                        sbtnHieuChinh.Enabled = sbtnXoa.Enabled = sbtnThem.Enabled = true;
                        sbtnLuu.Enabled =  false;
                        dangThemCT = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm chi tiết đơn hàng " + ex.Message, "", MessageBoxButtons.OK);
                        bdsCTDDH.Position = vitri;
                        return;
                    }
                }
            }
            else
            {
                vitri = bdsCTDDH.Position;
                if (MessageBox.Show("Bạn thật sự muốn lưu chi tiết đơn hàng này?", "Xác nhận", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    try
                    {
                        bdsCTDDH.EndEdit();
                        bdsCTDDH.ResetCurrentItem();
                        this.cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.cTDDHTableAdapter.Update(this.dS.CTDDH);
                        MessageBox.Show("Hiệu chỉnh thành công!", "", MessageBoxButtons.OK);
                        gridDatHang.Enabled = gridChiTiet.Enabled = true;
                        panelControl2.Enabled = false;
                        btnHieuChinh.Enabled = btnPhucHoi.Enabled = btnthem.Enabled = btnThoat.Enabled
                            = btnXoa.Enabled = btnReset.Enabled = true;
                        sbtnHieuChinh.Enabled = sbtnXoa.Enabled = sbtnThem.Enabled = true;
                        sbtnLuu.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi lưu chi tiết đơn hàng " + ex.Message, "", MessageBoxButtons.OK);
                        bdsCTDDH.Position = vitri;
                        return;
                    }

                }
            }
        }

        private void txtMaVt_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
