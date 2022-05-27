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


namespace QuanLyVatTu
{
    public partial class FormVatTu : Form
    {
        int vitri = 0;
        bool dangThem = false;
        Stack phucHoiList = new Stack();
        string cauTruyVan = "";
        string MaVT = "";
        string TenVT = "";
        string DVT = "";
        string SoLT = "";
        public FormVatTu()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormVatTu_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
            cbbChiNhanh.DataSource = Program.bindingSource;
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.Enabled = false;
            if (Program.role == "CONGTY")
            {
                cbbChiNhanh.Enabled = true;
                btnLamLai.Enabled = btnHieuChinh.Enabled = btnthem.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnPhucHoi.Enabled = false;
            }
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
            if(Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới!", "", MessageBoxButtons.OK);
            else
            {
                vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.vattuTableAdapter.Fill(this.dS.Vattu);
                cTDDHTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.cTDDHTableAdapter.Fill(this.dS.CTDDH);
                cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.cTPNTableAdapter.Fill(this.dS.CTPN);
                cTPXTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.cTPXTableAdapter.Fill(this.dS.CTPX);
            }    

        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnthem.Enabled == true)
            {
                try
                {
                    this.vattuTableAdapter.Fill(this.dS.Vattu);
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
                    txtTenVT.Text = txtMaVT.Text = txtDVT.Text =  "";
                    teSoLuongTon.Text = "0";
                }
                else
                {
                    txtMaVT.Text = MaVT;
                    txtTenVT.Text = TenVT;
                    txtDVT.Text = DVT;
                    teSoLuongTon.Text = SoLT;
                }    
            }    
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string mavt = "";
            mavt = ((DataRowView)bdsVT[bdsVT.Position])["MAVT"].ToString();
            if (bdsVT.Count == 0)
                return;
            if(bdsCTDDH.Count > 0)
            {
                MessageBox.Show(" Không thể xóa vì vật tư này đã được lập đơn đặt hàng!", "", MessageBoxButtons.OK);
                return;
            }  
            if(bdsCTPN.Count > 0)
            {
                MessageBox.Show(" Không thể xóa vì vật tư này đã được lập phiếu nhập!", "", MessageBoxButtons.OK);
                return;
            } 
            if(bdsCTPX.Count > 0)
            {
                MessageBox.Show(" Không thể xóa vì vật tư này đã được lập phiếu xuất!", "", MessageBoxButtons.OK);
                return;
            }

            string strLenh = "Declare @status int "
                            + "EXEC @status = SP_KiemTraMaVTCNKhac '"
                            + mavt + "' "
                            + "select @status";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int status = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if(status == 1)
            {
                MessageBox.Show("Mã vật tư đã được lập đơn đặt hàng ở chi nhánh khác!", "", MessageBoxButtons.OK);
                return;
            }
            else if(status == 2)
            {
                MessageBox.Show("Mã vật tư đã được lập phiếu xuất ở chi nhánh khác!", "", MessageBoxButtons.OK);
                return;
            }
            else if(status == 3)
            {
                MessageBox.Show("Mã vật tư đã được lập phiếu nhập ở chi nhánh khác!", "", MessageBoxButtons.OK);
                return;
            }    
            if (MessageBox.Show("Bạn thật sự muốn xóa vật tư này?","Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    cauTruyVan = $"insert into Vattu(MAVT, TENVT, DVT, SOLUONGTON) VALUES('{txtMaVT.Text}', N'{txtTenVT.Text}'," +
                                $"N'{txtDVT.Text}', {teSoLuongTon.Text})";
                    bdsVT.RemoveCurrent();
                    this.vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.vattuTableAdapter.Update(this.dS.Vattu);
                    phucHoiList.Push(cauTruyVan);
                    btnPhucHoi.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại!\n" + ex.Message,
                        "", MessageBoxButtons.OK);
                    this.vattuTableAdapter.Fill(this.dS.Vattu);
                    bdsVT.Position = bdsVT.Find("MAVT", mavt);
                    return;
                }
            }    
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsVT.Position;
            dangThem = true;
            bdsVT.AddNew();
            panelControl2.Enabled = true;
            txtMaVT.Enabled = true;
            btnHieuChinh.Enabled = btnXoa.Enabled = btnthem.Enabled = btnThoat.Enabled = false;
            gcVatTu.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (btnthem.Enabled == false)
            {
                bdsVT.CancelEdit();
                bdsVT.Position = vitri;
                gcVatTu.Enabled = true;
                panelControl2.Enabled = false;
                btnthem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReset.Enabled = true;
                //btnPhucHoi.Enabled = true;
                dangThem = false;
                btnLuu.Enabled = false;
                if (phucHoiList.Count == 0)
                    btnPhucHoi.Enabled = false;
                return;
            }
            string cauTruyVan = phucHoiList.Pop().ToString();
            int status = Program.ExecSqlNonQuery(cauTruyVan);
            this.vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            if (phucHoiList.Count == 0)
                btnPhucHoi.Enabled = false;
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MaVT = txtMaVT.Text;
            TenVT = txtTenVT.Text;
            DVT = txtDVT.Text;
            SoLT = teSoLuongTon.Text;
            cauTruyVan = $"update Vattu " +
                        $"set TENVT = N'{txtTenVT.Text}', DVT = N'{txtDVT.Text}', SOLUONGTON = {teSoLuongTon.Text} " +
                        $"where MAVT = '{txtMaVT.Text}'";
            vitri = bdsVT.Position;
            gcVatTu.Enabled = false;
            panelControl2.Enabled = true;
            btnthem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled =  false;
            btnPhucHoi.Enabled = btnLuu.Enabled = true;
            txtMaVT.Enabled = false;
        }
        /*
         * Bước 1: Kiểm tra nhập liệu
         * Bước 2: Kiểm tra xem có phải đang thêm mới hay không
         *      + Nếu đang thêm mới kiêm tra mã nhân viên có bị trùng không
         *          + Nếu trùng báo lỗi.
         *          + Nếu không trùng cho thêm
         *      + Nếu không phải đang thêm mới thì là đang update.
         *          + Không cần kiểm tra mã.
         * Bước 3: Bật tắt các nút lệnh
         */
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(txtMaVT.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được bỏ trống!", "", MessageBoxButtons.OK);
                //Đưa con trỏ về vị trí textbox mã nhân viên
                txtMaVT.Focus();
                return;
            }
            if(txtTenVT.Text.Trim() == "")
            {
                MessageBox.Show("Tên vật tư không được bỏ trống!", "", MessageBoxButtons.OK);
                //Đưa con trỏ về vị trí textbox mã nhân viên
                txtTenVT.Focus();
                return;
            }
            if(txtDVT.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính  không được bỏ trống!", "", MessageBoxButtons.OK);
                //Đưa con trỏ về vị trí textbox mã nhân viên
                txtDVT.Focus();
                return;
            }

            string strLenh = "Declare @status int "
                            + "EXEC @status = SP_KiemTraMaVT '"
                            + txtMaVT.Text + "' "
                            + "select @status";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int status = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if(dangThem == true)
            {
                if(status == 1)
                {
                    MessageBox.Show("Mã vật tư đã tồn tại!", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn thật sự muốn thêm mới vật tư này?", "Xác Nhận", MessageBoxButtons.OKCancel)
                        == DialogResult.OK)
                    {
                        try
                        {
                            cauTruyVan = $"delete from Vattu where MAVT = '{txtMaVT.Text}'";
                            bdsVT.EndEdit();
                            bdsVT.ResetCurrentItem();
                            this.vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
                            this.vattuTableAdapter.Update(this.dS.Vattu);
                            MessageBox.Show("Thêm vật tư thàng công!", "", MessageBoxButtons.OK);
                            dangThem = false;
                            //btnPhucHoi.
                            phucHoiList.Push(cauTruyVan);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi ghi vật tư " + ex.Message, "", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    else
                        return;
                }
            }
            else
            {
                if (MessageBox.Show("Bạn thật sự muốn lưu thay đổi này?", "Xác Nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        bdsVT.EndEdit();
                        bdsVT.ResetCurrentItem();
                        this.vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.vattuTableAdapter.Update(this.dS.Vattu);
                        MessageBox.Show("Hiệu chỉnh vật tư thành công!", "", MessageBoxButtons.OK);
                        phucHoiList.Push(cauTruyVan);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi lưu dữ liệu " + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                    return;
            }
            gcVatTu.Enabled = true;
            btnthem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnThoat.Enabled = btnReset.Enabled = true;
            panelControl2.Enabled = btnLuu.Enabled = false;
        }
    }
}
