using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalMVC.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Dateformation",
                table: "Formation",
                type: "datetime(6)",
                maxLength: 128,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Lieu",
                table: "Formation",
                type: "varchar(128)",
                maxLength: 128,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "sectionID",
                table: "Formation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Apprenant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomComplet = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telephone = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apprenant", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Section",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titre = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThumbnailPath = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Section", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Visiteur",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IPaddress = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Datevisite = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visiteur", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Preinscription",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    datepreinscription = table.Column<DateTime>(type: "datetime(6)", maxLength: 128, nullable: false),
                    apprenantID = table.Column<int>(type: "int", nullable: false),
                    formationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preinscription", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Preinscription_Apprenant_apprenantID",
                        column: x => x.apprenantID,
                        principalTable: "Apprenant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Preinscription_Formation_formationID",
                        column: x => x.formationID,
                        principalTable: "Formation",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Filiere",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titre = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sectionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filiere", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Filiere_Section_sectionID",
                        column: x => x.sectionID,
                        principalTable: "Section",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Matiere",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Titre = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    filiereID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matiere", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Matiere_Filiere_filiereID",
                        column: x => x.filiereID,
                        principalTable: "Filiere",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Formation_sectionID",
                table: "Formation",
                column: "sectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Filiere_sectionID",
                table: "Filiere",
                column: "sectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Matiere_filiereID",
                table: "Matiere",
                column: "filiereID");

            migrationBuilder.CreateIndex(
                name: "IX_Preinscription_apprenantID",
                table: "Preinscription",
                column: "apprenantID");

            migrationBuilder.CreateIndex(
                name: "IX_Preinscription_formationID",
                table: "Preinscription",
                column: "formationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Formation_Section_sectionID",
                table: "Formation",
                column: "sectionID",
                principalTable: "Section",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Formation_Section_sectionID",
                table: "Formation");

            migrationBuilder.DropTable(
                name: "Matiere");

            migrationBuilder.DropTable(
                name: "Preinscription");

            migrationBuilder.DropTable(
                name: "Visiteur");

            migrationBuilder.DropTable(
                name: "Filiere");

            migrationBuilder.DropTable(
                name: "Apprenant");

            migrationBuilder.DropTable(
                name: "Section");

            migrationBuilder.DropIndex(
                name: "IX_Formation_sectionID",
                table: "Formation");

            migrationBuilder.DropColumn(
                name: "Dateformation",
                table: "Formation");

            migrationBuilder.DropColumn(
                name: "Lieu",
                table: "Formation");

            migrationBuilder.DropColumn(
                name: "sectionID",
                table: "Formation");
        }
    }
}
