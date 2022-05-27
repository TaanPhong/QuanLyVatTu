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

namespace QuanLyVatTu
{
    public partial class FormDn : Form
    {
        private SqlConnection connPublisher = new SqlConnection();
        public FormDn()
        {
            InitializeComponent();
        }

        private void layDanhSachPhanManh(String cmd)
        {
            if (connPublisher.State == ConnectionState.Closed)
            {
                connPublisher.Open();
            }
            DataTable dt = new DataTable();
            // adapter dùng để đưa dữ liệu từ view sang database
            SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher);
            // dùng adapter thì mới đổ vào data table được
            da.Fill(dt);
            connPublisher.Close();
            Program.bindingSource.DataSource = dt;
            cmbCHINHANH.DataSource = Program.bindingSource;
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
        }
        
        //private Form CheckExists(Type ftype)
        //{
        //    foreach (Form f in this.MdiChildren)
        //        if (f.GetType() == ftype)
        //            return f;
        //    return null;
        //}
        private int KetNoiDatabaseGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connectionStringPublisher;
                connPublisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "" || txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            Program.loginName = txtTaiKhoan.Text;
            Program.password = txtMatKhau.Text;
            if (Program.KetNoi() == 0)
                return;
            Program.CN = cmbCHINHANH.SelectedIndex;
            Program.loginDN = Program.loginName;
            Program.passworDN = Program.password;
            String statement = "SP_DANGNHAP '" + Program.loginName + "'";// exec sp_DangNhap 'TP'
            Program.myReader = Program.ExecSqlDataReader(statement);
            if (Program.myReader == null)
                return;
            // đọc một dòng của myReader - điều này là hiển nhiên vì kết quả chỉ có 1 dùng duy nhất
            Program.myReader.Read();
            Program.userName = Program.myReader.GetString(0);// lấy userName
            //MessageBox.Show("ĐĂNG NHẬP");
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", "Thông Báo", MessageBoxButtons.OK);
            }
            Program.nameNV = Program.myReader.GetString(1);
            Program.role = Program.myReader.GetString(2);

            Program.myReader.Close();
            Program.con.Close();

            Program.formMain.MANV.Text ="Mã Nhân Viên: " + Program.userName;
            Program.formMain.HoTen.Text = "Họ Tên: " + Program.nameNV;
            Program.formMain.NHOM.Text = "Nhóm: " +Program.role;
            Program.formMain.HienThiMenu();

            this.Visible = false;
            Program.formMain.enabledBnt();
        }
        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cmbCHINHANH.SelectedValue.ToString();
               
            }
            catch (Exception)
            {

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        private void FormDn_Load(object sender, EventArgs e)
        {
            // đặt sẵn mật khẩu để đỡ nhập lại nhiều lần
            txtTaiKhoan.Text = "TT";// Trần Thanh- chi nhanh
            txtMatKhau.Text = "123456";
            if (KetNoiDatabaseGoc() == 0)
                return;
            //Lấy 2 cái đầu tiên của danh sách
            layDanhSachPhanManh("SELECT TOP 2 * FROM V_DS_PHANMANH");
            cmbCHINHANH.SelectedIndex = 0;
            cmbCHINHANH.SelectedIndex = 1;
            

        }

        private void btnHienMatKhau_CheckedChanged(object sender,EventArgs e)
        {
            if (btnHienMatKhau.Checked)
            {
                txtMatKhau.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.Properties.UseSystemPasswordChar = true;
            }
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
