using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsiOffice.FinancialMovimentAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "financial_moviment",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dt_creation = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dt_payment = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    is_expense = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    base_value = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    discounts = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    additions = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    full_value = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_financial_moviment", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "financial_moviment");
        }
    }
}
