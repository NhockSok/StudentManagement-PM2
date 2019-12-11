using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.StudentManagement
{
    class StudentView
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Class { get; set; }
        public string Email { get; set; }
        public string Home_Town { get; set; }
        public string Faculty { get; set; }
        public StudentView(Student student)
        {
            this.Id = student.Id;
            this.Code = student.Code;
            this.Name = student.Name;
            this.Birthday = student.Birthday;
            this.Class = student.Class.Name;
            this.Email = student.Email;
            this.Home_Town = student.Home_Town;
            this.Faculty = student.Faculty.Faculty_Name;
        }
    }
}
