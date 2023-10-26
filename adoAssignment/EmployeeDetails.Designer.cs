namespace adoAssignment
{
    partial class EmployeeDetails
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
            btnSearch = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            ChkIsActive = new CheckBox();
            txtEmployee = new TextBox();
            txtSalary = new TextBox();
            txtEmpName = new TextBox();
            cbDepartment = new ComboBox();
            cbIsActive = new ComboBox();
            cbDeptName = new ComboBox();
            lblEmployee = new Label();
            lblDepartment = new Label();
            lblIsActive1 = new Label();
            lblEmpName = new Label();
            lblDeptName = new Label();
            lblIsAcitve2 = new Label();
            lblSalary = new Label();
            groupBox1 = new GroupBox();
            dgEmp = new DataGridView();
            EmpName = new DataGridViewTextBoxColumn();
            Department = new DataGridViewTextBoxColumn();
            EmpSalary = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgEmp).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(665, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(574, 130);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(574, 191);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(295, 442);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(400, 442);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ChkIsActive
            // 
            ChkIsActive.AutoSize = true;
            ChkIsActive.Location = new Point(382, 416);
            ChkIsActive.Name = "ChkIsActive";
            ChkIsActive.Size = new Size(15, 14);
            ChkIsActive.TabIndex = 5;
            ChkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtEmployee
            // 
            txtEmployee.Location = new Point(78, 23);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(100, 23);
            txtEmployee.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(340, 375);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(135, 23);
            txtSalary.TabIndex = 7;
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(340, 293);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(135, 23);
            txtEmpName.TabIndex = 8;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new Point(276, 22);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new Size(121, 25);
            cbDepartment.TabIndex = 9;
            // 
            // cbIsActive
            // 
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Location = new Point(497, 21);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(121, 25);
            cbIsActive.TabIndex = 10;
            // 
            // cbDeptName
            // 
            cbDeptName.FormattingEnabled = true;
            cbDeptName.Location = new Point(340, 333);
            cbDeptName.Name = "cbDeptName";
            cbDeptName.Size = new Size(135, 25);
            cbDeptName.TabIndex = 11;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(12, 25);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(65, 17);
            lblEmployee.TabIndex = 12;
            lblEmployee.Text = "Employee";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(193, 26);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(77, 17);
            lblDepartment.TabIndex = 13;
            lblDepartment.Text = "Department";
            // 
            // lblIsActive1
            // 
            lblIsActive1.AutoSize = true;
            lblIsActive1.Location = new Point(423, 25);
            lblIsActive1.Name = "lblIsActive1";
            lblIsActive1.Size = new Size(52, 17);
            lblIsActive1.TabIndex = 14;
            lblIsActive1.Text = "IsAcitve";
            // 
            // lblEmpName
            // 
            lblEmpName.AutoSize = true;
            lblEmpName.Location = new Point(261, 296);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(69, 17);
            lblEmpName.TabIndex = 15;
            lblEmpName.Text = "EmpName";
            // 
            // lblDeptName
            // 
            lblDeptName.AutoSize = true;
            lblDeptName.Location = new Point(261, 336);
            lblDeptName.Name = "lblDeptName";
            lblDeptName.Size = new Size(71, 17);
            lblDeptName.TabIndex = 16;
            lblDeptName.Text = "DeptName";
            // 
            // lblIsAcitve2
            // 
            lblIsAcitve2.AutoSize = true;
            lblIsAcitve2.Location = new Point(261, 413);
            lblIsAcitve2.Name = "lblIsAcitve2";
            lblIsAcitve2.Size = new Size(52, 17);
            lblIsAcitve2.TabIndex = 17;
            lblIsAcitve2.Text = "IsActive";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(261, 378);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(43, 17);
            lblSalary.TabIndex = 18;
            lblSalary.Text = "Salary";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(206, 276);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 202);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // dgEmp
            // 
            dgEmp.AllowUserToDeleteRows = false;
            dgEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmp.Columns.AddRange(new DataGridViewColumn[] { EmpName, Department, EmpSalary, IsActive });
            dgEmp.Location = new Point(60, 95);
            dgEmp.Name = "dgEmp";
            dgEmp.ReadOnly = true;
            dgEmp.RowTemplate.Height = 25;
            dgEmp.Size = new Size(461, 150);
            dgEmp.TabIndex = 20;
            // 
            // EmpName
            // 
            EmpName.DataPropertyName = "EmpName";
            EmpName.HeaderText = "EmpName";
            EmpName.Name = "EmpName";
            EmpName.ReadOnly = true;
            // 
            // Department
            // 
            Department.DataPropertyName = "DeptName";
            Department.HeaderText = "Department";
            Department.Name = "Department";
            Department.ReadOnly = true;
            // 
            // EmpSalary
            // 
            EmpSalary.DataPropertyName = "EmpSalary";
            EmpSalary.HeaderText = "EmpSalary";
            EmpSalary.Name = "EmpSalary";
            EmpSalary.ReadOnly = true;
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "IsActive";
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            // 
            // EmployeeDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(dgEmp);
            Controls.Add(lblSalary);
            Controls.Add(lblIsAcitve2);
            Controls.Add(lblDeptName);
            Controls.Add(lblEmpName);
            Controls.Add(lblIsActive1);
            Controls.Add(lblDepartment);
            Controls.Add(lblEmployee);
            Controls.Add(cbDeptName);
            Controls.Add(cbIsActive);
            Controls.Add(cbDepartment);
            Controls.Add(txtEmpName);
            Controls.Add(txtSalary);
            Controls.Add(txtEmployee);
            Controls.Add(ChkIsActive);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnSearch);
            Controls.Add(groupBox1);
            MinimumSize = new Size(816, 538);
            Name = "EmployeeDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeDetails";
            ((System.ComponentModel.ISupportInitialize)dgEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnUpdate;
        private CheckBox ChkIsActive;
        private TextBox txtEmployee;
        private TextBox txtSalary;
        private TextBox txtEmpName;
        private ComboBox cbDepartment;
        private ComboBox cbIsActive;
        private ComboBox cbDeptName;
        private Label lblEmployee;
        private Label lblDepartment;
        private Label lblIsActive1;
        private Label lblEmpName;
        private Label lblDeptName;
        private Label lblIsAcitve2;
        private Label lblSalary;
        private GroupBox groupBox1;
        private DataGridView dgEmp;
        private DataGridViewTextBoxColumn EmpName;
        private DataGridViewTextBoxColumn Department;
        private DataGridViewTextBoxColumn EmpSalary;
        private DataGridViewTextBoxColumn IsActive;
    }
}