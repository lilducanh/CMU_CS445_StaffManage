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
    public partial class frm_StaffBenefit : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_StaffBenefit()
        {
            InitializeComponent();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            lopchung.OpenConnections(); // true cho MySQL, false cho SQL Server

            // Thực hiện truy vấn dữ liệu từ cơ sở dữ liệu
            string query = "select * from employee"; // Thay "tableName" bằng tên bảng của bạn
            DataTable dataTable = lopchung.ExecuteSqlServerQuery(query);

            // Nạp dữ liệu vào DataGridView
            dt_StaffBenefit.DataSource = dataTable;
           
        }

        private void dt_StaffBenefit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
