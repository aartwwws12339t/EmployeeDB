using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Models
{
    public class DepartmentEmployee
    {
        public int Id{ get; set; }
        public Department Department { get; set; }
        public Employee Employee { get; set; }
        public DateTime? Date { get; set; }
        public bool IsHead { get; set; }
    }
}
