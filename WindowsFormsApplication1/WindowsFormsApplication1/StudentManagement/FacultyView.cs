using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.StudentManagement
{
    class FacultyView
    {
        public int Id { get; set; }
        public string Faculty_Name { get; set; }
        public FacultyView(Faculty faculty)
        {
            this.Id = faculty.Id;
            this.Faculty_Name = faculty.Faculty_Name;

        }
    }
}
