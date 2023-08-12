using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentDetails.Migrations
{
    /// <inheritdoc />
    public partial class CreateStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Rollno = table.Column<int>(type: "int", nullable: false),
                    Studentame = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Addr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phno = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Rollno);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
