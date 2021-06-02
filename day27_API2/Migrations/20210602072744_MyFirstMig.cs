using Microsoft.EntityFrameworkCore.Migrations;

namespace day27_API2.Migrations
{
    public partial class MyFirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderDetails_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pincode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity_1 = table.Column<int>(type: "int", nullable: false),
                    Quantity_2 = table.Column<int>(type: "int", nullable: false),
                    Quantity_3 = table.Column<int>(type: "int", nullable: false),
                    Crust_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Crust_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Crust_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suggestions_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suggestions_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suggestions_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Additional = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderDetails_ID);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Pizza_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pizza_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Crust = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Toppings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsVeg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Pizza_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
