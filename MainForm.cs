using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWorkApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseWorkApp
{
    public partial class MainForm : Form
    {
        public int _addingInProcess = 0;
        public int _editingInProcess = 0;
        public Logic logic;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(Logic _logic)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            logic = _logic;
            InitializeComponent();
            UpdateList();

            bossBox.Enabled = false;
            salaryBox.Enabled = false;

            BindingSource depBs = new BindingSource();
            var departments = logic._context.Departments.Select(d => d.Name);
            depBs.DataSource = departments.ToList();
            departmentBox.DataSource = depBs;
            departmentBox.SelectedIndex = -1;

            BindingSource posBs = new BindingSource();
            posBs.DataSource = logic._context.Positions.Select(p => p.Name).ToList();
            positionBox.DataSource = posBs;
            positionBox.SelectedIndex = -1;

            vacationButton.Enabled = false;

            if(logic.mode != "admin")
            {
                adminPanel.Visible = false;
            }
            else
            {
                adminPanel.Visible = true;  
            }
        }

        private void employeesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (employeesList.SelectedItems.Count == 0)
            {
                nameBox.Text = "";
                surnameBox.Text = "";
                fnameBox.Text = "";
                pasportBox.Text = "";
                birthdayPicker.Value = DateTime.Now;
                birthplaceBox.Text = "";
                addresBox.Text = "";
                positionBox.SelectedIndex = -1;
                departmentBox.SelectedIndex = -1;
                bossBox.Text = "";
                salaryBox.Text = "";
                vacationButton.Enabled = false;
            }
            else
            {
                (Employee employee, DepartmentEmployee? head, Position ? position, double? salary, DateTime? startDate) empInfo = logic
                    .GetEmployeeInfo(employeesList.SelectedItem.ToString());
                
                nameBox.Text = empInfo.employee.Name;
                surnameBox.Text = empInfo.employee.Surname;
                fnameBox.Text = empInfo.employee.Fathersname;
                pasportBox.Text = empInfo.employee.PassportData;
                birthdayPicker.Value = empInfo.employee.BirthDate;
                birthplaceBox.Text = empInfo.employee.BirthPlace;
                addresBox.Text = empInfo.employee.HomeAddress;
                if(empInfo.head!= null)
                {
                    bossBox.Text = empInfo.head.Employee.Name + " " + empInfo.head.Employee.Surname + " " + empInfo.head.Employee.Fathersname;
                    departmentBox.SelectedIndex = departmentBox.FindStringExact(empInfo.head.Department.Name);
                }
                else
                {
                    bossBox.Text = "";
                    departmentBox.SelectedIndex = -1;
                }
                if(empInfo.salary!= null)
                {
                    DateTime zeroTime = new DateTime(1, 1, 1);
                    int yearsIn = DateTime.Now.Year - empInfo.startDate.Value.Year;
                    salaryBox.Text = Convert.ToString(empInfo.salary+ empInfo.salary/1000*12*yearsIn);
                }
                else
                {
                    salaryBox.Text = "";
                }
                if (empInfo.position != null)
                {
                    positionBox.SelectedIndex = positionBox.FindStringExact(empInfo.position.Name);
                }
                else
                {
                    positionBox.SelectedIndex = -1;
                }

                vacationButton.Enabled = true;
            }
            

        }
        private void UpdateList()
        {
            employeesList.Items.Clear();

            foreach (var Employee in logic.GetNames())
            {
                employeesList.Items.Add(Employee);
            }
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            if (_addingInProcess == 0)
            {
                employeesList.ClearSelected();
                addEmployeeButton.Text = "Adding in Process";
                _addingInProcess = 1;
            } else
            {
                Employee employee = new Employee();
                if(nameBox.Text == "" || surnameBox.Text == "" || fnameBox.Text == "")
                {
                    MessageBox.Show("Incorrectly entered data");
                }
                else
                {
                    var copy = logic._context.Employees
                        .AsNoTracking()
                        .Where(e => e.Name == nameBox.Text && e.Surname == surnameBox.Text && e.Fathersname == fnameBox.Text)
                        .FirstOrDefault();
                    var depMax = logic._context.DepartmentEmployees
                        .AsNoTracking()
                        .Where(de => de.Department.Name == departmentBox.Text)
                        .Select(de => de.Employee)
                        .Distinct()
                        .Count();
                    if (copy != null)
                    {
                        MessageBox.Show("Such employee already exists");
                    }
                    else
                    {
                        if (depMax >= 20)
                        {
                            MessageBox.Show("Too many employees in this department");
                        }
                        else
                        {
                            employee.Name = nameBox.Text;
                            employee.Surname = surnameBox.Text;
                            employee.Fathersname = fnameBox.Text;
                            employee.PassportData = pasportBox.Text;
                            employee.BirthDate = birthdayPicker.Value;
                            employee.BirthPlace = birthplaceBox.Text;
                            employee.HomeAddress = addresBox.Text;

                            if (positionBox.SelectedItem != null)
                            {
                                var posemp = new EmployeePosition();
                                posemp.Position = logic._context.Positions
                                    .Where(p => p.Name == positionBox.SelectedItem.ToString())
                                    .First();
                                posemp.Employee = employee;
                                posemp.Date = DateTime.Now;
                                logic._context.EmployeePositions.Add(posemp);
                                
                            }
                            if (departmentBox.SelectedItem != null)
                            {
                                var depemp = new DepartmentEmployee();
                                depemp.Date = DateTime.Now;
                                depemp.Department = logic._context.Departments
                                    .Where(d => d.Name == departmentBox.SelectedItem.ToString())
                                    .First();
                                depemp.Employee = employee;
                                logic._context.DepartmentEmployees.Add(depemp);
                                
                            }
                            logic._context.Employees.Add(employee);
                            logic._context.SaveChanges();

                        }
                    }
                }
                UpdateList();
                _addingInProcess = 0;
                addEmployeeButton.Text = "Add new Employee";
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(_editingInProcess == 0 && employeesList.SelectedItems.Count == 1)
            {
                _editingInProcess = 1;
                editButton.Text = "Editing in Progress";
            }
            else
            {
                var copy = logic._context.Employees
                        .AsNoTracking()
                        .Where(e => e.Name == nameBox.Text && e.Surname == surnameBox.Text && e.Fathersname == fnameBox.Text)
                        .Count();
                var depMax = logic._context.DepartmentEmployees
                    .AsNoTracking()
                    .Where(de => de.Department.Name == departmentBox.Text)
                    .Select(de => de.Employee)
                    .Distinct()
                    .Count();
                if (copy >=2)
                {
                    MessageBox.Show("Such employee already exists");
                }
                else
                {
                    if (depMax >= 20)
                    {
                        MessageBox.Show("Too many employees in this department");
                    }
                    else
                    {
                        var employee = logic._context.Employees
                    .Where(e => e.Name + " " + e.Surname + " " + e.Fathersname == employeesList.SelectedItem.ToString())
                    .First();
                        var position = logic._context.EmployeePositions
                            .Where(ep => ep.Employee.Id == employee.Id)
                            .OrderByDescending(ep => ep.Date)
                            .Include(ep => ep.Position)
                            .FirstOrDefault();
                        var department = logic._context.DepartmentEmployees
                            .Where(de => de.Employee.Id == employee.Id)
                            .OrderByDescending(de => de.Date)
                            .Include(de => de.Department)
                            .FirstOrDefault();
                        employee.Name = nameBox.Text;
                        employee.Surname = surnameBox.Text;
                        employee.Fathersname = fnameBox.Text;
                        employee.PassportData = pasportBox.Text;
                        employee.BirthDate = birthdayPicker.Value;
                        employee.BirthPlace = birthplaceBox.Text;
                        employee.HomeAddress = addresBox.Text;
                        if (positionBox.SelectedItem != null)
                        {
                            if (position == null || position.Position.Name != positionBox.SelectedItem.ToString())
                            {
                                var posemp = new EmployeePosition();
                                posemp.Position = logic._context.Positions
                                    .Where(p => p.Name == positionBox.SelectedItem.ToString())
                                    .First();
                                posemp.Employee = employee;
                                posemp.Date = DateTime.Now;
                                logic._context.EmployeePositions.Add(posemp);
                            }
                        }
                        if (departmentBox.SelectedItem != null)
                        {

                            if (department == null || department.Department.Name != departmentBox.SelectedItem.ToString())
                            {
                                var depemp = new DepartmentEmployee();
                                depemp.Date = DateTime.Now;
                                depemp.Department = logic._context.Departments
                                    .Where(d => d.Name == departmentBox.SelectedItem.ToString())
                                    .First();
                                depemp.Employee = employee;
                                logic._context.DepartmentEmployees.Add(depemp);
                            }
                        }
                        logic._context.SaveChanges();
                    }
                }
                _editingInProcess = 0;
                editButton.Text = "Edit Data";
            }
        }

        private void posdepButton_Click(object sender, EventArgs e)
        {
            employeesList.ClearSelected();
            new PosDepForm(logic).ShowDialog();
            BindingSource depBs = new BindingSource();
            var departments = logic._context.Departments.Select(d => d.Name);
            depBs.DataSource = departments.ToList();
            departmentBox.DataSource = depBs;
            departmentBox.SelectedIndex = -1;

            BindingSource posBs = new BindingSource();
            posBs.DataSource = logic._context.Positions.Select(p => p.Name).ToList();
            positionBox.DataSource = posBs;
            positionBox.SelectedIndex = -1;
        }

        private void vacationButton_Click(object sender, EventArgs e)
        {
            var employee = logic._context.Employees
                                .Where(e => e.Name + " " + e.Surname + " " + e.Fathersname == employeesList.SelectedItem.ToString())
                                .First();
            new VacationsForm(logic, employee).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Report1Form(logic).ShowDialog();
        }

        private void rep2Button_Click(object sender, EventArgs e)
        {
            new Report2Form(logic).ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
