using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SHeDSchedule.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    staffId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ATC = table.Column<bool>(nullable: false),
                    initials = table.Column<string>(nullable: true),
                    term = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.staffId);
                });

            migrationBuilder.CreateTable(
                name: "Friday",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    eight = table.Column<char>(nullable: false),
                    eightthirty = table.Column<char>(nullable: false),
                    eleven = table.Column<char>(nullable: false),
                    eleventhirty = table.Column<char>(nullable: false),
                    five = table.Column<char>(nullable: false),
                    fivethirty = table.Column<char>(nullable: false),
                    four = table.Column<char>(nullable: false),
                    fourthirty = table.Column<char>(nullable: false),
                    nine = table.Column<char>(nullable: false),
                    ninethirty = table.Column<char>(nullable: false),
                    one = table.Column<char>(nullable: false),
                    onethirty = table.Column<char>(nullable: false),
                    seventhirty = table.Column<char>(nullable: false),
                    six = table.Column<char>(nullable: false),
                    sixthirty = table.Column<char>(nullable: false),
                    staffId = table.Column<int>(nullable: false),
                    ten = table.Column<char>(nullable: false),
                    tenthirty = table.Column<char>(nullable: false),
                    three = table.Column<char>(nullable: false),
                    threethirty = table.Column<char>(nullable: false),
                    twelve = table.Column<char>(nullable: false),
                    twelvethirty = table.Column<char>(nullable: false),
                    two = table.Column<char>(nullable: false),
                    twothirty = table.Column<char>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friday", x => x.id);
                    table.ForeignKey(
                        name: "FK_Friday_Staff_staffId",
                        column: x => x.staffId,
                        principalTable: "Staff",
                        principalColumn: "staffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monday",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    eight = table.Column<char>(nullable: false),
                    eightthirty = table.Column<char>(nullable: false),
                    eleven = table.Column<char>(nullable: false),
                    eleventhirty = table.Column<char>(nullable: false),
                    five = table.Column<char>(nullable: false),
                    fivethirty = table.Column<char>(nullable: false),
                    four = table.Column<char>(nullable: false),
                    fourthirty = table.Column<char>(nullable: false),
                    nine = table.Column<char>(nullable: false),
                    ninethirty = table.Column<char>(nullable: false),
                    one = table.Column<char>(nullable: false),
                    onethirty = table.Column<char>(nullable: false),
                    seventhirty = table.Column<char>(nullable: false),
                    six = table.Column<char>(nullable: false),
                    sixthirty = table.Column<char>(nullable: false),
                    staffId = table.Column<int>(nullable: false),
                    ten = table.Column<char>(nullable: false),
                    tenthirty = table.Column<char>(nullable: false),
                    three = table.Column<char>(nullable: false),
                    threethirty = table.Column<char>(nullable: false),
                    twelve = table.Column<char>(nullable: false),
                    twelvethirty = table.Column<char>(nullable: false),
                    two = table.Column<char>(nullable: false),
                    twothirty = table.Column<char>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monday", x => x.id);
                    table.ForeignKey(
                        name: "FK_Monday_Staff_staffId",
                        column: x => x.staffId,
                        principalTable: "Staff",
                        principalColumn: "staffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thursday",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    eight = table.Column<char>(nullable: false),
                    eightthirty = table.Column<char>(nullable: false),
                    eleven = table.Column<char>(nullable: false),
                    eleventhirty = table.Column<char>(nullable: false),
                    five = table.Column<char>(nullable: false),
                    fivethirty = table.Column<char>(nullable: false),
                    four = table.Column<char>(nullable: false),
                    fourthirty = table.Column<char>(nullable: false),
                    nine = table.Column<char>(nullable: false),
                    ninethirty = table.Column<char>(nullable: false),
                    one = table.Column<char>(nullable: false),
                    onethirty = table.Column<char>(nullable: false),
                    seventhirty = table.Column<char>(nullable: false),
                    six = table.Column<char>(nullable: false),
                    sixthirty = table.Column<char>(nullable: false),
                    staffId = table.Column<int>(nullable: false),
                    ten = table.Column<char>(nullable: false),
                    tenthirty = table.Column<char>(nullable: false),
                    three = table.Column<char>(nullable: false),
                    threethirty = table.Column<char>(nullable: false),
                    twelve = table.Column<char>(nullable: false),
                    twelvethirty = table.Column<char>(nullable: false),
                    two = table.Column<char>(nullable: false),
                    twothirty = table.Column<char>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thursday", x => x.id);
                    table.ForeignKey(
                        name: "FK_Thursday_Staff_staffId",
                        column: x => x.staffId,
                        principalTable: "Staff",
                        principalColumn: "staffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tuesday",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    eight = table.Column<char>(nullable: false),
                    eightthirty = table.Column<char>(nullable: false),
                    eleven = table.Column<char>(nullable: false),
                    eleventhirty = table.Column<char>(nullable: false),
                    five = table.Column<char>(nullable: false),
                    fivethirty = table.Column<char>(nullable: false),
                    four = table.Column<char>(nullable: false),
                    fourthirty = table.Column<char>(nullable: false),
                    nine = table.Column<char>(nullable: false),
                    ninethirty = table.Column<char>(nullable: false),
                    one = table.Column<char>(nullable: false),
                    onethirty = table.Column<char>(nullable: false),
                    seventhirty = table.Column<char>(nullable: false),
                    six = table.Column<char>(nullable: false),
                    sixthirty = table.Column<char>(nullable: false),
                    staffId = table.Column<int>(nullable: false),
                    ten = table.Column<char>(nullable: false),
                    tenthirty = table.Column<char>(nullable: false),
                    three = table.Column<char>(nullable: false),
                    threethirty = table.Column<char>(nullable: false),
                    twelve = table.Column<char>(nullable: false),
                    twelvethirty = table.Column<char>(nullable: false),
                    two = table.Column<char>(nullable: false),
                    twothirty = table.Column<char>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tuesday", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tuesday_Staff_staffId",
                        column: x => x.staffId,
                        principalTable: "Staff",
                        principalColumn: "staffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wednesday",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    eight = table.Column<char>(nullable: false),
                    eightthirty = table.Column<char>(nullable: false),
                    eleven = table.Column<char>(nullable: false),
                    eleventhirty = table.Column<char>(nullable: false),
                    five = table.Column<char>(nullable: false),
                    fivethirty = table.Column<char>(nullable: false),
                    four = table.Column<char>(nullable: false),
                    fourthirty = table.Column<char>(nullable: false),
                    nine = table.Column<char>(nullable: false),
                    ninethirty = table.Column<char>(nullable: false),
                    one = table.Column<char>(nullable: false),
                    onethirty = table.Column<char>(nullable: false),
                    seventhirty = table.Column<char>(nullable: false),
                    six = table.Column<char>(nullable: false),
                    sixthirty = table.Column<char>(nullable: false),
                    staffId = table.Column<int>(nullable: false),
                    ten = table.Column<char>(nullable: false),
                    tenthirty = table.Column<char>(nullable: false),
                    three = table.Column<char>(nullable: false),
                    threethirty = table.Column<char>(nullable: false),
                    twelve = table.Column<char>(nullable: false),
                    twelvethirty = table.Column<char>(nullable: false),
                    two = table.Column<char>(nullable: false),
                    twothirty = table.Column<char>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wednesday", x => x.id);
                    table.ForeignKey(
                        name: "FK_Wednesday_Staff_staffId",
                        column: x => x.staffId,
                        principalTable: "Staff",
                        principalColumn: "staffId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friday_staffId",
                table: "Friday",
                column: "staffId");

            migrationBuilder.CreateIndex(
                name: "IX_Monday_staffId",
                table: "Monday",
                column: "staffId");

            migrationBuilder.CreateIndex(
                name: "IX_Thursday_staffId",
                table: "Thursday",
                column: "staffId");

            migrationBuilder.CreateIndex(
                name: "IX_Tuesday_staffId",
                table: "Tuesday",
                column: "staffId");

            migrationBuilder.CreateIndex(
                name: "IX_Wednesday_staffId",
                table: "Wednesday",
                column: "staffId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friday");

            migrationBuilder.DropTable(
                name: "Monday");

            migrationBuilder.DropTable(
                name: "Thursday");

            migrationBuilder.DropTable(
                name: "Tuesday");

            migrationBuilder.DropTable(
                name: "Wednesday");

            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
