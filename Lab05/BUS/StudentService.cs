using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StudentService
    {
        public List<Student> GetAll()
        {
            Model1 context = new Model1();
            return context.Students.ToList();
        }

        public List<Student> GetAllHasNoMajor()
        {
            Model1 context = new Model1();
            return context.Students.Where(p=> p.MajorID == null).ToList();
        }
        public List<Student> GetAllHasNoMajor(int facultyID)
        {
            Model1 context = new Model1();
            return context.Students.Where(p=>p.MajorID == null && p.FacultyID == facultyID).ToList();
        }
        public Student FindByid(String studentId)
        {
            Model1 context = new Model1();
            return context.Students.FirstOrDefault(p => p.StudentID == studentId);
        }
        public void InserUpdate(Student s)
        {
            Model1 context = new Model1();
            context.Students.AddOrUpdate(s);
            context.SaveChanges();
        }

        public bool checkMSSV(string id)
        {
            Model1 context = new Model1();
            var student = context.Students.FirstOrDefault(s => s.StudentID == id);
            return student != null;
        }
        public bool checkInfo(string masv, string tensv, string dtb)
        {
            return !string.IsNullOrEmpty(masv) && !string.IsNullOrEmpty(tensv) 
                && !string.IsNullOrEmpty(dtb);
        }

        
    }
}
