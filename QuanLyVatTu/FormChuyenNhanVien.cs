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

namespace QuanLyVatTu
{
    public partial class FormChuyenNhanVien : Form
    {
        string macn = "";
        public FormChuyenNhanVien()
        {
            InitializeComponent();
        }

        private void FormChuyenNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            DataTable dt = new DataTable();
            string strLenh = "select * from V_DS_ChiNHanh";
            SqlDataAdapter da = new SqlDataAdapter(strLenh, Program.con);
            da.Fill(dt);
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            cbbChiNhanh.DataSource = bds;
            cbbChiNhanh.DisplayMember = "ChiNhanh";
            cbbChiNhanh.ValueMember = "MACN";
            cbbChiNhanh.SelectedIndex = Program.CN;
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            Console.WriteLine(macn);
            macn = cbbChiNhanh.SelectedValue.ToString();
            if (Program.maCN == macn)
            {
                MessageBox.Show("Nhân viên đang làm việc tại chi nhánh này không thể chuyển!","", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn thật sự muốn chuyển chi nhanh làm việc của nhân viên này?", "Xác Nhận", MessageBoxButtons.OKCancel)
                    == DialogResult.OK)
                {
                    string lenh = "exec SP_ChuyenChiNhanh " + Program.maNV + ", '" + macn.Trim() + "'";
                    if(Program.KetNoi_ChuyenChiNhanh() == 0)
                    {
                        MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu!", "", MessageBoxButtons.OK);
                        return;
                    }    
                    Console.WriteLine(lenh);
                    int status = Program.ExecSqlNonQuery(lenh);
                    if(Program.KetNoi() == 0)
                    {
                        MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu!", "", MessageBoxButtons.OK);
                        return;
                    }    
                    if (status == 0)
                    {
                        MessageBox.Show("Chuyển thành công!", "", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi chuyển chi nhánh!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                    return;
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
