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
    public partial class Report2Form : Form
    {
        public Logic logic;
        public Report2Form(Logic _logic)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            logic = _logic;

            employeeBox.DataSource = logic.GetNames();
            employeeBox.SelectedIndex = -1;

            posBox.Enabled = false;
            salBox.Enabled = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(employeeBox.Text != "")
            {
                (Employee employee, DepartmentEmployee? head, Position? position, double? salary, DateTime? startDate) empInfo = logic
                    .GetEmployeeInfo(employeeBox.Text);
                if (empInfo.position != null)
                {
                    posBox.Text = empInfo.position.Name;
                    if (empInfo.salary != null)
                    {
                        DateTime zeroTime = new DateTime(1, 1, 1);
                        int yearsIn = DateTime.Now.Year - empInfo.startDate.Value.Year;
                        salBox.Text = Convert.ToString(empInfo.salary + empInfo.salary / 1000 * 12 * yearsIn);
                    }
                    else
                    {
                        salBox.Text = "";
                    }
                }
                else
                {
                    salBox.Text = "";
                    posBox.Text = "";
                }
            }
            else
            {
                salBox.Text = "";
                posBox.Text = "";
            }
        }
    }
}
