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
    public partial class FormTaoLogin : Form
    {
        public FormTaoLogin()
        {
            InitializeComponent();
        }

        private void FormTaoLogin_Load(object sender, EventArgs e)
        {
            hoTenNVTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.hoTenNVTableAdapter.Fill(this.dS.HoTenNV);
            
            Dictionary<string, string> phu = new Dictionary<string, string>();
            phu.Add("Công ty", "CONGTY");
            phu.Add("Chi nhánh", "CHINHANH");
            phu.Add("Người dùng", "USER");
            QuyenComboBox.DataSource = new BindingSource(phu, null);
            QuyenComboBox.DisplayMember = "Key";
            QuyenComboBox.ValueMember = "Value";
            QuyenComboBox.SelectedIndex = 1;
            TenComboBox.SelectedIndex = 1;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = txtName.Text.Trim();
            String pass = txtPass.Text.Trim();
            String id = TenComboBox.SelectedValue.ToString();
            string role = ((KeyValuePair<string, string>)QuyenComboBox.SelectedItem).Value;

            if (name == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "", MessageBoxButtons.OK);
                txtName.Focus();
                return;
            }
            if(pass=="")
            {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "", MessageBoxButtons.OK);
                    txtPass.Focus();
                    return;  
            }
            String sql= "declare @status int "
                              + "exec @status = SP_TAOLOGIN '"
                              + name + "', '"
                              + pass + "',' "
                              + id +"', ' "
                              + role +" '"
                              + "select @status";
            
            Program.myReader = Program.ExecSqlDataReader(sql);
            Program.myReader.Read();
            int status = int.Parse(Program.myReader.GetValue(0).ToString());
            if(status == 1)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "", MessageBoxButtons.OK);
                txtName.Focus();
                return;
            }
            if(status == 2)
            {
                MessageBox.Show("Người dùng đã có tài khoản!", "", MessageBoxButtons.OK);
                TenComboBox.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);
                TenComboBox.Focus();
                return;
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
