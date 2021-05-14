using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Migrations.Usuarios
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(type: "TEXT", nullable: true),
                    ApePat = table.Column<string>(type: "TEXT", nullable: true),
                    ApeMat = table.Column<string>(type: "TEXT", nullable: true),
                    matricula = table.Column<string>(type: "TEXT", nullable: true),
                    contraseña = table.Column<string>(type: "TEXT", nullable: true),
                    rol = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
