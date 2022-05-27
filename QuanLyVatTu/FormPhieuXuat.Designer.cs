
namespace QuanLyVatTu
{
    partial class FormPhieuXuat
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mAPXLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuXuat));
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
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QuanLyVatTu.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QuanLyVatTu.DSTableAdapters.TableAdapterManager();
            this.cTPXTableAdapter = new QuanLyVatTu.DSTableAdapters.CTPXTableAdapter();
            this.khoTableAdapter = new QuanLyVatTu.DSTableAdapters.KhoTableAdapter();
            this.gcPX = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.seDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.nmSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbMaVT = new System.Windows.Forms.ComboBox();
            this.txtMaPX_CTPX = new System.Windows.Forms.TextBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKho = new System.Windows.Forms.TextBox();
            this.cbbTenKho = new System.Windows.Forms.ComboBox();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cbbHoTenNV = new System.Windows.Forms.ComboBox();
            this.bdsHoTenNV = new System.Windows.Forms.BindingSource(this.components);
            this.deNgay = new DevExpress.XtraEditors.DateEdit();
            this.teMaPX = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.sbtnHoanTac = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnHieuChinh = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gcCTPX = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cedMaVT = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkMaVaTu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.hoTenNVTableAdapter = new QuanLyVatTu.DSTableAdapters.HoTenNVTableAdapter();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new QuanLyVatTu.DSTableAdapters.VattuTableAdapter();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mAPXLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTenNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cedMaVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMaVaTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(19, 30);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(47, 17);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "MAPX:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(247, 30);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(47, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(19, 103);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(57, 17);
            hOTENLabel.TabIndex = 6;
            hOTENLabel.Text = "HOTEN:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(245, 103);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 8;
            mANVLabel.Text = "MANV:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(428, 105);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(65, 17);
            tENKHOLabel.TabIndex = 9;
            tENKHOLabel.Text = "TENKHO:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(659, 105);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(58, 17);
            mAKHOLabel.TabIndex = 10;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(516, 31);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(74, 17);
            hOTENKHLabel.TabIndex = 12;
            hOTENKHLabel.Text = "HOTENKH:";
            // 
            // mAPXLabel1
            // 
            mAPXLabel1.AutoSize = true;
            mAPXLabel1.Location = new System.Drawing.Point(16, 222);
            mAPXLabel1.Name = "mAPXLabel1";
            mAPXLabel1.Size = new System.Drawing.Size(47, 17);
            mAPXLabel1.TabIndex = 19;
            mAPXLabel1.Text = "MAPX:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(196, 222);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(47, 17);
            mAVTLabel.TabIndex = 20;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(419, 220);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(75, 17);
            sOLUONGLabel.TabIndex = 21;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(667, 222);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(63, 17);
            dONGIALabel.TabIndex = 22;
            dONGIALabel.Text = "DONGIA:";
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
            this.btnthem.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_add_user_male_48;
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
            this.btnXoa.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_denied_48;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1371, 70);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 727);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1371, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 70);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 657);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1371, 70);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 657);
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
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1371, 85);
            this.panelControl1.TabIndex = 6;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(187, 33);
            this.cbbChiNhanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(655, 24);
            this.cbbChiNhanh.TabIndex = 1;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            // bdsPX
            // 
            this.bdsPX.DataMember = "PhieuXuat";
            this.bdsPX.DataSource = this.dS;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.cTPXTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTu.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPXTableAdapter
            // 
            this.cTPXTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // gcPX
            // 
            this.gcPX.DataSource = this.bdsPX;
            this.gcPX.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcPX.Location = new System.Drawing.Point(0, 155);
            this.gcPX.MainView = this.gridView1;
            this.gcPX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcPX.MenuManager = this.barManager1;
            this.gcPX.Name = "gcPX";
            this.gcPX.Size = new System.Drawing.Size(1371, 201);
            this.gcPX.TabIndex = 7;
            this.gcPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMAKHO,
            this.colMANV});
            this.gridView1.GridControl = this.gcPX;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã Phiếu Xuất";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.MinWidth = 25;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 93;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày Lập Phiếu";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 93;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Họ Tên Khách Hàng";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 25;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            this.colHOTENKH.Width = 93;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 3;
            this.colMAKHO.Width = 93;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã Nhân Viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 4;
            this.colMANV.Width = 93;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(dONGIALabel);
            this.panelControl2.Controls.Add(this.seDonGia);
            this.panelControl2.Controls.Add(sOLUONGLabel);
            this.panelControl2.Controls.Add(this.nmSoLuong);
            this.panelControl2.Controls.Add(mAVTLabel);
            this.panelControl2.Controls.Add(this.cbbMaVT);
            this.panelControl2.Controls.Add(mAPXLabel1);
            this.panelControl2.Controls.Add(this.txtMaPX_CTPX);
            this.panelControl2.Controls.Add(this.separatorControl1);
            this.panelControl2.Controls.Add(hOTENKHLabel);
            this.panelControl2.Controls.Add(this.txtHoTenKH);
            this.panelControl2.Controls.Add(mAKHOLabel);
            this.panelControl2.Controls.Add(this.txtMaKho);
            this.panelControl2.Controls.Add(tENKHOLabel);
            this.panelControl2.Controls.Add(this.cbbTenKho);
            this.panelControl2.Controls.Add(mANVLabel);
            this.panelControl2.Controls.Add(this.txtMaNV);
            this.panelControl2.Controls.Add(hOTENLabel);
            this.panelControl2.Controls.Add(this.cbbHoTenNV);
            this.panelControl2.Controls.Add(nGAYLabel);
            this.panelControl2.Controls.Add(this.deNgay);
            this.panelControl2.Controls.Add(mAPXLabel);
            this.panelControl2.Controls.Add(this.teMaPX);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Enabled = false;
            this.panelControl2.Location = new System.Drawing.Point(0, 356);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(925, 371);
            this.panelControl2.TabIndex = 8;
            // 
            // seDonGia
            // 
            this.seDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPX, "DONGIA", true));
            this.seDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDonGia.Location = new System.Drawing.Point(735, 219);
            this.seDonGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seDonGia.MenuManager = this.barManager1;
            this.seDonGia.Name = "seDonGia";
            this.seDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seDonGia.Size = new System.Drawing.Size(125, 24);
            this.seDonGia.TabIndex = 23;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_PX";
            this.bdsCTPX.DataSource = this.bdsPX;
            // 
            // nmSoLuong
            // 
            this.nmSoLuong.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTPX, "SOLUONG", true));
            this.nmSoLuong.Location = new System.Drawing.Point(499, 220);
            this.nmSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmSoLuong.Name = "nmSoLuong";
            this.nmSoLuong.Size = new System.Drawing.Size(120, 23);
            this.nmSoLuong.TabIndex = 22;
            // 
            // cbbMaVT
            // 
            this.cbbMaVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "MAVT", true));
            this.cbbMaVT.FormattingEnabled = true;
            this.cbbMaVT.Location = new System.Drawing.Point(249, 219);
            this.cbbMaVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaVT.Name = "cbbMaVT";
            this.cbbMaVT.Size = new System.Drawing.Size(121, 24);
            this.cbbMaVT.TabIndex = 21;
            // 
            // txtMaPX_CTPX
            // 
            this.txtMaPX_CTPX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCTPX, "MAPX", true));
            this.txtMaPX_CTPX.Enabled = false;
            this.txtMaPX_CTPX.Location = new System.Drawing.Point(69, 219);
            this.txtMaPX_CTPX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPX_CTPX.Name = "txtMaPX_CTPX";
            this.txtMaPX_CTPX.Size = new System.Drawing.Size(100, 23);
            this.txtMaPX_CTPX.TabIndex = 20;
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Near;
            this.separatorControl1.Location = new System.Drawing.Point(21, 169);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(848, 18);
            this.separatorControl1.TabIndex = 19;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "HOTENKH", true));
            this.txtHoTenKH.Location = new System.Drawing.Point(596, 28);
            this.txtHoTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(143, 23);
            this.txtHoTenKH.TabIndex = 13;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MAKHO", true));
            this.txtMaKho.Location = new System.Drawing.Point(723, 101);
            this.txtMaKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.ReadOnly = true;
            this.txtMaKho.Size = new System.Drawing.Size(100, 23);
            this.txtMaKho.TabIndex = 11;
            // 
            // cbbTenKho
            // 
            this.cbbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "TENKHO", true));
            this.cbbTenKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPX, "MAKHO", true));
            this.cbbTenKho.DataSource = this.bdsKho;
            this.cbbTenKho.DisplayMember = "TENKHO";
            this.cbbTenKho.FormattingEnabled = true;
            this.cbbTenKho.Location = new System.Drawing.Point(499, 102);
            this.cbbTenKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTenKho.Name = "cbbTenKho";
            this.cbbTenKho.Size = new System.Drawing.Size(121, 24);
            this.cbbTenKho.TabIndex = 10;
            this.cbbTenKho.ValueMember = "MAKHO";
            this.cbbTenKho.SelectedIndexChanged += new System.EventHandler(this.cbbTenKho_SelectedIndexChanged);
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.dS;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPX, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(300, 100);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(100, 23);
            this.txtMaNV.TabIndex = 9;
            // 
            // cbbHoTenNV
            // 
            this.cbbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoTenNV, "HOTEN", true));
            this.cbbHoTenNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPX, "MANV", true));
            this.cbbHoTenNV.DataSource = this.bdsHoTenNV;
            this.cbbHoTenNV.DisplayMember = "HOTEN";
            this.cbbHoTenNV.FormattingEnabled = true;
            this.cbbHoTenNV.Location = new System.Drawing.Point(83, 100);
            this.cbbHoTenNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbHoTenNV.Name = "cbbHoTenNV";
            this.cbbHoTenNV.Size = new System.Drawing.Size(121, 24);
            this.cbbHoTenNV.TabIndex = 7;
            this.cbbHoTenNV.ValueMember = "MANV";
            this.cbbHoTenNV.SelectedIndexChanged += new System.EventHandler(this.hOTENComboBox_SelectedIndexChanged);
            // 
            // bdsHoTenNV
            // 
            this.bdsHoTenNV.DataMember = "HoTenNV";
            this.bdsHoTenNV.DataSource = this.dS;
            // 
            // deNgay
            // 
            this.deNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "NGAY", true));
            this.deNgay.EditValue = null;
            this.deNgay.Location = new System.Drawing.Point(300, 27);
            this.deNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deNgay.MenuManager = this.barManager1;
            this.deNgay.Name = "deNgay";
            this.deNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgay.Size = new System.Drawing.Size(117, 22);
            this.deNgay.TabIndex = 3;
            // 
            // teMaPX
            // 
            this.teMaPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MAPX", true));
            this.teMaPX.Location = new System.Drawing.Point(83, 25);
            this.teMaPX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.teMaPX.MenuManager = this.barManager1;
            this.teMaPX.Name = "teMaPX";
            this.teMaPX.Size = new System.Drawing.Size(121, 22);
            this.teMaPX.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.sbtnHoanTac);
            this.panelControl3.Controls.Add(this.sbtnLuu);
            this.panelControl3.Controls.Add(this.sbtnHieuChinh);
            this.panelControl3.Controls.Add(this.sbtnXoa);
            this.panelControl3.Controls.Add(this.sbtnThem);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(925, 356);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(446, 74);
            this.panelControl3.TabIndex = 41;
            // 
            // sbtnHoanTac
            // 
            this.sbtnHoanTac.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnHoanTac.ImageOptions.SvgImage")));
            this.sbtnHoanTac.Location = new System.Drawing.Point(571, 18);
            this.sbtnHoanTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sbtnHoanTac.Name = "sbtnHoanTac";
            this.sbtnHoanTac.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnHoanTac.Size = new System.Drawing.Size(121, 39);
            this.sbtnHoanTac.TabIndex = 4;
            this.sbtnHoanTac.Text = "Hoàn Tác";
            this.sbtnHoanTac.Click += new System.EventHandler(this.sbtnHoanTac_Click);
            // 
            // sbtnLuu
            // 
            this.sbtnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnLuu.ImageOptions.SvgImage")));
            this.sbtnLuu.Location = new System.Drawing.Point(440, 18);
            this.sbtnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sbtnLuu.Name = "sbtnLuu";
            this.sbtnLuu.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnLuu.Size = new System.Drawing.Size(96, 39);
            this.sbtnLuu.TabIndex = 3;
            this.sbtnLuu.Text = "Lưu";
            this.sbtnLuu.Click += new System.EventHandler(this.sbtnLuu_Click);
            // 
            // sbtnHieuChinh
            // 
            this.sbtnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnHieuChinh.ImageOptions.SvgImage")));
            this.sbtnHieuChinh.Location = new System.Drawing.Point(285, 18);
            this.sbtnHieuChinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sbtnHieuChinh.Name = "sbtnHieuChinh";
            this.sbtnHieuChinh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnHieuChinh.Size = new System.Drawing.Size(121, 39);
            this.sbtnHieuChinh.TabIndex = 2;
            this.sbtnHieuChinh.Text = "Hiệu Chỉnh";
            this.sbtnHieuChinh.Click += new System.EventHandler(this.sbtnHieuChinh_Click);
            // 
            // sbtnXoa
            // 
            this.sbtnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnXoa.ImageOptions.SvgImage")));
            this.sbtnXoa.Location = new System.Drawing.Point(155, 18);
            this.sbtnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sbtnXoa.Name = "sbtnXoa";
            this.sbtnXoa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnXoa.Size = new System.Drawing.Size(96, 39);
            this.sbtnXoa.TabIndex = 1;
            this.sbtnXoa.Text = "Xóa";
            this.sbtnXoa.Click += new System.EventHandler(this.sbtnXoa_Click);
            // 
            // sbtnThem
            // 
            this.sbtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnThem.ImageOptions.SvgImage")));
            this.sbtnThem.Location = new System.Drawing.Point(25, 18);
            this.sbtnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sbtnThem.Name = "sbtnThem";
            this.sbtnThem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnThem.Size = new System.Drawing.Size(96, 39);
            this.sbtnThem.TabIndex = 0;
            this.sbtnThem.Text = "Thêm";
            this.sbtnThem.Click += new System.EventHandler(this.sbtnThem_Click);
            // 
            // gcCTPX
            // 
            this.gcCTPX.DataSource = this.bdsCTPX;
            this.gcCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcCTPX.Location = new System.Drawing.Point(925, 430);
            this.gcCTPX.MainView = this.gridView2;
            this.gcCTPX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcCTPX.MenuManager = this.barManager1;
            this.gcCTPX.Name = "gcCTPX";
            this.gcCTPX.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkMaVaTu,
            this.cedMaVT});
            this.gcCTPX.Size = new System.Drawing.Size(446, 297);
            this.gcCTPX.TabIndex = 41;
            this.gcCTPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.gcCTPX;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // colMAPX1
            // 
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.MinWidth = 25;
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
            this.colMAPX1.Width = 93;
            // 
            // colMAVT
            // 
            this.colMAVT.ColumnEdit = this.cedMaVT;
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 93;
            // 
            // cedMaVT
            // 
            this.cedMaVT.AutoHeight = false;
            this.cedMaVT.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cedMaVT.Name = "cedMaVT";
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 93;
            // 
            // colDONGIA
            // 
            this.colDONGIA.DisplayFormat.FormatString = "n0";
            this.colDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 93;
            // 
            // lkMaVaTu
            // 
            this.lkMaVaTu.AutoHeight = false;
            this.lkMaVaTu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkMaVaTu.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAVT", "MAVT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENVT", "TENVT")});
            this.lkMaVaTu.Name = "lkMaVaTu";
            // 
            // hoTenNVTableAdapter
            // 
            this.hoTenNVTableAdapter.ClearBeforeFill = true;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.dS;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // FormPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 727);
            this.Controls.Add(this.gcCTPX);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcPX);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPhieuXuat";
            this.Text = "FormPhieuXuat";
            this.Load += new System.EventHandler(this.FormPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTenNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teMaPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cedMaVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMaVaTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DevExpress.XtraBars.BarSubItem bsChonCheDo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsPX;
        private DS dS;
        private DSTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton sbtnLuu;
        private DevExpress.XtraEditors.SimpleButton sbtnHieuChinh;
        private DevExpress.XtraEditors.SimpleButton sbtnXoa;
        private DevExpress.XtraEditors.SimpleButton sbtnThem;
        private DSTableAdapters.CTPXTableAdapter cTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DevExpress.XtraGrid.GridControl gcCTPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraEditors.DateEdit deNgay;
        private DevExpress.XtraEditors.TextEdit teMaPX;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.BindingSource bdsKho;
        private System.Windows.Forms.BindingSource bdsHoTenNV;
        private DSTableAdapters.HoTenNVTableAdapter hoTenNVTableAdapter;
        private System.Windows.Forms.ComboBox cbbHoTenNV;
        private System.Windows.Forms.TextBox txtMaKho;
        private System.Windows.Forms.ComboBox cbbTenKho;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private DevExpress.XtraEditors.SimpleButton sbtnHoanTac;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkMaVaTu;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cedMaVT;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SpinEdit seDonGia;
        private System.Windows.Forms.NumericUpDown nmSoLuong;
        private System.Windows.Forms.ComboBox cbbMaVT;
        private System.Windows.Forms.TextBox txtMaPX_CTPX;
    }
}