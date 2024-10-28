using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealFit.Migrations
{
    /// <inheritdoc />
    public partial class correcao2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "VitaminD",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "VitaminC",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "VitaminA",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "TransFat",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "Sugar",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "Sodium",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "SaturatedFat",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "Protein",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "Potassium",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "PolyunsaturatedFat",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "MonounsaturatedFat",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "Iron",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "Fiber",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "Fat",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "Cholesterol",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "Carbohydrate",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "Calories",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "Calcium",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<double>(
                name: "AddedSugars",
                table: "Consumo",
                type: "double",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldMaxLength: 8);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminD",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminC",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "VitaminA",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "TransFat",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Sugar",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Sodium",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "SaturatedFat",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Protein",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Potassium",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "PolyunsaturatedFat",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "MonounsaturatedFat",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Iron",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Fiber",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Fat",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Cholesterol",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Carbohydrate",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Calories",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "Calcium",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<decimal>(
                name: "AddedSugars",
                table: "Consumo",
                type: "decimal(65,30)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double",
                oldMaxLength: 8);
        }
    }
}
