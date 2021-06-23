using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core.Migrations
{
    public partial class OnetoOneRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_users_UserId",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_users_Customer_CustomerId",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_addresses",
                table: "addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "addresses",
                newName: "Addresses");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_users_CustomerId",
                table: "Users",
                newName: "IX_Users_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_addresses_UserId",
                table: "Addresses",
                newName: "IX_Addresses_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Customers_CustomerId",
                table: "Users",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Customers_CustomerId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "addresses");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CustomerId",
                table: "users",
                newName: "IX_users_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_UserId",
                table: "addresses",
                newName: "IX_addresses_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_addresses",
                table: "addresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_users_UserId",
                table: "addresses",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_users_Customer_CustomerId",
                table: "users",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
