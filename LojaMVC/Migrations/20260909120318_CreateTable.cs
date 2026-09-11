using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaMVC.Migrations
{
    /// <inheritdoc />
    public partial class CreateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idade_cliente = table.Column<int>(type: "int", nullable: false),
                    status_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    id_produto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome_produto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preco_produto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    estoque_produto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.id_produto);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
