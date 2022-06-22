using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseWorkApp.Migrations
{
    public partial class LoginsRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sql = @"CREATE LOGIN admin1 WITH PASSWORD = 'admin1'

                       CREATE USER admin1 FOR LOGIN admin1

                       CREATE LOGIN user1 WITH PASSWORD = 'user1'

                       CREATE USER user1 FOR LOGIN user1

                       CREATE ROLE AdminRole 

                       GRANT SELECT, INSERT, UPDATE, DELETE ON SCHEMA :: dbo TO AdminRole

                       ALTER ROLE AdminRole ADD MEMBER admin1

                       CREATE ROLE UserRole 

                       GRANT SELECT ON SCHEMA :: dbo TO UserRole

                       ALTER ROLE UserRole ADD MEMBER user1
                       INSERT INTO Logins(LoginString,Role)
                        VALUES ('admin1','admin'),
                               ('user1','user')";

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sql = @"DROP LOGIN admin1

                       DROP USER admin1

                       DROP LOGIN user1

                       DROP USER user1

                       DROP ROLE UserRole

                       DROP ROLE AdminRole";

            migrationBuilder.Sql(sql);
        }
    }
}
