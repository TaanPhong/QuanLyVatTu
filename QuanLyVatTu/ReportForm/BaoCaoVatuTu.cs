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

namespace QuanLyVatTu.ReportForm
{
    public partial class BaoCaoVatuTu : Form
    {
        public BaoCaoVatuTu()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barDockControlTop_Click(object sender, EventArgs e)
        {

        }

        private void BaoCaoVatuTu_Load(object sender, EventArgs e)
        {
            this.vattuTableAdapter.Connection.ConnectionString = Program.connectionString;
            this.vattuTableAdapter.Fill(this.dS.Vattu);

        }

        private void btnXemTruoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                ReportVatTu report = new ReportVatTu();
                ReportPrintTool print = new ReportPrintTool(report);
                print.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xem báo cáo" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
 }

