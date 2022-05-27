using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyVatTu
{
    /*
    * Lý do bắt buộc phải viết biến tại đây là chỉ khi ta mở form
    * thì các biến nằm trong form đó mới hình thành, dù biến đó có tầm hoạt 
    * động toàn dự án nhưng khi cái form nào đóng lại thì các biến cũng biến mất
    * Do đó, form khác sẽ không hiểu các biến của form đã đóng nữa. Để phục vụ nhu cầu
    * xuyên suốt thì phải khai báo tại đây
    * 
    * Data Source= DESKTOP-2HMOH0N: tên server chủ, DESKTOP-K1O601Q\SERVERMAIN server của máy Mạnh
    * Initial Catalog=QLVT: tên cơ sở dữ liệu
    * Integrated Security=true: đăng nhập với chế độ Window Authentication
    * 
    * public static = biến toàn cục dự án
    */
    static class Program
    {
        /**********************************************
         * con: biến để kết nối tới cơ sở dữ liệu
         * connectionString: connection String , chuỗi kết nối động
         * dataReader: 
         **********************************************/
        public static SqlConnection con = new SqlConnection();
        public static string connectionString = "";
        // lấy danh sách server phân mảnh.
        public static string connectionStringPublisher = @"Data Source = DESKTOP-2HMOH0N; Initial Catalog = QLVT; Integrated Security = true";
        public static SqlDataReader myReader; // myRead

        /**********************************************
         * serverName: tên server sẽ kết nối tới
         * userName: tên userName
         * password: mật khẩu
         * loginName: tên đăng nhập
         * password: mật khẩu
        **********************************************/

        public static string serverName = "";
        public static string userName = "";
        public static string database = "QLVT";
        public static string loginName = "";
        public static string password = "";


        public static string remoteLogin = "HTKN"; // Để khi đã đăng nhập vào server phân mảnh và muốn 
        public static string remotePassword = "123456"; // truy cập qua sv phân mảnh khác bằng tài khoản HTKN
        public static string loginDN = "";
        public static string passworDN = "";

        public static BindingSource bindingSource = new BindingSource();

        /*
         * role: tên nhóm quyền truy cập: CongTy-ChiNhanh-User.
         * nameNV: Họ tên nhân viên;
         * CN: chi nhánh;
         */
        public static string role;
        public static string nameNV;
        public static int CN;
        /*các form của toàn dữ án cũng được coi như 1 một biến toàn cục*/
        public static FormMain formMain;
        public static FormNhanVien formNhanVien;
        public static FormDn formDn;
        public static FormKho formKho;
        public static FormDatHang formDatHang;
        public static FormPhieuNhap formPhieuNhap;
        public static FormPhieuXuat formPhieuXuat;
        public static FormVatTu formVatTu;
        public static FormTaoLogin formTaoLogin;
        public static FormInDanhSanhNhanVien formIDSNV;
        public static FormInBangKeChiTietSL_TriGiaNhapXuat formCTSL_TGNX;
        public static FormBaoCaoTinhTrangHoatDongCuaNVTheoThang formBCTTHDNV;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static int KetNoi()
        {
            if (Program.con != null && Program.con.State == ConnectionState.Open)
                Program.con.Close();
            try
            {
                Program.connectionString = "Data Source=" + Program.serverName + ";Initial Catalog=" +
                       Program.database + ";User ID=" +
                       Program.loginName + ";password=" + Program.password;
                Program.con.ConnectionString = Program.connectionString;

                Program.con.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " + e.Message, "", MessageBoxButtons.OK);
                //Console.WriteLine(e.Message);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.con);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                Program.con.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.Fill(dt);
            Program.con.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(string strLenh)
        {
            SqlCommand sqlCmd = new SqlCommand(strLenh, Program.con);
            sqlCmd.CommandType = CommandType.Text;
            if (Program.con.State == ConnectionState.Closed)
                Program.con.Open();
            try
            {
                // yêu cầu sp chạy tự động bên csdl và không nhận kết quả trả về
                sqlCmd.ExecuteNonQuery();
                //con.Close();
                return 0;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK);
                Program.con.Close();
                return ex.State; // trạng thái lỗi gửi từ RAISERROR trong SQL Server qua
            }
        }

        [STAThread]
        static void Main()
        {  

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formTaoLogin = new FormTaoLogin();
            formMain = new FormMain();
            Application.Run(formMain);
        }
    }
}
