using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Infosin.OpenAuth.EntityFrameworkCore.Migrations
{
    public partial class AddDict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dicts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DictCode = table.Column<string>(nullable: true),
                    DictDescription = table.Column<string>(nullable: true),
                    DictName = table.Column<string>(nullable: true),
                    IsDel = table.Column<bool>(nullable: false),
                    SortNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dicts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DictDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DictDetailsCode = table.Column<string>(nullable: true),
                    DictDetailsDescription = table.Column<string>(nullable: true),
                    DictDetailsName = table.Column<string>(nullable: true),
                    DictId = table.Column<Guid>(nullable: true),
                    IsDel = table.Column<bool>(nullable: false),
                    SortNum = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DictDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DictDetails_Dicts_DictId",
                        column: x => x.DictId,
                        principalTable: "Dicts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DictDetails_DictId",
                table: "DictDetails",
                column: "DictId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DictDetails");

            migrationBuilder.DropTable(
                name: "Dicts");
        }
    }
}
