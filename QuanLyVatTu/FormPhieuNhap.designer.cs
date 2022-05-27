
namespace QuanLyVatTu
{
    partial class FormPhieuNhap
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAPNLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuNhap));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnthem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReset = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnIDSNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamLai = new DevExpress.XtraBars.BarButtonItem();
            this.bsChonCheDo = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QuanLyVatTu.DS();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QuanLyVatTu.DSTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QuanLyVatTu.DSTableAdapters.TableAdapterManager();
            this.cTPNTableAdapter = new QuanLyVatTu.DSTableAdapters.CTPNTableAdapter();
            this.gcPN = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtMaPN_CTPN = new System.Windows.Forms.TextBox();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.seDonGiaCTPN = new DevExpress.XtraEditors.SpinEdit();
            this.nnSoLuong = new System.Windows.Forms.NumericUpDown();
            this.ccbMaVT = new System.Windows.Forms.ComboBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.cbbTenKho = new System.Windows.Forms.ComboBox();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.cbbMaSoDDH = new System.Windows.Forms.ComboBox();
            this.cbbHoTenNV = new System.Windows.Forms.ComboBox();
            this.bdsHoTenNV = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.deNgay = new DevExpress.XtraEditors.DateEdit();
            this.teMaPN = new DevExpress.XtraEditors.TextEdit();
            this.hoTenNVTableAdapter = new QuanLyVatTu.DSTableAdapters.HoTenNVTableAdapter();
            this.khoTableAdapter = new QuanLyVatTu.DSTableAdapters.KhoTableAdapter();
            this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QuanLyVatTu.DSTableAdapters.VattuTableAdapter();
            this.bdsMaSoDDH = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.sbtnPhucHoi = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnHieuChinh = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gcCTPN = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edCbbMaVT = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAPNLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDonGiaCTPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nnSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTenNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMaSoDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCbbMaVT)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(19, 80);
            mAPNLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(48, 17);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "MAPN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(411, 80);
            nGAYLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(47, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(410, 190);
            mANVLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "MANV:";
            mANVLabel.Click += new System.EventHandler(this.mANVLabel_Click);
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(1105, 186);
            mAKHOLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(58, 17);
            mAKHOLabel.TabIndex = 12;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(14, 190);
            hOTENLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(57, 17);
            hOTENLabel.TabIndex = 14;
            hOTENLabel.Text = "HOTEN:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(1042, 74);
            masoDDHLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(77, 17);
            masoDDHLabel.TabIndex = 15;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(748, 189);
            tENKHOLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(65, 17);
            tENKHOLabel.TabIndex = 16;
            tENKHOLabel.Text = "TENKHO:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(331, 364);
            mAVTLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(47, 17);
            mAVTLabel.TabIndex = 19;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(690, 358);
            sOLUONGLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(75, 17);
            sOLUONGLabel.TabIndex = 22;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(1086, 362);
            dONGIALabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(63, 17);
            dONGIALabel.TabIndex = 23;
            dONGIALabel.Text = "DONGIA:";
            // 
            // mAPNLabel1
            // 
            mAPNLabel1.AutoSize = true;
            mAPNLabel1.Location = new System.Drawing.Point(31, 362);
            mAPNLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mAPNLabel1.Name = "mAPNLabel1";
            mAPNLabel1.Size = new System.Drawing.Size(48, 17);
            mAPNLabel1.TabIndex = 24;
            mAPNLabel1.Text = "MAPN:";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnthem,
            this.barButtonItem1,
            this.btnHieuChinh,
            this.btnXoa,
            this.btnLuu,
            this.btnPhucHoi,
            this.barButtonItem6,
            this.barButtonItem7,
            this.btnIDSNV,
            this.btnThoat,
            this.btnLamLai,
            this.btnReset,
            this.bsChonCheDo,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 16;
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnthem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReset, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.Text = "Tools";
            // 
            // btnthem
            // 
            this.btnthem.Caption = "Thêm";
            this.btnthem.Id = 0;
            this.btnthem.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_add_48;
            this.btnthem.Name = "btnthem";
            this.btnthem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthem_ItemClick);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_edit_text_file_48;
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinh_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 3;
            this.btnXoa.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_remove_48;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Enabled = false;
            this.btnLuu.Id = 4;
            this.btnLuu.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_save_48;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 5;
            this.btnPhucHoi.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.Undo_icon__1_;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReset
            // 
            this.btnReset.Caption = "reset";
            this.btnReset.Id = 12;
            this.btnReset.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.Button_Refresh_icon;
            this.btnReset.Name = "btnReset";
            this.btnReset.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReset_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 10;
            this.btnThoat.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.inside_logout_icon;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(1370, 70);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 750);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1370, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 70);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 680);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1370, 70);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 680);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Thoát";
            this.barButtonItem7.Id = 8;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btnIDSNV
            // 
            this.btnIDSNV.Caption = "In danh sách nhân viên";
            this.btnIDSNV.Id = 9;
            this.btnIDSNV.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.Print_icon;
            this.btnIDSNV.Name = "btnIDSNV";
            // 
            // btnLamLai
            // 
            this.btnLamLai.Caption = "Làm lại";
            this.btnLamLai.Id = 11;
            this.btnLamLai.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.Redo_icon;
            this.btnLamLai.Name = "btnLamLai";
            // 
            // bsChonCheDo
            // 
            this.bsChonCheDo.Caption = "Chọn chế độ";
            this.bsChonCheDo.Id = 13;
            this.bsChonCheDo.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_single_choice_48;
            this.bsChonCheDo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bsChonCheDo.Name = "bsChonCheDo";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Phiếu Nhập";
            this.barButtonItem2.Id = 14;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Chi Tiết Phiếu Nhập";
            this.barButtonItem3.Id = 15;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 70);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1370, 120);
            this.panelControl1.TabIndex = 5;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(290, 51);
            this.cbbChiNhanh.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(1019, 24);
            this.cbbChiNhanh.TabIndex = 1;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "PhieuNhap";
            this.bdsPN.DataSource = this.dS;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTu.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // gcPN
            // 
            this.gcPN.DataSource = this.bdsPN;
            this.gcPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gcPN.Location = new System.Drawing.Point(0, 190);
            this.gcPN.MainView = this.gridView1;
            this.gcPN.Margin = new System.Windows.Forms.Padding(5);
            this.gcPN.MenuManager = this.barManager1;
            this.gcPN.Name = "gcPN";
            this.gcPN.Size = new System.Drawing.Size(1370, 315);
            this.gcPN.TabIndex = 10;
            this.gcPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcPN;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "Mã Phiếu Nhập";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 25;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày Lập Phiếu";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã Số Đơn Đặt Hàng";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            this.colMasoDDH.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã Nhân Viên ";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(mAPNLabel1);
            this.panelControl2.Controls.Add(this.txtMaPN_CTPN);
            this.panelControl2.Controls.Add(dONGIALabel);
            this.panelControl2.Controls.Add(this.seDonGiaCTPN);
            this.panelControl2.Controls.Add(sOLUONGLabel);
            this.panelControl2.Controls.Add(this.nnSoLuong);
            this.panelControl2.Controls.Add(mAVTLabel);
            this.panelControl2.Controls.Add(this.ccbMaVT);
            this.panelControl2.Controls.Add(this.separatorControl1);
            this.panelControl2.Controls.Add(tENKHOLabel);
            this.panelControl2.Controls.Add(this.cbbTenKho);
            this.panelControl2.Controls.Add(masoDDHLabel);
            this.panelControl2.Controls.Add(this.cbbMaSoDDH);
            this.panelControl2.Controls.Add(hOTENLabel);
            this.panelControl2.Controls.Add(this.cbbHoTenNV);
            this.panelControl2.Controls.Add(mAKHOLabel);
            this.panelControl2.Controls.Add(this.txtMaKho);
            this.panelControl2.Controls.Add(mANVLabel);
            this.panelControl2.Controls.Add(this.txtMaNV);
            this.panelControl2.Controls.Add(nGAYLabel);
            this.panelControl2.Controls.Add(this.deNgay);
            this.panelControl2.Controls.Add(mAPNLabel);
            this.panelControl2.Controls.Add(this.teMaPN);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 505);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1461, 245);
            this.panelControl2.TabIndex = 11;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // txtMaPN_CTPN
            // 
            this.txtMaPN_CTPN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "MAPN", true));
            this.txtMaPN_CTPN.Enabled = false;
            this.txtMaPN_CTPN.Location = new System.Drawing.Point(115, 358);
            this.txtMaPN_CTPN.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaPN_CTPN.Name = "txtMaPN_CTPN";
            this.txtMaPN_CTPN.Size = new System.Drawing.Size(154, 23);
            this.txtMaPN_CTPN.TabIndex = 25;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsCTPN.DataSource = this.bdsPN;
            // 
            // seDonGiaCTPN
            // 
            this.seDonGiaCTPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "DONGIA", true));
            this.seDonGiaCTPN.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDonGiaCTPN.Location = new System.Drawing.Point(1194, 358);
            this.seDonGiaCTPN.Margin = new System.Windows.Forms.Padding(5);
            this.seDonGiaCTPN.MenuManager = this.barManager1;
            this.seDonGiaCTPN.Name = "seDonGiaCTPN";
            this.seDonGiaCTPN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seDonGiaCTPN.Size = new System.Drawing.Size(195, 24);
            this.seDonGiaCTPN.TabIndex = 24;
            // 
            // nnSoLuong
            // 
            this.nnSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTPN, "SOLUONG", true));
            this.nnSoLuong.Location = new System.Drawing.Point(818, 358);
            this.nnSoLuong.Margin = new System.Windows.Forms.Padding(5);
            this.nnSoLuong.Name = "nnSoLuong";
            this.nnSoLuong.Size = new System.Drawing.Size(188, 23);
            this.nnSoLuong.TabIndex = 23;
            // 
            // ccbMaVT
            // 
            this.ccbMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPN, "MAVT", true));
            this.ccbMaVT.FormattingEnabled = true;
            this.ccbMaVT.Location = new System.Drawing.Point(414, 352);
            this.ccbMaVT.Margin = new System.Windows.Forms.Padding(5);
            this.ccbMaVT.Name = "ccbMaVT";
            this.ccbMaVT.Size = new System.Drawing.Size(186, 24);
            this.ccbMaVT.TabIndex = 20;
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Near;
            this.separatorControl1.Location = new System.Drawing.Point(40, 275);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(5);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(14);
            this.separatorControl1.Size = new System.Drawing.Size(1349, 30);
            this.separatorControl1.TabIndex = 18;
            this.separatorControl1.Click += new System.EventHandler(this.separatorControl1_Click);
            // 
            // cbbTenKho
            // 
            this.cbbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "TENKHO", true));
            this.cbbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPN, "MAKHO", true));
            this.cbbTenKho.DataSource = this.bdsKho;
            this.cbbTenKho.DisplayMember = "TENKHO";
            this.cbbTenKho.FormattingEnabled = true;
            this.cbbTenKho.Location = new System.Drawing.Point(858, 185);
            this.cbbTenKho.Margin = new System.Windows.Forms.Padding(5);
            this.cbbTenKho.Name = "cbbTenKho";
            this.cbbTenKho.Size = new System.Drawing.Size(186, 24);
            this.cbbTenKho.TabIndex = 17;
            this.cbbTenKho.ValueMember = "MAKHO";
            this.cbbTenKho.SelectedIndexChanged += new System.EventHandler(this.cbbTenKho_SelectedIndexChanged);
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.dS;
            // 
            // cbbMaSoDDH
            // 
            this.cbbMaSoDDH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MasoDDH", true));
            this.cbbMaSoDDH.FormattingEnabled = true;
            this.cbbMaSoDDH.Location = new System.Drawing.Point(1172, 69);
            this.cbbMaSoDDH.Margin = new System.Windows.Forms.Padding(5);
            this.cbbMaSoDDH.Name = "cbbMaSoDDH";
            this.cbbMaSoDDH.Size = new System.Drawing.Size(186, 24);
            this.cbbMaSoDDH.TabIndex = 16;
            // 
            // cbbHoTenNV
            // 
            this.cbbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoTenNV, "HOTEN", true));
            this.cbbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPN, "MANV", true));
            this.cbbHoTenNV.DataSource = this.bdsHoTenNV;
            this.cbbHoTenNV.DisplayMember = "HOTEN";
            this.cbbHoTenNV.FormattingEnabled = true;
            this.cbbHoTenNV.Location = new System.Drawing.Point(138, 186);
            this.cbbHoTenNV.Margin = new System.Windows.Forms.Padding(5);
            this.cbbHoTenNV.Name = "cbbHoTenNV";
            this.cbbHoTenNV.Size = new System.Drawing.Size(186, 24);
            this.cbbHoTenNV.TabIndex = 15;
            this.cbbHoTenNV.ValueMember = "MANV";
            this.cbbHoTenNV.SelectedIndexChanged += new System.EventHandler(this.cbbHoTenNV_SelectedIndexChanged_1);
            // 
            // bdsHoTenNV
            // 
            this.bdsHoTenNV.DataMember = "HoTenNV";
            this.bdsHoTenNV.DataSource = this.dS;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MAKHO", true));
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Location = new System.Drawing.Point(1205, 180);
            this.txtMaKho.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(154, 23);
            this.txtMaKho.TabIndex = 13;
            this.txtMaKho.TextChanged += new System.EventHandler(this.txtMaKho_TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(495, 186);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(154, 23);
            this.txtMaNV.TabIndex = 9;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // deNgay
            // 
            this.deNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "NGAY", true));
            this.deNgay.EditValue = null;
            this.deNgay.Location = new System.Drawing.Point(511, 75);
            this.deNgay.Margin = new System.Windows.Forms.Padding(5);
            this.deNgay.MenuManager = this.barManager1;
            this.deNgay.Name = "deNgay";
            this.deNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgay.Size = new System.Drawing.Size(238, 22);
            this.deNgay.TabIndex = 3;
            // 
            // teMaPN
            // 
            this.teMaPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MAPN", true));
            this.teMaPN.Location = new System.Drawing.Point(138, 75);
            this.teMaPN.Margin = new System.Windows.Forms.Padding(5);
            this.teMaPN.MenuManager = this.barManager1;
            this.teMaPN.Name = "teMaPN";
            this.teMaPN.Size = new System.Drawing.Size(195, 22);
            this.teMaPN.TabIndex = 1;
            // 
            // hoTenNVTableAdapter
            // 
            this.hoTenNVTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // bdsVT
            // 
            this.bdsVT.DataMember = "Vattu";
            this.bdsVT.DataSource = this.dS;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // bdsMaSoDDH
            // 
            this.bdsMaSoDDH.DataMember = "MaSoDDH";
            this.bdsMaSoDDH.DataSource = this.dS;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.sbtnPhucHoi);
            this.panelControl3.Controls.Add(this.sbtnLuu);
            this.panelControl3.Controls.Add(this.sbtnHieuChinh);
            this.panelControl3.Controls.Add(this.sbtnXoa);
            this.panelControl3.Controls.Add(this.sbtnThem);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(1461, 505);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(0, 115);
            this.panelControl3.TabIndex = 40;
            // 
            // sbtnPhucHoi
            // 
            this.sbtnPhucHoi.Enabled = false;
            this.sbtnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnPhucHoi.ImageOptions.SvgImage")));
            this.sbtnPhucHoi.Location = new System.Drawing.Point(748, 28);
            this.sbtnPhucHoi.Margin = new System.Windows.Forms.Padding(5);
            this.sbtnPhucHoi.Name = "sbtnPhucHoi";
            this.sbtnPhucHoi.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnPhucHoi.Size = new System.Drawing.Size(180, 62);
            this.sbtnPhucHoi.TabIndex = 4;
            this.sbtnPhucHoi.Text = "Hoàn Tác ";
            this.sbtnPhucHoi.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // sbtnLuu
            // 
            this.sbtnLuu.Enabled = false;
            this.sbtnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnLuu.ImageOptions.SvgImage")));
            this.sbtnLuu.Location = new System.Drawing.Point(578, 28);
            this.sbtnLuu.Margin = new System.Windows.Forms.Padding(5);
            this.sbtnLuu.Name = "sbtnLuu";
            this.sbtnLuu.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnLuu.Size = new System.Drawing.Size(130, 62);
            this.sbtnLuu.TabIndex = 3;
            this.sbtnLuu.Text = "Lưu";
            this.sbtnLuu.Click += new System.EventHandler(this.sbtnLuu_Click);
            // 
            // sbtnHieuChinh
            // 
            this.sbtnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnHieuChinh.ImageOptions.SvgImage")));
            this.sbtnHieuChinh.Location = new System.Drawing.Point(355, 28);
            this.sbtnHieuChinh.Margin = new System.Windows.Forms.Padding(5);
            this.sbtnHieuChinh.Name = "sbtnHieuChinh";
            this.sbtnHieuChinh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnHieuChinh.Size = new System.Drawing.Size(185, 62);
            this.sbtnHieuChinh.TabIndex = 2;
            this.sbtnHieuChinh.Text = "Hiệu Chỉnh";
            this.sbtnHieuChinh.Click += new System.EventHandler(this.sbtnHieuChinh_Click);
            // 
            // sbtnXoa
            // 
            this.sbtnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnXoa.ImageOptions.SvgImage")));
            this.sbtnXoa.Location = new System.Drawing.Point(185, 28);
            this.sbtnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.sbtnXoa.Name = "sbtnXoa";
            this.sbtnXoa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnXoa.Size = new System.Drawing.Size(131, 62);
            this.sbtnXoa.TabIndex = 1;
            this.sbtnXoa.Text = "Xóa";
            this.sbtnXoa.Click += new System.EventHandler(this.sbtnXoa_Click);
            // 
            // sbtnThem
            // 
            this.sbtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnThem.ImageOptions.SvgImage")));
            this.sbtnThem.Location = new System.Drawing.Point(15, 28);
            this.sbtnThem.Margin = new System.Windows.Forms.Padding(5);
            this.sbtnThem.Name = "sbtnThem";
            this.sbtnThem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnThem.Size = new System.Drawing.Size(138, 62);
            this.sbtnThem.TabIndex = 0;
            this.sbtnThem.Text = "Thêm";
            this.sbtnThem.Click += new System.EventHandler(this.sbtnThem_Click);
            // 
            // gcCTPN
            // 
            this.gcCTPN.DataSource = this.bdsCTPN;
            this.gcCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPN.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5);
            this.gcCTPN.Location = new System.Drawing.Point(1461, 620);
            this.gcCTPN.MainView = this.gridView2;
            this.gcCTPN.Margin = new System.Windows.Forms.Padding(5);
            this.gcCTPN.MenuManager = this.barManager1;
            this.gcCTPN.Name = "gcCTPN";
            this.gcCTPN.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.edCbbMaVT});
            this.gcCTPN.Size = new System.Drawing.Size(0, 130);
            this.gcCTPN.TabIndex = 49;
            this.gcCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.gcCTPN;
            this.gridView2.Name = "gridView2";
            // 
            // colMAPN1
            // 
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.MinWidth = 25;
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            this.colMAPN1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.ColumnEdit = this.edCbbMaVT;
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // edCbbMaVT
            // 
            this.edCbbMaVT.AutoHeight = false;
            this.edCbbMaVT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.edCbbMaVT.Name = "edCbbMaVT";
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.gcCTPN);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcPN);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPhieuNhap";
            this.Text = "FormPhieuNhap";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDonGiaCTPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nnSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTenNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bdsMaSoDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edCbbMaVT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnthem;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReset;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btnIDSNV;
        private DevExpress.XtraBars.BarButtonItem btnLamLai;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.BindingSource bdsPN;
        private DS dS;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DevExpress.XtraEditors.DateEdit deNgay;
        private DevExpress.XtraEditors.TextEdit teMaPN;
        private System.Windows.Forms.BindingSource bdsHoTenNV;
        private DSTableAdapters.HoTenNVTableAdapter hoTenNVTableAdapter;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.BindingSource bdsKho;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.BindingSource bdsVT;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DevExpress.XtraBars.BarSubItem bsChonCheDo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.ComboBox cbbHoTenNV;
        private System.Windows.Forms.ComboBox cbbMaSoDDH;
        private System.Windows.Forms.BindingSource bdsMaSoDDH;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton sbtnLuu;
        private DevExpress.XtraEditors.SimpleButton sbtnHieuChinh;
        private DevExpress.XtraEditors.SimpleButton sbtnXoa;
        private DevExpress.XtraEditors.SimpleButton sbtnThem;
        private DevExpress.XtraGrid.GridControl gcCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox edCbbMaVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.ComboBox cbbTenKho;
        private System.Windows.Forms.ComboBox ccbMaVT;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.NumericUpDown nnSoLuong;
        private DevExpress.XtraEditors.SpinEdit seDonGiaCTPN;
        private System.Windows.Forms.TextBox txtMaPN_CTPN;
        private DevExpress.XtraEditors.SimpleButton sbtnPhucHoi;
        private System.Windows.Forms.Label label1;
    }
}