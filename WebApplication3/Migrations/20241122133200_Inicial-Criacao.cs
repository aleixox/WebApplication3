using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Migrations
{
    /// <inheritdoc />
    public partial class InicialCriacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notas Fiscais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    numeroNf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    valorTotal = table.Column<float>(type: "real", nullable: false),
                    dataNf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cnpfEmissorNf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cnpjDestinatarioNf = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notas Fiscais", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notas Fiscais");
        }
    }
}
