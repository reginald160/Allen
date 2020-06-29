using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeBitesAcademyEFC.Migrations
{
    public partial class Binding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentTabl",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentTabl", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "SystemUserTabl",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Status = table.Column<string>(type: "varchar(10)", nullable: false),
                    Role = table.Column<string>(type: "varchar(10)", nullable: false),
                    Username = table.Column<string>(type: "varchar(10)", nullable: false),
                    Password = table.Column<string>(type: "varchar(10)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemUserTabl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTaabl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LasttName = table.Column<string>(maxLength: 20, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Number = table.Column<string>(maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTaabl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeTaabl_DepartmentTabl_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "DepartmentTabl",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTaabl_DepartmentId",
                table: "EmployeeTaabl",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTaabl");

            migrationBuilder.DropTable(
                name: "SystemUserTabl");

            migrationBuilder.DropTable(
                name: "DepartmentTabl");
        }
    }
}
