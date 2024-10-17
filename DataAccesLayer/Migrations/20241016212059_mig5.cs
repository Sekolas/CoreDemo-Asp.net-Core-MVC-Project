using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WriterName",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "WriterName",
                table: "Writers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
