using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelApp.Migrations
{
    public partial class addnewtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpecRooms_Rooms_RoomId1",
                table: "SpecRooms");

            migrationBuilder.DropIndex(
                name: "IX_SpecRooms_RoomId1",
                table: "SpecRooms");

            migrationBuilder.DropColumn(
                name: "RoomId1",
                table: "SpecRooms");

            migrationBuilder.AlterColumn<int>(
                name: "RoomId",
                table: "SpecRooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_SpecRooms_RoomId",
                table: "SpecRooms",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_SpecRooms_Rooms_RoomId",
                table: "SpecRooms",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SpecRooms_Rooms_RoomId",
                table: "SpecRooms");

            migrationBuilder.DropIndex(
                name: "IX_SpecRooms_RoomId",
                table: "SpecRooms");

            migrationBuilder.AlterColumn<string>(
                name: "RoomId",
                table: "SpecRooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RoomId1",
                table: "SpecRooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SpecRooms_RoomId1",
                table: "SpecRooms",
                column: "RoomId1");

            migrationBuilder.AddForeignKey(
                name: "FK_SpecRooms_Rooms_RoomId1",
                table: "SpecRooms",
                column: "RoomId1",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
