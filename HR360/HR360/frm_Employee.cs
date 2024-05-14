using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace HR360
{
    public partial class frm_Employee : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_Employee()
        {
            InitializeComponent();
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {

            // Lấy employee ID từ TextBox
            string employeeId = txt_EmployeeId.Text;

            // Kiểm tra nếu employee ID rỗng
            if (string.IsNullOrEmpty(employeeId))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.");
                return;
            }

            // Truy vấn cơ sở dữ liệu để lấy thông tin về nhân viên
            string query = @"
    SELECT TOP 1
        p.CURRENT_FIRST_NAME AS FirstName,
        p.CURRENT_LAST_NAME AS LastName,
        p.BIRTH_DATE AS BirthDate,
        p.CURRENT_ADDRESS_1 AS Address1,
        p.CURRENT_PHONE_NUMBER AS PhoneNumber,
        p.CURRENT_PERSONAL_EMAIL AS Email,
        p.CURRENT_GENDER AS Gender,
        p.SHAREHOLDER_STATUS AS ShareHolderStatus,
        p.ETHNICITY AS Ethnicity,
        p.BENEFIT_PLAN_ID AS BenefitPlanID,
        p.CURRENT_MARITAL_STATUS AS MaritalStatus,
        p.DRIVERS_LICENSE AS DriverLicense,
        p.SOCIAL_SECURITY_NUMBER AS SSN,
        e.EMPLOYMENT_ID AS EmploymentID,
        e.EMPLOYMENT_STATUS AS EmploymentStatus,
        e.HIRE_DATE_FOR_WORKING AS HireDate,
        j.DEPARTMENT AS Department
    FROM PERSONAL p
    INNER JOIN EMPLOYMENT e ON p.PERSONAL_ID = e.PERSONAL_ID
    INNER JOIN JOB_HISTORY j ON e.EMPLOYMENT_ID = j.EMPLOYMENT_ID
    WHERE p.PERSONAL_ID = @EmployeeId
    ORDER BY j.FROM_DATE DESC;";

            // Mở kết nối cơ sở dữ liệu
            lopchung.OpenConnections();

            try
            {
                // Tạo tham số truy vấn @EmployeeId
                SqlParameter employeeIdParameter = new SqlParameter("@EmployeeId", SqlDbType.Int);
                employeeIdParameter.Value = int.Parse(employeeId); // Chuyển đổi EmployeeId sang kiểu số nguyên

                // Thực hiện truy vấn bằng cách gọi ExecuteSqlServerQuery với câu truy vấn và tham số @EmployeeId
                DataTable dt = lopchung.ExecuteSqlServerQuery(query, employeeIdParameter);

                // Kiểm tra nếu có dữ liệu
                if (dt.Rows.Count > 0)
                {
                    // Đọc dòng dữ liệu đầu tiên
                    DataRow row = dt.Rows[0];
                    // Điền dữ liệu vào các điều khiển trên form
                    txt_FirstName.Text = row["FirstName"].ToString();
                    txt_LastName.Text = row["LastName"].ToString();
                    dtp_BirthDate.Value = Convert.ToDateTime(row["BirthDate"]);
                    txt_Address1.Text = row["Address1"].ToString();
                    txt_PhoneNumber.Text = row["PhoneNumber"].ToString();
                    txt_Email.Text = row["Email"].ToString();
                    txt_Gender.Text = row["Gender"].ToString();
                    txt_Ethnicity.Text = row["Ethnicity"].ToString();
                    txt_BenefitPlanID.Text = row["BenefitPlanID"].ToString();
                    txt_ShareHolderStatus.Text = row["ShareHolderStatus"].ToString();
                    txt_MaritalStatus.Text = row["MaritalStatus"].ToString();
                    txt_DriverLicense.Text = row["DriverLicense"].ToString();
                    txt_SSN.Text = row["SSN"].ToString();
                    txt_EmploymentID.Text = row["EmploymentID"].ToString();
                    txt_EmploymentStatus.Text = row["EmploymentStatus"].ToString();
                    dtp_HireDate.Value = Convert.ToDateTime(row["HireDate"]);
                    txt_Department.Text = row["Department"].ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin về nhân viên với mã nhân viên đã nhập.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối
                lopchung.CloseConnections();
            }

        }
    }
}
