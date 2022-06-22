using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Models
{
    public class EmployeePosition
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public Position Position { get; set; }
        public DateTime? Date { get; set; }
    }
}
