using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.StudentManagement
{
    class LogicLayer
    {
        public Student[] GetStudents()
        {
            var db = new OOPServerEntities3();
            return db.Students.ToArray();
        }

        public Student GetStudent(int id)
        {
            var db = new OOPServerEntities3();
            return db.Students.Find(id);
        }

        public void CreateStudent(string code, string name, DateTime birthday, int class_id, string email, string hometown, int faculty, double averageScore)
        {
            var student = new Student();
            student.Code = code;
            student.Name = name;
            student.Birthday = birthday;
            student.Class_id = class_id;
            student.Email = email;
            student.Home_Town = hometown;
            student.Faculty_ID = faculty;
            student.Average_Score = averageScore;

            var db = new OOPServerEntities3();
            db.Students.Add(student);
            db.SaveChanges();
        }

        public void UpdateStudent(int id, string code, string name, DateTime birthday, int class_id, string email, string hometown, int faculty, double averageScore)
        {
            var db = new OOPServerEntities3();
            var student = db.Students.Find(id);

            student.Code = code;
            student.Name = name;
            student.Birthday = birthday;
            student.Class_id = class_id;
            student.Email = email;
            student.Home_Town = hometown;
            student.Faculty_ID = faculty;
            student.Average_Score = averageScore;

            db.Entry(student).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var db = new OOPServerEntities3();
            var student = db.Students.Find(id);

            db.Students.Remove(student);
            db.SaveChanges();
        }
        public Class[] GetClasses()
        {
            var db = new OOPServerEntities3();
            return db.Classes.ToArray();
        }

        public Class GetClass(int id)
        {
            var db = new OOPServerEntities3();
            return db.Classes.Find(id);
        }
        public void DeleteClass(int id)
        {
            var db = new OOPServerEntities3();
            var @class = db.Classes.Find(id);

            db.Classes.Remove(@class);
            db.SaveChanges();
        } 
        public Faculty[] getFacultyes()
        {
            var db = new OOPServerEntities3();
            return db.Faculties.ToArray();
        }

        public Faculty GetFaculty(int id)
        {
            var db = new OOPServerEntities3();
            return db.Faculties.Find(id);
        }

        public void DeleteFacuty(int id)
        {
            var db = new OOPServerEntities3();
            var @Faculty = db.Faculties.Find(id);

            db.Faculties.Remove(@Faculty);
            db.SaveChanges();
        }
        public Faculty[] getStatistics()
        {
            var db = new OOPServerEntities3();
            return db.Faculties.ToArray();
        }
        public Student[] getSort()
        {
            var db = new OOPServerEntities3();
            return db.Students.ToArray();
        }
    }
}
