using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication3.Data.Migrations
{
    public partial class SeedColumnNumberAvailableInMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string sql = ("UPDATE Movies Set NumberAvailable = NumberInStock");
                
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
