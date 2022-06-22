using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkApp.Models
{
    public class PositionSalary
    {
        public int Id { get; set; }
        public Position Position { get; set; }
        public double Ammount { get; set; }
        public DateTime Date { get; set; }
    }
}
