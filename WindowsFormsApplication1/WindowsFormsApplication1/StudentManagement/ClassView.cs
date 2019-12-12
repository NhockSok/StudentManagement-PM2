using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.StudentManagement
{
    class ClassView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ClassView(Class classView)
        {
            this.Id = classView.Id;
            this.Name = classView.Name;           
        }
    }
}
