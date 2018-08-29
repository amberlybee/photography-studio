using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhotographyStudio.Migrations
{
    public partial class CreatedGallerySessionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GallerySessionId",
                table: "Photos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GallerySessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GalleryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GallerySessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GallerySessions_Galleries_GalleryId",
                        column: x => x.GalleryId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_GallerySessionId",
                table: "Photos",
                column: "GallerySessionId");

            migrationBuilder.CreateIndex(
                name: "IX_GallerySessions_GalleryId",
                table: "GallerySessions",
                column: "GalleryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_GallerySessions_GallerySessionId",
                table: "Photos",
                column: "GallerySessionId",
                principalTable: "GallerySessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_GallerySessions_GallerySessionId",
                table: "Photos");

            migrationBuilder.DropTable(
                name: "GallerySessions");

            migrationBuilder.DropIndex(
                name: "IX_Photos_GallerySessionId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "GallerySessionId",
                table: "Photos");
        }
    }
}
