namespace HR360
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Ham = new System.Windows.Forms.PictureBox();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.menuEmployee = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_ListOfEmployee = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btn_Employee = new System.Windows.Forms.Button();
            this.pnl_StaffInformation = new System.Windows.Forms.Panel();
            this.btn_StaffInformation = new System.Windows.Forms.Button();
            this.pnl_SetAlerts = new System.Windows.Forms.Panel();
            this.btn_SetAlerts = new System.Windows.Forms.Button();
            this.pnl_Notification = new System.Windows.Forms.Panel();
            this.btn_Notification = new System.Windows.Forms.Button();
            this.pnl_StaffBenefit = new System.Windows.Forms.Panel();
            this.btn_StaffBenefit = new System.Windows.Forms.Button();
            this.pnl_Dayoff = new System.Windows.Forms.Panel();
            this.btn_Dayoff = new System.Windows.Forms.Button();
            this.pnl_Salary = new System.Windows.Forms.Panel();
            this.btn_Salary = new System.Windows.Forms.Button();
            this.pnl_Quit = new System.Windows.Forms.Panel();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ham)).BeginInit();
            this.pnl_Dashboard.SuspendLayout();
            this.menuEmployee.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.pnl_StaffInformation.SuspendLayout();
            this.pnl_SetAlerts.SuspendLayout();
            this.pnl_Notification.SuspendLayout();
            this.pnl_StaffBenefit.SuspendLayout();
            this.pnl_Dayoff.SuspendLayout();
            this.pnl_Salary.SuspendLayout();
            this.pnl_Quit.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(81)))));
            this.sidebar.Controls.Add(this.btn_Ham);
            this.sidebar.Controls.Add(this.pnl_Dashboard);
            this.sidebar.Controls.Add(this.menuEmployee);
            this.sidebar.Controls.Add(this.pnl_SetAlerts);
            this.sidebar.Controls.Add(this.pnl_Dayoff);
            this.sidebar.Controls.Add(this.pnl_StaffBenefit);
            this.sidebar.Controls.Add(this.pnl_Salary);
            this.sidebar.Controls.Add(this.pnl_Notification);
            this.sidebar.Controls.Add(this.pnl_Quit);
            resources.ApplyResources(this.sidebar, "sidebar");
            this.sidebar.Name = "sidebar";
            // 
            // btn_Ham
            // 
            this.btn_Ham.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ham.Image = global::HR360.Properties.Resources.bar;
            resources.ApplyResources(this.btn_Ham, "btn_Ham");
            this.btn_Ham.Name = "btn_Ham";
            this.btn_Ham.TabStop = false;
            this.btn_Ham.Click += new System.EventHandler(this.btn_Ham_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.btn_Dashboard);
            resources.ApplyResources(this.pnl_Dashboard, "pnl_Dashboard");
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(81)))));
            this.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.Image = global::HR360.Properties.Resources.home;
            resources.ApplyResources(this.btn_Dashboard, "btn_Dashboard");
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // menuEmployee
            // 
            this.menuEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(26)))), ((int)(((byte)(67)))));
            this.menuEmployee.Controls.Add(this.panel2);
            this.menuEmployee.Controls.Add(this.panel7);
            this.menuEmployee.Controls.Add(this.panel11);
            this.menuEmployee.Controls.Add(this.pnl_StaffInformation);
            resources.ApplyResources(this.menuEmployee, "menuEmployee");
            this.menuEmployee.Name = "menuEmployee";
            this.menuEmployee.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_AddEmployee);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(26)))), ((int)(((byte)(67)))));
            this.btn_AddEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_AddEmployee.Image = global::HR360.Properties.Resources.sub_class;
            resources.ApplyResources(this.btn_AddEmployee, "btn_AddEmployee");
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.UseVisualStyleBackColor = false;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_ListOfEmployee);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // btn_ListOfEmployee
            // 
            this.btn_ListOfEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(26)))), ((int)(((byte)(67)))));
            this.btn_ListOfEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_ListOfEmployee.Image = global::HR360.Properties.Resources.sub_class;
            resources.ApplyResources(this.btn_ListOfEmployee, "btn_ListOfEmployee");
            this.btn_ListOfEmployee.Name = "btn_ListOfEmployee";
            this.btn_ListOfEmployee.UseVisualStyleBackColor = false;
            this.btn_ListOfEmployee.Click += new System.EventHandler(this.btn_ListOfEmployee_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btn_Employee);
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // btn_Employee
            // 
            this.btn_Employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(26)))), ((int)(((byte)(67)))));
            this.btn_Employee.ForeColor = System.Drawing.Color.White;
            this.btn_Employee.Image = global::HR360.Properties.Resources.sub_class;
            resources.ApplyResources(this.btn_Employee, "btn_Employee");
            this.btn_Employee.Name = "btn_Employee";
            this.btn_Employee.UseVisualStyleBackColor = false;
            this.btn_Employee.Click += new System.EventHandler(this.btn_Employee_Click);
            // 
            // pnl_StaffInformation
            // 
            this.pnl_StaffInformation.Controls.Add(this.btn_StaffInformation);
            resources.ApplyResources(this.pnl_StaffInformation, "pnl_StaffInformation");
            this.pnl_StaffInformation.Name = "pnl_StaffInformation";
            // 
            // btn_StaffInformation
            // 
            this.btn_StaffInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(81)))));
            this.btn_StaffInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StaffInformation.ForeColor = System.Drawing.Color.White;
            this.btn_StaffInformation.Image = global::HR360.Properties.Resources.infor;
            resources.ApplyResources(this.btn_StaffInformation, "btn_StaffInformation");
            this.btn_StaffInformation.Name = "btn_StaffInformation";
            this.btn_StaffInformation.UseVisualStyleBackColor = false;
            this.btn_StaffInformation.Click += new System.EventHandler(this.btn_StaffInformation_Click);
            // 
            // pnl_SetAlerts
            // 
            this.pnl_SetAlerts.Controls.Add(this.btn_SetAlerts);
            resources.ApplyResources(this.pnl_SetAlerts, "pnl_SetAlerts");
            this.pnl_SetAlerts.Name = "pnl_SetAlerts";
            // 
            // btn_SetAlerts
            // 
            this.btn_SetAlerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(81)))));
            this.btn_SetAlerts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SetAlerts.ForeColor = System.Drawing.Color.White;
            this.btn_SetAlerts.Image = global::HR360.Properties.Resources.set_alert;
            resources.ApplyResources(this.btn_SetAlerts, "btn_SetAlerts");
            this.btn_SetAlerts.Name = "btn_SetAlerts";
            this.btn_SetAlerts.UseVisualStyleBackColor = false;
            this.btn_SetAlerts.Click += new System.EventHandler(this.btn_SetAlerts_Click);
            // 
            // pnl_Notification
            // 
            this.pnl_Notification.Controls.Add(this.btn_Notification);
            resources.ApplyResources(this.pnl_Notification, "pnl_Notification");
            this.pnl_Notification.Name = "pnl_Notification";
            // 
            // btn_Notification
            // 
            this.btn_Notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(81)))));
            this.btn_Notification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Notification.ForeColor = System.Drawing.Color.White;
            this.btn_Notification.Image = global::HR360.Properties.Resources.noti;
            resources.ApplyResources(this.btn_Notification, "btn_Notification");
            this.btn_Notification.Name = "btn_Notification";
            this.btn_Notification.UseVisualStyleBackColor = false;
            this.btn_Notification.Click += new System.EventHandler(this.btn_Notification_Click);
            // 
            // pnl_StaffBenefit
            // 
            this.pnl_StaffBenefit.Controls.Add(this.btn_StaffBenefit);
            resources.ApplyResources(this.pnl_StaffBenefit, "pnl_StaffBenefit");
            this.pnl_StaffBenefit.Name = "pnl_StaffBenefit";
            // 
            // btn_StaffBenefit
            // 
            this.btn_StaffBenefit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(81)))));
            this.btn_StaffBenefit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StaffBenefit.ForeColor = System.Drawing.Color.White;
            this.btn_StaffBenefit.Image = global::HR360.Properties.Resources.staffbene;
            resources.ApplyResources(this.btn_StaffBenefit, "btn_StaffBenefit");
            this.btn_StaffBenefit.Name = "btn_StaffBenefit";
            this.btn_StaffBenefit.UseVisualStyleBackColor = false;
            this.btn_StaffBenefit.Click += new System.EventHandler(this.btn_StaffBenefit_Click);
            // 
            // pnl_Dayoff
            // 
            this.pnl_Dayoff.Controls.Add(this.btn_Dayoff);
            resources.ApplyResources(this.pnl_Dayoff, "pnl_Dayoff");
            this.pnl_Dayoff.Name = "pnl_Dayoff";
            // 
            // btn_Dayoff
            // 
            this.btn_Dayoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(81)))));
            this.btn_Dayoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dayoff.ForeColor = System.Drawing.Color.White;
            this.btn_Dayoff.Image = global::HR360.Properties.Resources.Day_off;
            resources.ApplyResources(this.btn_Dayoff, "btn_Dayoff");
            this.btn_Dayoff.Name = "btn_Dayoff";
            this.btn_Dayoff.UseVisualStyleBackColor = false;
            this.btn_Dayoff.Click += new System.EventHandler(this.btn_Dayoff_Click);
            // 
            // pnl_Salary
            // 
            this.pnl_Salary.Controls.Add(this.btn_Salary);
            resources.ApplyResources(this.pnl_Salary, "pnl_Salary");
            this.pnl_Salary.Name = "pnl_Salary";
            // 
            // btn_Salary
            // 
            this.btn_Salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(81)))));
            this.btn_Salary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salary.ForeColor = System.Drawing.Color.White;
            this.btn_Salary.Image = global::HR360.Properties.Resources.salary;
            resources.ApplyResources(this.btn_Salary, "btn_Salary");
            this.btn_Salary.Name = "btn_Salary";
            this.btn_Salary.UseVisualStyleBackColor = false;
            this.btn_Salary.Click += new System.EventHandler(this.btn_Salary_Click);
            // 
            // pnl_Quit
            // 
            this.pnl_Quit.Controls.Add(this.btn_Quit);
            resources.ApplyResources(this.pnl_Quit, "pnl_Quit");
            this.pnl_Quit.Name = "pnl_Quit";
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(81)))));
            this.btn_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Quit.ForeColor = System.Drawing.Color.White;
            this.btn_Quit.Image = global::HR360.Properties.Resources.quit;
            resources.ApplyResources(this.btn_Quit, "btn_Quit");
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.UseVisualStyleBackColor = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HR360.Properties.Resources.logo;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = global::HR360.Properties.Resources.Screenshot_2024_04_29_152111;
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ham)).EndInit();
            this.pnl_Dashboard.ResumeLayout(false);
            this.menuEmployee.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.pnl_StaffInformation.ResumeLayout(false);
            this.pnl_SetAlerts.ResumeLayout(false);
            this.pnl_Notification.ResumeLayout(false);
            this.pnl_StaffBenefit.ResumeLayout(false);
            this.pnl_Dayoff.ResumeLayout(false);
            this.pnl_Salary.ResumeLayout(false);
            this.pnl_Quit.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Panel pnl_Salary;
        private System.Windows.Forms.Button btn_Salary;
        private System.Windows.Forms.Panel pnl_Dayoff;
        private System.Windows.Forms.Button btn_Dayoff;
        private System.Windows.Forms.Panel pnl_StaffBenefit;
        private System.Windows.Forms.Button btn_StaffBenefit;
        private System.Windows.Forms.Panel pnl_Notification;
        private System.Windows.Forms.Button btn_Notification;
        private System.Windows.Forms.Panel pnl_SetAlerts;
        private System.Windows.Forms.Button btn_SetAlerts;
        private System.Windows.Forms.Panel pnl_StaffInformation;
        private System.Windows.Forms.Button btn_StaffInformation;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Panel menuEmployee;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_ListOfEmployee;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btn_Employee;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.PictureBox btn_Ham;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Quit;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_AddEmployee;
    }
}

