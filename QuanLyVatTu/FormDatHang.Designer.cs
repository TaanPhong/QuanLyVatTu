
namespace QuanLyVatTu
{
    partial class FormDatHang
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label hOTENLabel1;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label tENVTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatHang));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridDatHang = new DevExpress.XtraGrid.GridControl();
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QuanLyVatTu.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.datHangTableAdapter = new QuanLyVatTu.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QuanLyVatTu.DSTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QuanLyVatTu.DSTableAdapters.CTDDHTableAdapter();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.TenVtComboBox = new System.Windows.Forms.ComboBox();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaVt = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
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
            this.DonGiaEdit = new DevExpress.XtraEditors.SpinEdit();
            this.SoLuongEdit = new System.Windows.Forms.NumericUpDown();
            this.MaKhoText = new DevExpress.XtraEditors.TextEdit();
            this.TenKhoComboBox = new System.Windows.Forms.ComboBox();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.MaNvTextbox = new System.Windows.Forms.TextBox();
            this.HoTenComboBox = new System.Windows.Forms.ComboBox();
            this.bdsHoTenNV = new System.Windows.Forms.BindingSource(this.components);
            this.txtNhaCungCap = new DevExpress.XtraEditors.TextEdit();
            this.DateNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaDon = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridChiTiet = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaDonCT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khoTableAdapter = new QuanLyVatTu.DSTableAdapters.KhoTableAdapter();
            this.hoTenNVTableAdapter = new QuanLyVatTu.DSTableAdapters.HoTenNVTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.vattuTableAdapter = new QuanLyVatTu.DSTableAdapters.VattuTableAdapter();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.sbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnHieuChinh = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnLuu = new DevExpress.XtraEditors.SimpleButton();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            hOTENLabel1 = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonGiaEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhoText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTenNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(5, 50);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(60, 13);
            masoDDHLabel.TabIndex = 1;
            masoDDHLabel.Text = "Mã số đơn:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(236, 54);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(36, 13);
            nGAYLabel.TabIndex = 3;
            nGAYLabel.Text = "Ngày:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(439, 50);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(76, 13);
            nhaCCLabel.TabIndex = 5;
            nhaCCLabel.Text = "Nhà cung cấp:";
            // 
            // hOTENLabel1
            // 
            hOTENLabel1.AutoSize = true;
            hOTENLabel1.Location = new System.Drawing.Point(236, 104);
            hOTENLabel1.Name = "hOTENLabel1";
            hOTENLabel1.Size = new System.Drawing.Size(79, 13);
            hOTENLabel1.TabIndex = 12;
            hOTENLabel1.Text = "Tên nhân viên:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(5, 104);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(75, 13);
            mANVLabel.TabIndex = 13;
            mANVLabel.Text = "Mã nhân viên:";
            mANVLabel.Click += new System.EventHandler(this.mANVLabel_Click);
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(5, 149);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(49, 13);
            tENKHOLabel.TabIndex = 14;
            tENKHOLabel.Text = "Tên kho:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(236, 149);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(45, 13);
            mAKHOLabel.TabIndex = 15;
            mAKHOLabel.Text = "Mã kho:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(5, 206);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(58, 13);
            mAVTLabel.TabIndex = 16;
            mAVTLabel.Text = "Mã vật tư:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(448, 205);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(53, 13);
            sOLUONGLabel.TabIndex = 17;
            sOLUONGLabel.Text = "Số lượng:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(615, 204);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(48, 13);
            dONGIALabel.TabIndex = 19;
            dONGIALabel.Text = "Đơn giá:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(210, 206);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(62, 13);
            tENVTLabel.TabIndex = 23;
            tENVTLabel.Text = "Tên vật tư:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbbChiNhanh);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 56);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1296, 55);
            this.panelControl1.TabIndex = 15;
            // 
            // cbbChiNhanh
            // 
            this.cbbChiNhanh.FormattingEnabled = true;
            this.cbbChiNhanh.Location = new System.Drawing.Point(181, 11);
            this.cbbChiNhanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbChiNhanh.Name = "cbbChiNhanh";
            this.cbbChiNhanh.Size = new System.Drawing.Size(334, 21);
            this.cbbChiNhanh.TabIndex = 2;
            this.cbbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbbChiNhanh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi Nhánh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gridDatHang
            // 
            this.gridDatHang.DataSource = this.bdsDatHang;
            this.gridDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDatHang.Location = new System.Drawing.Point(0, 111);
            this.gridDatHang.MainView = this.gridView1;
            this.gridDatHang.Name = "gridDatHang";
            this.gridDatHang.Size = new System.Drawing.Size(1296, 638);
            this.gridDatHang.TabIndex = 16;
            this.gridDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsDatHang
            // 
            this.bdsDatHang.DataMember = "DatHang";
            this.bdsDatHang.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMAKHO,
            this.colMANV});
            this.gridView1.GridControl = this.gridDatHang;
            this.gridView1.Name = "gridView1";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã số đơn";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày lập";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nhà cung cấp";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 3;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 4;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTu.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.TenVtComboBox);
            this.panelControl2.Controls.Add(this.txtMaVt);
            this.panelControl2.Controls.Add(tENVTLabel);
            this.panelControl2.Controls.Add(dONGIALabel);
            this.panelControl2.Controls.Add(this.DonGiaEdit);
            this.panelControl2.Controls.Add(sOLUONGLabel);
            this.panelControl2.Controls.Add(this.SoLuongEdit);
            this.panelControl2.Controls.Add(mAVTLabel);
            this.panelControl2.Controls.Add(mAKHOLabel);
            this.panelControl2.Controls.Add(this.MaKhoText);
            this.panelControl2.Controls.Add(tENKHOLabel);
            this.panelControl2.Controls.Add(this.TenKhoComboBox);
            this.panelControl2.Controls.Add(mANVLabel);
            this.panelControl2.Controls.Add(this.MaNvTextbox);
            this.panelControl2.Controls.Add(hOTENLabel1);
            this.panelControl2.Controls.Add(this.HoTenComboBox);
            this.panelControl2.Controls.Add(nhaCCLabel);
            this.panelControl2.Controls.Add(this.txtNhaCungCap);
            this.panelControl2.Controls.Add(nGAYLabel);
            this.panelControl2.Controls.Add(this.DateNgay);
            this.panelControl2.Controls.Add(masoDDHLabel);
            this.panelControl2.Controls.Add(this.txtMaDon);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 472);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1296, 277);
            this.panelControl2.TabIndex = 17;
            // 
            // TenVtComboBox
            // 
            this.TenVtComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vattuBindingSource, "TENVT", true));
            this.TenVtComboBox.DataSource = this.vattuBindingSource;
            this.TenVtComboBox.DisplayMember = "TENVT";
            this.TenVtComboBox.FormattingEnabled = true;
            this.TenVtComboBox.Location = new System.Drawing.Point(292, 201);
            this.TenVtComboBox.Name = "TenVtComboBox";
            this.TenVtComboBox.Size = new System.Drawing.Size(94, 21);
            this.TenVtComboBox.TabIndex = 25;
            this.TenVtComboBox.ValueMember = "MAVT";
            this.TenVtComboBox.SelectedIndexChanged += new System.EventHandler(this.TenVtComboBox_SelectedIndexChanged_1);
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.dS;
            // 
            // txtMaVt
            // 
            this.txtMaVt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "MAVT", true));
            this.txtMaVt.Location = new System.Drawing.Point(71, 200);
            this.txtMaVt.MenuManager = this.barManager1;
            this.txtMaVt.Name = "txtMaVt";
            this.txtMaVt.Properties.ReadOnly = true;
            this.txtMaVt.Size = new System.Drawing.Size(100, 20);
            this.txtMaVt.TabIndex = 24;
            this.txtMaVt.EditValueChanged += new System.EventHandler(this.txtMaVt_EditValueChanged);
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
            this.bdsCTDDH.DataSource = this.bdsDatHang;
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
            this.btnthem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnthem_ItemClick_1);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1296, 56);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 749);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1296, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 56);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 693);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1296, 56);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 693);
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
            // DonGiaEdit
            // 
            this.DonGiaEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "DONGIA", true));
            this.DonGiaEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.DonGiaEdit.Location = new System.Drawing.Point(673, 198);
            this.DonGiaEdit.Name = "DonGiaEdit";
            this.DonGiaEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DonGiaEdit.Size = new System.Drawing.Size(100, 20);
            this.DonGiaEdit.TabIndex = 20;
            // 
            // SoLuongEdit
            // 
            this.SoLuongEdit.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsCTDDH, "SOLUONG", true));
            this.SoLuongEdit.Location = new System.Drawing.Point(521, 199);
            this.SoLuongEdit.Name = "SoLuongEdit";
            this.SoLuongEdit.Size = new System.Drawing.Size(62, 21);
            this.SoLuongEdit.TabIndex = 18;
            // 
            // MaKhoText
            // 
            this.MaKhoText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "MAKHO", true));
            this.MaKhoText.Location = new System.Drawing.Point(292, 146);
            this.MaKhoText.Name = "MaKhoText";
            this.MaKhoText.Properties.ReadOnly = true;
            this.MaKhoText.Size = new System.Drawing.Size(147, 20);
            this.MaKhoText.TabIndex = 16;
            this.MaKhoText.EditValueChanged += new System.EventHandler(this.MaKhoText_EditValueChanged);
            // 
            // TenKhoComboBox
            // 
            this.TenKhoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKho, "TENKHO", true));
            this.TenKhoComboBox.DataSource = this.bdsKho;
            this.TenKhoComboBox.DisplayMember = "TENKHO";
            this.TenKhoComboBox.FormattingEnabled = true;
            this.TenKhoComboBox.Location = new System.Drawing.Point(71, 146);
            this.TenKhoComboBox.Name = "TenKhoComboBox";
            this.TenKhoComboBox.Size = new System.Drawing.Size(121, 21);
            this.TenKhoComboBox.TabIndex = 15;
            this.TenKhoComboBox.ValueMember = "MAKHO";
            this.TenKhoComboBox.SelectedIndexChanged += new System.EventHandler(this.TenKhoComboBox_SelectedIndexChanged);
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.dS;
            // 
            // MaNvTextbox
            // 
            this.MaNvTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDatHang, "MANV", true));
            this.MaNvTextbox.Location = new System.Drawing.Point(86, 96);
            this.MaNvTextbox.Name = "MaNvTextbox";
            this.MaNvTextbox.ReadOnly = true;
            this.MaNvTextbox.Size = new System.Drawing.Size(126, 21);
            this.MaNvTextbox.TabIndex = 14;
            this.MaNvTextbox.TextChanged += new System.EventHandler(this.mANVTextBox_TextChanged);
            // 
            // HoTenComboBox
            // 
            this.HoTenComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoTenNV, "HOTEN", true));
            this.HoTenComboBox.DataSource = this.bdsHoTenNV;
            this.HoTenComboBox.DisplayMember = "HOTEN";
            this.HoTenComboBox.FormattingEnabled = true;
            this.HoTenComboBox.Location = new System.Drawing.Point(360, 96);
            this.HoTenComboBox.Name = "HoTenComboBox";
            this.HoTenComboBox.Size = new System.Drawing.Size(260, 21);
            this.HoTenComboBox.TabIndex = 13;
            this.HoTenComboBox.ValueMember = "MANV";
            this.HoTenComboBox.SelectedIndexChanged += new System.EventHandler(this.HoTenComboBox_SelectedIndexChanged);
            // 
            // bdsHoTenNV
            // 
            this.bdsHoTenNV.DataMember = "HoTenNV";
            this.bdsHoTenNV.DataSource = this.dS;
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "NhaCC", true));
            this.txtNhaCungCap.Location = new System.Drawing.Point(530, 47);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(156, 20);
            this.txtNhaCungCap.TabIndex = 6;
            // 
            // DateNgay
            // 
            this.DateNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "NGAY", true));
            this.DateNgay.EditValue = null;
            this.DateNgay.Location = new System.Drawing.Point(292, 51);
            this.DateNgay.Name = "DateNgay";
            this.DateNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateNgay.Size = new System.Drawing.Size(100, 20);
            this.DateNgay.TabIndex = 4;
            // 
            // txtMaDon
            // 
            this.txtMaDon.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDatHang, "MasoDDH", true));
            this.txtMaDon.Location = new System.Drawing.Point(71, 47);
            this.txtMaDon.Name = "txtMaDon";
            this.txtMaDon.Size = new System.Drawing.Size(100, 20);
            this.txtMaDon.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.gridChiTiet);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(880, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(414, 273);
            this.panelControl3.TabIndex = 0;
            // 
            // gridChiTiet
            // 
            this.gridChiTiet.DataSource = this.bdsCTDDH;
            this.gridChiTiet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridChiTiet.Location = new System.Drawing.Point(2, 48);
            this.gridChiTiet.MainView = this.gridView2;
            this.gridChiTiet.Name = "gridChiTiet";
            this.gridChiTiet.Size = new System.Drawing.Size(410, 223);
            this.gridChiTiet.TabIndex = 0;
            this.gridChiTiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaDonCT,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.gridChiTiet;
            this.gridView2.Name = "gridView2";
            // 
            // MaDonCT
            // 
            this.MaDonCT.Caption = "Mã số đơn";
            this.MaDonCT.FieldName = "MasoDDH";
            this.MaDonCT.Name = "MaDonCT";
            this.MaDonCT.Visible = true;
            this.MaDonCT.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // hoTenNVTableAdapter
            // 
            this.hoTenNVTableAdapter.ClearBeforeFill = true;
            // 
            // dSBindingSource
            // 
            this.dSBindingSource.DataSource = this.dS;
            this.dSBindingSource.Position = 0;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Tools";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Thêm";
            this.barButtonItem4.Id = 0;
            this.barButtonItem4.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_add_user_male_48;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Hiệu chỉnh";
            this.barButtonItem5.Id = 2;
            this.barButtonItem5.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_edit_text_file_48;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Xóa";
            this.barButtonItem8.Id = 3;
            this.barButtonItem8.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_denied_48;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Lưu";
            this.barButtonItem9.Enabled = false;
            this.barButtonItem9.Id = 4;
            this.barButtonItem9.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.icons8_save_48;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Phục hồi";
            this.barButtonItem10.Id = 5;
            this.barButtonItem10.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.Undo_icon__1_;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "reset";
            this.barButtonItem11.Id = 12;
            this.barButtonItem11.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.Button_Refresh_icon;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Thoát";
            this.barButtonItem12.Id = 10;
            this.barButtonItem12.ImageOptions.Image = global::QuanLyVatTu.Properties.Resources.inside_logout_icon;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1296, 56);
            this.barDockControl4.Manager = null;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl4.Size = new System.Drawing.Size(0, 693);
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.sbtnLuu);
            this.panelControl4.Controls.Add(this.sbtnHieuChinh);
            this.panelControl4.Controls.Add(this.sbtnXoa);
            this.panelControl4.Controls.Add(this.sbtnThem);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(410, 47);
            this.panelControl4.TabIndex = 1;
            // 
            // sbtnThem
            // 
            this.sbtnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnThem.ImageOptions.SvgImage")));
            this.sbtnThem.Location = new System.Drawing.Point(20, 5);
            this.sbtnThem.Name = "sbtnThem";
            this.sbtnThem.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnThem.Size = new System.Drawing.Size(88, 40);
            this.sbtnThem.TabIndex = 1;
            this.sbtnThem.Text = "Thêm";
            this.sbtnThem.Click += new System.EventHandler(this.sbtnThem_Click);
            // 
            // sbtnXoa
            // 
            this.sbtnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnXoa.ImageOptions.SvgImage")));
            this.sbtnXoa.Location = new System.Drawing.Point(114, 5);
            this.sbtnXoa.Name = "sbtnXoa";
            this.sbtnXoa.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnXoa.Size = new System.Drawing.Size(84, 40);
            this.sbtnXoa.TabIndex = 2;
            this.sbtnXoa.Text = "Xóa";
            this.sbtnXoa.Click += new System.EventHandler(this.sbtnXoa_Click);
            // 
            // sbtnHieuChinh
            // 
            this.sbtnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnHieuChinh.ImageOptions.SvgImage")));
            this.sbtnHieuChinh.Location = new System.Drawing.Point(204, 5);
            this.sbtnHieuChinh.Name = "sbtnHieuChinh";
            this.sbtnHieuChinh.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnHieuChinh.Size = new System.Drawing.Size(82, 40);
            this.sbtnHieuChinh.TabIndex = 3;
            this.sbtnHieuChinh.Text = "Sửa";
            this.sbtnHieuChinh.Click += new System.EventHandler(this.sbtnHieuChinh_Click);
            // 
            // sbtnLuu
            // 
            this.sbtnLuu.Enabled = false;
            this.sbtnLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sbtnLuu.ImageOptions.SvgImage")));
            this.sbtnLuu.Location = new System.Drawing.Point(292, 3);
            this.sbtnLuu.Name = "sbtnLuu";
            this.sbtnLuu.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.sbtnLuu.Size = new System.Drawing.Size(83, 40);
            this.sbtnLuu.TabIndex = 4;
            this.sbtnLuu.Text = "Lưu";
            this.sbtnLuu.Click += new System.EventHandler(this.sbtnLuu_Click);
            // 
            // FormDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1296, 749);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gridDatHang);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.Name = "FormDatHang";
            this.Text = "FormDatHang";
            this.Load += new System.EventHandler(this.FormDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DonGiaEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaKhoText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTenNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridChiTiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbChiNhanh;
        private DevExpress.XtraGrid.GridControl gridDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private System.Windows.Forms.BindingSource bdsKho;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit txtNhaCungCap;
        private DevExpress.XtraEditors.DateEdit DateNgay;
        private DevExpress.XtraEditors.TextEdit txtMaDon;
        private System.Windows.Forms.BindingSource bdsHoTenNV;
        private DSTableAdapters.HoTenNVTableAdapter hoTenNVTableAdapter;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.ComboBox HoTenComboBox;
        private System.Windows.Forms.TextBox MaNvTextbox;
        private System.Windows.Forms.ComboBox TenKhoComboBox;
        private System.Windows.Forms.BindingSource dSBindingSource;
        private DevExpress.XtraEditors.TextEdit MaKhoText;
        private DevExpress.XtraEditors.SpinEdit DonGiaEdit;
        private System.Windows.Forms.NumericUpDown SoLuongEdit;
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
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem btnIDSNV;
        private DevExpress.XtraBars.BarButtonItem btnLamLai;
        private DevExpress.XtraBars.BarSubItem bsChonCheDo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.GridControl gridChiTiet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn MaDonCT;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMaVt;
        private System.Windows.Forms.ComboBox TenVtComboBox;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton sbtnThem;
        private DevExpress.XtraEditors.SimpleButton sbtnXoa;
        private DevExpress.XtraEditors.SimpleButton sbtnHieuChinh;
        private DevExpress.XtraEditors.SimpleButton sbtnLuu;
    }
}