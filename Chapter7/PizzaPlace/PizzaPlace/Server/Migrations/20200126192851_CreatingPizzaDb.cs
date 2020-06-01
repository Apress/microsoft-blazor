using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaPlace.Server.Migrations
{
  public partial class CreatingPizzaDb : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "Pizzas",
          columns: table => new
          {
            Id = table.Column<int>(nullable: false)
                  .Annotation("SqlServer:Identity", "1, 1"),
            Name = table.Column<string>(nullable: true),
            Price = table.Column<decimal>(type: "money", nullable: false),
            Spiciness = table.Column<int>(nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Pizzas", x => x.Id);
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Pizzas");
    }
  }
}
