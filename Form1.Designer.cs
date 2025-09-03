namespace WinFormsCRUD
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtSalary = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            cmbGender = new ComboBox();
            btnLoad = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            lblName = new Label();
            lblEmail = new Label();
            lblSalary = new Label();
            lblPhone = new Label();
            lblAddress = new Label();
            lblGender = new Label();
            lblDepartment = new Label();
            cmbDepartment = new ComboBox();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(262, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 23);
            txtName.TabIndex = 21;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(262, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 22;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(262, 138);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(183, 23);
            txtSalary.TabIndex = 23;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(262, 178);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(183, 23);
            txtPhone.TabIndex = 24;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(262, 218);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(183, 50);
            txtAddress.TabIndex = 25;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = SystemColors.Window;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(262, 288);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(183, 23);
            cmbGender.TabIndex = 26;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.White;
            btnLoad.Location = new Point(455, 58);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(100, 30);
            btnLoad.TabIndex = 27;
            btnLoad.Text = "List";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Location = new Point(455, 98);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 30);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.Location = new Point(455, 138);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 30);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Location = new Point(455, 178);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(25, 366);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(700, 314);
            dataGridView1.TabIndex = 31;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // lblName
            // 
            lblName.BackColor = Color.White;
            lblName.Location = new Point(155, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 15;
            lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            lblEmail.BackColor = Color.White;
            lblEmail.Location = new Point(155, 101);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 16;
            lblEmail.Text = "Email:";
            // 
            // lblSalary
            // 
            lblSalary.BackColor = Color.White;
            lblSalary.Location = new Point(155, 141);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(100, 23);
            lblSalary.TabIndex = 17;
            lblSalary.Text = "Salary:";
            // 
            // lblPhone
            // 
            lblPhone.BackColor = Color.White;
            lblPhone.Location = new Point(155, 181);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 18;
            lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            lblAddress.BackColor = Color.White;
            lblAddress.Location = new Point(155, 221);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 19;
            lblAddress.Text = "Address:";
            // 
            // lblGender
            // 
            lblGender.BackColor = Color.White;
            lblGender.Location = new Point(155, 291);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 20;
            lblGender.Text = "Gender:";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.BackColor = Color.White;
            lblDepartment.Location = new Point(155, 330);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(73, 15);
            lblDepartment.TabIndex = 20;
            lblDepartment.Text = "Department:";
            // 
            // cmbDepartment
            // 
            cmbDepartment.BackColor = SystemColors.ButtonHighlight;
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.Items.AddRange(new object[] { "HR", "IT", "Finance", "Sales", "Marketing" });
            cmbDepartment.Location = new Point(262, 330);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(183, 23);
            cmbDepartment.TabIndex = 14;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(202, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(338, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Employee Management System";
            // 
            // Form1
            // 
            BackColor = Color.LightBlue;
            ClientSize = new Size(760, 683);
            Controls.Add(lblTitle);
            Controls.Add(lblDepartment);
            Controls.Add(cmbDepartment);
            Controls.Add(lblName);
            Controls.Add(lblEmail);
            Controls.Add(lblSalary);
            Controls.Add(lblPhone);
            Controls.Add(lblAddress);
            Controls.Add(lblGender);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtSalary);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(cmbGender);
            Controls.Add(btnLoad);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "WinForms CRUD Example";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbGender;

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;

        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
    }
}
