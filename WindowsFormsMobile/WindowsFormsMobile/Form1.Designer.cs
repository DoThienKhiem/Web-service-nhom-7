namespace WindowsFormsMobile
{
    partial class Form1
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
            this.GridViewUser = new System.Windows.Forms.DataGridView();
            this.iDUserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobileDataSetUser = new WindowsFormsMobile.MobileDataSetUser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNguoiDung = new System.Windows.Forms.TabPage();
            this.txt_Tim = new System.Windows.Forms.TextBox();
            this.cbb_loaitimkiem = new System.Windows.Forms.ComboBox();
            this.but_Tim = new System.Windows.Forms.Button();
            this.but_dele = new System.Windows.Forms.Button();
            this.but_update = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.txt_Ngaysinh = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Sodt = new System.Windows.Forms.TextBox();
            this.txt_Addres = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDonHang = new System.Windows.Forms.TabPage();
            this.but_capnhatdh = new System.Windows.Forms.Button();
            this.but_xemCTDH = new System.Windows.Forms.Button();
            this.txt_Timdh = new System.Windows.Forms.TextBox();
            this.cbb_timdh = new System.Windows.Forms.ComboBox();
            this.but_Timhd = new System.Windows.Forms.Button();
            this.cbb_trangthaidh = new System.Windows.Forms.ComboBox();
            this.GridViewDH = new System.Windows.Forms.DataGridView();
            this.maDHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUserDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDatHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobileDataSet1 = new WindowsFormsMobile.MobileDataSet1();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.txt_ngaylapdh = new System.Windows.Forms.TextBox();
            this.txt_idusdh = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_mdhdh = new System.Windows.Forms.TextBox();
            this.tabNhapHang = new System.Windows.Forms.TabPage();
            this.tabTonKho = new System.Windows.Forms.TabPage();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.txt_timsp = new System.Windows.Forms.TextBox();
            this.cbb_loaitimsp = new System.Windows.Forms.ComboBox();
            this.but_timsp = new System.Windows.Forms.Button();
            this.cbb_danhmucsp = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_timhinhsp = new System.Windows.Forms.Button();
            this.but_xoasp = new System.Windows.Forms.Button();
            this.but_suasp = new System.Windows.Forms.Button();
            this.but_addsp = new System.Windows.Forms.Button();
            this.txt_ghichusp = new System.Windows.Forms.TextBox();
            this.txt_hinhanhsp = new System.Windows.Forms.TextBox();
            this.txt_soluongsp = new System.Windows.Forms.TextBox();
            this.txt_giasp = new System.Windows.Forms.TextBox();
            this.txt_motasp = new System.Windows.Forms.TextBox();
            this.txt_tenspsp = new System.Windows.Forms.TextBox();
            this.txt_maspsp = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GridViewSP = new System.Windows.Forms.DataGridView();
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobileDataSet = new WindowsFormsMobile.MobileDataSet();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_timdm = new System.Windows.Forms.TextBox();
            this.cbb_loaitimdm = new System.Windows.Forms.ComboBox();
            this.but_timdm = new System.Windows.Forms.Button();
            this.but_Xoadm = new System.Windows.Forms.Button();
            this.but_Suadm = new System.Windows.Forms.Button();
            this.but_Themdm = new System.Windows.Forms.Button();
            this.txt_tendmdm = new System.Windows.Forms.TextBox();
            this.txt_madmdm = new System.Windows.Forms.TextBox();
            this.GridViewDM = new System.Windows.Forms.DataGridView();
            this.maDMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danhMucSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobileDataSetDanhMucSP = new WindowsFormsMobile.MobileDataSetDanhMucSP();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nguoiDungTableAdapter = new WindowsFormsMobile.MobileDataSetUserTableAdapters.NguoiDungTableAdapter();
            this.sanPhamTableAdapter = new WindowsFormsMobile.MobileDataSetTableAdapters.SanPhamTableAdapter();
            this.danhMucSPTableAdapter = new WindowsFormsMobile.MobileDataSetDanhMucSPTableAdapters.DanhMucSPTableAdapter();
            this.donHangTableAdapter = new WindowsFormsMobile.MobileDataSet1TableAdapters.DonHangTableAdapter();
            this.GridViewNhapHang = new System.Windows.Forms.DataGridView();
            this.mobileDataSet2 = new WindowsFormsMobile.MobileDataSet2();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new WindowsFormsMobile.MobileDataSet2TableAdapters.PhieuNhapTableAdapter();
            this.but_Thempn = new System.Windows.Forms.Button();
            this.maPNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUserDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_XemCTPN = new System.Windows.Forms.Button();
            this.cbb_quyenus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataSetUser)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabNguoiDung.SuspendLayout();
            this.tabDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataSet1)).BeginInit();
            this.tabNhapHang.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucSPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataSetDanhMucSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewUser
            // 
            this.GridViewUser.AutoGenerateColumns = false;
            this.GridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GridViewUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUserDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.quyenDataGridViewTextBoxColumn});
            this.GridViewUser.DataSource = this.nguoiDungBindingSource;
            this.GridViewUser.Location = new System.Drawing.Point(28, 304);
            this.GridViewUser.Name = "GridViewUser";
            this.GridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewUser.Size = new System.Drawing.Size(567, 152);
            this.GridViewUser.TabIndex = 0;
            this.GridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewUser_CellContentClick);
            // 
            // iDUserDataGridViewTextBoxColumn
            // 
            this.iDUserDataGridViewTextBoxColumn.DataPropertyName = "IDUser";
            this.iDUserDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDUserDataGridViewTextBoxColumn.Name = "iDUserDataGridViewTextBoxColumn";
            this.iDUserDataGridViewTextBoxColumn.Width = 43;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "Pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.Width = 78;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 79;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 65;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 54;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "Ngày sinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 79;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // quyenDataGridViewTextBoxColumn
            // 
            this.quyenDataGridViewTextBoxColumn.DataPropertyName = "Quyen";
            this.quyenDataGridViewTextBoxColumn.HeaderText = "Quyền";
            this.quyenDataGridViewTextBoxColumn.Name = "quyenDataGridViewTextBoxColumn";
            this.quyenDataGridViewTextBoxColumn.Width = 63;
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataMember = "NguoiDung";
            this.nguoiDungBindingSource.DataSource = this.mobileDataSetUser;
            // 
            // mobileDataSetUser
            // 
            this.mobileDataSetUser.DataSetName = "MobileDataSetUser";
            this.mobileDataSetUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNguoiDung);
            this.tabControl1.Controls.Add(this.tabDonHang);
            this.tabControl1.Controls.Add(this.tabNhapHang);
            this.tabControl1.Controls.Add(this.tabTonKho);
            this.tabControl1.Controls.Add(this.tabSanPham);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(42, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 460);
            this.tabControl1.TabIndex = 1;
            // 
            // tabNguoiDung
            // 
            this.tabNguoiDung.Controls.Add(this.cbb_quyenus);
            this.tabNguoiDung.Controls.Add(this.txt_Tim);
            this.tabNguoiDung.Controls.Add(this.cbb_loaitimkiem);
            this.tabNguoiDung.Controls.Add(this.but_Tim);
            this.tabNguoiDung.Controls.Add(this.but_dele);
            this.tabNguoiDung.Controls.Add(this.but_update);
            this.tabNguoiDung.Controls.Add(this.but_add);
            this.tabNguoiDung.Controls.Add(this.txt_Ngaysinh);
            this.tabNguoiDung.Controls.Add(this.txt_Email);
            this.tabNguoiDung.Controls.Add(this.txt_Sodt);
            this.tabNguoiDung.Controls.Add(this.txt_Addres);
            this.tabNguoiDung.Controls.Add(this.txt_Name);
            this.tabNguoiDung.Controls.Add(this.txt_Pass);
            this.tabNguoiDung.Controls.Add(this.txt_ID);
            this.tabNguoiDung.Controls.Add(this.label8);
            this.tabNguoiDung.Controls.Add(this.label7);
            this.tabNguoiDung.Controls.Add(this.label6);
            this.tabNguoiDung.Controls.Add(this.label5);
            this.tabNguoiDung.Controls.Add(this.label4);
            this.tabNguoiDung.Controls.Add(this.label3);
            this.tabNguoiDung.Controls.Add(this.label2);
            this.tabNguoiDung.Controls.Add(this.label1);
            this.tabNguoiDung.Controls.Add(this.GridViewUser);
            this.tabNguoiDung.Location = new System.Drawing.Point(4, 22);
            this.tabNguoiDung.Name = "tabNguoiDung";
            this.tabNguoiDung.Padding = new System.Windows.Forms.Padding(3);
            this.tabNguoiDung.Size = new System.Drawing.Size(617, 434);
            this.tabNguoiDung.TabIndex = 0;
            this.tabNguoiDung.Text = "Quản lý người dùng";
            this.tabNguoiDung.UseVisualStyleBackColor = true;
            // 
            // txt_Tim
            // 
            this.txt_Tim.Location = new System.Drawing.Point(330, 269);
            this.txt_Tim.Name = "txt_Tim";
            this.txt_Tim.Size = new System.Drawing.Size(100, 20);
            this.txt_Tim.TabIndex = 21;
            // 
            // cbb_loaitimkiem
            // 
            this.cbb_loaitimkiem.FormattingEnabled = true;
            this.cbb_loaitimkiem.Items.AddRange(new object[] {
            "Tìm kiếm theo ID",
            "Tìm kiếm theo họ tên"});
            this.cbb_loaitimkiem.Location = new System.Drawing.Point(184, 269);
            this.cbb_loaitimkiem.Name = "cbb_loaitimkiem";
            this.cbb_loaitimkiem.Size = new System.Drawing.Size(124, 21);
            this.cbb_loaitimkiem.TabIndex = 20;
            // 
            // but_Tim
            // 
            this.but_Tim.Location = new System.Drawing.Point(65, 269);
            this.but_Tim.Name = "but_Tim";
            this.but_Tim.Size = new System.Drawing.Size(67, 20);
            this.but_Tim.TabIndex = 19;
            this.but_Tim.Text = "Tìm";
            this.but_Tim.UseVisualStyleBackColor = true;
            this.but_Tim.Click += new System.EventHandler(this.but_Tim_Click);
            // 
            // but_dele
            // 
            this.but_dele.Location = new System.Drawing.Point(274, 188);
            this.but_dele.Name = "but_dele";
            this.but_dele.Size = new System.Drawing.Size(67, 20);
            this.but_dele.TabIndex = 18;
            this.but_dele.Text = "Xóa";
            this.but_dele.UseVisualStyleBackColor = true;
            this.but_dele.Click += new System.EventHandler(this.but_dele_Click);
            // 
            // but_update
            // 
            this.but_update.Location = new System.Drawing.Point(159, 188);
            this.but_update.Name = "but_update";
            this.but_update.Size = new System.Drawing.Size(67, 20);
            this.but_update.TabIndex = 17;
            this.but_update.Text = "Sửa";
            this.but_update.UseVisualStyleBackColor = true;
            this.but_update.Click += new System.EventHandler(this.but_update_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(65, 188);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(67, 20);
            this.but_add.TabIndex = 16;
            this.but_add.Text = "Thêm";
            this.but_add.UseVisualStyleBackColor = true;
            //this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // txt_Ngaysinh
            // 
            this.txt_Ngaysinh.Location = new System.Drawing.Point(342, 98);
            this.txt_Ngaysinh.Name = "txt_Ngaysinh";
            this.txt_Ngaysinh.Size = new System.Drawing.Size(100, 20);
            this.txt_Ngaysinh.TabIndex = 14;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(342, 67);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(100, 20);
            this.txt_Email.TabIndex = 13;
            // 
            // txt_Sodt
            // 
            this.txt_Sodt.Location = new System.Drawing.Point(342, 29);
            this.txt_Sodt.Name = "txt_Sodt";
            this.txt_Sodt.Size = new System.Drawing.Size(100, 20);
            this.txt_Sodt.TabIndex = 12;
            // 
            // txt_Addres
            // 
            this.txt_Addres.Location = new System.Drawing.Point(97, 137);
            this.txt_Addres.Name = "txt_Addres";
            this.txt_Addres.Size = new System.Drawing.Size(100, 20);
            this.txt_Addres.TabIndex = 11;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(97, 98);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 10;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(97, 60);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(100, 20);
            this.txt_Pass.TabIndex = 9;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(97, 29);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quyền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // tabDonHang
            // 
            this.tabDonHang.Controls.Add(this.but_capnhatdh);
            this.tabDonHang.Controls.Add(this.but_xemCTDH);
            this.tabDonHang.Controls.Add(this.txt_Timdh);
            this.tabDonHang.Controls.Add(this.cbb_timdh);
            this.tabDonHang.Controls.Add(this.but_Timhd);
            this.tabDonHang.Controls.Add(this.cbb_trangthaidh);
            this.tabDonHang.Controls.Add(this.GridViewDH);
            this.tabDonHang.Controls.Add(this.txt_tongtien);
            this.tabDonHang.Controls.Add(this.txt_ngaylapdh);
            this.tabDonHang.Controls.Add(this.txt_idusdh);
            this.tabDonHang.Controls.Add(this.label23);
            this.tabDonHang.Controls.Add(this.label22);
            this.tabDonHang.Controls.Add(this.label21);
            this.tabDonHang.Controls.Add(this.label20);
            this.tabDonHang.Controls.Add(this.label19);
            this.tabDonHang.Controls.Add(this.txt_mdhdh);
            this.tabDonHang.Location = new System.Drawing.Point(4, 22);
            this.tabDonHang.Name = "tabDonHang";
            this.tabDonHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonHang.Size = new System.Drawing.Size(617, 434);
            this.tabDonHang.TabIndex = 1;
            this.tabDonHang.Text = "Quản lý đơn hàng";
            this.tabDonHang.UseVisualStyleBackColor = true;
            // 
            // but_capnhatdh
            // 
            this.but_capnhatdh.Location = new System.Drawing.Point(525, 146);
            this.but_capnhatdh.Name = "but_capnhatdh";
            this.but_capnhatdh.Size = new System.Drawing.Size(74, 23);
            this.but_capnhatdh.TabIndex = 16;
            this.but_capnhatdh.Text = "Cập nhật";
            this.but_capnhatdh.UseVisualStyleBackColor = true;
            this.but_capnhatdh.Click += new System.EventHandler(this.but_capnhatdh_Click);
            // 
            // but_xemCTDH
            // 
            this.but_xemCTDH.Location = new System.Drawing.Point(431, 146);
            this.but_xemCTDH.Name = "but_xemCTDH";
            this.but_xemCTDH.Size = new System.Drawing.Size(74, 23);
            this.but_xemCTDH.TabIndex = 15;
            this.but_xemCTDH.Text = "Xem chi tiết";
            this.but_xemCTDH.UseVisualStyleBackColor = true;
            // 
            // txt_Timdh
            // 
            this.txt_Timdh.Location = new System.Drawing.Point(298, 146);
            this.txt_Timdh.Name = "txt_Timdh";
            this.txt_Timdh.Size = new System.Drawing.Size(100, 20);
            this.txt_Timdh.TabIndex = 14;
            // 
            // cbb_timdh
            // 
            this.cbb_timdh.FormattingEnabled = true;
            this.cbb_timdh.Items.AddRange(new object[] {
            "theo mã đơn hàng",
            "theo tên người dùng"});
            this.cbb_timdh.Location = new System.Drawing.Point(138, 144);
            this.cbb_timdh.Name = "cbb_timdh";
            this.cbb_timdh.Size = new System.Drawing.Size(134, 21);
            this.cbb_timdh.TabIndex = 13;
            // 
            // but_Timhd
            // 
            this.but_Timhd.Location = new System.Drawing.Point(43, 144);
            this.but_Timhd.Name = "but_Timhd";
            this.but_Timhd.Size = new System.Drawing.Size(74, 23);
            this.but_Timhd.TabIndex = 12;
            this.but_Timhd.Text = "Tìm";
            this.but_Timhd.UseVisualStyleBackColor = true;
            this.but_Timhd.Click += new System.EventHandler(this.but_Timhd_Click);
            // 
            // cbb_trangthaidh
            // 
            this.cbb_trangthaidh.FormattingEnabled = true;
            this.cbb_trangthaidh.Items.AddRange(new object[] {
            "",
            "Chưa giao",
            "Đã giao"});
            this.cbb_trangthaidh.Location = new System.Drawing.Point(490, 27);
            this.cbb_trangthaidh.Name = "cbb_trangthaidh";
            this.cbb_trangthaidh.Size = new System.Drawing.Size(121, 21);
            this.cbb_trangthaidh.TabIndex = 11;
            // 
            // GridViewDH
            // 
            this.GridViewDH.AutoGenerateColumns = false;
            this.GridViewDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDHDataGridViewTextBoxColumn,
            this.iDUserDataGridViewTextBoxColumn1,
            this.ngayDatHangDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.GridViewDH.DataSource = this.donHangBindingSource;
            this.GridViewDH.Location = new System.Drawing.Point(27, 190);
            this.GridViewDH.Name = "GridViewDH";
            this.GridViewDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewDH.Size = new System.Drawing.Size(552, 238);
            this.GridViewDH.TabIndex = 10;
            this.GridViewDH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewDH_CellContentClick_1);
            // 
            // maDHDataGridViewTextBoxColumn
            // 
            this.maDHDataGridViewTextBoxColumn.DataPropertyName = "MaDH";
            this.maDHDataGridViewTextBoxColumn.HeaderText = "MaDH";
            this.maDHDataGridViewTextBoxColumn.Name = "maDHDataGridViewTextBoxColumn";
            this.maDHDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDUserDataGridViewTextBoxColumn1
            // 
            this.iDUserDataGridViewTextBoxColumn1.DataPropertyName = "IDUser";
            this.iDUserDataGridViewTextBoxColumn1.HeaderText = "IDUser";
            this.iDUserDataGridViewTextBoxColumn1.Name = "iDUserDataGridViewTextBoxColumn1";
            // 
            // ngayDatHangDataGridViewTextBoxColumn
            // 
            this.ngayDatHangDataGridViewTextBoxColumn.DataPropertyName = "NgayDatHang";
            this.ngayDatHangDataGridViewTextBoxColumn.HeaderText = "NgayDatHang";
            this.ngayDatHangDataGridViewTextBoxColumn.Name = "ngayDatHangDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            // 
            // donHangBindingSource
            // 
            this.donHangBindingSource.DataMember = "DonHang";
            this.donHangBindingSource.DataSource = this.mobileDataSet1;
            // 
            // mobileDataSet1
            // 
            this.mobileDataSet1.DataSetName = "MobileDataSet1";
            this.mobileDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(298, 93);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(100, 20);
            this.txt_tongtien.TabIndex = 8;
            // 
            // txt_ngaylapdh
            // 
            this.txt_ngaylapdh.Location = new System.Drawing.Point(298, 31);
            this.txt_ngaylapdh.Name = "txt_ngaylapdh";
            this.txt_ngaylapdh.Size = new System.Drawing.Size(100, 20);
            this.txt_ngaylapdh.TabIndex = 7;
            // 
            // txt_idusdh
            // 
            this.txt_idusdh.Location = new System.Drawing.Point(79, 93);
            this.txt_idusdh.Name = "txt_idusdh";
            this.txt_idusdh.Size = new System.Drawing.Size(100, 20);
            this.txt_idusdh.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(428, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Trạng thái";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(240, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 13);
            this.label22.TabIndex = 4;
            this.label22.Text = "Tổng tiền";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(240, 35);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Ngày lập";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(24, 96);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "ID user";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(2, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Mã đơn hàng";
            // 
            // txt_mdhdh
            // 
            this.txt_mdhdh.Location = new System.Drawing.Point(79, 35);
            this.txt_mdhdh.Name = "txt_mdhdh";
            this.txt_mdhdh.Size = new System.Drawing.Size(100, 20);
            this.txt_mdhdh.TabIndex = 0;
            // 
            // tabNhapHang
            // 
            this.tabNhapHang.Controls.Add(this.but_XemCTPN);
            this.tabNhapHang.Controls.Add(this.but_Thempn);
            this.tabNhapHang.Controls.Add(this.GridViewNhapHang);
            this.tabNhapHang.Location = new System.Drawing.Point(4, 22);
            this.tabNhapHang.Name = "tabNhapHang";
            this.tabNhapHang.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhapHang.Size = new System.Drawing.Size(617, 434);
            this.tabNhapHang.TabIndex = 2;
            this.tabNhapHang.Text = "Quản lý nhập hàng";
            this.tabNhapHang.UseVisualStyleBackColor = true;
            // 
            // tabTonKho
            // 
            this.tabTonKho.Location = new System.Drawing.Point(4, 22);
            this.tabTonKho.Name = "tabTonKho";
            this.tabTonKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabTonKho.Size = new System.Drawing.Size(617, 434);
            this.tabTonKho.TabIndex = 3;
            this.tabTonKho.Text = "Quản lý tồn kho";
            this.tabTonKho.UseVisualStyleBackColor = true;
            // 
            // tabSanPham
            // 
            this.tabSanPham.Controls.Add(this.txt_timsp);
            this.tabSanPham.Controls.Add(this.cbb_loaitimsp);
            this.tabSanPham.Controls.Add(this.but_timsp);
            this.tabSanPham.Controls.Add(this.cbb_danhmucsp);
            this.tabSanPham.Controls.Add(this.pictureBox1);
            this.tabSanPham.Controls.Add(this.but_timhinhsp);
            this.tabSanPham.Controls.Add(this.but_xoasp);
            this.tabSanPham.Controls.Add(this.but_suasp);
            this.tabSanPham.Controls.Add(this.but_addsp);
            this.tabSanPham.Controls.Add(this.txt_ghichusp);
            this.tabSanPham.Controls.Add(this.txt_hinhanhsp);
            this.tabSanPham.Controls.Add(this.txt_soluongsp);
            this.tabSanPham.Controls.Add(this.txt_giasp);
            this.tabSanPham.Controls.Add(this.txt_motasp);
            this.tabSanPham.Controls.Add(this.txt_tenspsp);
            this.tabSanPham.Controls.Add(this.txt_maspsp);
            this.tabSanPham.Controls.Add(this.label16);
            this.tabSanPham.Controls.Add(this.label15);
            this.tabSanPham.Controls.Add(this.label14);
            this.tabSanPham.Controls.Add(this.label13);
            this.tabSanPham.Controls.Add(this.label12);
            this.tabSanPham.Controls.Add(this.label11);
            this.tabSanPham.Controls.Add(this.label10);
            this.tabSanPham.Controls.Add(this.label9);
            this.tabSanPham.Controls.Add(this.GridViewSP);
            this.tabSanPham.Location = new System.Drawing.Point(4, 22);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tabSanPham.Size = new System.Drawing.Size(617, 434);
            this.tabSanPham.TabIndex = 4;
            this.tabSanPham.Text = "Quản lý sản phẩm";
            this.tabSanPham.UseVisualStyleBackColor = true;
            // 
            // txt_timsp
            // 
            this.txt_timsp.Location = new System.Drawing.Point(381, 273);
            this.txt_timsp.Name = "txt_timsp";
            this.txt_timsp.Size = new System.Drawing.Size(106, 20);
            this.txt_timsp.TabIndex = 25;
            // 
            // cbb_loaitimsp
            // 
            this.cbb_loaitimsp.FormattingEnabled = true;
            this.cbb_loaitimsp.Items.AddRange(new object[] {
            "theo mã danh mục",
            "theo tên sản phẩm",
            "theo mã sản phẩm"});
            this.cbb_loaitimsp.Location = new System.Drawing.Point(227, 271);
            this.cbb_loaitimsp.Name = "cbb_loaitimsp";
            this.cbb_loaitimsp.Size = new System.Drawing.Size(121, 21);
            this.cbb_loaitimsp.TabIndex = 24;
            // 
            // but_timsp
            // 
            this.but_timsp.Location = new System.Drawing.Point(92, 270);
            this.but_timsp.Name = "but_timsp";
            this.but_timsp.Size = new System.Drawing.Size(75, 23);
            this.but_timsp.TabIndex = 23;
            this.but_timsp.Text = "Tìm kiếm";
            this.but_timsp.UseVisualStyleBackColor = true;
            this.but_timsp.Click += new System.EventHandler(this.but_timsp_Click);
            // 
            // cbb_danhmucsp
            // 
            this.cbb_danhmucsp.FormattingEnabled = true;
            this.cbb_danhmucsp.Location = new System.Drawing.Point(353, 195);
            this.cbb_danhmucsp.Name = "cbb_danhmucsp";
            this.cbb_danhmucsp.Size = new System.Drawing.Size(102, 21);
            this.cbb_danhmucsp.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(350, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // but_timhinhsp
            // 
            this.but_timhinhsp.Location = new System.Drawing.Point(495, 23);
            this.but_timhinhsp.Name = "but_timhinhsp";
            this.but_timhinhsp.Size = new System.Drawing.Size(75, 23);
            this.but_timhinhsp.TabIndex = 20;
            this.but_timhinhsp.Text = "Browse";
            this.but_timhinhsp.UseVisualStyleBackColor = true;
            this.but_timhinhsp.Click += new System.EventHandler(this.but_timhinhsp_Click);
            // 
            // but_xoasp
            // 
            this.but_xoasp.Location = new System.Drawing.Point(381, 228);
            this.but_xoasp.Name = "but_xoasp";
            this.but_xoasp.Size = new System.Drawing.Size(75, 23);
            this.but_xoasp.TabIndex = 19;
            this.but_xoasp.Text = "Xóa";
            this.but_xoasp.UseVisualStyleBackColor = true;
            this.but_xoasp.Click += new System.EventHandler(this.but_xoasp_Click);
            // 
            // but_suasp
            // 
            this.but_suasp.Location = new System.Drawing.Point(227, 228);
            this.but_suasp.Name = "but_suasp";
            this.but_suasp.Size = new System.Drawing.Size(75, 23);
            this.but_suasp.TabIndex = 18;
            this.but_suasp.Text = "Sửa";
            this.but_suasp.UseVisualStyleBackColor = true;
            this.but_suasp.Click += new System.EventHandler(this.but_suasp_Click);
            // 
            // but_addsp
            // 
            this.but_addsp.Location = new System.Drawing.Point(92, 228);
            this.but_addsp.Name = "but_addsp";
            this.but_addsp.Size = new System.Drawing.Size(75, 23);
            this.but_addsp.TabIndex = 17;
            this.but_addsp.Text = "Thêm";
            this.but_addsp.UseVisualStyleBackColor = true;
            this.but_addsp.Click += new System.EventHandler(this.but_addsp_Click);
            // 
            // txt_ghichusp
            // 
            this.txt_ghichusp.Location = new System.Drawing.Point(350, 155);
            this.txt_ghichusp.Multiline = true;
            this.txt_ghichusp.Name = "txt_ghichusp";
            this.txt_ghichusp.Size = new System.Drawing.Size(168, 34);
            this.txt_ghichusp.TabIndex = 15;
            // 
            // txt_hinhanhsp
            // 
            this.txt_hinhanhsp.Location = new System.Drawing.Point(350, 25);
            this.txt_hinhanhsp.Name = "txt_hinhanhsp";
            this.txt_hinhanhsp.Size = new System.Drawing.Size(106, 20);
            this.txt_hinhanhsp.TabIndex = 14;
            // 
            // txt_soluongsp
            // 
            this.txt_soluongsp.Location = new System.Drawing.Point(103, 197);
            this.txt_soluongsp.Name = "txt_soluongsp";
            this.txt_soluongsp.Size = new System.Drawing.Size(106, 20);
            this.txt_soluongsp.TabIndex = 13;
            // 
            // txt_giasp
            // 
            this.txt_giasp.Location = new System.Drawing.Point(103, 155);
            this.txt_giasp.Name = "txt_giasp";
            this.txt_giasp.Size = new System.Drawing.Size(106, 20);
            this.txt_giasp.TabIndex = 12;
            // 
            // txt_motasp
            // 
            this.txt_motasp.Location = new System.Drawing.Point(103, 103);
            this.txt_motasp.Name = "txt_motasp";
            this.txt_motasp.Size = new System.Drawing.Size(106, 20);
            this.txt_motasp.TabIndex = 11;
            // 
            // txt_tenspsp
            // 
            this.txt_tenspsp.Location = new System.Drawing.Point(103, 59);
            this.txt_tenspsp.Name = "txt_tenspsp";
            this.txt_tenspsp.Size = new System.Drawing.Size(106, 20);
            this.txt_tenspsp.TabIndex = 10;
            // 
            // txt_maspsp
            // 
            this.txt_maspsp.Location = new System.Drawing.Point(103, 20);
            this.txt_maspsp.Name = "txt_maspsp";
            this.txt_maspsp.ReadOnly = true;
            this.txt_maspsp.Size = new System.Drawing.Size(106, 20);
            this.txt_maspsp.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(288, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Danh mục";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(288, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Ghi chú";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(294, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Hình ảnh";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Số lượng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Mô tả";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã sản phẩm";
            // 
            // GridViewSP
            // 
            this.GridViewSP.AutoGenerateColumns = false;
            this.GridViewSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn,
            this.maDMDataGridViewTextBoxColumn});
            this.GridViewSP.DataSource = this.sanPhamBindingSource;
            this.GridViewSP.Location = new System.Drawing.Point(23, 310);
            this.GridViewSP.Name = "GridViewSP";
            this.GridViewSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewSP.Size = new System.Drawing.Size(559, 118);
            this.GridViewSP.TabIndex = 0;
            this.GridViewSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewSP_CellContentClick);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "MaSP";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            this.maSPDataGridViewTextBoxColumn.ReadOnly = true;
            this.maSPDataGridViewTextBoxColumn.Width = 61;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.Width = 65;
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "MoTa";
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            this.moTaDataGridViewTextBoxColumn.Width = 60;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            this.giaDataGridViewTextBoxColumn.Width = 48;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.Width = 75;
            // 
            // hinhAnhDataGridViewTextBoxColumn
            // 
            this.hinhAnhDataGridViewTextBoxColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewTextBoxColumn.HeaderText = "HinhAnh";
            this.hinhAnhDataGridViewTextBoxColumn.Name = "hinhAnhDataGridViewTextBoxColumn";
            this.hinhAnhDataGridViewTextBoxColumn.Width = 73;
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            this.ghiChuDataGridViewTextBoxColumn.Width = 67;
            // 
            // maDMDataGridViewTextBoxColumn
            // 
            this.maDMDataGridViewTextBoxColumn.DataPropertyName = "MaDM";
            this.maDMDataGridViewTextBoxColumn.HeaderText = "MaDM";
            this.maDMDataGridViewTextBoxColumn.Name = "maDMDataGridViewTextBoxColumn";
            this.maDMDataGridViewTextBoxColumn.Width = 64;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataMember = "SanPham";
            this.sanPhamBindingSource.DataSource = this.mobileDataSet;
            // 
            // mobileDataSet
            // 
            this.mobileDataSet.DataSetName = "MobileDataSet";
            this.mobileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_timdm);
            this.tabPage1.Controls.Add(this.cbb_loaitimdm);
            this.tabPage1.Controls.Add(this.but_timdm);
            this.tabPage1.Controls.Add(this.but_Xoadm);
            this.tabPage1.Controls.Add(this.but_Suadm);
            this.tabPage1.Controls.Add(this.but_Themdm);
            this.tabPage1.Controls.Add(this.txt_tendmdm);
            this.tabPage1.Controls.Add(this.txt_madmdm);
            this.tabPage1.Controls.Add(this.GridViewDM);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 434);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Quản lý danh mục";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_timdm
            // 
            this.txt_timdm.Location = new System.Drawing.Point(386, 156);
            this.txt_timdm.Name = "txt_timdm";
            this.txt_timdm.Size = new System.Drawing.Size(123, 20);
            this.txt_timdm.TabIndex = 10;
            // 
            // cbb_loaitimdm
            // 
            this.cbb_loaitimdm.FormattingEnabled = true;
            this.cbb_loaitimdm.Items.AddRange(new object[] {
            "tìm theo mã danh mục",
            "tìm theo tên danh mục"});
            this.cbb_loaitimdm.Location = new System.Drawing.Point(192, 159);
            this.cbb_loaitimdm.Name = "cbb_loaitimdm";
            this.cbb_loaitimdm.Size = new System.Drawing.Size(121, 21);
            this.cbb_loaitimdm.TabIndex = 9;
            // 
            // but_timdm
            // 
            this.but_timdm.Location = new System.Drawing.Point(61, 159);
            this.but_timdm.Name = "but_timdm";
            this.but_timdm.Size = new System.Drawing.Size(93, 29);
            this.but_timdm.TabIndex = 8;
            this.but_timdm.Text = "Tìm";
            this.but_timdm.UseVisualStyleBackColor = true;
            this.but_timdm.Click += new System.EventHandler(this.but_timdm_Click);
            // 
            // but_Xoadm
            // 
            this.but_Xoadm.Location = new System.Drawing.Point(441, 89);
            this.but_Xoadm.Name = "but_Xoadm";
            this.but_Xoadm.Size = new System.Drawing.Size(93, 29);
            this.but_Xoadm.TabIndex = 7;
            this.but_Xoadm.Text = "Xóa";
            this.but_Xoadm.UseVisualStyleBackColor = true;
            this.but_Xoadm.Click += new System.EventHandler(this.but_Xoadm_Click);
            // 
            // but_Suadm
            // 
            this.but_Suadm.Location = new System.Drawing.Point(243, 89);
            this.but_Suadm.Name = "but_Suadm";
            this.but_Suadm.Size = new System.Drawing.Size(93, 29);
            this.but_Suadm.TabIndex = 6;
            this.but_Suadm.Text = "Sửa";
            this.but_Suadm.UseVisualStyleBackColor = true;
            this.but_Suadm.Click += new System.EventHandler(this.but_Suadm_Click);
            // 
            // but_Themdm
            // 
            this.but_Themdm.Location = new System.Drawing.Point(62, 89);
            this.but_Themdm.Name = "but_Themdm";
            this.but_Themdm.Size = new System.Drawing.Size(93, 29);
            this.but_Themdm.TabIndex = 5;
            this.but_Themdm.Text = "Thêm";
            this.but_Themdm.UseVisualStyleBackColor = true;
            this.but_Themdm.Click += new System.EventHandler(this.but_Themdm_Click);
            // 
            // txt_tendmdm
            // 
            this.txt_tendmdm.Location = new System.Drawing.Point(428, 42);
            this.txt_tendmdm.Name = "txt_tendmdm";
            this.txt_tendmdm.Size = new System.Drawing.Size(125, 20);
            this.txt_tendmdm.TabIndex = 4;
            // 
            // txt_madmdm
            // 
            this.txt_madmdm.Location = new System.Drawing.Point(142, 36);
            this.txt_madmdm.Name = "txt_madmdm";
            this.txt_madmdm.Size = new System.Drawing.Size(125, 20);
            this.txt_madmdm.TabIndex = 3;
            // 
            // GridViewDM
            // 
            this.GridViewDM.AutoGenerateColumns = false;
            this.GridViewDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDMDataGridViewTextBoxColumn1,
            this.tenDMDataGridViewTextBoxColumn});
            this.GridViewDM.DataSource = this.danhMucSPBindingSource;
            this.GridViewDM.Location = new System.Drawing.Point(62, 221);
            this.GridViewDM.Name = "GridViewDM";
            this.GridViewDM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewDM.Size = new System.Drawing.Size(373, 140);
            this.GridViewDM.TabIndex = 2;
            this.GridViewDM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDM_CellContentClick);
            // 
            // maDMDataGridViewTextBoxColumn1
            // 
            this.maDMDataGridViewTextBoxColumn1.DataPropertyName = "MaDM";
            this.maDMDataGridViewTextBoxColumn1.HeaderText = "MaDM";
            this.maDMDataGridViewTextBoxColumn1.Name = "maDMDataGridViewTextBoxColumn1";
            // 
            // tenDMDataGridViewTextBoxColumn
            // 
            this.tenDMDataGridViewTextBoxColumn.DataPropertyName = "TenDM";
            this.tenDMDataGridViewTextBoxColumn.HeaderText = "TenDM";
            this.tenDMDataGridViewTextBoxColumn.Name = "tenDMDataGridViewTextBoxColumn";
            // 
            // danhMucSPBindingSource
            // 
            this.danhMucSPBindingSource.DataMember = "DanhMucSP";
            this.danhMucSPBindingSource.DataSource = this.mobileDataSetDanhMucSP;
            // 
            // mobileDataSetDanhMucSP
            // 
            this.mobileDataSetDanhMucSP.DataSetName = "MobileDataSetDanhMucSP";
            this.mobileDataSetDanhMucSP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(316, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Tên danh mục";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(58, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Mã danh mục";
            // 
            // nguoiDungTableAdapter
            // 
            this.nguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // sanPhamTableAdapter
            // 
            this.sanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // danhMucSPTableAdapter
            // 
            this.danhMucSPTableAdapter.ClearBeforeFill = true;
            // 
            // donHangTableAdapter
            // 
            this.donHangTableAdapter.ClearBeforeFill = true;
            // 
            // GridViewNhapHang
            // 
            this.GridViewNhapHang.AutoGenerateColumns = false;
            this.GridViewNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPNDataGridViewTextBoxColumn,
            this.iDUserDataGridViewTextBoxColumn2,
            this.ngayNhapDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn1});
            this.GridViewNhapHang.DataSource = this.phieuNhapBindingSource;
            this.GridViewNhapHang.Location = new System.Drawing.Point(57, 94);
            this.GridViewNhapHang.Name = "GridViewNhapHang";
            this.GridViewNhapHang.Size = new System.Drawing.Size(507, 218);
            this.GridViewNhapHang.TabIndex = 0;
            // 
            // mobileDataSet2
            // 
            this.mobileDataSet2.DataSetName = "MobileDataSet2";
            this.mobileDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.mobileDataSet2;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // but_Thempn
            // 
            this.but_Thempn.Location = new System.Drawing.Point(72, 42);
            this.but_Thempn.Name = "but_Thempn";
            this.but_Thempn.Size = new System.Drawing.Size(75, 23);
            this.but_Thempn.TabIndex = 1;
            this.but_Thempn.Text = "Thêm phiếu nhập";
            this.but_Thempn.UseVisualStyleBackColor = true;
            // 
            // maPNDataGridViewTextBoxColumn
            // 
            this.maPNDataGridViewTextBoxColumn.DataPropertyName = "MaPN";
            this.maPNDataGridViewTextBoxColumn.HeaderText = "MaPN";
            this.maPNDataGridViewTextBoxColumn.Name = "maPNDataGridViewTextBoxColumn";
            this.maPNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDUserDataGridViewTextBoxColumn2
            // 
            this.iDUserDataGridViewTextBoxColumn2.DataPropertyName = "IDUser";
            this.iDUserDataGridViewTextBoxColumn2.HeaderText = "IDUser";
            this.iDUserDataGridViewTextBoxColumn2.Name = "iDUserDataGridViewTextBoxColumn2";
            // 
            // ngayNhapDataGridViewTextBoxColumn
            // 
            this.ngayNhapDataGridViewTextBoxColumn.DataPropertyName = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.HeaderText = "NgayNhap";
            this.ngayNhapDataGridViewTextBoxColumn.Name = "ngayNhapDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn1
            // 
            this.tongTienDataGridViewTextBoxColumn1.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn1.HeaderText = "TongTien";
            this.tongTienDataGridViewTextBoxColumn1.Name = "tongTienDataGridViewTextBoxColumn1";
            // 
            // but_XemCTPN
            // 
            this.but_XemCTPN.Location = new System.Drawing.Point(240, 41);
            this.but_XemCTPN.Name = "but_XemCTPN";
            this.but_XemCTPN.Size = new System.Drawing.Size(98, 23);
            this.but_XemCTPN.TabIndex = 2;
            this.but_XemCTPN.Text = "Xem chi tiết";
            this.but_XemCTPN.UseVisualStyleBackColor = true;
            // 
            // cbb_quyenus
            // 
            this.cbb_quyenus.FormattingEnabled = true;
            this.cbb_quyenus.Location = new System.Drawing.Point(342, 140);
            this.cbb_quyenus.Name = "cbb_quyenus";
            this.cbb_quyenus.Size = new System.Drawing.Size(99, 21);
            this.cbb_quyenus.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 514);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataSetUser)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabNguoiDung.ResumeLayout(false);
            this.tabNguoiDung.PerformLayout();
            this.tabDonHang.ResumeLayout(false);
            this.tabDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataSet1)).EndInit();
            this.tabNhapHang.ResumeLayout(false);
            this.tabSanPham.ResumeLayout(false);
            this.tabSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhMucSPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataSetDanhMucSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNguoiDung;
        private System.Windows.Forms.TabPage tabDonHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private MobileDataSetUser mobileDataSetUser;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private MobileDataSetUserTableAdapters.NguoiDungTableAdapter nguoiDungTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_Ngaysinh;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Sodt;
        private System.Windows.Forms.TextBox txt_Addres;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TabPage tabNhapHang;
        private System.Windows.Forms.TabPage tabTonKho;
        private System.Windows.Forms.Button but_dele;
        private System.Windows.Forms.Button but_update;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.TextBox txt_Tim;
        private System.Windows.Forms.ComboBox cbb_loaitimkiem;
        private System.Windows.Forms.Button but_Tim;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.DataGridView GridViewSP;
        private MobileDataSet mobileDataSet;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private MobileDataSetTableAdapters.SanPhamTableAdapter sanPhamTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button but_timhinhsp;
        private System.Windows.Forms.Button but_xoasp;
        private System.Windows.Forms.Button but_suasp;
        private System.Windows.Forms.Button but_addsp;
        private System.Windows.Forms.TextBox txt_ghichusp;
        private System.Windows.Forms.TextBox txt_hinhanhsp;
        private System.Windows.Forms.TextBox txt_soluongsp;
        private System.Windows.Forms.TextBox txt_giasp;
        private System.Windows.Forms.TextBox txt_motasp;
        private System.Windows.Forms.TextBox txt_tenspsp;
        private System.Windows.Forms.TextBox txt_maspsp;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhAnhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDMDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbb_danhmucsp;
        private System.Windows.Forms.TextBox txt_timsp;
        private System.Windows.Forms.ComboBox cbb_loaitimsp;
        private System.Windows.Forms.Button but_timsp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView GridViewDM;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private MobileDataSetDanhMucSP mobileDataSetDanhMucSP;
        private System.Windows.Forms.BindingSource danhMucSPBindingSource;
        private MobileDataSetDanhMucSPTableAdapters.DanhMucSPTableAdapter danhMucSPTableAdapter;
        private System.Windows.Forms.TextBox txt_timdm;
        private System.Windows.Forms.ComboBox cbb_loaitimdm;
        private System.Windows.Forms.Button but_timdm;
        private System.Windows.Forms.Button but_Xoadm;
        private System.Windows.Forms.Button but_Suadm;
        private System.Windows.Forms.Button but_Themdm;
        private System.Windows.Forms.TextBox txt_tendmdm;
        private System.Windows.Forms.TextBox txt_madmdm;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDMDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_mdhdh;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.TextBox txt_ngaylapdh;
        private System.Windows.Forms.TextBox txt_idusdh;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView GridViewDH;
        private MobileDataSet1 mobileDataSet1;
        private System.Windows.Forms.BindingSource donHangBindingSource;
        private MobileDataSet1TableAdapters.DonHangTableAdapter donHangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUserDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDatHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbb_trangthaidh;
        private System.Windows.Forms.Button but_capnhatdh;
        private System.Windows.Forms.Button but_xemCTDH;
        private System.Windows.Forms.TextBox txt_Timdh;
        private System.Windows.Forms.ComboBox cbb_timdh;
        private System.Windows.Forms.Button but_Timhd;
        private System.Windows.Forms.DataGridView GridViewNhapHang;
        private MobileDataSet2 mobileDataSet2;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private MobileDataSet2TableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.Button but_Thempn;
        private System.Windows.Forms.Button but_XemCTPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUserDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ComboBox cbb_quyenus;
    }
}

