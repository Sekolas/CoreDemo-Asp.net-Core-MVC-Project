using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class sgfdg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            

            migrationBuilder.CreateTable(
                name: "Mesajlar",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<int>(type: "int", nullable: true),
                    ReceiverId = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajlar", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Mesajlar_Writers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Writers",
                        principalColumn: "WriterID");
                    table.ForeignKey(
                        name: "FK_Mesajlar_Writers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Writers",
                        principalColumn: "WriterID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mesajlar_ReceiverId",
                table: "Mesajlar",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Mesajlar_SenderId",
                table: "Mesajlar",
                column: "SenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                });

            migrationBuilder.CreateTable(
                name: "Messages2",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiverId = table.Column<int>(type: "int", nullable: true),
                    SenderId = table.Column<int>(type: "int", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages2", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Messages2_Writers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "Writers",
                        principalColumn: "WriterID");
                    table.ForeignKey(
                        name: "FK_Messages2_Writers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Writers",
                        principalColumn: "WriterID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_ReceiverId",
                table: "Messages2",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages2_SenderId",
                table: "Messages2",
                column: "SenderId");
        }
    }
}
