using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.StudentManagement
{
    class SortView
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Faculty { get; set; }
        public double Average_Score { get; set; }
        public SortView(Student student)
        {
            this.Id = student.Id;
            this.Code = student.Code;
            this.Name = student.Name;
            this.Class = student.Class.Name;
            this.Faculty = student.Faculty.Faculty_Name;
            this.Average_Score = student.Average_Score;

        }
    }
}
