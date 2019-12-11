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
    public partial class StatisticForm : Form
    {
        private LogicLayer Business;
        public StatisticForm()
        {
            this.Business = new LogicLayer();
            InitializeComponent();
            this.Load += StatisticForm_Load;
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            this.ShowAllFacullty();
        }
        private void ShowAllFacullty()
        {
            var faculty = this.Business.getStatistics();
            var facultyviews = new StatisticView[faculty.Length];
            for (int i = 0; i < facultyviews.Length; i++)
            {
                facultyviews[i] = new StatisticView(faculty[i]);
            }
            grdStatistic.DataSource = facultyviews;
            this.grdStatistic.Columns[0].HeaderText = "Faculty name";
            this.grdStatistic.Columns[1].HeaderText = "Number of Student";
        }

    }
}
