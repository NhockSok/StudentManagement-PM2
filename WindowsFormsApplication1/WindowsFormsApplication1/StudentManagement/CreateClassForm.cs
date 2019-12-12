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
    public partial class CreateClassForm : Form
    {
        private LogicLayer Business;
        public CreateClassForm()
        {
            InitializeComponent();
            this.Business = new LogicLayer();
            this.Load += CreateClassForm_Load;
            this.grdClass.CellClick += GrdClass_CellClick;
            this.btnAddClass.Click += BtnAddClass_Click;
            this.btnUpdateClass.Click += BtnUpdateClass_Click;
            this.btnDeleteClass.Click += BtnDeleteClass_Click;
            this.btnCancel.Click += BtnCancel_Click;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDeleteClass_Click(object sender, EventArgs e)
        {
            var db = new OOPServerEntities3();
            string classname = this.grdClass.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Are you sure to delete this", "Confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    Class @class = db.Classes.Single(x => x.Name.Equals(classname));
                    db.Classes.Remove(@class);
                    db.SaveChanges();
                    this.LoadAllClass();
                    MessageBox.Show("Delete successfully");
                }
                catch
                {
                    MessageBox.Show("Delete failed");
                }
            }
        }
        private void BtnUpdateClass_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new OOPServerEntities3();
                string classname = this.grdClass.CurrentRow.Cells[0].Value.ToString();
                Class @class = db.Classes.Single(x => x.Name.Equals(classname));
                @class.Name = this.txtClassName.Text;
                db.SaveChanges();
                this.LoadAllClass();
                MessageBox.Show("Update Class Successfully");
            }
            catch
            {
                MessageBox.Show("Update Class Failed");
            }
        }

        private void BtnAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new OOPServerEntities3();
                Class @class = new Class();
                @class.Name = this.txtClassName.Text;
                db.Classes.Add(@class);
                db.SaveChanges();
                this.LoadAllClass();
                MessageBox.Show("Add Class Successfully");
            }
            catch
            {
                MessageBox.Show("Add Class Failed");   
            }
        }

        private void GrdClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var db = new OOPServerEntities3();
            string classname = this.grdClass.CurrentRow.Cells[0].Value.ToString();
            Class @class = db.Classes.Single(x => x.Name.Equals(classname));
            this.txtClassName.Text = @class.Name;
        }

        private void CreateClassForm_Load(object sender, EventArgs e)
        {
            this.LoadAllClass();
        }
        private void LoadAllClass()
        {
            var db = new OOPServerEntities3();
            this.grdClass.DataSource = db.Classes.Select(x => new
            {
                Name = x.Name
            }).ToList();
            this.grdClass.Columns[0].HeaderText = "Class name";

            //var classes = this.Business.GetClasses();
            //var classViews = new ClassView[classes.Length];
            //for (int i = 0; i < classViews.Length; i++)
            //{
            //    classViews[i] = new ClassView(classes[i]);
            //}
            //this.grdClass.DataSource = classViews;
        }
    }
}
