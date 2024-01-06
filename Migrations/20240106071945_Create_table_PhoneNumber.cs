using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VuTienDiep_192.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_PhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhoneNumber",
                columns: table => new
                {
                    PhoneNumberID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhoneNumberValue = table.Column<string>(type: "TEXT", nullable: false),
                    PersonID = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumber", x => x.PhoneNumberID);
                    table.ForeignKey(
                        name: "FK_PhoneNumber_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumber_PersonID",
                table: "PhoneNumber",
                column: "PersonID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneNumber");
        }
    }
}
