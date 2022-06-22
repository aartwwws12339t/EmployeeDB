using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Models
{
    public class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Fathersname { get; set; }
        public DateTime BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? PassportData { get; set; }
        public List<EmployeePosition> Positions { get; set; }
        public string HomeAddress { get; set; }
    }
}
