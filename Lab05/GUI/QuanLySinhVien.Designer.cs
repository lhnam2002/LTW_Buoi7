namespace GUI
{
    partial class frmQLSV
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
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.chkUnregisterMajor = new System.Windows.Forms.CheckBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKíChuyênNgànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(169, 332);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(59, 22);
            this.txtDTB.TabIndex = 40;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(167, 193);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(166, 22);
            this.txtHoTen.TabIndex = 39;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(168, 145);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(165, 22);
            this.txtMSSV.TabIndex = 38;
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbFaculty.Location = new System.Drawing.Point(167, 257);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(166, 24);
            this.cmbFaculty.TabIndex = 37;
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column3});
            this.dgvStudent.Location = new System.Drawing.Point(511, 169);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(768, 317);
            this.dgvStudent.TabIndex = 36;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MSSV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "HoTen";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Khoa";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Diem";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Chuyên ngành";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(29, 257);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(38, 16);
            this.lblKhoa.TabIndex = 35;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(30, 332);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(98, 16);
            this.lblDTB.TabIndex = 34;
            this.lblDTB.Text = "Điểm trung bình";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(29, 193);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 16);
            this.lblHoTen.TabIndex = 33;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(29, 145);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(99, 16);
            this.lblMSSV.TabIndex = 32;
            this.lblMSSV.Text = "Mã số sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Thông tin Sinh Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(315, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(778, 525);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(925, 525);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ảnh đại diện";
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(136, 385);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(338, 325);
            this.picAvatar.TabIndex = 46;
            this.picAvatar.TabStop = false;
            // 
            // chkUnregisterMajor
            // 
            this.chkUnregisterMajor.AutoSize = true;
            this.chkUnregisterMajor.Location = new System.Drawing.Point(1019, 121);
            this.chkUnregisterMajor.Name = "chkUnregisterMajor";
            this.chkUnregisterMajor.Size = new System.Drawing.Size(195, 20);
            this.chkUnregisterMajor.TabIndex = 47;
            this.chkUnregisterMajor.Text = "Chưa đăng kí Chuyên ngành";
            this.chkUnregisterMajor.UseVisualStyleBackColor = true;
            this.chkUnregisterMajor.CheckedChanged += new System.EventHandler(this.chkUnregisterMajor_CheckedChanged);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(1085, 525);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1291, 28);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngKíChuyênNgànhToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // đăngKíChuyênNgànhToolStripMenuItem
            // 
            this.đăngKíChuyênNgànhToolStripMenuItem.Name = "đăngKíChuyênNgànhToolStripMenuItem";
            this.đăngKíChuyênNgànhToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.đăngKíChuyênNgànhToolStripMenuItem.Text = "Đăng kí chuyên ngành";
            this.đăngKíChuyênNgànhToolStripMenuItem.Click += new System.EventHandler(this.đăngKíChuyênNgànhToolStripMenuItem_Click);
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 722);
            this.Controls.Add(this.chkUnregisterMajor);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lblDTB);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQLSV";
            this.Text = "Quan Ly Sinh Vien";
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.CheckBox chkUnregisterMajor;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKíChuyênNgànhToolStripMenuItem;
    }
}

