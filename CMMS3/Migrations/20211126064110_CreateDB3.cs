using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMMS3.Migrations
{
    public partial class CreateDB3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompnayIndex = table.Column<byte>(type: "tinyint", nullable: false),
                    CompanyTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublicTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepairMens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepairmanFullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RepairManStatus = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairMens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitOfMeasurements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitOfMeasurements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Applicants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CompanyIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applicants_Companies_CompanyIdFk",
                        column: x => x.CompanyIdFk,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LimetedCompany = table.Column<bool>(type: "bit", nullable: false),
                    CompanyIdFk = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companies_CompanyIdFk",
                        column: x => x.CompanyIdFk,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyIdFk = table.Column<int>(type: "int", nullable: false),
                    GroupIndex = table.Column<byte>(type: "tinyint", nullable: false),
                    GroupTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Companies_CompanyIdFk",
                        column: x => x.CompanyIdFk,
                        principalTable: "Companies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyIdFk = table.Column<int>(type: "int", nullable: false),
                    GroupIdFk = table.Column<int>(type: "int", nullable: false),
                    SubGroupIndex = table.Column<byte>(type: "tinyint", nullable: false),
                    SubGroupTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubGroups_Companies_CompanyIdFk",
                        column: x => x.CompanyIdFk,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubGroups_Groups_GroupIdFk",
                        column: x => x.GroupIdFk,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IdentityCodes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyIdFk = table.Column<int>(type: "int", nullable: false),
                    GroupIdFk = table.Column<int>(type: "int", nullable: false),
                    SubGroupIdFk = table.Column<int>(type: "int", nullable: false),
                    UserIdFk = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CodeIndex = table.Column<short>(type: "smallint", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    CodeTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityCodes_AspNetUsers_UserIdFk",
                        column: x => x.UserIdFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IdentityCodes_Companies_CompanyIdFk",
                        column: x => x.CompanyIdFk,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IdentityCodes_Groups_GroupIdFk",
                        column: x => x.GroupIdFk,
                        principalTable: "Groups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IdentityCodes_SubGroups_SubGroupIdFk",
                        column: x => x.SubGroupIdFk,
                        principalTable: "SubGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Machineries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    IdentityCodeIdFk = table.Column<long>(type: "bigint", nullable: false),
                    ApplicantIdFk = table.Column<int>(type: "int", nullable: false),
                    MachineryTitle = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machineries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Machineries_Applicants_ApplicantIdFk",
                        column: x => x.ApplicantIdFk,
                        principalTable: "Applicants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Machineries_IdentityCodes_IdentityCodeIdFk",
                        column: x => x.IdentityCodeIdFk,
                        principalTable: "IdentityCodes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IdentityMachineries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachinerIdFk = table.Column<int>(type: "int", nullable: false),
                    TypeDevice = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DateTimeImport = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateTimeStart = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateStartWaranty = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateEndWaranty = table.Column<DateTime>(type: "datetime", nullable: false),
                    Calibration = table.Column<bool>(type: "bit", nullable: false),
                    NewDivice = table.Column<bool>(type: "bit", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Wight = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Countery = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CompanyTel = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CompanyFax = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SupplyName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SupplyAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SupplyTel = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    SupplyFax = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CalibrationCompany = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CalibrationAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CalibrationTel = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CalibrationFax = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityMachineries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentityMachineries_Machineries_MachinerIdFk",
                        column: x => x.MachinerIdFk,
                        principalTable: "Machineries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PowerElectricalMachineries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineryIdFk = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Manifactor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Kw = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Rpm = table.Column<int>(type: "int", nullable: false),
                    Voltag = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Amper = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerElectricalMachineries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PowerElectricalMachineries_Machineries_MachineryIdFk",
                        column: x => x.MachineryIdFk,
                        principalTable: "Machineries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestRepairs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsRepairOut = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsClose = table.Column<bool>(type: "bit", nullable: false),
                    Em = table.Column<bool>(type: "bit", nullable: false),
                    CompanyIdFk = table.Column<int>(type: "int", nullable: false),
                    MachineryIdFk = table.Column<int>(type: "int", nullable: false),
                    UserIdFk = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RequestDataTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    PublicTypeIdFk = table.Column<int>(type: "int", nullable: false),
                    ApplicantIdFk = table.Column<int>(type: "int", nullable: false),
                    RequestTitle = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestRepairs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestRepairs_Applicants_ApplicantIdFk",
                        column: x => x.ApplicantIdFk,
                        principalTable: "Applicants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestRepairs_AspNetUsers_UserIdFk",
                        column: x => x.UserIdFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestRepairs_Companies_CompanyIdFk",
                        column: x => x.CompanyIdFk,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestRepairs_Machineries_MachineryIdFk",
                        column: x => x.MachineryIdFk,
                        principalTable: "Machineries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RequestRepairs_PublicTypes_PublicTypeIdFk",
                        column: x => x.PublicTypeIdFk,
                        principalTable: "PublicTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ServicePeriodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineryIdFk = table.Column<int>(type: "int", nullable: false),
                    ServiceTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Periode = table.Column<int>(type: "int", nullable: false),
                    UnitIdFk = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Registred = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicePeriodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicePeriodes_Machineries_MachineryIdFk",
                        column: x => x.MachineryIdFk,
                        principalTable: "Machineries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServicePeriodes_UnitOfMeasurements_UnitIdFk",
                        column: x => x.UnitIdFk,
                        principalTable: "UnitOfMeasurements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SpareParts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineryIdFk = table.Column<int>(type: "int", nullable: false),
                    SparePartTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SparePartNumber = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Minimal = table.Column<int>(type: "int", nullable: false),
                    UnitIdFk = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpareParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpareParts_Machineries_MachineryIdFk",
                        column: x => x.MachineryIdFk,
                        principalTable: "Machineries",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SpareParts_UnitOfMeasurements_UnitIdFk",
                        column: x => x.UnitIdFk,
                        principalTable: "UnitOfMeasurements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConsumableParts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestIdFk = table.Column<long>(type: "bigint", nullable: false),
                    ConsumablePartTitel = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    UnitIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumableParts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsumableParts_RequestRepairs_RequestIdFk",
                        column: x => x.RequestIdFk,
                        principalTable: "RequestRepairs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConsumableParts_UnitOfMeasurements_UnitIdFk",
                        column: x => x.UnitIdFk,
                        principalTable: "UnitOfMeasurements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Repairouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyIdFk = table.Column<int>(type: "int", nullable: false),
                    UserIdFk = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RequestIdFk = table.Column<long>(type: "bigint", nullable: false),
                    RequestRepairOut = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Regidtered = table.Column<DateTime>(type: "datetime", nullable: false),
                    RepairOutFullName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RepairReportOut = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BackendRequest = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsClosed = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repairouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Repairouts_AspNetUsers_UserIdFk",
                        column: x => x.UserIdFk,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Repairouts_RequestRepairs_RequestIdFk",
                        column: x => x.RequestIdFk,
                        principalTable: "RequestRepairs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WorkOrders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    RequestIdFk = table.Column<long>(type: "bigint", nullable: false),
                    WorkingTotalMin = table.Column<int>(type: "int", nullable: false),
                    StopTotalMin = table.Column<int>(type: "int", nullable: false),
                    RepairOutside = table.Column<bool>(type: "bit", nullable: false),
                    RepairOutSideReportIdFk = table.Column<int>(type: "int", nullable: true),
                    StartWorking = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndWorking = table.Column<DateTime>(type: "datetime", nullable: false),
                    CauseExhaustion = table.Column<bool>(type: "bit", nullable: false),
                    CauseOperatorNegligence = table.Column<bool>(type: "bit", nullable: false),
                    CauseQualityofSpareParts = table.Column<bool>(type: "bit", nullable: false),
                    OtherError = table.Column<bool>(type: "bit", nullable: false),
                    OtherErrorDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ReportRepair = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: false),
                    PersonHours = table.Column<bool>(type: "bit", nullable: false),
                    PersonHoursTime = table.Column<short>(type: "smallint", nullable: true),
                    PersonHoursDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ProductionPlanning = table.Column<bool>(type: "bit", nullable: false),
                    ProductionPlanningTime = table.Column<short>(type: "smallint", nullable: true),
                    ProductionPlanningDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NoSpareParts = table.Column<bool>(type: "bit", nullable: false),
                    NoSparePartsTime = table.Column<short>(type: "smallint", nullable: true),
                    NoSparePartsDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Other = table.Column<bool>(type: "bit", nullable: false),
                    OtherTime = table.Column<short>(type: "smallint", nullable: true),
                    OtherDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CloseRequest = table.Column<bool>(type: "bit", nullable: false),
                    DateTimeClosing = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkOrders_RequestRepairs_RequestIdFk",
                        column: x => x.RequestIdFk,
                        principalTable: "RequestRepairs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RepairManListeds",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepairManIdFk = table.Column<int>(type: "int", nullable: false),
                    WorkOrderIdFk = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairManListeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RepairManListeds_RepairMens_RepairManIdFk",
                        column: x => x.RepairManIdFk,
                        principalTable: "RepairMens",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RepairManListeds_WorkOrders_WorkOrderIdFk",
                        column: x => x.WorkOrderIdFk,
                        principalTable: "WorkOrders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_CompanyIdFk",
                table: "Applicants",
                column: "CompanyIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyIdFk",
                table: "AspNetUsers",
                column: "CompanyIdFk");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumableParts_RequestIdFk",
                table: "ConsumableParts",
                column: "RequestIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumableParts_UnitIdFk",
                table: "ConsumableParts",
                column: "UnitIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_CompanyIdFk",
                table: "Groups",
                column: "CompanyIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityCodes_CompanyIdFk",
                table: "IdentityCodes",
                column: "CompanyIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityCodes_GroupIdFk",
                table: "IdentityCodes",
                column: "GroupIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityCodes_SubGroupIdFk",
                table: "IdentityCodes",
                column: "SubGroupIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityCodes_UserIdFk",
                table: "IdentityCodes",
                column: "UserIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityMachineries_MachinerIdFk",
                table: "IdentityMachineries",
                column: "MachinerIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_Machineries_ApplicantIdFk",
                table: "Machineries",
                column: "ApplicantIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_Machineries_IdentityCodeIdFk",
                table: "Machineries",
                column: "IdentityCodeIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_PowerElectricalMachineries_MachineryIdFk",
                table: "PowerElectricalMachineries",
                column: "MachineryIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_RepairManListeds_RepairManIdFk",
                table: "RepairManListeds",
                column: "RepairManIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_RepairManListeds_WorkOrderIdFk",
                table: "RepairManListeds",
                column: "WorkOrderIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_Repairouts_RequestIdFk",
                table: "Repairouts",
                column: "RequestIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_Repairouts_UserIdFk",
                table: "Repairouts",
                column: "UserIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_RequestRepairs_ApplicantIdFk",
                table: "RequestRepairs",
                column: "ApplicantIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_RequestRepairs_CompanyIdFk",
                table: "RequestRepairs",
                column: "CompanyIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_RequestRepairs_MachineryIdFk",
                table: "RequestRepairs",
                column: "MachineryIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_RequestRepairs_PublicTypeIdFk",
                table: "RequestRepairs",
                column: "PublicTypeIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_RequestRepairs_UserIdFk",
                table: "RequestRepairs",
                column: "UserIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePeriodes_MachineryIdFk",
                table: "ServicePeriodes",
                column: "MachineryIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_ServicePeriodes_UnitIdFk",
                table: "ServicePeriodes",
                column: "UnitIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_SpareParts_MachineryIdFk",
                table: "SpareParts",
                column: "MachineryIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_SpareParts_UnitIdFk",
                table: "SpareParts",
                column: "UnitIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_SubGroups_CompanyIdFk",
                table: "SubGroups",
                column: "CompanyIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_SubGroups_GroupIdFk",
                table: "SubGroups",
                column: "GroupIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_WorkOrders_RequestIdFk",
                table: "WorkOrders",
                column: "RequestIdFk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ConsumableParts");

            migrationBuilder.DropTable(
                name: "IdentityMachineries");

            migrationBuilder.DropTable(
                name: "PowerElectricalMachineries");

            migrationBuilder.DropTable(
                name: "RepairManListeds");

            migrationBuilder.DropTable(
                name: "Repairouts");

            migrationBuilder.DropTable(
                name: "ServicePeriodes");

            migrationBuilder.DropTable(
                name: "SpareParts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "RepairMens");

            migrationBuilder.DropTable(
                name: "WorkOrders");

            migrationBuilder.DropTable(
                name: "UnitOfMeasurements");

            migrationBuilder.DropTable(
                name: "RequestRepairs");

            migrationBuilder.DropTable(
                name: "Machineries");

            migrationBuilder.DropTable(
                name: "PublicTypes");

            migrationBuilder.DropTable(
                name: "Applicants");

            migrationBuilder.DropTable(
                name: "IdentityCodes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SubGroups");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
