namespace WindowsFormsApplication1.StudentManagement
{
    partial class SortForm
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
            this.grdSort = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdSort)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSort
            // 
            this.grdSort.AllowUserToAddRows = false;
            this.grdSort.AllowUserToDeleteRows = false;
            this.grdSort.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSort.Location = new System.Drawing.Point(0, 0);
            this.grdSort.Name = "grdSort";
            this.grdSort.ReadOnly = true;
            this.grdSort.RowHeadersWidth = 51;
            this.grdSort.RowTemplate.Height = 24;
            this.grdSort.Size = new System.Drawing.Size(800, 450);
            this.grdSort.TabIndex = 0;
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdSort);
            this.Name = "SortForm";
            this.Text = "SortForm";
            ((System.ComponentModel.ISupportInitialize)(this.grdSort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSort;
    }
}