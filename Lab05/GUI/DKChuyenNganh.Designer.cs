namespace GUI
{
    partial class frmDKChuyenNganh
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.cmbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.ChonDangKy = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChonDangKy,
            this.StudentID,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvStudent.Location = new System.Drawing.Point(106, 210);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(785, 311);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chuyên ngành";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(431, 98);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(253, 24);
            this.cmbFaculty.TabIndex = 3;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // cmbChuyenNganh
            // 
            this.cmbChuyenNganh.FormattingEnabled = true;
            this.cmbChuyenNganh.Location = new System.Drawing.Point(431, 139);
            this.cmbChuyenNganh.Name = "cmbChuyenNganh";
            this.cmbChuyenNganh.Size = new System.Drawing.Size(253, 24);
            this.cmbChuyenNganh.TabIndex = 4;
            // 
            // ChonDangKy
            // 
            this.ChonDangKy.HeaderText = "ChonDangKy";
            this.ChonDangKy.MinimumWidth = 6;
            this.ChonDangKy.Name = "ChonDangKy";
            this.ChonDangKy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChonDangKy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChonDangKy.Width = 125;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "MSSV";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Họ Tên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Khoa";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DTB";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(345, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "Đăng kí chuyên ngành";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(421, 537);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(94, 41);
            this.btnRegister.TabIndex = 32;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmDKChuyenNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 590);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbChuyenNganh);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvStudent);
            this.Name = "frmDKChuyenNganh";
            this.Text = "DKChuyenNganh";
            this.Load += new System.EventHandler(this.frmDKChuyenNganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.ComboBox cmbChuyenNganh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChonDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegister;
    }
}