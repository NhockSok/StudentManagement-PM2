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
    public partial class CreateForm : Form
    {
        private LogicLayer Business;
        public CreateForm()
        {
            InitializeComponent();
            this.Business = new LogicLayer();
            this.Load += CreateForm_Load;
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }
        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                var code = this.txtCode.Text;
                var name = this.txtName.Text;
                var birthday = this.dtpBirthday.Value;
                var class_id = (int)this.cboClass.SelectedValue;
                var email = this.txtEmail.Text;
                var hometown = this.txtHometown.Text;
                var faculty = (int)this.cboFaculty.SelectedValue;
                var averageScore = Double.Parse(this.txtAverageScore.Text);
                this.Business.CreateStudent(code, name, birthday, class_id, email, hometown, faculty, averageScore);
                MessageBox.Show("Create student successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please check all information completely", "Note");
            }
        }

        void CreateForm_Load(object sender, EventArgs e)
        {
            this.cboClass.DataSource = this.Business.GetClasses();
            this.cboClass.DisplayMember = "Name";
            this.cboClass.ValueMember = "id";

            this.cboFaculty.DataSource = this.Business.getFacultyes();
            this.cboFaculty.DisplayMember = "Faculty_Name";
            this.cboFaculty.ValueMember = "id";
        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show("You have not entered a student code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCode.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("You have not entered a name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("You have not entered a email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHometown.Text))
            {
                MessageBox.Show("You have not entered a home town", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHometown.Focus();
                return false;
            }
            return true;
        }

    }
}
