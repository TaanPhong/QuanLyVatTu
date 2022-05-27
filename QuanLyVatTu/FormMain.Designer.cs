
namespace QuanLyVatTu
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bntDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.bntNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.bntVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.bntKho = new DevExpress.XtraBars.BarButtonItem();
            this.bntLapPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.bnt = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bntCTPX = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bntHDNV = new DevExpress.XtraBars.BarButtonItem();
            this.bntTHNX = new DevExpress.XtraBars.BarButtonItem();
            this.bntDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.bntTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.bntThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnDDH = new DevExpress.XtraBars.BarButtonItem();
            this.pageTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HoTen,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 17, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1162, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(82, 17);
            this.MANV.Text = "Mã Nhân Viên";
            // 
            // HoTen
            // 
            this.HoTen.Name = "HoTen";
            this.HoTen.Size = new System.Drawing.Size(44, 17);
            this.HoTen.Text = "Họ Tên";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(41, 17);
            this.NHOM.Text = "Nhóm";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bntDangNhap,
            this.bntNhanVien,
            this.bntVatTu,
            this.bntKho,
            this.bntLapPhieu,
            this.bnt,
            this.barButtonItem3,
            this.bntCTPX,
            this.barButtonItem2,
            this.barButtonItem4,
            this.bntHDNV,
            this.bntTHNX,
            this.bntDangXuat,
            this.bntTaoTK,
            this.bntThoat,
            this.barSubItem1,
            this.btnPN,
            this.btnPX,
            this.btnDDH});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageTaiKhoan,
            this.pageNhanVien,
            this.pageBaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(1162, 158);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // bntDangNhap
            // 
            this.bntDangNhap.Caption = "Đăng Nhập";
            this.bntDangNhap.Id = 1;
            this.bntDangNhap.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.symbol_check_icon;
            this.bntDangNhap.LargeWidth = 100;
            this.bntDangNhap.Name = "bntDangNhap";
            this.bntDangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bntDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntDangNhap_ItemClick);
            // 
            // bntNhanVien
            // 
            this.bntNhanVien.Caption = "Nhân Viên";
            this.bntNhanVien.Id = 2;
            this.bntNhanVien.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_management_48;
            this.bntNhanVien.LargeWidth = 100;
            this.bntNhanVien.Name = "bntNhanVien";
            this.bntNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bntNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntNhanVien_ItemClick);
            // 
            // bntVatTu
            // 
            this.bntVatTu.Caption = "Vật Tư";
            this.bntVatTu.Id = 3;
            this.bntVatTu.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_open_box_48;
            this.bntVatTu.LargeWidth = 100;
            this.bntVatTu.Name = "bntVatTu";
            this.bntVatTu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bntVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntVatTu_ItemClick);
            // 
            // bntKho
            // 
            this.bntKho.Caption = "Kho";
            this.bntKho.Id = 5;
            this.bntKho.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_warehouse_48;
            this.bntKho.LargeWidth = 100;
            this.bntKho.Name = "bntKho";
            this.bntKho.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bntKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntKho_ItemClick);
            // 
            // bntLapPhieu
            // 
            this.bntLapPhieu.Caption = "Lập Phiếu";
            this.bntLapPhieu.Id = 6;
            this.bntLapPhieu.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_edit_text_file_48;
            this.bntLapPhieu.LargeWidth = 100;
            this.bntLapPhieu.Name = "bntLapPhieu";
            this.bntLapPhieu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bntLapPhieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntLapPhieu_ItemClick);
            // 
            // bnt
            // 
            this.bnt.Caption = "Danh Sách \r\nNhân Viên\r\n";
            this.bnt.Id = 7;
            this.bnt.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_management_48;
            this.bnt.LargeWidth = 100;
            this.bnt.Name = "bnt";
            this.bnt.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bnt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bnt_ItemClick);
            // 
            // barButtonItem3
            // 
           
            // bntCTPX
            // 
            this.bntCTPX.Caption = "Chi Tiết Nhập Xuất";
            this.bntCTPX.Id = 9;
            this.bntCTPX.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.Sales_report_icon;
            this.bntCTPX.LargeWidth = 100;
            this.bntCTPX.Name = "bntCTPX";
            this.bntCTPX.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bntCTPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntCTPX_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 10;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Đơn Đặt Hàng Chưa Phiếu Nhập";
            this.barButtonItem4.Id = 11;
            this.barButtonItem4.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_buying_48;
            this.barButtonItem4.LargeWidth = 100;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bntHDNV
            // 
            this.bntHDNV.Caption = "Hoạt Động Của Nhân Viên";
            this.bntHDNV.Id = 12;
            this.bntHDNV.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_name_tag_48;
            this.bntHDNV.LargeWidth = 100;
            this.bntHDNV.Name = "bntHDNV";
            this.bntHDNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bntHDNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntHDNV_ItemClick);
            // 
            // bntTHNX
            // 
            this.bntTHNX.Caption = "Tổng Hợp Nhập Xuất";
            this.bntTHNX.Id = 13;
            this.bntTHNX.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_analytics_48;
            this.bntTHNX.LargeWidth = 100;
            this.bntTHNX.Name = "bntTHNX";
            this.bntTHNX.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // bntDangXuat
            // 
            this.bntDangXuat.Caption = "Đăng Xuất";
            this.bntDangXuat.Enabled = false;
            this.bntDangXuat.Id = 14;
            this.bntDangXuat.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_logout_48;
            this.bntDangXuat.LargeWidth = 100;
            this.bntDangXuat.Name = "bntDangXuat";
            this.bntDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bntDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntDangXuat_ItemClick);
            // 
            // bntTaoTK
            // 
            this.bntTaoTK.Caption = "Tạo Tài Khoản";
            this.bntTaoTK.Enabled = false;
            this.bntTaoTK.Id = 15;
            this.bntTaoTK.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_add_48;
            this.bntTaoTK.LargeWidth = 100;
            this.bntTaoTK.Name = "bntTaoTK";
            this.bntTaoTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bntTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntTaoTK_ItemClick);
            // 
            // bntThoat
            // 
            this.bntThoat.Caption = "Thoát";
            this.bntThoat.Id = 16;
            this.bntThoat.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_cancel_48;
            this.bntThoat.LargeWidth = 100;
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.bntThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bntThoat_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Lập Phiếu";
            this.barSubItem1.Id = 18;
            this.barSubItem1.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_edit_text_file_48;
            this.barSubItem1.LargeWidth = 100;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPN),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPX),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDDH)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnPN
            // 
            this.btnPN.Caption = "Phiếu Nhập";
            this.btnPN.Id = 19;
            this.btnPN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPN.ImageOptions.SvgImage")));
            this.btnPN.Name = "btnPN";
            this.btnPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPN_ItemClick);
            // 
            // btnPX
            // 
            this.btnPX.Caption = "Phiếu Xuất";
            this.btnPX.Id = 20;
            this.btnPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPX.ImageOptions.SvgImage")));
            this.btnPX.Name = "btnPX";
            this.btnPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPX_ItemClick);
            // 
            // btnDDH
            // 
            this.btnDDH.Caption = "Đơn Đặt Hàng";
            this.btnDDH.Id = 21;
            this.btnDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDDH.ImageOptions.SvgImage")));
            this.btnDDH.Name = "btnDDH";
            this.btnDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDDH_ItemClick);
            // 
            // pageTaiKhoan
            // 
            this.pageTaiKhoan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.pageTaiKhoan.Name = "pageTaiKhoan";
            this.pageTaiKhoan.Text = "Tài Khoản";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bntDangNhap);
            this.ribbonPageGroup3.ItemLinks.Add(this.bntDangXuat);
            this.ribbonPageGroup3.ItemLinks.Add(this.bntTaoTK);
            this.ribbonPageGroup3.ItemLinks.Add(this.bntThoat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý tài khoản";
            // 
            // pageNhanVien
            // 
            this.pageNhanVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.pageNhanVien.Name = "pageNhanVien";
            this.pageNhanVien.Text = "Nhân Viên";
            this.pageNhanVien.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bntNhanVien);
            this.ribbonPageGroup1.ItemLinks.Add(this.bntVatTu);
            this.ribbonPageGroup1.ItemLinks.Add(this.bntKho);
            this.ribbonPageGroup1.ItemLinks.Add(this.barSubItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý nhân viên";
            // 
            // pageBaoCao
            // 
            this.pageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.pageBaoCao.Name = "pageBaoCao";
            this.pageBaoCao.Text = "Báo Cáo";
            this.pageBaoCao.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bnt);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.ItemLinks.Add(this.bntCTPX);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup2.ItemLinks.Add(this.bntHDNV);
            this.ribbonPageGroup2.ItemLinks.Add(this.bntTHNX);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý báo cáo";
            // 
            // FormMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 502);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bntDangNhap;
        private DevExpress.XtraBars.BarButtonItem bntNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageTaiKhoan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem bntVatTu;
        private DevExpress.XtraBars.BarButtonItem bntKho;
        private DevExpress.XtraBars.BarButtonItem bntLapPhieu;
        private DevExpress.XtraBars.BarButtonItem bnt;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem bntCTPX;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem bntHDNV;
        private DevExpress.XtraBars.BarButtonItem bntTHNX;
        private DevExpress.XtraBars.BarButtonItem bntDangXuat;
        private DevExpress.XtraBars.BarButtonItem bntTaoTK;
        private DevExpress.XtraBars.BarButtonItem bntThoat;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HoTen;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnPN;
        private DevExpress.XtraBars.BarButtonItem btnPX;
        private DevExpress.XtraBars.BarButtonItem btnDDH;
    }
}