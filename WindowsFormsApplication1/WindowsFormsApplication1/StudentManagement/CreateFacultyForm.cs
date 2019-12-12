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
    public partial class CreateFacultyForm : Form
    {
        private LogicLayer Business;
        public CreateFacultyForm()
        {
            InitializeComponent();
            this.Business = new LogicLayer();
            this.Load += CreateFacultyForm_Load;
            this.grdFaculty.CellClick += GrdFaculty_CellClick;
            this.btnAddFaculty.Click += BtnAddFaculty_Click;
            this.btnUpdateFaculty.Click += BtnUpdateFaculty_Click;
            this.btnDeleteFaculty.Click += BtnDeleteFaculty_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDeleteFaculty_Click(object sender, EventArgs e)
        {
            var db = new OOPServerEntities3();
            string facultyname = this.grdFaculty.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Are you sure to delete this", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Faculty faculty = db.Faculties.Single(x => x.Faculty_Name.Equals(facultyname));
                    db.Faculties.Remove(faculty);
                    db.SaveChanges();
                    this.LoadAllFaculty();
                    MessageBox.Show("Delete successfully");
                }
                catch
                {
                    MessageBox.Show("Delete failed");
                }
            }
        }
        private void BtnUpdateFaculty_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new OOPServerEntities3();
                string facultyname = this.grdFaculty.CurrentRow.Cells[0].Value.ToString();
                Faculty faculty = db.Faculties.Single(x => x.Faculty_Name.Equals(facultyname));
                faculty.Faculty_Name = this.txtFacultyName.Text;
                db.SaveChanges();
                this.LoadAllFaculty();
                MessageBox.Show("Update Faculty Successfully");
            }
            catch
            {
                MessageBox.Show("Update Faculty Failed");
            }
        }

        private void BtnAddFaculty_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new OOPServerEntities3();
                Faculty faculty = new Faculty();
                faculty.Faculty_Name = this.txtFacultyName.Text;
                db.Faculties.Add(faculty);
                db.SaveChanges();
                this.LoadAllFaculty();
                MessageBox.Show("Add Faculty Successfully");
            }
            catch
            {
                MessageBox.Show("Add Faculty Failed");
            }
        }

        private void GrdFaculty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var db = new OOPServerEntities3();
            string Facultyname = this.grdFaculty.CurrentRow.Cells[0].Value.ToString();
            Faculty faculty = db.Faculties.Single(x => x.Faculty_Name.Equals(Facultyname));
            this.txtFacultyName.Text = faculty.Faculty_Name;
        }

        private void CreateFacultyForm_Load(object sender, EventArgs e)
        {
            this.LoadAllFaculty();
        }
        private void LoadAllFaculty()
        {
            var db = new OOPServerEntities3();
            this.grdFaculty.DataSource = db.Faculties.Select(x => new
            {
                FacultyName = x.Faculty_Name
            }).ToList();
            this.grdFaculty.Columns[0].HeaderText = "Faculty name";

        }
    }
}
