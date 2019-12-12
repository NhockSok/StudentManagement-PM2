using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.StudentManagement
{
    public partial class SortForm : Form
    {
        private LogicLayer Business;
        public SortForm()
        {
            this.Business = new LogicLayer();
            InitializeComponent();
            this.Load += SortForm_Load;
        }

        private void SortForm_Load(object sender, EventArgs e)
        {
            this.ShowAllSort();
        }
        private void ShowAllSort()
        {
            var sort = this.Business.getSort();
            var SortView = new SortView[sort.Length];
            for (int i = 0; i < sort.Length; i++)
                SortView[i] = new SortView(sort[i]);
            this.grdSort.DataSource = SortView.OrderBy(x =>x.Average_Score).ToList();

        }
    }
}
