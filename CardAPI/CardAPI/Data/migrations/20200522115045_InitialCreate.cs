﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CardAPI.Data.migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    CardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageRef = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Military1 = table.Column<int>(nullable: false),
                    Military2 = table.Column<int>(nullable: false),
                    Happiness1 = table.Column<int>(nullable: false),
                    Happiness2 = table.Column<int>(nullable: false),
                    Economy1 = table.Column<int>(nullable: false),
                    Economy2 = table.Column<int>(nullable: false),
                    Relations1 = table.Column<int>(nullable: false),
                    Relations2 = table.Column<int>(nullable: false),
                    CharacterID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.CardID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");
        }
    }
}
