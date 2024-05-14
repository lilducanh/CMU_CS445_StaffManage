namespace HR360
{
    partial class frm_Salary
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
            this.gradientPanel1 = new HR360.GradientPanel();
            this.dtgv_thongtinSalary = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_to_date = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_from_date = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_employee_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_ethnicity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_shareholder = new System.Windows.Forms.ComboBox();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongtinSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(26)))), ((int)(((byte)(67)))));
            this.gradientPanel1.Controls.Add(this.btn_Apply);
            this.gradientPanel1.Controls.Add(this.dtgv_thongtinSalary);
            this.gradientPanel1.Controls.Add(this.label7);
            this.gradientPanel1.Controls.Add(this.cb_to_date);
            this.gradientPanel1.Controls.Add(this.label6);
            this.gradientPanel1.Controls.Add(this.cb_from_date);
            this.gradientPanel1.Controls.Add(this.label5);
            this.gradientPanel1.Controls.Add(this.cb_employee_type);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.cb_ethnicity);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.cb_department);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.cb_gender);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.cb_shareholder);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1251, 843);
            this.gradientPanel1.TabIndex = 2;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(166)))));
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // dtgv_thongtinSalary
            // 
            this.dtgv_thongtinSalary.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_thongtinSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_thongtinSalary.Location = new System.Drawing.Point(102, 214);
            this.dtgv_thongtinSalary.Name = "dtgv_thongtinSalary";
            this.dtgv_thongtinSalary.RowHeadersWidth = 51;
            this.dtgv_thongtinSalary.RowTemplate.Height = 24;
            this.dtgv_thongtinSalary.Size = new System.Drawing.Size(1058, 589);
            this.dtgv_thongtinSalary.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(628, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "To Date";
            // 
            // cb_to_date
            // 
            this.cb_to_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.cb_to_date.DisplayMember = "Your Value";
            this.cb_to_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_to_date.FormattingEnabled = true;
            this.cb_to_date.Location = new System.Drawing.Point(621, 112);
            this.cb_to_date.Name = "cb_to_date";
            this.cb_to_date.Size = new System.Drawing.Size(219, 24);
            this.cb_to_date.TabIndex = 30;
            this.cb_to_date.Tag = "Your Value";
            this.cb_to_date.ValueMember = "Your Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(368, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "From Date";
            // 
            // cb_from_date
            // 
            this.cb_from_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.cb_from_date.DisplayMember = "Your Value";
            this.cb_from_date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_from_date.FormattingEnabled = true;
            this.cb_from_date.Location = new System.Drawing.Point(361, 112);
            this.cb_from_date.Name = "cb_from_date";
            this.cb_from_date.Size = new System.Drawing.Size(219, 24);
            this.cb_from_date.TabIndex = 28;
            this.cb_from_date.Tag = "Your Value";
            this.cb_from_date.ValueMember = "Your Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(109, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Employee Type";
            // 
            // cb_employee_type
            // 
            this.cb_employee_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.cb_employee_type.DisplayMember = "Your Value";
            this.cb_employee_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_employee_type.FormattingEnabled = true;
            this.cb_employee_type.Location = new System.Drawing.Point(102, 112);
            this.cb_employee_type.Name = "cb_employee_type";
            this.cb_employee_type.Size = new System.Drawing.Size(219, 24);
            this.cb_employee_type.TabIndex = 26;
            this.cb_employee_type.Tag = "Your Value";
            this.cb_employee_type.ValueMember = "Your Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(888, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ethnicity";
            // 
            // cb_ethnicity
            // 
            this.cb_ethnicity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.cb_ethnicity.DisplayMember = "Your Value";
            this.cb_ethnicity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ethnicity.FormattingEnabled = true;
            this.cb_ethnicity.Location = new System.Drawing.Point(881, 44);
            this.cb_ethnicity.Name = "cb_ethnicity";
            this.cb_ethnicity.Size = new System.Drawing.Size(219, 24);
            this.cb_ethnicity.TabIndex = 24;
            this.cb_ethnicity.Tag = "Your Value";
            this.cb_ethnicity.ValueMember = "Your Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(628, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Department";
            // 
            // cb_department
            // 
            this.cb_department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.cb_department.DisplayMember = "Your Value";
            this.cb_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(621, 44);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(219, 24);
            this.cb_department.TabIndex = 22;
            this.cb_department.Tag = "Your Value";
            this.cb_department.ValueMember = "Your Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(368, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Gender";
            // 
            // cb_gender
            // 
            this.cb_gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.cb_gender.DisplayMember = "Your Value";
            this.cb_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_gender.FormattingEnabled = true;
            this.cb_gender.Location = new System.Drawing.Point(361, 44);
            this.cb_gender.Name = "cb_gender";
            this.cb_gender.Size = new System.Drawing.Size(219, 24);
            this.cb_gender.TabIndex = 20;
            this.cb_gender.Tag = "Your Value";
            this.cb_gender.ValueMember = "Your Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(109, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Shareholder";
            // 
            // cb_shareholder
            // 
            this.cb_shareholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(60)))));
            this.cb_shareholder.DisplayMember = "Your Value";
            this.cb_shareholder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_shareholder.FormattingEnabled = true;
            this.cb_shareholder.Location = new System.Drawing.Point(102, 44);
            this.cb_shareholder.Name = "cb_shareholder";
            this.cb_shareholder.Size = new System.Drawing.Size(219, 24);
            this.cb_shareholder.TabIndex = 18;
            this.cb_shareholder.Tag = "Your Value";
            this.cb_shareholder.ValueMember = "Your Value";
            // 
            // btn_Apply
            // 
            this.btn_Apply.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Apply.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Apply.Location = new System.Drawing.Point(947, 100);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(92, 36);
            this.btn_Apply.TabIndex = 33;
            this.btn_Apply.Text = "APPLY";
            this.btn_Apply.UseVisualStyleBackColor = false;
            // 
            // frm_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 843);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Salary";
            this.Text = "frm_Salary";
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongtinSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.DataGridView dtgv_thongtinSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_to_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_from_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_employee_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_ethnicity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_shareholder;
        private System.Windows.Forms.Button btn_Apply;
    }
}