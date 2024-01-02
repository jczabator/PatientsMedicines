using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PatientsMedicines.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAndGroupChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineGroups_Medicines_MedicineId",
                table: "MedicineGroups");

            migrationBuilder.DropColumn(
                name: "GroupType",
                table: "Groups");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Patients",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineId",
                table: "MedicineGroups",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "GroupType",
                table: "MedicineGroups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "A" },
                    { 2, "B" }
                });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Description", "ExpiryDate", "Name", "SerialNumber" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus rutrum nisi quis interdum tincidunt. \r\n                Suspendisse venenatis diam eu dui pulvinar, vel auctor felis aliquam. Quisque bibendum velit consectetur tellus suscipit, \r\n                sit amet accumsan enim sagittis. Vestibulum sit amet diam et orci pulvinar interdum. Nulla ac nulla a ligula euismod accumsan. \r\n                In ac turpis eu eros hendrerit sagittis. Aliquam erat volutpat. Aliquam blandit pretium congue.", new DateOnly(2024, 1, 2), "Pfumoflux", "ASD1234QWER" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "BMI", "BirthDate", "FirstName", "Gender", "Height", "LastName", "SocialNumber", "Weight" },
                values: new object[,]
                {
                    { 1, 45, 27m, new DateOnly(1979, 1, 2), "Jan", 1, 175m, "Kowalski", "72033075515", 80m },
                    { 2, 47, 30m, new DateOnly(1977, 1, 2), "Janina", 0, 155m, "Kowalska", "72033075515", 70m }
                });

            migrationBuilder.InsertData(
                table: "MedicineGroups",
                columns: new[] { "Id", "GroupId", "GroupType", "MedicineId" },
                values: new object[,]
                {
                    { 1, 1, 0, 1 },
                    { 2, 2, 1, null }
                });

            migrationBuilder.InsertData(
                table: "PatientMedicineGroups",
                columns: new[] { "Id", "MedicineGroupId", "PatientId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineGroups_Medicines_MedicineId",
                table: "MedicineGroups",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicineGroups_Medicines_MedicineId",
                table: "MedicineGroups");

            migrationBuilder.DeleteData(
                table: "PatientMedicineGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PatientMedicineGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MedicineGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MedicineGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "GroupType",
                table: "MedicineGroups");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineId",
                table: "MedicineGroups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupType",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicineGroups_Medicines_MedicineId",
                table: "MedicineGroups",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
