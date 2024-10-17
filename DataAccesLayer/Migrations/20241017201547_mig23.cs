using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Writers_WriterID",
                table: "Comment");

            migrationBuilder.DropIndex(
                name: "IX_Comment_WriterID",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Comment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Comment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_WriterID",
                table: "Comment",
                column: "WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Writers_WriterID",
                table: "Comment",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID");
        }
    }
}
