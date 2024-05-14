using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace HR360
{
    public class LOPDUNGCHUNG
    {
        // Chuỗi kết nối cho MySQL và SQL Server
        string mysqlConnectionString = "server=localhost;user=root;pwd=12345;database=mydb;port=3306";
        string sqlServerConnectionString = @"Data Source=ADMIN-PC\DUCANH;Initial Catalog=HRM;Integrated Security=True";

        // Kết nối cho cả MySQL và SQL Server
        MySqlConnection mysqlConnection;
        SqlConnection sqlServerConnection;

        // Constructor
        public LOPDUNGCHUNG()
        {
            mysqlConnection = new MySqlConnection(mysqlConnectionString);
            sqlServerConnection = new SqlConnection(sqlServerConnectionString);
        }

        // Phương thức mở kết nối cho cả MySQL và SQL Server
        public void OpenConnections()
        {
            // Mở kết nối cho MySQL
            if (mysqlConnection.State != ConnectionState.Open)
            {
                mysqlConnection.Open();
            }

            // Mở kết nối cho SQL Server
            if (sqlServerConnection.State != ConnectionState.Open)
            {
                sqlServerConnection.Open();
            }
        }

        // Đóng kết nối cho cả MySQL và SQL Server
        public void CloseConnections()
        {
            if (mysqlConnection.State != ConnectionState.Closed)
            {
                mysqlConnection.Close();
            }

            if (sqlServerConnection.State != ConnectionState.Closed)
            {
                sqlServerConnection.Close();
            }
        }

        // Thực hiện truy vấn trên MySQL và trả về DataTable
        public DataTable ExecuteMySqlQuery(string query)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(query, mysqlConnection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        // Thực hiện truy vấn trên SQL Server và trả về DataTable
        public DataTable ExecuteSqlServerQuery(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, sqlServerConnection))
            {
                // Thêm các tham số vào câu lệnh truy vấn
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                // Thực hiện truy vấn và đọc dữ liệu
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
            return dt;
        }

        // Thực hiện câu lệnh không truy vấn (INSERT, UPDATE, DELETE) trên MySQL và trả về số hàng bị ảnh hưởng
        public int ExecuteMySqlNonQuery(string commandText)
        {
            using (MySqlCommand cmd = new MySqlCommand(commandText, mysqlConnection))
            {
                return cmd.ExecuteNonQuery();
            }
        }

        // Thực hiện câu lệnh không truy vấn (INSERT, UPDATE, DELETE) trên SQL Server và trả về số hàng bị ảnh hưởng
        public int ExecuteSqlServerNonQuery(string commandText)
        {
            using (SqlCommand cmd = new SqlCommand(commandText, sqlServerConnection))
            {
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
