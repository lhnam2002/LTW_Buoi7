using BUS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDKChuyenNganh : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();
        public frmDKChuyenNganh()
        {
            InitializeComponent();
        }

        private void frmDKChuyenNganh_Load(object sender, EventArgs e)
        {
            try
            {
                var listFacultys = facultyService.GetAll();
                FillFalcultyCombobox(listFacultys);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            this.cmbFaculty.DataSource = listFacultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty selectedFaculty = cmbFaculty.SelectedItem as Faculty;
            if(selectedFaculty != null)
            {
                var listMajor = majorService.GetAllByFaculty(selectedFaculty.FacultyID);
                FillMajorCombobox(listMajor);
                var listStudents = studentService.GetAllHasNoMajor(selectedFaculty.FacultyID);
                BindGrid(listStudents);
            }
        }

        private void FillMajorCombobox(List<Major> listMajor)
        {
            this.cmbChuyenNganh.DataSource = listMajor;
            this.cmbChuyenNganh.DisplayMember ="Name";
            this.cmbChuyenNganh.ValueMember = "MajorID";
        }

        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[1].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[2].Value = item.FullName;
                if (item.Faculty != null)
                    dgvStudent.Rows[index].Cells[3].Value =item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[4].Value = item.AverageScore + "";
                if (item.MajorID != null)
                    dgvStudent.Rows[index].Cells[5].Value = item.Major.Name + "";
             
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvStudent.Rows.Count; i++)
                {
                    if (Checktick())
                    {
                        if (dgvStudent.Rows[i].Cells[0].Value != null && dgvStudent.Rows[i].Cells[0].Value.Equals(true))
                        {
                            var student = studentService.FindByid(dgvStudent.Rows[i].Cells[1].Value.ToString());
                            student.MajorID = (int)cmbChuyenNganh.SelectedValue;
                            studentService.InserUpdate(student);
                            MessageBox.Show("Đăng ký chuyên ngành thành công!!!", "Thông báo", MessageBoxButtons.OK);
                            frmDKChuyenNganh_Load(sender, e);
                        }
                    }
                    else
                        MessageBox.Show("Không có sinh viên nào được chọn!!!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool Checktick()
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
                if (dgvStudent.Rows[i].Cells[0].Value != null)
                    return true;
            return false;
        }
    }

}
