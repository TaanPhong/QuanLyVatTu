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
    public partial class FormInDanhSanhNhanVien : Form
    {
        string macn = "";
        public FormInDanhSanhNhanVien()
        {
            InitializeComponent();
        }

        private void InDanhSanhNhanVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            cbbChiNhanh.DataSource = Program.bindingSource;
            cbbChiNhanh.DisplayMember = "TENCN";
            cbbChiNhanh.ValueMember = "TENSERVER";
            cbbChiNhanh.SelectedIndex = Program.CN;
            cbbChiNhanh.Enabled = false;
            if (Program.role == "CONGTY")
                cbbChiNhanh.Enabled = true;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.serverName = cbbChiNhanh.SelectedValue.ToString();
            if(Program.CN != cbbChiNhanh.SelectedIndex)
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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectionString;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }    
        }

        private void btnXemTruoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                macn = ((DataRowView)Program.bindingSource[cbbChiNhanh.SelectedIndex])["TENCN"].ToString();
                Console.WriteLine(macn);
                ReportInDanhSanhNhanVien report = new ReportInDanhSanhNhanVien();
                report.lbTenCN.Text = "Chi Nhánh: " + macn;
                ReportPrintTool print = new ReportPrintTool(report);
                print.ShowPreviewDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi xem báo trước báo cáo " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
