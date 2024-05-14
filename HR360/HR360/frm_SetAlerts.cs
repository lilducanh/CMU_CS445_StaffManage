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
    public partial class frm_SetAlerts : Form
    {
        public frm_SetAlerts()
        {
            InitializeComponent();
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái hiện tại của nút
            if (toggleButton.Text == "ON")
            {
                toggleButton.Text = "OFF";
                toggleButton.BackColor = Color.Gray; // Màu đỏ cho trạng thái OFF
                                                    // Thêm code để xử lý khi nút ở trạng thái OFF
            }
            else
            {
                toggleButton.Text = "ON";
                toggleButton.BackColor = Color.Blue; // Màu xanh cho trạng thái ON
                toggleButton.ForeColor = Color.White;                           // Thêm code để xử lý khi nút ở trạng thái ON
            }
        }

        private void btn_toggle2_Click(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái hiện tại của nút
            if (btn_toggle2.Text == "ON")
            {
                btn_toggle2.Text = "OFF";
                btn_toggle2.BackColor = Color.Gray; // Màu đỏ cho trạng thái OFF
                                                     // Thêm code để xử lý khi nút ở trạng thái OFF
            }
            else
            {
                btn_toggle2.Text = "ON";
                btn_toggle2.BackColor = Color.Blue; // Màu xanh cho trạng thái ON
                btn_toggle2.ForeColor = Color.White;                           // Thêm code để xử lý khi nút ở trạng thái ON
            }
        }

        private void btn_toggle3_Click(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái hiện tại của nút
            if (btn_toggle3.Text == "ON")
            {
                btn_toggle3.Text = "OFF";
                btn_toggle3.BackColor = Color.Gray; // Màu đỏ cho trạng thái OFF
                                                     // Thêm code để xử lý khi nút ở trạng thái OFF
            }
            else
            {
                btn_toggle3.Text = "ON";
                btn_toggle3.BackColor = Color.Blue; // Màu xanh cho trạng thái ON
                btn_toggle3.ForeColor = Color.White;                           // Thêm code để xử lý khi nút ở trạng thái ON
            }
        }

        private void btn_toggle4_Click(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái hiện tại của nút
            if (btn_toggle4.Text == "ON")
            {
                btn_toggle4.Text = "OFF";
                btn_toggle4.BackColor = Color.Gray; // Màu đỏ cho trạng thái OFF
                                                     // Thêm code để xử lý khi nút ở trạng thái OFF
            }
            else
            {
                btn_toggle4.Text = "ON";
                btn_toggle4.BackColor = Color.Blue; // Màu xanh cho trạng thái ON
                btn_toggle4.ForeColor = Color.White;                           // Thêm code để xử lý khi nút ở trạng thái ON
            }
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
