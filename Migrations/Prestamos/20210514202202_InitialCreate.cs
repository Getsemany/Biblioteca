using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Migrations.Prestamos
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    idUsuario = table.Column<int>(type: "INTEGER", nullable: false),
                    estado = table.Column<bool>(type: "INTEGER", nullable: false),
                    fechaPres = table.Column<DateTime>(type: "TEXT", nullable: false),
                    fechaRe = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prestamos");
        }
    }
}
