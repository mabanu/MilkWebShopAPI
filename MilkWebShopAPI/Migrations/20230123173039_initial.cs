using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilkWebShopAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MilkProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Type = table.Column<string>(type: "longtext", nullable: false),
                    Storage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilkProducts", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "MilkProducts",
                columns: new[] { "Id", "Name", "Storage", "Type" },
                values: new object[] { new Guid("1277e861-b33b-485d-b86f-400769d25a82"), "Monet's powerful cashew milk", 27, "Cashew milk" });

            migrationBuilder.InsertData(
                table: "MilkProducts",
                columns: new[] { "Id", "Name", "Storage", "Type" },
                values: new object[] { new Guid("210aeed2-413b-4e53-98e7-62c9f6fd31ba"), "Julianne's relevant pea milk", 33, "Pea milk" });

            migrationBuilder.InsertData(
                table: "MilkProducts",
                columns: new[] { "Id", "Name", "Storage", "Type" },
                values: new object[] { new Guid("301d5dcf-a2a8-4a34-b26b-efcaa103963c"), "Dillion's unequaled cashew milk", 99, "Cashew milk" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MilkProducts");
        }
    }
}
