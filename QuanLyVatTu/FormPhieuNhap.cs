using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace QuanLyVatTu
{
    public partial class FormPhieuNhap : Form
    {
        int vitri = 0;
        bool dangThemPN = false;
        bool dangThemCTPN = false;
        Stack phucHoiList = new Stack();
        string cauTruyVan = "";
        string maSoDDH = "";
        string manv = "";
        string maKho = "";
        DateTime ngay;
        public FormPhieuNhap()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.vattuTableAdapter.Fill(this.dS.Vattu);
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.khoTableAdapter.Fill(this.dS.Kho);
            // TODO: This line of code loads data into the 'dS.HoTenNV' table. You can move, or remove it, as needed.
            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.hoTenNVTableAdapter.Fill(this.dS.HoTenNV);
            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            cbbChiNhanh.DataSource = Program.bindingSource;
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CN;
            cbbChiNhanh.Enabled = false;
            if(Program.role == "CONGTY")
            {
                cbbChiNhanh.Enabled = true;
                btnthem.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = btnLuu.Enabled = btnPhucHoi.Enabled = false;
                panelControl3.Enabled = false;

            }    
        }


        private void mANVLabel_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnthem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string strLenh = "Declare @status int "
                            + "exec @status = SP_ChoPhepThemPN "
                            + "select @status";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int status = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if(status == 1)
            {
                MessageBox.Show("Không thể thêm phiếu nhập vì tất cả đơn đặt hàng đều đã được lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }    
            dangThemPN = true;
            vitri = bdsPN.Position;
            panelControl2.Enabled = true;
            // thêm mới
            bdsPN.AddNew();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from V_DanhSachDDH", Program.con);
            da.Fill(dt);
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            cbbMaSoDDH.DataSource = bds;
            cbbMaSoDDH.DisplayMember = "MasoDDH";
            cbbMaSoDDH.ValueMember = "MasoDDH";
            btnthem.Enabled =  btnThoat.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            teMaPN.Enabled = cbbHoTenNV.Enabled = cbbMaSoDDH.Enabled = cbbTenKho.Enabled = deNgay.Enabled = true;
            deNgay.EditValue = DateTime.Now;
            ccbMaVT.Enabled = nnSoLuong.Enabled = seDonGiaCTPN.Enabled = false;
            gcPN.Enabled = false;
            gcCTPN.Enabled = false;
            panelControl3.Enabled = false;
            ccbMaVT.Enabled = nnSoLuong.Enabled = seDonGiaCTPN.Enabled = false;
        }

        private void txtMaKho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (btnthem.Enabled == false)
            {
                bdsPN.CancelEdit();
                bdsPN.Position = vitri;
                btnthem.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnHieuChinh.Enabled = true;
                btnLuu.Enabled = false;
                gcPN.Enabled =gcCTPN.Enabled = true;
                panelControl2.Enabled = false;
                panelControl3.Enabled = true;
                dangThemPN = false;
                if (phucHoiList.Count == 0)
                    btnPhucHoi.Enabled = false;
                return;
            }
            string cauTruyVan = phucHoiList.Pop().ToString();
            int status = Program.ExecSqlNonQuery(cauTruyVan);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            if (phucHoiList.Count == 0)
                btnPhucHoi.Enabled = false;
        }

        private void btnReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnHieuChinh.Enabled == true)
            {
                try
                {
                    this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi reset: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                if(dangThemPN == true)
                {
                    teMaPN.Text = "";
                    deNgay.EditValue = DateTime.Now;
                    //cbbTenKho.SelectedValue = "";
                }
                else
                {
                    deNgay.EditValue = ngay;
                    txtMaKho.Text = maKho;
                    cbbTenKho.SelectedValue = maKho;
                    txtMaNV.Text = manv;
                    cbbHoTenNV.SelectedValue = manv;
                    cbbMaSoDDH.Text = maSoDDH;
                }    
            }    
        }

        /*
         * Bước 1: kiểm tra số phiếu nhập > 0 mới cho xóa
         * Bước 2: kiểm tra phiếu nhập đã có CTPN chưa
         * Bước 3: xóa
         */
        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsPN.Position;
            if (bdsPN.Count == 0)
            {
                MessageBox.Show("Không có phiếu nhập nào để xóa", "", MessageBoxButtons.OK); 
                return;
            } 
            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa phiếu nhập đã  tồn tại ");   
                return;
            }
            if (MessageBox.Show("Bạn thật sự muốn xóa phiếu nhập này?", "Xác nhận", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {    
                try   
                {
                    ngay = (DateTime)((DataRowView)bdsPN[bdsPN.Position])["NGAY"];
                    maSoDDH = ((DataRowView)bdsPN[bdsPN.Position])["MasoDDH"].ToString();
                    cauTruyVan = $"insert into PhieuNhap(MAPN, NGAY, MasoDDH, MANV, MAKHO) values('{teMaPN.Text}', '{ngay.ToString("yyyy-MM-dd")}', " +
                        $"'{maSoDDH}', '{txtMaNV.Text}', '{txtMaKho.Text}')";
                    Console.WriteLine(cauTruyVan);
                    bdsPN.RemoveCurrent(); 
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;   
                    this.phieuNhapTableAdapter.Update(this.dS.PhieuNhap);
                    phucHoiList.Push(cauTruyVan);
                    MessageBox.Show("Xóa phiếu nhập thành công!","",MessageBoxButtons.OK);
                }    
                catch (Exception ex)
                {   
                    MessageBox.Show("Lỗi xóa phiếu nhập " + ex.Message, "", MessageBoxButtons.OK);
                    this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap); 
                    bdsPN.Position = vitri;  
                    return;
                } 
            }
               
        }

        private void btnHieuChinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ngay = (DateTime)((DataRowView)bdsPN[bdsPN.Position])["NGAY"];
            maSoDDH = cbbMaSoDDH.Text;
            manv = txtMaNV.Text;
            maKho = txtMaKho.Text;
            cauTruyVan = $"update PhieuNhap " +
                        $"set NGAY = '{ngay.ToString("yyyy-MM-dd")}', MasoDDH = '{cbbMaSoDDH.Text}', MANV = {txtMaNV.Text}, " +
                        $"MAKHO = '{txtMaKho.Text}' " +
                        $"where MAPN = '{teMaPN.Text}'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from V_DanhSachDDH", Program.con);
            da.Fill(dt);
            dt.Rows.Add(cbbMaSoDDH.Text);
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            cbbMaSoDDH.DataSource = bds;
            cbbMaSoDDH.DisplayMember = "MasoDDH";
            cbbMaSoDDH.ValueMember = "MasoDDH";
            gcPN.Enabled = false;
            panelControl3.Enabled = false;
            panelControl2.Enabled = true; 
            teMaPN.Enabled = false; 
            btnHieuChinh.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnthem.Enabled = false; 
            btnLuu.Enabled = btnPhucHoi.Enabled = true;
            ccbMaVT.Enabled = nnSoLuong.Enabled = seDonGiaCTPN.Enabled = false;
            cbbTenKho.Enabled = cbbHoTenNV.Enabled = cbbMaSoDDH.Enabled = deNgay.Enabled = true;
        }
        /*
         * B1: Kiểm tra định dạng
         * B2: Kiêm tra xem mã PN đã trùng chưa?
         * b3: lưu vào csdl
         */
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            if(txtMaNV.Text.Trim() == "") 
            {
                MessageBox.Show("Không thể bỏ trống mã nhân viên!", "", MessageBoxButtons.OK);  
                cbbHoTenNV.Focus();    
                return;
            }
                
            if(txtMaKho.Text.Trim() == "") 
            {   
                MessageBox.Show("Không thể bỏ trống mã kho!", "", MessageBoxButtons.OK);    
                cbbTenKho.Focus();  
                return;
            }
                
            /*    
             * Declare @status int   
             * EXEC @status = SP_KiemTraMaPN 'tePN'    
             * select @status    
             */
                
            string strLenh = "Declare @status int "
                                 + "EXEC @status = SP_KiemTraMaPN "
                                 + "'"
                                 + teMaPN.Text
                                 + "' "
                                 + "select @status";    
            Program.myReader = Program.ExecSqlDataReader(strLenh);  
            Program.myReader.Read();  
            int status = int.Parse(Program.myReader.GetValue(0).ToString());  
            Program.myReader.Close();  
              
            if(dangThemPN == true) 
            {
                if (status == 1)
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại!", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if (MessageBox.Show("Bạn thật sự muốn thêm phiếu nhập này?", "Xác nhận", MessageBoxButtons.OKCancel)
                            == DialogResult.OK)
                    {
                        try
                        {
                            cauTruyVan = $"delete from PhieuNhap" +
                                        $" where MAPN = '{teMaPN.Text}'";
                            bdsPN.EndEdit();
                            bdsPN.ResetCurrentItem();
                            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
                            this.phieuNhapTableAdapter.Update(this.dS.PhieuNhap);
                            MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK);
                            dangThemPN = false;
                            phucHoiList.Push(cauTruyVan);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi lưu phiếu nhập " + ex.Message, "", MessageBoxButtons.OK);
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
                if (MessageBox.Show("Bạn thật sự muốn thay đổi nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel)
                        == DialogResult.OK) 
                {    
                    try    
                    {    
                        bdsPN.EndEdit();   
                        bdsPN.ResetCurrentItem();
                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString; 
                        this.phieuNhapTableAdapter.Update(this.dS.PhieuNhap);
                        MessageBox.Show("Hiệu chỉnh thành công!", "", MessageBoxButtons.OK);
                        phucHoiList.Push(cauTruyVan);
                    }   
                    catch (Exception ex) 
                    {    
                        MessageBox.Show("Lỗi lưu phiếu nhập " + ex.Message, "", MessageBoxButtons.OK);     
                        return;  
                    }
                }
                else
                {
                    return;
                }    
            }
            btnthem.Enabled =  btnThoat.Enabled = btnHieuChinh.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            //teMaPN.Enabled = true;
            //deNgay.EditValue = DateTime.Now;
            gcPN.Enabled = true;
            gcCTPN.Enabled = true;
            panelControl3.Enabled = true;
            panelControl2.Enabled = false;
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
            if(Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới!", "", MessageBoxButtons.OK);
            else
            {
                this.vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.vattuTableAdapter.Fill(this.dS.Vattu);
                this.khoTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.khoTableAdapter.Fill(this.dS.Kho);
                this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.hoTenNVTableAdapter.Fill(this.dS.HoTenNV);
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
                this.cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.cTPNTableAdapter.Fill(this.dS.CTPN);
            }    
        }

        private void cbbMaDDH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbHoTenNV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbbHoTenNV.SelectedValue != null)
                    txtMaNV.Text = cbbHoTenNV.SelectedValue.ToString();
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
                    txtMaKho.Text = cbbTenKho.SelectedValue.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi lấy mã nhân viên " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void separatorControl1_Click(object sender, EventArgs e)
        {

        }

        private void sOLUONGNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sbtnThem_Click(object sender, EventArgs e)
        {
            string strLenh = "declare @status int "
                            + "exec @status = SP_ChoPhepThemCTPN '"
                            + teMaPN.Text
                            + "', '"
                            + cbbMaSoDDH.Text
                            + "' "
                            + "select @status";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int status = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();
            if(status == 1)
            {
                MessageBox.Show("Không thể thêm chi tiết phiếu nhập vì tất cả các vật trong trong mã đơn đặt hàng " + cbbMaSoDDH.Text + " đều đã được lập chi tiết phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }    
            bdsCTPN.AddNew();
            txtMaPN_CTPN.Text = teMaPN.Text;
            //ccbMaVT.Enabled = true;
            gcCTPN.Enabled = gcPN.Enabled = false;
            btnHieuChinh.Enabled = btnLuu.Enabled = btnPhucHoi.Enabled = btnThoat.Enabled = btnXoa.Enabled = btnReset.Enabled = btnthem.Enabled = false;
            seDonGiaCTPN.Enabled = nnSoLuong.Enabled = ccbMaVT.Enabled = true;
            sbtnThem.Enabled = sbtnHieuChinh.Enabled = sbtnXoa.Enabled = false;
            //Console.WriteLine(cbbMaSoDDH.Text);
            DataTable dt = new DataTable();
            strLenh = "Select * from dbo.F_MAVTDDH('" + cbbMaSoDDH.Text.Trim() + "', '" + teMaPN.Text.Trim() + "')";
            SqlDataAdapter da = new SqlDataAdapter(strLenh, Program.con);
            da.Fill(dt);
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            ccbMaVT.DataSource = bds;
            ccbMaVT.DisplayMember = "MAVT";
            ccbMaVT.ValueMember = "MAVT";
            ccbMaVT.Enabled = nnSoLuong.Enabled = seDonGiaCTPN.Enabled = true;
            teMaPN.Enabled = deNgay.Enabled = cbbHoTenNV.Enabled = cbbMaSoDDH.Enabled = cbbTenKho.Enabled = false;
            panelControl2.Enabled = true;
            sbtnLuu.Enabled = sbtnPhucHoi.Enabled = true;
            vitri = bdsCTPN.Position;
            dangThemCTPN = true;
            nnSoLuong.Value = 0;
            seDonGiaCTPN.Value = 0;
        }

        private void sbtnXoa_Click(object sender, EventArgs e)
        {
            if(bdsCTPN.Count == 0)
            {
                MessageBox.Show("Không có chi tiết phiếu nhập nào để xóa!", "", MessageBoxButtons.OK);
                return;
            }    
            if(MessageBox.Show("Bạn thật sự muốn xóa chi tiết phiếu nhập này?", "Xác Nhận", MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                try
                {
                    vitri = bdsCTPN.Position;
                    bdsCTPN.RemoveCurrent();
                    this.cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;
                    this.cTPNTableAdapter.Update(this.dS.CTPN);
                    MessageBox.Show("Xóa thành công!", "", MessageBoxButtons.OK);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết vật tư " + ex.Message, "", MessageBoxButtons.OK);
                    this.cTPNTableAdapter.Fill(this.dS.CTPN);
                    bdsCTPN.Position = vitri;
                }
            }    
        }

        private void sbtnHieuChinh_Click(object sender, EventArgs e)
        {
            gcPN.Enabled = gcCTPN.Enabled = false;
            panelControl2.Enabled = true;
            btnHieuChinh.Enabled = btnLuu.Enabled = btnPhucHoi.Enabled = btnReset.Enabled = btnthem.Enabled = btnThoat.Enabled = btnXoa.Enabled = false;
            sbtnHieuChinh.Enabled = sbtnThem.Enabled = sbtnXoa.Enabled = false;
            teMaPN.Enabled = deNgay.Enabled = cbbMaSoDDH.Enabled = cbbTenKho.Enabled = cbbHoTenNV.Enabled = false;
            ccbMaVT.Enabled = false;
            nnSoLuong.Enabled = seDonGiaCTPN.Enabled = true;
            sbtnPhucHoi.Enabled = sbtnLuu.Enabled = true;
        }

        /*
         * Bước 1: Kiểm tra dangThemCTPN = true?false
         * Bước 2: Nếu bằng true kiểm tra xem bạn thật sự muốn thêm CTPN này?(Đến bước 4)
         * Bước 4: tiết hành lưu
         *          + dangThemCPTN = false;
         *          + bdsCTPN.EndEdit(); kết thúc quá trình edit();
         *          + bdsCTPN.ResestCurrentItem(); reset lại grid view
         *          + update dữ liệu
         *          + bật tắt các nút lệnh;
         * Bước 5: tiến hành lưu(hiệu chỉnh)
         *          + vitri = bdsCTPN.Position(); // mục đính nếu sảy ra lỗi thì con trỏ sẽ trả về vị trí đang edit;
         *          + bdsCTPN.EndEdit(); kết thúc quá trình edit();
         *          + bdsCTPN.ResestCurrentItem(); reset lại grid view
         *          + update dữ liệu
         *          + bật tắt các nút lệnh;
         */
        private void sbtnLuu_Click(object sender, EventArgs e)
        {
            if(nnSoLuong.Value == 0)
            {
                MessageBox.Show("Không thể lưu vì số lượng phải lớn hơn không", "", MessageBoxButtons.OK);
                return;
            }
            if(seDonGiaCTPN.Value == 0)
            {
                MessageBox.Show("Không thể lưu vì đơn giá phải lớn hơn không", "", MessageBoxButtons.OK);
                return;
            }    

            if(dangThemCTPN == true)
            {
                if(MessageBox.Show("Bạn thật sự muốn thêm chi tiết phiếu nhập này?","Xác nhận",MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    try 
                    {
                        
                        //vitri = bdsCTPN.Position;
                        bdsCTPN.EndEdit();
                        bdsCTPN.ResetCurrentItem();
                        this.cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.cTPNTableAdapter.Update(this.dS.CTPN);
                        MessageBox.Show("Thêm thành công!", "", MessageBoxButtons.OK);
                        gcCTPN.Enabled = gcPN.Enabled = true;
                        panelControl2.Enabled = false;
                        btnHieuChinh.Enabled = btnPhucHoi.Enabled = btnthem.Enabled = btnThoat.Enabled
                            = btnXoa.Enabled = btnReset.Enabled = true;
                        sbtnHieuChinh.Enabled = sbtnXoa.Enabled = sbtnThem.Enabled = true;
                        sbtnLuu.Enabled = sbtnPhucHoi.Enabled = false;
                        dangThemCTPN = false;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm chi tiết phiếu nhập " + ex.Message, "", MessageBoxButtons.OK);
                        bdsCTPN.Position = vitri;
                        return;
                    }
                }    
            }
            else
            {
                vitri = bdsCTPN.Position;
                if (MessageBox.Show("Bạn thật sự muốn lưu chi tiết phiếu nhập này?", "Xác nhận", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    try
                    {
                        bdsCTPN.EndEdit();
                        bdsCTPN.ResetCurrentItem();
                        this.cTPNTableAdapter.Connection.ConnectionString = Program.connectionString;
                        this.cTPNTableAdapter.Update(this.dS.CTPN);
                        MessageBox.Show("Hiệu chỉnh thành công!", "", MessageBoxButtons.OK);
                        gcCTPN.Enabled = gcPN.Enabled = true;
                        panelControl2.Enabled = false;
                        btnHieuChinh.Enabled = btnPhucHoi.Enabled = btnthem.Enabled = btnThoat.Enabled
                            = btnXoa.Enabled = btnReset.Enabled = true;
                        sbtnHieuChinh.Enabled = sbtnXoa.Enabled = sbtnThem.Enabled = true;
                        sbtnPhucHoi.Enabled = sbtnLuu.Enabled = false;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lỗi lưu chi tiết phiếu nhập " + ex.Message, "", MessageBoxButtons.OK);
                        bdsVT.Position = vitri;
                        return;
                    }
                    
                }
            }    
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bdsCTPN.CancelEdit();
            bdsCTPN.Position = vitri;
            gcCTPN.Enabled = gcPN.Enabled = true;
            btnHieuChinh.Enabled = btnthem.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReset.Enabled = btnPhucHoi.Enabled = true;
            sbtnHieuChinh.Enabled = sbtnThem.Enabled = sbtnXoa.Enabled = true;
            sbtnLuu.Enabled = sbtnPhucHoi.Enabled = false;
            panelControl2.Enabled = false;
         }
    }
}
