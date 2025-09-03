using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsCRUD.Models;

namespace WinFormsCRUD
{
    public partial class Form1 : Form
    {
        private int _selectedId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ReloadGrid()
        {
            using var db = new AppDbContext();
            dataGridView1.DataSource = db.Employees.OrderBy(e => e.Id).ToList();
        }

        private void ClearInputs()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtSalary.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            cmbGender.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            _selectedId = 0;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ReloadGrid();
            ClearInputs();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtSalary.Text, out var salary))
            {
                MessageBox.Show("Enter a valid salary.");
                return;
            }

            using var db = new AppDbContext();
            var emp = new Employee
            {
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Salary = salary,
                PhoneNumber = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Gender = cmbGender.SelectedItem?.ToString() ?? "",
                Department = cmbDepartment.SelectedItem?.ToString() ?? string.Empty
            };
            db.Employees.Add(emp);
            db.SaveChanges();

            ReloadGrid();
            ClearInputs();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            if (row?.Cells["Id"].Value is int id)
            {
                _selectedId = id;
                txtName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtSalary.Text = row.Cells["Salary"].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                txtAddress.Text = row.Cells["Address"].Value?.ToString() ?? "";
                cmbGender.SelectedItem = row.Cells["Gender"].Value?.ToString() ?? "";
                cmbDepartment.SelectedItem = row.Cells["Department"].Value?.ToString() ?? "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Select a row to update.");
                return;
            }
            if (!decimal.TryParse(txtSalary.Text, out var salary))
            {
                MessageBox.Show("Enter a valid salary.");
                return;
            }

            using var db = new AppDbContext();
            var emp = db.Employees.Find(_selectedId);
            if (emp == null)
            {
                MessageBox.Show("Record not found.");
                ReloadGrid();
                return;
            }

            emp.Name = txtName.Text.Trim();
            emp.Email = txtEmail.Text.Trim();
            emp.Salary = salary;
            emp.PhoneNumber = txtPhone.Text.Trim();
            emp.Address = txtAddress.Text.Trim();
            emp.Gender = cmbGender.SelectedItem?.ToString() ?? "";
            emp.Department = cmbDepartment.SelectedItem?.ToString() ?? "";

            db.SaveChanges();
            ReloadGrid();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0)
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            var confirm = MessageBox.Show("Delete selected record?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            using var db = new AppDbContext();
            var emp = db.Employees.Find(_selectedId);
            if (emp != null)
            {
                db.Employees.Remove(emp);
                db.SaveChanges();
            }

            ReloadGrid();
            ClearInputs();
        }
    }
}
