using CourseWorkApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseWorkApp
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new 
                {
                Id = 1,
                Name = "Tania",
                Surname = "Sidelnyk",
                Fathersname = "Zinoviivna",
                HomeAddress = "Lviv",
                BirthDate = new DateTime(2022,03,19),
                PassportData = "800333183492"
                }
            );

            modelBuilder.Entity<EmployeePosition>().HasData(
                new
                {
                    Id = 1,
                    EmployeeId = 1,
                    PositionId = 1,
                    Date = new DateTime(2022,04,21)
                }
            );

            modelBuilder.Entity<Position>().HasData(
                new
                {
                    Id = 1,
                    Name = "Art director",
                    DepartmentId = 1
                },
                new 
                {
                    Id = -1,
                    Name = "Fired",
                }
            );

            modelBuilder.Entity<Department>().HasData(
                new {
                    Id = 1,
                    Name = "Department of Art ",
                    HeadId = 1,
                    Abbriviation = "AD"
                }
            );
        }
    }
}
