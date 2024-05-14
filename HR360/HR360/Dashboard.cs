using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR360
{
    public partial class Dashboard : Form
    {
        frm_DashBoard sub_dasboard;
        frm_Salary sub_salary;
        frm_Dayoff sub_dayoff;
        frm_StaffBenefit sub_benefit;
        frm_Notification sub_notification;
        frm_Employee sub_employee;
        frm_ListOfEmployee sub_listofemployee;
        frm_SetAlerts sub_setalerts;
        
        
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuEmployee.Height += 10;
                if (menuEmployee.Height >= 220)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuEmployee.Height -= 10;
                if (menuEmployee.Height <= 55)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void btn_StaffInformation_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if(sidebar.Width <= 69)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    //pnl_Dashboard.Width = sidebar.Width;
                    //pnl_Salary.Width = sidebar.Width;
                    //pnl_Dayoff.Width = sidebar.Width;
                    //pnl_StaffBenefit.Width = sidebar.Width;
                    //pnl_Notification.Width = sidebar.Width;
                    //pnl_StaffInformation.Width = sidebar.Width;
                    //pnl_SetAlerts.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 5;
                if(sidebar.Width >= 225)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    //pnl_Dashboard.Width = sidebar.Width;
                    //pnl_Salary.Width = sidebar.Width;
                    //pnl_Dayoff.Width = sidebar.Width;
                    //pnl_StaffBenefit.Width = sidebar.Width;
                    //pnl_Notification.Width = sidebar.Width;
                    //pnl_StaffInformation.Width = sidebar.Width;
                    //pnl_SetAlerts.Width = sidebar.Width;


                }
            }
        }

        private void btn_Ham_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            if(sub_dasboard == null)
            {
                sub_dasboard = new frm_DashBoard();
                sub_dasboard.FormClosed += frm_DashBoard_FormClosed;
                sub_dasboard.MdiParent = this;
                sub_dasboard.Dock = DockStyle.Fill;
                sub_dasboard.Show();
            }
            else
            {
                sub_dasboard.Activate();
            }
        }

        private void frm_DashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub_dasboard = null;

        }

        private void btn_ListOfEmployee_Click(object sender, EventArgs e)
        {
            if(sub_listofemployee == null)
            {
                sub_listofemployee = new frm_ListOfEmployee();
                sub_listofemployee.FormClosed += frm_ListOfEmployee_FormClosed;
                sub_listofemployee.MdiParent = this;
                sub_listofemployee.Dock = DockStyle.Fill;
                sub_listofemployee.Show();
            }
            else
            {
                sub_listofemployee.Activate();
            }
        }

        private void frm_ListOfEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub_listofemployee = null;
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            if (sub_employee == null)
            {
                sub_employee = new frm_Employee();
                sub_employee.FormClosed += frm_Employee_FormClosed;
                sub_employee.MdiParent = this;
                sub_employee.Dock = DockStyle.Fill;
                sub_employee.Show();
            }
            else
            {
                sub_employee.Activate();
            }
        }

        private void frm_Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ = sub_employee == null;
        }

        private void btn_SetAlerts_Click(object sender, EventArgs e)
        {
            if (sub_setalerts == null)
            {
                sub_setalerts = new frm_SetAlerts();
                sub_setalerts.FormClosed += frm_SetAlerts_FormClosed;
                sub_setalerts.MdiParent = this;
                sub_setalerts.Dock = DockStyle.Fill;
                sub_setalerts.Show();
            }
            else
            {
                sub_setalerts.Activate();
            }
        }

        private void frm_SetAlerts_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub_setalerts = null;
        }

        private void btn_Notification_Click(object sender, EventArgs e)
        {
            if (sub_notification == null)
            {
                sub_notification = new frm_Notification();
                sub_notification.FormClosed += frm_Notification_FormClosed;
                sub_notification.MdiParent = this;
                sub_notification.Dock = DockStyle.Fill;
                sub_notification.Show();
            }
            else
            {
                sub_notification.Activate();
            }
        }

        private void frm_Notification_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub_notification = null;
        }

        private void btn_StaffBenefit_Click(object sender, EventArgs e)
        {
            if (sub_benefit == null)
            {
                sub_benefit = new frm_StaffBenefit();
                sub_benefit.FormClosed += frm_StaffBenefit_FormClosed;
                sub_benefit.MdiParent = this;
                sub_benefit.Dock = DockStyle.Fill;
                sub_benefit.Show();
            }
            else
            {
                sub_benefit.Activate();
            }
        }

        private void frm_StaffBenefit_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub_benefit = null;
        }

        private void btn_Dayoff_Click(object sender, EventArgs e)
        {
            if (sub_dayoff == null)
            {
                sub_dayoff = new frm_Dayoff();
                sub_dayoff.FormClosed += frm_Dayoff_FormClosed;
                sub_dayoff.MdiParent = this;
                sub_dayoff.Dock = DockStyle.Fill;
                sub_dayoff.Show();
            }
            else
            {
                sub_dayoff.Activate();
            }
        }

        private void frm_Dayoff_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub_dayoff = null;
        }

        private void btn_Salary_Click(object sender, EventArgs e)
        {
            if (sub_salary == null)
            {
                sub_salary = new frm_Salary();
                sub_salary.FormClosed += frm_Salary_FormClosed;
                sub_salary.MdiParent = this;
                sub_salary.Dock = DockStyle.Fill;
                sub_salary.Show();
            }
            else
            {
                sub_salary.Activate();
            }
        }

        private void frm_Salary_FormClosed(object sender, FormClosedEventArgs e)
        {
            sub_salary = null;
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // The user clicked 'Yes', close the form
                this.Close();
            }
        }

        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
