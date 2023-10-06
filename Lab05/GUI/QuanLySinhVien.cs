using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entities;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace GUI
{
    public partial class frmQLSV : Form
    {
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvStudent);
                var listFacultys = facultyService.GetAll();
                var listStudents = studentService.GetAll();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
            } 
            catch 
            (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            listFacultys.Insert(0, new Faculty());
            this.cmbFaculty.DataSource = listFacultys;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                    dgvStudent.Rows[index].Cells[2].Value =
                    item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore + "";
                if (item.MajorID != null)
                    dgvStudent.Rows[index].Cells[4].Value = item.Major.Name + "";
                //ShowAvatar(item.Avatar);
            }
        }
        private void ShowAvatar(string ImageName)
        {
            if (string.IsNullOrEmpty(ImageName))
            {
                picAvatar.Image =null;
            }
            else
            {
                string parentDirectory =
                Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagePath = Path.Combine(parentDirectory, "Images",ImageName);
                picAvatar.Image = Image.FromFile(imagePath);
                picAvatar.Refresh();
            }
        }
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle =
            DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0 && dgvStudent.SelectedRows[0].Cells[0].Value!=null)
            {
                    txtMSSV.Text = dgvStudent.SelectedRows[0].Cells[0].Value.ToString();
                    txtHoTen.Text = dgvStudent.SelectedRows[0].Cells[1].Value.ToString();
                    cmbFaculty.Text = dgvStudent.SelectedRows[0].Cells[2].Value.ToString();
                    txtDTB.Text = dgvStudent.SelectedRows[0].Cells[3].Value.ToString();
                    Model1 context = new Model1();
                    Student student = context.Students.FirstOrDefault(x => x.StudentID == txtMSSV.Text);
                    ShowAvatar(student.Avatar);
            }
        }

        private void chkUnregisterMajor_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.chkUnregisterMajor.Checked)
                listStudents = studentService.GetAllHasNoMajor();
            else
                listStudents = studentService.GetAll();
            BindGrid(listStudents);
        }

        private void đăngKíChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDKChuyenNganh fr2 = new frmDKChuyenNganh();
            fr2.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                    Model1 context = new Model1();
                    Student s = new Student();

                    if (!studentService.checkMSSV(txtMSSV.Text))
                    {
                        Student a = new Student();
                        a.StudentID = txtMSSV.Text;
                        a.FullName = txtHoTen.Text;
                        a.AverageScore = float.Parse(txtDTB.Text);
                        a.FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                        a.Major = null;
                        a.Avatar = null;
                        context.Students.Add(a);
                        context.SaveChanges();
                        MessageBox.Show("Thêm thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmQLSV_Load(sender, e);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Model1 context = new Model1();
                Student x = context.Students.FirstOrDefault(p => p.StudentID == txtMSSV.Text);
                if( x != null)
                {
                    context.Students.Remove(x);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmQLSV_Load(sender, e);
                }    
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message) ;
            }

            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (studentService.checkInfo(txtMSSV.Text, txtHoTen.Text, txtDTB.Text))
                {
                    if (studentService.checkMSSV(txtMSSV.Text))
                    {
                        Model1 context = new Model1();
                        var a = studentService.FindByid(txtMSSV.Text);
                        if (a != null)
                        {
                            a.FullName = txtHoTen.Text;
                            a.AverageScore = float.Parse(txtDTB.Text);
                            a.FacultyID = (int)cmbFaculty.SelectedValue;
                            studentService.InserUpdate(a);

                            MessageBox.Show("Sửa thành công", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmQLSV_Load(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên với MSSV này", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
