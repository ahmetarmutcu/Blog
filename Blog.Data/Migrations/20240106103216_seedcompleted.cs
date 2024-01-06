using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    public partial class seedcompleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeleteBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("763c40b8-de23-4afa-bba6-680f2dde4b14"), "Admin Test2", new DateTime(2024, 1, 6, 13, 32, 16, 346, DateTimeKind.Local).AddTicks(5849), null, null, false, null, null, "ASP.NET Core2" },
                    { new Guid("7c8dcd23-143f-4145-ac5d-3d2172e8b876"), "Admin Test", new DateTime(2024, 1, 6, 13, 32, 16, 346, DateTimeKind.Local).AddTicks(5831), null, null, false, null, null, "ASP.NET Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeleteBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("7c8dcd23-143f-4145-ac5d-3d2172e8b876"), "Admin Test", new DateTime(2024, 1, 6, 13, 32, 16, 346, DateTimeKind.Local).AddTicks(5959), null, null, "images/testimage", "jpg", false, null, null },
                    { new Guid("a1c39b5d-05d2-42ce-b23c-b312ec8af679"), "Admin Test", new DateTime(2024, 1, 6, 13, 32, 16, 346, DateTimeKind.Local).AddTicks(5962), null, null, "images/testimage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeleteBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("482cd3ea-f77e-4b7d-bf61-6f353071fae5"), new Guid("763c40b8-de23-4afa-bba6-680f2dde4b14"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2024, 1, 6, 13, 32, 16, 346, DateTimeKind.Local).AddTicks(5629), null, null, new Guid("a1c39b5d-05d2-42ce-b23c-b312ec8af679"), false, null, null, "Visual Studion Deneme Makalesi 1", 15 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeleteBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[] { new Guid("8f0f1374-3f50-484e-bab2-9e15198eff49"), new Guid("7c8dcd23-143f-4145-ac5d-3d2172e8b876"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Admin Test", new DateTime(2024, 1, 6, 13, 32, 16, 346, DateTimeKind.Local).AddTicks(5572), null, null, new Guid("7c8dcd23-143f-4145-ac5d-3d2172e8b876"), false, null, null, "Asp net Core Deneme Makalesi 1", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("482cd3ea-f77e-4b7d-bf61-6f353071fae5"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8f0f1374-3f50-484e-bab2-9e15198eff49"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("763c40b8-de23-4afa-bba6-680f2dde4b14"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7c8dcd23-143f-4145-ac5d-3d2172e8b876"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("7c8dcd23-143f-4145-ac5d-3d2172e8b876"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a1c39b5d-05d2-42ce-b23c-b312ec8af679"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
