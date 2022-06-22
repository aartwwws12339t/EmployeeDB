using Microsoft.EntityFrameworkCore;
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

namespace CourseWorkApp
{
    public partial class PosDepForm : Form
    {

        public int _addingPosInProcess = 0;
        public int _addingDepInProcess = 0;
        public int _editingPosInProcess = 0;
        public int _editingDepInProcess = 0;
        public Logic _logic;
        public PosDepForm()
        {
            InitializeComponent();
        }
        public PosDepForm(Logic logic)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
            _logic = logic;
            UpdateDepartmentList();
            UpdatePositionList();
            BindingSource depBs = new BindingSource();
            depBs.DataSource = _logic.GetNames();
            depHeadBox.DataSource = depBs;
            depHeadBox.SelectedIndex = -1;
            foreach (var cont in this.Controls)
            {
                if(cont.GetType() == typeof(TextBox))
                {
                    ((TextBox)cont).Enabled = false;
                }
            }
            depHeadBox.Enabled = false;
        }
        private void UpdatePositionList()
        {
            posList.Items.Clear();

            foreach (var Position in _logic._context.Positions)
            {
                posList.Items.Add(Position.Name);
            }
        }
        private void UpdateDepartmentList()
        {
            departmentList.Items.Clear();

            foreach (var Department in _logic._context.Departments)
            {
                departmentList.Items.Add(Department.Name);
            }
        }

        private void posAddButton_Click(object sender, EventArgs e)
        {
            if (_addingPosInProcess == 0)
            {
                posNameBox.Enabled = true;
                vacationBox.Enabled = true;
                salaryBox.Enabled = true;
                posNameBox.Text = "";
                vacationBox.Text = "";
                salaryBox.Text = "";
                posAddButton.Text = "Adding";
                _addingPosInProcess = 1;
            }
            else
            {
                Position position = new Position();
                PositionSalary posSal = new PositionSalary();
                if(posNameBox.Text == "" || salaryBox.Text == "")
                {
                    MessageBox.Show("Incorrectly entered data");

                }
                else
                {
                    position.Name = posNameBox.Text;
                    position.VacancyDays = Convert.ToInt32(vacationBox.Text);
                    posSal.Date = DateTime.Now;
                    posSal.Ammount = Convert.ToDouble(salaryBox.Text);
                    posSal.Position = position;
                    _logic._context.Positions.Add(position);
                    _logic._context.PositionSalarys.Add(posSal);
                    _logic._context.SaveChanges();
                }
                _addingPosInProcess = 0;
                posAddButton.Text = "Add";
                UpdatePositionList();
                posNameBox.Enabled = false;
                vacationBox.Enabled = false;
                salaryBox.Enabled = false;
            }
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void depAdd_Click(object sender, EventArgs e)
        {
            if (_addingDepInProcess == 0)
            {
                depNameBox.Enabled = true;
                abbBox.Enabled = true;
                depHeadBox.Enabled = true;
                depNameBox.Text = "";
                abbBox.Text = "";
                depHeadBox.SelectedIndex = -1;
                depAdd.Text = "Adding";
                _addingDepInProcess = 1;
            }
            else
            {
                Department Department = new Department();
                DepartmentEmployee depSal = new DepartmentEmployee();
                if (depNameBox.Text == "" || abbBox.Text == "" || depHeadBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Incorrectly entered data");
                }
                else
                {
                    Department.Name = depNameBox.Text;
                    Department.Abbriviation = abbBox.Text;
                    depSal.Date = DateTime.Now;
                    string allname = depHeadBox.SelectedItem.ToString();
                    depSal.Employee = _logic._context.Employees
                        .Where((e) => e.Name + " " + e.Surname + " " + e.Fathersname == allname)
                        .First();
                    depSal.IsHead = true;
                    depSal.Department = Department;
                    _logic._context.Departments.Add(Department);
                    _logic._context.DepartmentEmployees.Add(depSal);
                    _logic._context.SaveChanges();
                }
                depAdd.Text = "Add";
                _addingDepInProcess = 0;
                UpdateDepartmentList();
                depNameBox.Enabled = false;
                abbBox.Enabled = false;
                depHeadBox.Enabled = false;
            }
        }

        private void posEditButton_Click(object sender, EventArgs e)
        {
            if (_editingPosInProcess == 0 && posList.SelectedItems.Count == 1)
            {
                posNameBox.Enabled = true;
                vacationBox.Enabled = true;
                salaryBox.Enabled = true;
                _editingPosInProcess = 1;
                posEditButton.Text = "Editing";
            }
            else
            {
                Position position = _logic._context.Positions
                    .Where(p => p.Name == posList.SelectedItem.ToString())
                    .First();
                PositionSalary posSal = _logic._context.PositionSalarys
                    .Where(ps => ps.Position.Id == position.Id)
                    .First();
                if (posNameBox.Text == "" || salaryBox.Text == "")
                {
                    MessageBox.Show("Incorrectly entered data");
                }
                else
                {
                    position.Name = posNameBox.Text;
                    position.VacancyDays = Convert.ToInt32(vacationBox.Text);
                    if(posSal.Ammount != Convert.ToDouble(salaryBox.Text))
                    {
                        PositionSalary posSalNew = new PositionSalary();
                        posSalNew.Date = DateTime.Now;
                        posSalNew.Ammount = Convert.ToDouble(salaryBox.Text);
                        posSalNew.Position = position;
                        _logic._context.PositionSalarys.Add(posSalNew);
                    }
                    _logic._context.SaveChanges();
                }
                _editingPosInProcess = 0;
                posEditButton.Text = "Edit";
                UpdatePositionList();
                posNameBox.Enabled = false;
                vacationBox.Enabled = false;
                salaryBox.Enabled = false;
            }
        }

        private void depEdit_Click(object sender, EventArgs e)
        {
            if (_editingDepInProcess == 0 && departmentList.SelectedItems.Count == 1)
            {
                depNameBox.Enabled = true;
                abbBox.Enabled = true;
                depHeadBox.Enabled = true;
                _editingDepInProcess = 1;
                depEdit.Text = "Editing";
            }
            else
            {
                Department department = _logic._context.Departments
                    .Where(d => d.Name == departmentList.SelectedItem.ToString())
                    .First();
                DepartmentEmployee depPrev = _logic._context.DepartmentEmployees
                    .Where(de => de.Department.Id == department.Id)
                    .Include(de => de.Employee)
                    .First();
                if (depNameBox.Text == "" || abbBox.Text == "" || depHeadBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Incorrectly entered data");
                }
                else
                {
                    department.Name = depNameBox.Text;
                    department.Abbriviation = abbBox.Text;
                    if (depPrev.Employee.Name + " " + depPrev.Employee.Surname + " " + depPrev.Employee.Fathersname != depHeadBox.SelectedItem.ToString())
                    {
                        DepartmentEmployee depEmp = new DepartmentEmployee();
                        DepartmentEmployee depPrevNew = new DepartmentEmployee();
                        depEmp.Date = DateTime.Now;
                        depEmp.Employee = _logic._context.Employees
                            .Where((e) => e.Name + " " + e.Surname + " " + e.Fathersname == depHeadBox.SelectedItem.ToString())
                            .First();
                        depEmp.Department = department;
                        depEmp.IsHead = true;
                        _logic._context.DepartmentEmployees.Add(depEmp);
                        depPrevNew.Date = DateTime.Now;
                        depPrevNew.Employee = depPrev.Employee;
                        depPrevNew.Department = depPrev.Department;
                        depPrevNew.IsHead = false;
                        _logic._context.DepartmentEmployees.Add(depPrevNew);

                    }
                    _logic._context.SaveChanges();
                }
                _editingDepInProcess = 0;
                depEdit.Text = "Edit";
                UpdateDepartmentList();
                depNameBox.Enabled = false;
                abbBox.Enabled = false;
                depHeadBox.Enabled = false;
            }
        }

        private void posList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (posList.SelectedItems.Count == 0)
            {
                posNameBox.Text = "";
                vacationBox.Text = "";
                salaryBox.Text = "";
                return;
            }
            var position = _logic._context.Positions.Where((e) => e.Name == posList.SelectedItem.ToString()).First();
            posNameBox.Text = position.Name;
            vacationBox.Text = position.VacancyDays.ToString();
            try
            {
                var posSalary = _logic._context.PositionSalarys.Where((e) => e.Position == position).OrderByDescending(e => e.Date).First();
                salaryBox.Text = posSalary.Ammount.ToString();
            }
            catch
            {
                salaryBox.Text = "";
            }

        }

        private void departmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departmentList.SelectedItems.Count == 0)
            {
                depNameBox.Text = "";
                abbBox.Text = "";
                amountLabel.Text = "";
                depHeadBox.SelectedIndex = -1;
                return;
            }
            var department = _logic._context.Departments.Where((e) => e.Name == departmentList.SelectedItem
                                                                                    .ToString()).First();
            depNameBox.Text = department.Name;
            abbBox.Text = department.Abbriviation;
            var DepEmployees = _logic._context.DepartmentEmployees
                .AsNoTracking()
                .Where(de => de.Department.Id == department.Id)
                .Select(de => de.Employee)
                .Distinct()
                .ToList();
            int amount = DepEmployees.Count();
            amountLabel.Text = amount.ToString();
            try
            {
                var depemp = _logic._context.DepartmentEmployees
                    .AsNoTracking()
                    .Where((e) => e.Department.Id == department.Id && e.IsHead == true)
                    .Include(de => de.Employee)
                    .OrderByDescending(e => e.Date).First();
                depHeadBox.SelectedIndex = depHeadBox.FindStringExact(depemp.Employee.Name + " " + depemp.Employee.Surname + " " + depemp.Employee.Fathersname);
            }
            catch
            {
                depHeadBox.SelectedIndex = -1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
