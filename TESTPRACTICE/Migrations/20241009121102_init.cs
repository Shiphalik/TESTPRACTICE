using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TESTPRACTICE.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "STUDENT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AGE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IMAGE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CLASS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ROLLNUMBER = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDENT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Languages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    TeachersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeachersId",
                table: "Subjects",
                column: "TeachersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "STUDENT");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
