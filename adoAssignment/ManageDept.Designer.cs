namespace adoAssignment
{
    partial class ManageDept
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            dgDept = new DataGridView();
            DeptName = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            MDD = new Label();
            lblIsActive = new Label();
            lblDeptName = new Label();
            txtDeptName = new TextBox();
            ChkIsActive = new CheckBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgDept).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(410, 128);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(410, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(46, 93);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(137, 93);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgDept
            // 
            dgDept.AllowUserToAddRows = false;
            dgDept.AllowUserToDeleteRows = false;
            dgDept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDept.Columns.AddRange(new DataGridViewColumn[] { DeptName, IsActive });
            dgDept.Location = new Point(75, 75);
            dgDept.Name = "dgDept";
            dgDept.ReadOnly = true;
            dgDept.RowTemplate.Height = 25;
            dgDept.Size = new Size(283, 181);
            dgDept.TabIndex = 4;
            // 
            // DeptName
            // 
            DeptName.DataPropertyName = "DeptName";
            DeptName.HeaderText = "DeptName";
            DeptName.Name = "DeptName";
            DeptName.ReadOnly = true;
            DeptName.Width = 120;
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "IsActive";
            IsActive.Name = "IsActive";
            IsActive.ReadOnly = true;
            IsActive.Width = 120;
            // 
            // MDD
            // 
            MDD.AutoSize = true;
            MDD.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            MDD.Location = new Point(75, 47);
            MDD.Name = "MDD";
            MDD.Size = new Size(263, 25);
            MDD.TabIndex = 5;
            MDD.Text = "Manage Department Details";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(19, 59);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(52, 17);
            lblIsActive.TabIndex = 6;
            lblIsActive.Text = "IsActive";
            // 
            // lblDeptName
            // 
            lblDeptName.AutoSize = true;
            lblDeptName.Location = new Point(19, 25);
            lblDeptName.Name = "lblDeptName";
            lblDeptName.Size = new Size(75, 17);
            lblDeptName.TabIndex = 7;
            lblDeptName.Text = "Dept Name";
            // 
            // txtDeptName
            // 
            txtDeptName.Location = new Point(112, 25);
            txtDeptName.Name = "txtDeptName";
            txtDeptName.Size = new Size(100, 23);
            txtDeptName.TabIndex = 8;
            // 
            // ChkIsActive
            // 
            ChkIsActive.AutoSize = true;
            ChkIsActive.Location = new Point(112, 59);
            ChkIsActive.Name = "ChkIsActive";
            ChkIsActive.Size = new Size(15, 14);
            ChkIsActive.TabIndex = 9;
            ChkIsActive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ChkIsActive);
            groupBox1.Controls.Add(txtDeptName);
            groupBox1.Controls.Add(lblDeptName);
            groupBox1.Controls.Add(lblIsActive);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Location = new Point(126, 291);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 135);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // ManageDept
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 450);
            Controls.Add(groupBox1);
            Controls.Add(MDD);
            Controls.Add(dgDept);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            MaximumSize = new Size(583, 489);
            MinimumSize = new Size(583, 489);
            Name = "ManageDept";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageDept";
            ((System.ComponentModel.ISupportInitialize)dgDept).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnUpdate;
        private DataGridView dgDept;
        private Label MDD;
        private Label lblIsActive;
        private Label lblDeptName;
        private TextBox txtDeptName;
        private CheckBox ChkIsActive;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn DeptName;
        private DataGridViewTextBoxColumn IsActive;
    }
}