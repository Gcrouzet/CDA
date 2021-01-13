using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Freelancer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    cat_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cat_Nom = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    cat_description = table.Column<string>(type: "Text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.cat_Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    client_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cat_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.client_id);
                });

            migrationBuilder.CreateTable(
                name: "Devis",
                columns: table => new
                {
                    devis_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    devis_etat = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false),
                    devis_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    devis_montant = table.Column<int>(type: "int", nullable: false),
                    devis_date_finale = table.Column<DateTime>(type: "datetime2", nullable: false),
                    devis_montant_final = table.Column<int>(type: "int", nullable: false),
                    mission_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devis", x => x.devis_id);
                });

            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    mission_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mission_etat = table.Column<string>(type: "char(10)", maxLength: 10, nullable: false),
                    mission_titre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    mission_debut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    mission_fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    mission_description = table.Column<string>(type: "text", nullable: true),
                    client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.mission_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Devis");

            migrationBuilder.DropTable(
                name: "Missions");
        }
    }
}
