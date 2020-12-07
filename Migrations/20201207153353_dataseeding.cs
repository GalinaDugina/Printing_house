using Microsoft.EntityFrameworkCore.Migrations;

namespace PH.Migrations
{
    public partial class dataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "Clients",
                new[] {"Id", "Name"},
                new object[] {1, "Эфес Казахстан"}
            );
            migrationBuilder.InsertData(
                "Clients",
                new[] {"Id", "Name"},
                new object[] {2, "Первый Пивзавод"}
            );
            migrationBuilder.InsertData(
                "Clients",
                new[] {"Id", "Name"},
                new object[] {3, "Каспиан"}
            );
            migrationBuilder.InsertData(
                              "Papers",
                              new[] {"Id", "Name", "Height","Width","Density","Price"},
                              new object[] {1, "этикеточная", 52,72,80,36}
                          );
            migrationBuilder.InsertData(
                "Papers",
                new[] {"Id", "Name", "Height","Width","Density","Price"},
                new object[] {2, "металлизированная", 52,72,69,56}
            );
            migrationBuilder.InsertData(
                "Papers",
                new[] {"Id", "Name", "Height","Width","Density","Price"},
                new object[] {3, "металлизированная", 59,72,69,66}
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                "Clients",
                new[] {"Id", "Name"},
                new object[] {1, "Эфес Казахстан"}
            );
            migrationBuilder.DeleteData(
                "Clients",
                new[] {"Id", "Name"},
                new object[] {2, "Первый Пивзавод"}
            );
            migrationBuilder.DeleteData(
                "Clients",
                new[] {"Id", "Name"},
                new object[] {3, "Каспиан"}
            ); 
            migrationBuilder.DeleteData(
                "Papers",
                new[] {"Id", "Name", "Height","Width","Density","Price"},
                new object[] {1, "этикеточная", 52,72,80,36}
            ); 
            migrationBuilder.DeleteData(
                "Papers",
                new[] {"Id", "Name", "Height","Width","Density","Price"},
                new object[] {2, "металлизированная", 52,72,69,56}
            ); 
            migrationBuilder.DeleteData(
                "Papers",
                new[] {"Id", "Name", "Height","Width","Density","Price"},
                new object[] {3, "металлизированная", 59,72,69,66}
            ); 
        }
    }
}
