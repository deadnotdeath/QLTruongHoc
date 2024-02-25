namespace QLTruongHoc
{
    partial class UCThongTin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHoVaTen = new TextBox();
            txtDiaChi = new TextBox();
            txtCMND = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            gvThongTin = new DataGridView();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            lblNgaySinh = new Label();
            lblCMND = new Label();
            lblDiaChi = new Label();
            lblHoVaTen = new Label();
            txtID = new TextBox();
            lblID = new Label();
            lblGioiTinh = new Label();
            cbbGioiTinh = new ComboBox();
            lblSoDienThoai = new Label();
            lblEmail = new Label();
            txtSoDienThoai = new TextBox();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gvThongTin).BeginInit();
            SuspendLayout();
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(187, 91);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(248, 27);
            txtHoVaTen.TabIndex = 23;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(187, 132);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(248, 27);
            txtDiaChi.TabIndex = 22;
            // 
            // txtCMND
            // 
            txtCMND.Location = new Point(187, 204);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(134, 27);
            txtCMND.TabIndex = 21;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(185, 240);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 20;
            // 
            // gvThongTin
            // 
            gvThongTin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvThongTin.Location = new Point(478, 43);
            gvThongTin.Name = "gvThongTin";
            gvThongTin.RowHeadersWidth = 51;
            gvThongTin.Size = new Size(300, 376);
            gvThongTin.TabIndex = 19;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(328, 390);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(185, 390);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(56, 390);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(56, 240);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(76, 20);
            lblNgaySinh.TabIndex = 15;
            lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblCMND
            // 
            lblCMND.AutoSize = true;
            lblCMND.Location = new Point(56, 204);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(53, 20);
            lblCMND.TabIndex = 14;
            lblCMND.Text = "CMND";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(56, 132);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(57, 20);
            lblDiaChi.TabIndex = 13;
            lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Location = new Point(56, 94);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(76, 20);
            lblHoVaTen.TabIndex = 12;
            lblHoVaTen.Text = "Họ Và Tên";
            // 
            // txtID
            // 
            txtID.Location = new Point(187, 49);
            txtID.Name = "txtID";
            txtID.Size = new Size(92, 27);
            txtID.TabIndex = 24;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(56, 52);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 25;
            lblID.Text = "ID";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(56, 168);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(68, 20);
            lblGioiTinh.TabIndex = 26;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // cbbGioiTinh
            // 
            cbbGioiTinh.AllowDrop = true;
            cbbGioiTinh.FormattingEnabled = true;
            cbbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbGioiTinh.Location = new Point(185, 168);
            cbbGioiTinh.Name = "cbbGioiTinh";
            cbbGioiTinh.Size = new Size(94, 28);
            cbbGioiTinh.TabIndex = 27;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(56, 281);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(102, 20);
            lblSoDienThoai.TabIndex = 28;
            lblSoDienThoai.Text = "Số Điện Thoại";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(56, 317);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 29;
            lblEmail.Text = "Email";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(185, 284);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(136, 27);
            txtSoDienThoai.TabIndex = 30;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(186, 324);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(236, 27);
            txtEmail.TabIndex = 31;
            // 
            // UCThongTin
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtEmail);
            Controls.Add(txtSoDienThoai);
            Controls.Add(lblEmail);
            Controls.Add(lblSoDienThoai);
            Controls.Add(cbbGioiTinh);
            Controls.Add(lblGioiTinh);
            Controls.Add(lblID);
            Controls.Add(txtID);
            Controls.Add(txtHoVaTen);
            Controls.Add(txtDiaChi);
            Controls.Add(txtCMND);
            Controls.Add(dtpNgaySinh);
            Controls.Add(gvThongTin);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblCMND);
            Controls.Add(lblDiaChi);
            Controls.Add(lblHoVaTen);
            Name = "UCThongTin";
            Size = new Size(798, 477);
            ((System.ComponentModel.ISupportInitialize)gvThongTin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoVaTen;
        private TextBox txtDiaChi;
        private TextBox txtCMND;
        private DateTimePicker dtpNgaySinh;
        private DataGridView gvThongTin;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Label lblNgaySinh;
        private Label lblCMND;
        private Label lblDiaChi;
        private Label lblHoVaTen;
        private TextBox txtID;
        private Label lblID;
        private Label lblGioiTinh;
        private ComboBox cbbGioiTinh;
        private Label lblSoDienThoai;
        private Label lblEmail;
        private TextBox txtSoDienThoai;
        private TextBox txtEmail;
    }
}
