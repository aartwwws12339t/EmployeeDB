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
    public partial class VacationsForm : Form
    {
        public Logic logic;
        public Employee employee;
        public int _adding = 0;
        public int _editing = 0;
        public double grantedDays = 0;
        public VacationsForm(Logic _logic, Employee _employee)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            employee = _employee;
            logic = _logic;
            
            UpdateVacationsList();

            var emppos = logic._context.EmployeePositions
                .AsNoTracking()
                .Where(ep => ep.Employee.Id == employee.Id)
                .Include(ep => ep.Position)
                .FirstOrDefault();
            var firstPosition = logic._context.EmployeePositions
                .Where(ep => ep.Employee.Id == employee.Id)
                .OrderBy(ep => ep.Date)
                .FirstOrDefault()
                ;
            int yearsIn = 1;
            DateTime? startDate = null;
            if (firstPosition != null)
            {
                startDate = firstPosition.Date;
                DateTime zeroTime = new DateTime(1, 1, 1);
                yearsIn = DateTime.Now.Year - startDate.Value.Year;
            }


            if (emppos != null)
            {
                grantedDays = Convert.ToDouble(emppos.Position.VacancyDays)*(yearsIn+1);
                grantedLabel.Text = grantedDays.ToString();
            }

            if (logic.mode != "admin")
            {
                adminPanel.Visible = false;
            }
            else
            {
                adminPanel.Visible = true;
            }
        }
        public void UpdateVacationsList()
        {
            double days = 0;
            vacationsList.Items.Clear();
            var employeesVacations = logic._context.Vacations
                .Where(v => v.Employee.Id == employee.Id);
            foreach (var vacation in employeesVacations)
            {
                days += (vacation.DateEnd - vacation.DateStart).TotalDays;
                vacationsList.Items.Add(vacation.DateStart.Date.ToString("dd/MM/yyyy") +" - "+vacation.DateEnd.Date.ToString("dd/MM/yyyy"));
            }
            usedLabel.Text = days.ToString();
            if (days > grantedDays)
            {
                usedLabel.ForeColor = Color.Red;
            }
            else
            {
                usedLabel.ForeColor = Color.Black;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(_adding == 0)
            {
                _adding = 1;
                AddButton.Text = "Adding";
            }
            else
            {
                var vac = new Vacation();
                vac.DateStart = startPicker.Value;
                vac.DateEnd = endPicker.Value;
                vac.Employee = employee;
                logic._context.Vacations.Add(vac);
                logic._context.SaveChanges();
                _adding = 0;
                AddButton.Text = "Add";
                UpdateVacationsList();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_editing == 0)
            {
                _editing = 1;
                EditButton.Text = "Editing";
            }
            else
            {
                
                if(vacationsList.SelectedIndex != -1)
                {
                    string[] dates = vacationsList.SelectedItem.ToString().Split();
                    DateTime startD = DateTime.ParseExact(dates[0], "dd/MM/yyyy", null);
                    DateTime endD = DateTime.ParseExact(dates[2], "dd/MM/yyyy", null);
                    var vac = logic._context.Vacations
                            .Where(v => v.Employee.Id == employee.Id &&
                                v.DateStart.Date == startD &&
                                v.DateEnd.Date == endD)
                            .First();
                    vac.DateStart = startPicker.Value;
                    vac.DateEnd = endPicker.Value;
                    vac.Employee = employee;
                }

                logic._context.SaveChanges();
                _editing = 0;
                EditButton.Text = "Edit";
                UpdateVacationsList();
            }
        }

        private void vacationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(vacationsList.SelectedIndex == -1)
            {
                startPicker.Value = DateTime.Now;
                endPicker.Value = DateTime.Now;
            }
            else
            {
                string[] dates = vacationsList.SelectedItem.ToString().Split();
                DateTime startD = DateTime.ParseExact(dates[0], "dd/MM/yyyy", null);
                DateTime endD = DateTime.ParseExact(dates[2], "dd/MM/yyyy", null);
                var vac = logic._context.Vacations
                        .Where(v => v.Employee.Id == employee.Id &&
                            v.DateStart.Date == startD &&
                            v.DateEnd.Date == endD)
                        .First();
                startPicker.Value = vac.DateStart;
                endPicker.Value = vac.DateEnd;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
