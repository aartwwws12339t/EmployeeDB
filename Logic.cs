using CourseWorkApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp
{
    public class Logic
    {

        public ApplicationDataContext _context;
        public string mode;
        public Logic()
        {

        }

            public Logic(TransferContext context)
        {
            _context = context.context;
            mode = _context.Logins
                .Where((l) => l.LoginString == context.username)
                .First()
                .Role;
        }
        public List<string> GetNames()
        {
            return _context.Employees
                .AsNoTracking()
                .Select(x => x.Name + " " + x.Surname + " " + x.Fathersname).ToList();
        }
        
        public (Employee employee, DepartmentEmployee? head, Position? position, double? salary, DateTime? startDate) GetEmployeeInfo(string allname)
        {

            var employee = _context.Employees
                .Where(e => e.Name + " " + e.Surname + " " + e.Fathersname == allname).First();
            DepartmentEmployee? head = null;
            DepartmentEmployee? department = _context.DepartmentEmployees
                .Where(de => de.Employee.Id == employee.Id)
                .Include(de => de.Department)
                .FirstOrDefault();
            if(department != null)
            {
                int depId = department.Department.Id;
                head = _context.DepartmentEmployees
                    .Where(de => de.Department.Id == depId && de.IsHead == true)
                    .OrderByDescending(de => de.Date)
                    .Include(de => de.Department)
                    .Include(de => de.Employee)
                    .First();
            } 
            

            Position? position = _context.Positions
                .Where(p => p.Id == _context.EmployeePositions
                    .Where(ep => ep.Employee.Id == employee.Id)
                    .OrderByDescending(ep => ep.Date)
                    .FirstOrDefault()
                    .Position.Id
                ).FirstOrDefault();
            double? salary = null;
            if (position != null)
            {
                PositionSalary? pos = _context.PositionSalarys
                .Where(ps => ps.Position.Id == position.Id)
                .OrderByDescending(ps => ps.Date)
                .FirstOrDefault()
                ;
                if (pos != null)
                {
                    salary = pos.Ammount;
                }
            }
            EmployeePosition firstPosition = _context.EmployeePositions
                .Where(ep => ep.Employee.Id == employee.Id)
                .OrderBy(ep => ep.Date)
                .FirstOrDefault()
                ;
            DateTime? startDate= null;
            if (firstPosition != null)
            {
                startDate = firstPosition.Date;
            }
            
            return (employee, head, position, salary, startDate);
        }
    }
}