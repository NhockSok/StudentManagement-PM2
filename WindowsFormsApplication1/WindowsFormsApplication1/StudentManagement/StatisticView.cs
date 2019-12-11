using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.StudentManagement
{
    class StatisticView
    {
        public string Faculty_Name { get; set; }
        public int Number_of_Student { get; set; }
        public StatisticView(Faculty faculty)
        {
            this.Faculty_Name = faculty.Faculty_Name;
            this.Number_of_Student = faculty.Students.Count;
        }
    }
}
