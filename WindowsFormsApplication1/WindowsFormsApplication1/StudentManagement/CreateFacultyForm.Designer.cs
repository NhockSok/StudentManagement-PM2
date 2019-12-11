namespace WindowsFormsApplication1.StudentManagement
{
    partial class CreateFacultyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdFaculty = new System.Windows.Forms.DataGridView();
            this.btnAddFaculty = new System.Windows.Forms.Button();
            this.btnUpdateFaculty = new System.Windows.Forms.Button();
            this.btnDeleteFaculty = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFaculty
            // 
            this.grdFaculty.AllowUserToAddRows = false;
            this.grdFaculty.AllowUserToDeleteRows = false;
            this.grdFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFaculty.Location = new System.Drawing.Point(12, 12);
            this.grdFaculty.Name = "grdFaculty";
            this.grdFaculty.ReadOnly = true;
            this.grdFaculty.RowHeadersWidth = 51;
            this.grdFaculty.RowTemplate.Height = 24;
            this.grdFaculty.Size = new System.Drawing.Size(421, 150);
            this.grdFaculty.TabIndex = 10;
            // 
            // btnAddFaculty
            // 
            this.btnAddFaculty.Location = new System.Drawing.Point(12, 232);
            this.btnAddFaculty.Name = "btnAddFaculty";
            this.btnAddFaculty.Size = new System.Drawing.Size(90, 35);
            this.btnAddFaculty.TabIndex = 12;
            this.btnAddFaculty.Text = "CREATE";
            this.btnAddFaculty.UseVisualStyleBackColor = true;
            // 
            // btnUpdateFaculty
            // 
            this.btnUpdateFaculty.Location = new System.Drawing.Point(108, 232);
            this.btnUpdateFaculty.Name = "btnUpdateFaculty";
            this.btnUpdateFaculty.Size = new System.Drawing.Size(97, 35);
            this.btnUpdateFaculty.TabIndex = 13;
            this.btnUpdateFaculty.Text = "UPDATE";
            this.btnUpdateFaculty.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFaculty
            // 
            this.btnDeleteFaculty.Location = new System.Drawing.Point(211, 232);
            this.btnDeleteFaculty.Name = "btnDeleteFaculty";
            this.btnDeleteFaculty.Size = new System.Drawing.Size(82, 35);
            this.btnDeleteFaculty.TabIndex = 14;
            this.btnDeleteFaculty.Text = "DELETE";
            this.btnDeleteFaculty.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(299, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Faculty name : ";
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(126, 186);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(253, 22);
            this.txtFacultyName.TabIndex = 17;
            // 
            // CreateFacultyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 288);
            this.Controls.Add(this.txtFacultyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteFaculty);
            this.Controls.Add(this.btnUpdateFaculty);
            this.Controls.Add(this.btnAddFaculty);
            this.Controls.Add(this.grdFaculty);
            this.MaximizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.Name = "CreateFacultyForm";
            this.Text = "CreateFacultyForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdFaculty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdFaculty;
        private System.Windows.Forms.Button btnAddFaculty;
        private System.Windows.Forms.Button btnUpdateFaculty;
        private System.Windows.Forms.Button btnDeleteFaculty;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFacultyName;
    }
}