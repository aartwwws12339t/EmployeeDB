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
    public partial class Report1Form : Form
    {

        public Logic logic;
        public Report1Form(Logic _logic)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            logic = _logic;

            BindingSource depBs = new BindingSource();
            var departments = logic._context.Departments.Select(d => d.Name);
            depBs.DataSource = departments.ToList();
            departmentBox.DataSource = depBs;
            departmentBox.SelectedIndex = -1;
        }

        private void departmentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeList.Items.Clear();
            var DepEmployees = logic._context.DepartmentEmployees
                .AsNoTracking()
                .Where(de => de.Department.Name == departmentBox.Text)
                .Select(de => de.Employee)
                .Distinct()
                .ToList();
            int amount = DepEmployees.Count();
            foreach (var employee in DepEmployees)
            {
                employeeList.Items.Add(employee.Name+" "+employee.Surname+" "+employee.Fathersname);
            }
            if(departmentBox.SelectedIndex == -1)
            {
                amountLabel.Text = "";
            }
            else
            {
                amountLabel.Text = "Amount of employees working in " + departmentBox.Text + " : " + amount.ToString();
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
