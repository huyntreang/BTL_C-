
namespace BTL_HSK
{
    partial class SanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTinSP = new System.Windows.Forms.GroupBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.cbMaNCC = new System.Windows.Forms.ComboBox();
            this.txtDoDai = new System.Windows.Forms.TextBox();
            this.txtNguyenLieuChinh = new System.Windows.Forms.TextBox();
            this.txtChatLieu = new System.Windows.Forms.TextBox();
            this.txtMauSac = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.cbMaLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblDoDai = new System.Windows.Forms.Label();
            this.lblNguyenLieuChinh = new System.Windows.Forms.Label();
            this.lblChatLieu = new System.Windows.Forms.Label();
            this.lblMauSac = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaLoaiSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHienThiDSSP = new System.Windows.Forms.DataGridView();
            this.grbThongTinSP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(354, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // grbThongTinSP
            // 
            this.grbThongTinSP.Controls.Add(this.txtSL);
            this.grbThongTinSP.Controls.Add(this.lblSL);
            this.grbThongTinSP.Controls.Add(this.cbMaNCC);
            this.grbThongTinSP.Controls.Add(this.txtDoDai);
            this.grbThongTinSP.Controls.Add(this.txtNguyenLieuChinh);
            this.grbThongTinSP.Controls.Add(this.txtChatLieu);
            this.grbThongTinSP.Controls.Add(this.txtMauSac);
            this.grbThongTinSP.Controls.Add(this.txtSoLuong);
            this.grbThongTinSP.Controls.Add(this.txtTenSP);
            this.grbThongTinSP.Controls.Add(this.cbMaLoaiSP);
            this.grbThongTinSP.Controls.Add(this.txtMaSP);
            this.grbThongTinSP.Controls.Add(this.lblMaNCC);
            this.grbThongTinSP.Controls.Add(this.lblDoDai);
            this.grbThongTinSP.Controls.Add(this.lblNguyenLieuChinh);
            this.grbThongTinSP.Controls.Add(this.lblChatLieu);
            this.grbThongTinSP.Controls.Add(this.lblMauSac);
            this.grbThongTinSP.Controls.Add(this.lblSoLuong);
            this.grbThongTinSP.Controls.Add(this.lblTenSP);
            this.grbThongTinSP.Controls.Add(this.lblMaLoaiSP);
            this.grbThongTinSP.Controls.Add(this.lblMaSP);
            this.grbThongTinSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinSP.Location = new System.Drawing.Point(23, 53);
            this.grbThongTinSP.Name = "grbThongTinSP";
            this.grbThongTinSP.Size = new System.Drawing.Size(459, 458);
            this.grbThongTinSP.TabIndex = 1;
            this.grbThongTinSP.TabStop = false;
            this.grbThongTinSP.Text = "Thông tin sản phẩm";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(179, 419);
            this.txtSL.Name = "txtSL";
            this.txtSL.ReadOnly = true;
            this.txtSL.Size = new System.Drawing.Size(237, 27);
            this.txtSL.TabIndex = 9;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.Location = new System.Drawing.Point(17, 419);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(143, 20);
            this.lblSL.TabIndex = 27;
            this.lblSL.Text = "Số lượng tìm thấy:";
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.Location = new System.Drawing.Point(179, 373);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(237, 30);
            this.cbMaNCC.TabIndex = 8;
            // 
            // txtDoDai
            // 
            this.txtDoDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoDai.Location = new System.Drawing.Point(179, 331);
            this.txtDoDai.Name = "txtDoDai";
            this.txtDoDai.Size = new System.Drawing.Size(237, 28);
            this.txtDoDai.TabIndex = 7;
            // 
            // txtNguyenLieuChinh
            // 
            this.txtNguyenLieuChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguyenLieuChinh.Location = new System.Drawing.Point(179, 289);
            this.txtNguyenLieuChinh.Name = "txtNguyenLieuChinh";
            this.txtNguyenLieuChinh.Size = new System.Drawing.Size(237, 28);
            this.txtNguyenLieuChinh.TabIndex = 6;
            // 
            // txtChatLieu
            // 
            this.txtChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChatLieu.Location = new System.Drawing.Point(179, 247);
            this.txtChatLieu.Name = "txtChatLieu";
            this.txtChatLieu.Size = new System.Drawing.Size(237, 28);
            this.txtChatLieu.TabIndex = 5;
            // 
            // txtMauSac
            // 
            this.txtMauSac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMauSac.Location = new System.Drawing.Point(179, 205);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(237, 28);
            this.txtMauSac.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(179, 163);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(237, 28);
            this.txtSoLuong.TabIndex = 3;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(179, 121);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(237, 28);
            this.txtTenSP.TabIndex = 2;
            // 
            // cbMaLoaiSP
            // 
            this.cbMaLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaLoaiSP.FormattingEnabled = true;
            this.cbMaLoaiSP.Location = new System.Drawing.Point(179, 77);
            this.cbMaLoaiSP.Name = "cbMaLoaiSP";
            this.cbMaLoaiSP.Size = new System.Drawing.Size(237, 30);
            this.cbMaLoaiSP.TabIndex = 1;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(179, 35);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(237, 28);
            this.txtMaSP.TabIndex = 0;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.Location = new System.Drawing.Point(32, 379);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(50, 20);
            this.lblMaNCC.TabIndex = 17;
            this.lblMaNCC.Text = "NCC:";
            this.lblMaNCC.Click += new System.EventHandler(this.lblMaNCC_Click);
            // 
            // lblDoDai
            // 
            this.lblDoDai.AutoSize = true;
            this.lblDoDai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoDai.Location = new System.Drawing.Point(32, 337);
            this.lblDoDai.Name = "lblDoDai";
            this.lblDoDai.Size = new System.Drawing.Size(62, 20);
            this.lblDoDai.TabIndex = 16;
            this.lblDoDai.Text = "Độ dài:";
            // 
            // lblNguyenLieuChinh
            // 
            this.lblNguyenLieuChinh.AutoSize = true;
            this.lblNguyenLieuChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguyenLieuChinh.Location = new System.Drawing.Point(32, 295);
            this.lblNguyenLieuChinh.Name = "lblNguyenLieuChinh";
            this.lblNguyenLieuChinh.Size = new System.Drawing.Size(146, 20);
            this.lblNguyenLieuChinh.TabIndex = 15;
            this.lblNguyenLieuChinh.Text = "Nguyên liệu chính:";
            // 
            // lblChatLieu
            // 
            this.lblChatLieu.AutoSize = true;
            this.lblChatLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatLieu.Location = new System.Drawing.Point(32, 253);
            this.lblChatLieu.Name = "lblChatLieu";
            this.lblChatLieu.Size = new System.Drawing.Size(80, 20);
            this.lblChatLieu.TabIndex = 14;
            this.lblChatLieu.Text = "Chất liệu:";
            // 
            // lblMauSac
            // 
            this.lblMauSac.AutoSize = true;
            this.lblMauSac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMauSac.Location = new System.Drawing.Point(32, 211);
            this.lblMauSac.Name = "lblMauSac";
            this.lblMauSac.Size = new System.Drawing.Size(78, 20);
            this.lblMauSac.TabIndex = 13;
            this.lblMauSac.Text = "Màu sắc:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(32, 169);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(79, 20);
            this.lblSoLuong.TabIndex = 12;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(32, 127);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(120, 20);
            this.lblTenSP.TabIndex = 11;
            this.lblTenSP.Text = "Tên sản phẩm:";
            this.lblTenSP.Click += new System.EventHandler(this.lblTenSP_Click);
            // 
            // lblMaLoaiSP
            // 
            this.lblMaLoaiSP.AutoSize = true;
            this.lblMaLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoaiSP.Location = new System.Drawing.Point(32, 83);
            this.lblMaLoaiSP.Name = "lblMaLoaiSP";
            this.lblMaLoaiSP.Size = new System.Drawing.Size(73, 20);
            this.lblMaLoaiSP.TabIndex = 10;
            this.lblMaLoaiSP.Text = "Loại SP:";
            this.lblMaLoaiSP.Click += new System.EventHandler(this.lblMaLoaiSP_Click);
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(32, 41);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(115, 20);
            this.lblMaSP.TabIndex = 9;
            this.lblMaSP.Text = "Mã sản phẩm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 527);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 165);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(188, 109);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 37);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(319, 109);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 37);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(50, 46);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 37);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(179, 46);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 37);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(50, 109);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 37);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(306, 46);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 37);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHienThiDSSP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(552, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 511);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hiển thị sản phẩm";
            // 
            // dgvHienThiDSSP
            // 
            this.dgvHienThiDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThiDSSP.Location = new System.Drawing.Point(6, 35);
            this.dgvHienThiDSSP.Name = "dgvHienThiDSSP";
            this.dgvHienThiDSSP.RowHeadersWidth = 51;
            this.dgvHienThiDSSP.RowTemplate.Height = 24;
            this.dgvHienThiDSSP.Size = new System.Drawing.Size(636, 448);
            this.dgvHienThiDSSP.TabIndex = 16;
            this.dgvHienThiDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienThiDSSP_CellClick);
            this.dgvHienThiDSSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienThiDSSP_CellContentClick);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1241, 741);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbThongTinSP);
            this.Controls.Add(this.label1);
            this.Name = "SanPham";
            this.Text = "0";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.grbThongTinSP.ResumeLayout(false);
            this.grbThongTinSP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThiDSSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTinSP;
        private System.Windows.Forms.ComboBox cbMaNCC;
        private System.Windows.Forms.TextBox txtDoDai;
        private System.Windows.Forms.TextBox txtNguyenLieuChinh;
        private System.Windows.Forms.TextBox txtChatLieu;
        private System.Windows.Forms.TextBox txtMauSac;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cbMaLoaiSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblDoDai;
        private System.Windows.Forms.Label lblNguyenLieuChinh;
        private System.Windows.Forms.Label lblChatLieu;
        private System.Windows.Forms.Label lblMauSac;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaLoaiSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHienThiDSSP;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.Button btnReset;
    }
}