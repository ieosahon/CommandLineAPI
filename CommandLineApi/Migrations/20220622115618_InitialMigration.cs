using Microsoft.EntityFrameworkCore.Migrations;

namespace CommandLineApi.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Commands",
                columns: table => new
                {
                    CommandId = table.Column<string>(type: "text", nullable: false),
                    CommandName = table.Column<string>(type: "text", nullable: true),
                    CommandSnippet = table.Column<string>(type: "text", nullable: true),
                    TargetEnvironment = table.Column<string>(type: "text", nullable: true),
                    OS = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commands", x => x.CommandId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commands");
        }
    }
}
