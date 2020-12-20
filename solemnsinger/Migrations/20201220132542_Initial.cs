using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace solemnsinger.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LineAddress1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LineAddress2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SongSingers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongSingers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllDay = table.Column<bool>(type: "bit", nullable: false),
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    CategorySuggestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendars_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Calendars_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SongSingerId = table.Column<long>(type: "bigint", nullable: false),
                    Part = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_SongSingers_SongSingerId",
                        column: x => x.SongSingerId,
                        principalTable: "SongSingers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RuleTerm",
                columns: table => new
                {
                    RulesId = table.Column<long>(type: "bigint", nullable: false),
                    TermsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuleTerm", x => new { x.RulesId, x.TermsId });
                    table.ForeignKey(
                        name: "FK_RuleTerm_Rules_RulesId",
                        column: x => x.RulesId,
                        principalTable: "Rules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RuleTerm_Terms_TermsId",
                        column: x => x.TermsId,
                        principalTable: "Terms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccessLevels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Create = table.Column<bool>(type: "bit", nullable: false),
                    Read = table.Column<bool>(type: "bit", nullable: false),
                    Update = table.Column<bool>(type: "bit", nullable: false),
                    Delete = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessLevels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccessLevels_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    TermId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    PrintableContract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DigitalContract = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastTimeModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => new { x.LocationId, x.TermId });
                    table.ForeignKey(
                        name: "FK_Contracts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_Terms_TermId",
                        column: x => x.TermId,
                        principalTable: "Terms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Modifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    AccessLevelId = table.Column<long>(type: "bigint", nullable: true),
                    CalendarId = table.Column<long>(type: "bigint", nullable: true),
                    CategoryId = table.Column<long>(type: "bigint", nullable: true),
                    ContractLocationId = table.Column<long>(type: "bigint", nullable: true),
                    ContractTermId = table.Column<long>(type: "bigint", nullable: true),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true),
                    LocationId = table.Column<long>(type: "bigint", nullable: true),
                    RuleId = table.Column<long>(type: "bigint", nullable: true),
                    SongId = table.Column<long>(type: "bigint", nullable: true),
                    SongSingerId = table.Column<long>(type: "bigint", nullable: true),
                    TermId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modifications_AccessLevels_AccessLevelId",
                        column: x => x.AccessLevelId,
                        principalTable: "AccessLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modifications_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modifications_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modifications_Contracts_ContractLocationId_ContractTermId",
                        columns: x => new { x.ContractLocationId, x.ContractTermId },
                        principalTable: "Contracts",
                        principalColumns: new[] { "LocationId", "TermId" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modifications_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modifications_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modifications_Rules_RuleId",
                        column: x => x.RuleId,
                        principalTable: "Rules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modifications_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modifications_SongSingers_SongSingerId",
                        column: x => x.SongSingerId,
                        principalTable: "SongSingers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modifications_Terms_TermId",
                        column: x => x.TermId,
                        principalTable: "Terms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Modifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AccessLevelModifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessLevelId = table.Column<long>(type: "bigint", nullable: false),
                    ModificationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessLevelModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccessLevelModifications_AccessLevels_AccessLevelId",
                        column: x => x.AccessLevelId,
                        principalTable: "AccessLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AccessLevelModifications_Modifications_ModificationId",
                        column: x => x.ModificationId,
                        principalTable: "Modifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalendarModifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalendarId = table.Column<long>(type: "bigint", nullable: false),
                    ModificationId = table.Column<long>(type: "bigint", nullable: true),
                    ModidicantionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalendarModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CalendarModifications_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalendarModifications_Modifications_ModificationId",
                        column: x => x.ModificationId,
                        principalTable: "Modifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategoryModifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    ModificationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryModifications_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryModifications_Modifications_ModificationId",
                        column: x => x.ModificationId,
                        principalTable: "Modifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractModifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractLocationId = table.Column<long>(type: "bigint", nullable: false),
                    ContractTermId = table.Column<long>(type: "bigint", nullable: false),
                    ContractId = table.Column<long>(type: "bigint", nullable: false),
                    ModificationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractModifications_Contracts_ContractLocationId_ContractTermId",
                        columns: x => new { x.ContractLocationId, x.ContractTermId },
                        principalTable: "Contracts",
                        principalColumns: new[] { "LocationId", "TermId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractModifications_Modifications_ModificationId",
                        column: x => x.ModificationId,
                        principalTable: "Modifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerModifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false),
                    ModificationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerModifications_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerModifications_Modifications_ModificationId",
                        column: x => x.ModificationId,
                        principalTable: "Modifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocationModifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    ModificationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationModifications_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LocationModifications_Modifications_ModificationId",
                        column: x => x.ModificationId,
                        principalTable: "Modifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RuleModifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuleId = table.Column<long>(type: "bigint", nullable: false),
                    ModificationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RuleModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RuleModifications_Modifications_ModificationId",
                        column: x => x.ModificationId,
                        principalTable: "Modifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RuleModifications_Rules_RuleId",
                        column: x => x.RuleId,
                        principalTable: "Rules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SongModifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongId = table.Column<long>(type: "bigint", nullable: false),
                    ModificationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SongModifications_Modifications_ModificationId",
                        column: x => x.ModificationId,
                        principalTable: "Modifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SongModifications_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SongSingerModifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SongSingerId = table.Column<long>(type: "bigint", nullable: false),
                    ModificationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongSingerModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SongSingerModifications_Modifications_ModificationId",
                        column: x => x.ModificationId,
                        principalTable: "Modifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SongSingerModifications_SongSingers_SongSingerId",
                        column: x => x.SongSingerId,
                        principalTable: "SongSingers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TermModifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModificationId = table.Column<long>(type: "bigint", nullable: true),
                    TermId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TermModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TermModifications_Modifications_ModificationId",
                        column: x => x.ModificationId,
                        principalTable: "Modifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TermModifications_Terms_TermId",
                        column: x => x.TermId,
                        principalTable: "Terms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserModifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ModificationId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserModifications_Modifications_ModificationId",
                        column: x => x.ModificationId,
                        principalTable: "Modifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserModifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccessLevelModifications_AccessLevelId",
                table: "AccessLevelModifications",
                column: "AccessLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessLevelModifications_ModificationId",
                table: "AccessLevelModifications",
                column: "ModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessLevels_UserId",
                table: "AccessLevels",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CalendarModifications_CalendarId",
                table: "CalendarModifications",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_CalendarModifications_ModificationId",
                table: "CalendarModifications",
                column: "ModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_CategoryId",
                table: "Calendars",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_LocationId",
                table: "Calendars",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryModifications_CategoryId",
                table: "CategoryModifications",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryModifications_ModificationId",
                table: "CategoryModifications",
                column: "ModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractModifications_ContractLocationId_ContractTermId",
                table: "ContractModifications",
                columns: new[] { "ContractLocationId", "ContractTermId" });

            migrationBuilder.CreateIndex(
                name: "IX_ContractModifications_ModificationId",
                table: "ContractModifications",
                column: "ModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_CustomerId",
                table: "Contracts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_LocationId",
                table: "Contracts",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_TermId",
                table: "Contracts",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerModifications_CustomerId",
                table: "CustomerModifications",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerModifications_ModificationId",
                table: "CustomerModifications",
                column: "ModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_LocationId",
                table: "Customers",
                column: "LocationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LocationModifications_LocationId",
                table: "LocationModifications",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationModifications_ModificationId",
                table: "LocationModifications",
                column: "ModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Modifications_AccessLevelId",
                table: "Modifications",
                column: "AccessLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Modifications_CalendarId",
                table: "Modifications",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Modifications_CategoryId",
                table: "Modifications",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Modifications_ContractLocationId_ContractTermId",
                table: "Modifications",
                columns: new[] { "ContractLocationId", "ContractTermId" });

            migrationBuilder.CreateIndex(
                name: "IX_Modifications_CustomerId",
                table: "Modifications",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Modifications_LocationId",
                table: "Modifications",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Modifications_RuleId",
                table: "Modifications",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_Modifications_SongId",
                table: "Modifications",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Modifications_SongSingerId",
                table: "Modifications",
                column: "SongSingerId");

            migrationBuilder.CreateIndex(
                name: "IX_Modifications_TermId",
                table: "Modifications",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_Modifications_UserId",
                table: "Modifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RuleModifications_ModificationId",
                table: "RuleModifications",
                column: "ModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_RuleModifications_RuleId",
                table: "RuleModifications",
                column: "RuleId");

            migrationBuilder.CreateIndex(
                name: "IX_RuleTerm_TermsId",
                table: "RuleTerm",
                column: "TermsId");

            migrationBuilder.CreateIndex(
                name: "IX_SongModifications_ModificationId",
                table: "SongModifications",
                column: "ModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_SongModifications_SongId",
                table: "SongModifications",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_SongSingerId",
                table: "Songs",
                column: "SongSingerId");

            migrationBuilder.CreateIndex(
                name: "IX_SongSingerModifications_ModificationId",
                table: "SongSingerModifications",
                column: "ModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_SongSingerModifications_SongSingerId",
                table: "SongSingerModifications",
                column: "SongSingerId");

            migrationBuilder.CreateIndex(
                name: "IX_TermModifications_ModificationId",
                table: "TermModifications",
                column: "ModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_TermModifications_TermId",
                table: "TermModifications",
                column: "TermId");

            migrationBuilder.CreateIndex(
                name: "IX_UserModifications_ModificationId",
                table: "UserModifications",
                column: "ModificationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserModifications_UserId",
                table: "UserModifications",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessLevelModifications");

            migrationBuilder.DropTable(
                name: "CalendarModifications");

            migrationBuilder.DropTable(
                name: "CategoryModifications");

            migrationBuilder.DropTable(
                name: "ContractModifications");

            migrationBuilder.DropTable(
                name: "CustomerModifications");

            migrationBuilder.DropTable(
                name: "LocationModifications");

            migrationBuilder.DropTable(
                name: "RuleModifications");

            migrationBuilder.DropTable(
                name: "RuleTerm");

            migrationBuilder.DropTable(
                name: "SongModifications");

            migrationBuilder.DropTable(
                name: "SongSingerModifications");

            migrationBuilder.DropTable(
                name: "TermModifications");

            migrationBuilder.DropTable(
                name: "UserModifications");

            migrationBuilder.DropTable(
                name: "Modifications");

            migrationBuilder.DropTable(
                name: "AccessLevels");

            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropTable(
                name: "SongSingers");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
