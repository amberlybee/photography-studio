using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PhotographyStudio.Migrations
{
    public partial class AddGalleryPhotoFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GalleryId",
                table: "Photos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_GalleryId",
                table: "Photos",
                column: "GalleryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Galleries_GalleryId",
                table: "Photos",
                column: "GalleryId",
                principalTable: "Galleries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Galleries_GalleryId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_GalleryId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "GalleryId",
                table: "Photos");
        }
    }
}
