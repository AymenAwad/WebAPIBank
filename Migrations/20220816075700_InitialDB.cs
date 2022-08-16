using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIBank.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kics",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthNo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PackageNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubcBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubcAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubcStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Installments = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OpResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decoder = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kics", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kics");
        }
    }
}
