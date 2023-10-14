using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamASP.Migrations
{
    /// <inheritdoc />
    public partial class examasp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department_Tbl",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    location = table.Column<string>(type: "text", nullable: false),
                    numberOfPersonals = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department_Tbl", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Tbl",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    code = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    department_id = table.Column<int>(type: "int", nullable: false),
                    rank = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Tbl", x => x.id);
                    table.ForeignKey(
                        name: "FK_Employee_Tbl_Department_Tbl_department_id",
                        column: x => x.department_id,
                        principalTable: "Department_Tbl",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Tbl_department_id",
                table: "Employee_Tbl",
                column: "department_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_Tbl");

            migrationBuilder.DropTable(
                name: "Department_Tbl");
        }
    }
}
