namespace adoAssignment
{
    partial class EmpMDIParent
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
            ToolStripMenu = new MenuStrip();
            manageEmployeeToolStripMenuItem = new ToolStripMenuItem();
            manageDepartmentToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenu.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStripMenu
            // 
            ToolStripMenu.Items.AddRange(new ToolStripItem[] { manageEmployeeToolStripMenuItem, manageDepartmentToolStripMenuItem });
            ToolStripMenu.Location = new Point(0, 0);
            ToolStripMenu.Name = "ToolStripMenu";
            ToolStripMenu.Size = new Size(782, 25);
            ToolStripMenu.TabIndex = 1;
            // 
            // manageEmployeeToolStripMenuItem
            // 
            manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            manageEmployeeToolStripMenuItem.Size = new Size(133, 21);
            manageEmployeeToolStripMenuItem.Text = "Manage Employee ";
            manageEmployeeToolStripMenuItem.Click += manageEmployeeToolStripMenuItem_Click;
            // 
            // manageDepartmentToolStripMenuItem
            // 
            manageDepartmentToolStripMenuItem.Name = "manageDepartmentToolStripMenuItem";
            manageDepartmentToolStripMenuItem.Size = new Size(141, 21);
            manageDepartmentToolStripMenuItem.Text = "Manage Department";
            manageDepartmentToolStripMenuItem.Click += manageDepartmentToolStripMenuItem_Click;
            // 
            // EmpMDIParent
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 450);
            Controls.Add(ToolStripMenu);
            IsMdiContainer = true;
            MainMenuStrip = ToolStripMenu;
            Name = "EmpMDIParent";
            Text = "EmpMDIParent";
            WindowState = FormWindowState.Maximized;
            ToolStripMenu.ResumeLayout(false);
            ToolStripMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip ToolStripMenu;
        private ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private ToolStripMenuItem manageDepartmentToolStripMenuItem;
    }
}