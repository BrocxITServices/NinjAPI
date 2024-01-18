using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NinjAPI.Migrations
{
    /// <inheritdoc />
    public partial class ManyToOnev2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ninjas",
                columns: table => new
                {
                    NinjaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Specialization = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ninjas", x => x.NinjaId);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    TrainingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Title = table.Column<int>(type: "int", nullable: false),
                    Trainer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NinjaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.TrainingId);
                    table.ForeignKey(
                        name: "FK_Trainings_Ninjas_NinjaId",
                        column: x => x.NinjaId,
                        principalTable: "Ninjas",
                        principalColumn: "NinjaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_NinjaId",
                table: "Trainings",
                column: "NinjaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Ninjas");
        }
    }
}
