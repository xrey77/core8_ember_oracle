using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace core8_ember_oracle.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "C##REY");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "C##REY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    category = table.Column<string>(type: "varchar2(50)", nullable: true),
                    descriptions = table.Column<string>(type: "varchar2(100)", nullable: true),
                    qty = table.Column<short>(type: "number(5)", nullable: false),
                    unit = table.Column<string>(type: "varchar2(10)", nullable: true),
                    costprice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    sellprice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    saleprice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    productpicture = table.Column<string>(type: "varchar2(100)", nullable: true),
                    alertstocks = table.Column<short>(type: "number(5)", nullable: false),
                    criticalstocks = table.Column<short>(type: "number(5)", nullable: false),
                    createdAt = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "SYSDATE"),
                    updatedAt = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "SYSDATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "C##REY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    lastname = table.Column<string>(type: "varchar2(10)", nullable: true),
                    firstname = table.Column<string>(type: "varchar2(10)", nullable: true),
                    username = table.Column<string>(type: "varchar2(10)", nullable: true),
                    password = table.Column<string>(type: "varchar2(100)", nullable: true),
                    email = table.Column<string>(type: "varchar2(100)", nullable: true),
                    mobile = table.Column<string>(type: "varchar2(20)", nullable: true),
                    roles = table.Column<string>(type: "varchar2(10)", nullable: true),
                    isactivated = table.Column<byte>(type: "number(2)", nullable: false),
                    isblocked = table.Column<byte>(type: "number(2)", nullable: false),
                    mailtoken = table.Column<short>(type: "number(5)", nullable: false),
                    qrcodeurl = table.Column<string>(type: "varchar2(900)", nullable: true),
                    profilepic = table.Column<string>(type: "varchar2(100)", nullable: true),
                    secretkey = table.Column<string>(type: "varchar2(900)", nullable: true),
                    createdat = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "SYSDATE"),
                    updatedat = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "SYSDATE")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "C##REY");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "C##REY");
        }
    }
}
