using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AweCoreDemo.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    ActivityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ActivityCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ActivityID);
                });

            migrationBuilder.CreateTable(
                name: "ArmyDivision",
                columns: table => new
                {
                    ArmyDivisionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmyDivision", x => x.ArmyDivisionID);
                });

            migrationBuilder.CreateTable(
                name: "ArmyServices",
                columns: table => new
                {
                    ArmyServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmyServices", x => x.ArmyServiceID);
                });

            migrationBuilder.CreateTable(
                name: "ArmyStatuses",
                columns: table => new
                {
                    ArmyStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmyStatuses", x => x.ArmyStatusID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BillItemTypes",
                columns: table => new
                {
                    BillItemTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillItemTypes", x => x.BillItemTypeID);
                });

            migrationBuilder.CreateTable(
                name: "BillStatus",
                columns: table => new
                {
                    BillStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillStatus", x => x.BillStatusID);
                });

            migrationBuilder.CreateTable(
                name: "BranchTypes",
                columns: table => new
                {
                    BranchTyeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchTypes", x => x.BranchTyeID);
                });

            migrationBuilder.CreateTable(
                name: "DispenseStatuses",
                columns: table => new
                {
                    DispenseStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispenseStatuses", x => x.DispenseStatusID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeGroups",
                columns: table => new
                {
                    EmployeeGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Groupcode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeGroups", x => x.EmployeeGroupID);
                });

            migrationBuilder.CreateTable(
                name: "EntityTypes",
                columns: table => new
                {
                    EntityTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityTypes", x => x.EntityTypeID);
                });

            migrationBuilder.CreateTable(
                name: "ExaminationStatuses",
                columns: table => new
                {
                    ExaminationStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExaminationStatuses", x => x.ExaminationStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Families",
                columns: table => new
                {
                    FamilyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Credit = table.Column<int>(nullable: false),
                    Debit = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MaxCredit = table.Column<int>(nullable: false),
                    OSBalance = table.Column<int>(nullable: false),
                    InitialDeposit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Families", x => x.FamilyID);
                });

            migrationBuilder.CreateTable(
                name: "HServices",
                columns: table => new
                {
                    HServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HServices", x => x.HServiceID);
                });

            migrationBuilder.CreateTable(
                name: "ItemSuperTypes",
                columns: table => new
                {
                    ItemSuperTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSuperTypes", x => x.ItemSuperTypeID);
                });

            migrationBuilder.CreateTable(
                name: "ItemUnits",
                columns: table => new
                {
                    ItemUnitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Abbreviation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemUnits", x => x.ItemUnitID);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleID);
                });

            migrationBuilder.CreateTable(
                name: "NOKRelationships",
                columns: table => new
                {
                    NOKRelationshipID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NOKRelationships", x => x.NOKRelationshipID);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    OrganisationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Credit = table.Column<int>(nullable: false),
                    Debit = table.Column<int>(nullable: false),
                    Charge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganisationID);
                });

            migrationBuilder.CreateTable(
                name: "PatientTypes",
                columns: table => new
                {
                    PatientTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PatientTypeID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientTypes", x => x.PatientTypeID);
                    table.ForeignKey(
                        name: "FK_PatientTypes_PatientTypes_PatientTypeID1",
                        column: x => x.PatientTypeID1,
                        principalTable: "PatientTypes",
                        principalColumn: "PatientTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    RankID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.RankID);
                });

            migrationBuilder.CreateTable(
                name: "ReferralStatuses",
                columns: table => new
                {
                    ReferralStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralStatuses", x => x.ReferralStatusID);
                });

            migrationBuilder.CreateTable(
                name: "RoutineType",
                columns: table => new
                {
                    RoutineTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutineType", x => x.RoutineTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "ArmyUnits",
                columns: table => new
                {
                    ArmyUnitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArmyDivisionID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmyUnits", x => x.ArmyUnitID);
                    table.ForeignKey(
                        name: "FK_ArmyUnits_ArmyDivision_ArmyDivisionID",
                        column: x => x.ArmyDivisionID,
                        principalTable: "ArmyDivision",
                        principalColumn: "ArmyDivisionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                name: "Permissions",
                columns: table => new
                {
                    PermissionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CanEdit = table.Column<bool>(nullable: false),
                    CanRead = table.Column<bool>(nullable: false),
                    CanDelete = table.Column<bool>(nullable: false),
                    CanAdd = table.Column<bool>(nullable: false),
                    CanApprove = table.Column<bool>(nullable: false),
                    CanConfirm = table.Column<bool>(nullable: false),
                    EmployeeGroupID = table.Column<int>(nullable: true),
                    ActivityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.PermissionID);
                    table.ForeignKey(
                        name: "FK_Permissions_Activity_ActivityID",
                        column: x => x.ActivityID,
                        principalTable: "Activity",
                        principalColumn: "ActivityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Permissions_EmployeeGroups_EmployeeGroupID",
                        column: x => x.EmployeeGroupID,
                        principalTable: "EmployeeGroups",
                        principalColumn: "EmployeeGroupID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemSubGroups",
                columns: table => new
                {
                    ItemSubGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ItemSuperTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemSubGroups", x => x.ItemSubGroupID);
                    table.ForeignKey(
                        name: "FK_ItemSubGroups_ItemSuperTypes_ItemSuperTypeID",
                        column: x => x.ItemSuperTypeID,
                        principalTable: "ItemSuperTypes",
                        principalColumn: "ItemSuperTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NextOfKins",
                columns: table => new
                {
                    NextOfKinID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Guid = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    NOKRelationshipID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NextOfKins", x => x.NextOfKinID);
                    table.ForeignKey(
                        name: "FK_NextOfKins_NOKRelationships_NOKRelationshipID",
                        column: x => x.NOKRelationshipID,
                        principalTable: "NOKRelationships",
                        principalColumn: "NOKRelationshipID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    HospitalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    BoxNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ContractLength = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    StatusID = table.Column<int>(nullable: true),
                    EntityTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.HospitalID);
                    table.ForeignKey(
                        name: "FK_Hospitals_EntityTypes_EntityTypeID",
                        column: x => x.EntityTypeID,
                        principalTable: "EntityTypes",
                        principalColumn: "EntityTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hospitals_Statuses_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Statuses",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemTypes",
                columns: table => new
                {
                    ItemTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    SubGroup = table.Column<string>(nullable: true),
                    RefSubGroup = table.Column<int>(nullable: false),
                    CompleteName = table.Column<string>(nullable: true),
                    ItemSubGroupID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTypes", x => x.ItemTypeID);
                    table.ForeignKey(
                        name: "FK_ItemTypes_ItemSubGroups_ItemSubGroupID",
                        column: x => x.ItemSubGroupID,
                        principalTable: "ItemSubGroups",
                        principalColumn: "ItemSubGroupID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    HospitalID = table.Column<int>(nullable: true),
                    HospitalD = table.Column<int>(nullable: true),
                    BranchTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchID);
                    table.ForeignKey(
                        name: "FK_Branches_BranchTypes_BranchTypeID",
                        column: x => x.BranchTypeID,
                        principalTable: "BranchTypes",
                        principalColumn: "BranchTyeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Branches_Hospitals_HospitalD",
                        column: x => x.HospitalD,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mappings",
                columns: table => new
                {
                    MappingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalID = table.Column<int>(nullable: false),
                    ModuleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mappings", x => x.MappingID);
                    table.ForeignKey(
                        name: "FK_Mappings_Hospitals_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mappings_Modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "Modules",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    BranchID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Departments_Branches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branches",
                        principalColumn: "BranchID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    EmployeeGroupID = table.Column<int>(nullable: true),
                    HospitalId = table.Column<int>(nullable: true),
                    DepartmentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_EmployeeGroups_EmployeeGroupID",
                        column: x => x.EmployeeGroupID,
                        principalTable: "EmployeeGroups",
                        principalColumn: "EmployeeGroupID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    CardNO = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    AccNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: true),
                    PatientTypeID = table.Column<int>(nullable: true),
                    NextOfKinID = table.Column<int>(nullable: true),
                    FamilyID = table.Column<int>(nullable: true),
                    OrganisationID = table.Column<int>(nullable: true),
                    ArmyNumber = table.Column<string>(nullable: true),
                    ArmyUnitID = table.Column<int>(nullable: true),
                    ServiceCodeID = table.Column<int>(nullable: true),
                    RankID = table.Column<int>(nullable: true),
                    ArmyStatusID = table.Column<int>(nullable: true),
                    HospitalID = table.Column<int>(nullable: true),
                    DepartmentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientID);
                    table.ForeignKey(
                        name: "FK_Patients_ArmyStatuses_ArmyStatusID",
                        column: x => x.ArmyStatusID,
                        principalTable: "ArmyStatuses",
                        principalColumn: "ArmyStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_ArmyUnits_ArmyUnitID",
                        column: x => x.ArmyUnitID,
                        principalTable: "ArmyUnits",
                        principalColumn: "ArmyUnitID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Families_FamilyID",
                        column: x => x.FamilyID,
                        principalTable: "Families",
                        principalColumn: "FamilyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Hospitals_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "Hospitals",
                        principalColumn: "HospitalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_NextOfKins_NextOfKinID",
                        column: x => x.NextOfKinID,
                        principalTable: "NextOfKins",
                        principalColumn: "NextOfKinID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Organizations_OrganisationID",
                        column: x => x.OrganisationID,
                        principalTable: "Organizations",
                        principalColumn: "OrganisationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_PatientTypes_PatientTypeID",
                        column: x => x.PatientTypeID,
                        principalTable: "PatientTypes",
                        principalColumn: "PatientTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Ranks_RankID",
                        column: x => x.RankID,
                        principalTable: "Ranks",
                        principalColumn: "RankID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_ArmyServices_ServiceCodeID",
                        column: x => x.ServiceCodeID,
                        principalTable: "ArmyServices",
                        principalColumn: "ArmyServiceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    TestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DepartmentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.TestID);
                    table.ForeignKey(
                        name: "FK_Tests_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Assignments",
                columns: table => new
                {
                    AssignmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Emergency = table.Column<bool>(nullable: false),
                    Recommendation = table.Column<string>(nullable: true),
                    LastVisted = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    Reported = table.Column<DateTime>(nullable: false),
                    PatientID = table.Column<int>(nullable: false),
                    ReferralStatusID = table.Column<int>(nullable: true),
                    PatientTypeID = table.Column<int>(nullable: true),
                    BillStatusID = table.Column<int>(nullable: true),
                    DoctorID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentID);
                    table.ForeignKey(
                        name: "FK_Assignments_BillStatus_BillStatusID",
                        column: x => x.BillStatusID,
                        principalTable: "BillStatus",
                        principalColumn: "BillStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignments_AspNetUsers_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignments_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignments_PatientTypes_PatientTypeID",
                        column: x => x.PatientTypeID,
                        principalTable: "PatientTypes",
                        principalColumn: "PatientTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignments_ReferralStatuses_ReferralStatusID",
                        column: x => x.ReferralStatusID,
                        principalTable: "ReferralStatuses",
                        principalColumn: "ReferralStatusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    BIllID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Balance = table.Column<int>(nullable: true),
                    InitialPrint = table.Column<bool>(nullable: false),
                    FinalPrint = table.Column<bool>(nullable: false),
                    BillStatusID = table.Column<int>(nullable: true),
                    PatientID = table.Column<int>(nullable: true),
                    Total = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.BIllID);
                    table.ForeignKey(
                        name: "FK_Bills_BillStatus_BillStatusID",
                        column: x => x.BillStatusID,
                        principalTable: "BillStatus",
                        principalColumn: "BillStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bills_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ExtendedName = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    TradeName = table.Column<string>(nullable: true),
                    PackageName = table.Column<string>(nullable: true),
                    PackageDesc = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    ItemsPerPkg = table.Column<int>(nullable: false),
                    Ref_Supplier = table.Column<int>(nullable: false),
                    ItemTypeID = table.Column<int>(nullable: false),
                    ItemUnitID = table.Column<int>(nullable: false),
                    ModifiedByUserId = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    TestID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK_Items_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_ItemTypes_ItemTypeID",
                        column: x => x.ItemTypeID,
                        principalTable: "ItemTypes",
                        principalColumn: "ItemTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_ItemUnits_ItemUnitID",
                        column: x => x.ItemUnitID,
                        principalTable: "ItemUnits",
                        principalColumn: "ItemUnitID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_AspNetUsers_ModifiedByUserId",
                        column: x => x.ModifiedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Items_Tests_TestID",
                        column: x => x.TestID,
                        principalTable: "Tests",
                        principalColumn: "TestID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Examinations",
                columns: table => new
                {
                    ExaminationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Findings = table.Column<string>(nullable: true),
                    ExaminationStatusID = table.Column<int>(nullable: true),
                    BillStatusID = table.Column<int>(nullable: true),
                    AssignmentID = table.Column<int>(nullable: true),
                    BillID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinations", x => x.ExaminationID);
                    table.ForeignKey(
                        name: "FK_Examinations_Assignments_AssignmentID",
                        column: x => x.AssignmentID,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examinations_Bills_BillID",
                        column: x => x.BillID,
                        principalTable: "Bills",
                        principalColumn: "BIllID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examinations_BillStatus_BillStatusID",
                        column: x => x.BillStatusID,
                        principalTable: "BillStatus",
                        principalColumn: "BillStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examinations_ExaminationStatuses_ExaminationStatusID",
                        column: x => x.ExaminationStatusID,
                        principalTable: "ExaminationStatuses",
                        principalColumn: "ExaminationStatusID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReceiptRoutines",
                columns: table => new
                {
                    ReceiptRoutineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptNumber = table.Column<string>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    BillID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiptRoutines", x => x.ReceiptRoutineID);
                    table.ForeignKey(
                        name: "FK_ReceiptRoutines_Bills_BillID",
                        column: x => x.BillID,
                        principalTable: "Bills",
                        principalColumn: "BIllID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillItems",
                columns: table => new
                {
                    BillItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    BillItemTypeID = table.Column<int>(nullable: true),
                    ItemID = table.Column<int>(nullable: true),
                    TestID = table.Column<int>(nullable: true),
                    HServiceID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillItems", x => x.BillItemID);
                    table.ForeignKey(
                        name: "FK_BillItems_BillItemTypes_BillItemTypeID",
                        column: x => x.BillItemTypeID,
                        principalTable: "BillItemTypes",
                        principalColumn: "BillItemTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillItems_HServices_HServiceID",
                        column: x => x.HServiceID,
                        principalTable: "HServices",
                        principalColumn: "HServiceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillItems_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BillItems_Tests_TestID",
                        column: x => x.TestID,
                        principalTable: "Tests",
                        principalColumn: "TestID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    RequestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    RequestedBy = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    IssuedQty = table.Column<int>(nullable: false),
                    ApprovedQty = table.Column<int>(nullable: false),
                    Requested_On = table.Column<DateTime>(nullable: false),
                    Balance = table.Column<int>(nullable: false),
                    Approved_On = table.Column<DateTime>(nullable: false),
                    Received = table.Column<bool>(nullable: false),
                    Confirmed = table.Column<bool>(nullable: false),
                    Appoved = table.Column<bool>(nullable: false),
                    Issued = table.Column<bool>(nullable: false),
                    ItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.RequestID);
                    table.ForeignKey(
                        name: "FK_Request_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stoks",
                columns: table => new
                {
                    StockID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    ItemID = table.Column<int>(nullable: true),
                    DepartmentID = table.Column<int>(nullable: true),
                    Available = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stoks", x => x.StockID);
                    table.ForeignKey(
                        name: "FK_Stoks_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Stoks_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TestConsumables",
                columns: table => new
                {
                    TestConsumableID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestID = table.Column<int>(nullable: true),
                    ItemID = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestConsumables", x => x.TestConsumableID);
                    table.ForeignKey(
                        name: "FK_TestConsumables_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestConsumables_Tests_TestID",
                        column: x => x.TestID,
                        principalTable: "Tests",
                        principalColumn: "TestID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    TreatmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Days = table.Column<int>(nullable: true),
                    PreQuantity = table.Column<int>(nullable: true),
                    PostQuantity = table.Column<int>(nullable: true),
                    OriginalAmount = table.Column<int>(nullable: true),
                    AdjustedAmount = table.Column<int>(nullable: true),
                    ItemID = table.Column<int>(nullable: true),
                    BIllID = table.Column<int>(nullable: true),
                    AssignmentID = table.Column<int>(nullable: true),
                    DispenseStatusID = table.Column<int>(nullable: true),
                    DispensedQty = table.Column<int>(nullable: true),
                    Balance = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.TreatmentID);
                    table.ForeignKey(
                        name: "FK_Treatments_Assignments_AssignmentID",
                        column: x => x.AssignmentID,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_Bills_BIllID",
                        column: x => x.BIllID,
                        principalTable: "Bills",
                        principalColumn: "BIllID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_DispenseStatuses_DispenseStatusID",
                        column: x => x.DispenseStatusID,
                        principalTable: "DispenseStatuses",
                        principalColumn: "DispenseStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treatments_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Procedures",
                columns: table => new
                {
                    ProcedureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    TestID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Findings = table.Column<string>(nullable: true),
                    ExaminationID = table.Column<int>(nullable: true),
                    ExaminationStatusID = table.Column<int>(nullable: true),
                    BillID = table.Column<int>(nullable: true),
                    OriginalAmount = table.Column<int>(nullable: true),
                    AdjustedAmount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedures", x => x.ProcedureID);
                    table.ForeignKey(
                        name: "FK_Procedures_Bills_BillID",
                        column: x => x.BillID,
                        principalTable: "Bills",
                        principalColumn: "BIllID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Procedures_Examinations_ExaminationID",
                        column: x => x.ExaminationID,
                        principalTable: "Examinations",
                        principalColumn: "ExaminationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Procedures_ExaminationStatuses_ExaminationStatusID",
                        column: x => x.ExaminationStatusID,
                        principalTable: "ExaminationStatuses",
                        principalColumn: "ExaminationStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Procedures_Tests_TestID",
                        column: x => x.TestID,
                        principalTable: "Tests",
                        principalColumn: "TestID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DispenseRoutines",
                columns: table => new
                {
                    DispenseRoutineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    ItemID = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    PatientID = table.Column<int>(nullable: true),
                    TreatmentID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispenseRoutines", x => x.DispenseRoutineID);
                    table.ForeignKey(
                        name: "FK_DispenseRoutines_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DispenseRoutines_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DispenseRoutines_Treatments_TreatmentID",
                        column: x => x.TreatmentID,
                        principalTable: "Treatments",
                        principalColumn: "TreatmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    ReceiptID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceiptNumber = table.Column<string>(maxLength: 15, nullable: true),
                    Amount = table.Column<int>(nullable: true),
                    AdjustedAmount = table.Column<int>(nullable: true),
                    AdjustedCost = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: true),
                    BillID = table.Column<int>(nullable: true),
                    TreatmentID = table.Column<int>(nullable: true),
                    ProcedureID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.ReceiptID);
                    table.ForeignKey(
                        name: "FK_Receipts_Bills_BillID",
                        column: x => x.BillID,
                        principalTable: "Bills",
                        principalColumn: "BIllID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipts_Procedures_ProcedureID",
                        column: x => x.ProcedureID,
                        principalTable: "Procedures",
                        principalColumn: "ProcedureID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receipts_Treatments_TreatmentID",
                        column: x => x.TreatmentID,
                        principalTable: "Treatments",
                        principalColumn: "TreatmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockRoutines",
                columns: table => new
                {
                    StockRoutineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    ItemID = table.Column<int>(nullable: true),
                    StockID = table.Column<int>(nullable: true),
                    ProcedureID = table.Column<int>(nullable: true),
                    TestConsumableID = table.Column<int>(nullable: true),
                    TreatmentID = table.Column<int>(nullable: true),
                    ExaminationID = table.Column<int>(nullable: true),
                    RoutineTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockRoutines", x => x.StockRoutineID);
                    table.ForeignKey(
                        name: "FK_StockRoutines_Examinations_ExaminationID",
                        column: x => x.ExaminationID,
                        principalTable: "Examinations",
                        principalColumn: "ExaminationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockRoutines_Items_ItemID",
                        column: x => x.ItemID,
                        principalTable: "Items",
                        principalColumn: "ItemID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockRoutines_Procedures_ProcedureID",
                        column: x => x.ProcedureID,
                        principalTable: "Procedures",
                        principalColumn: "ProcedureID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockRoutines_RoutineType_RoutineTypeID",
                        column: x => x.RoutineTypeID,
                        principalTable: "RoutineType",
                        principalColumn: "RoutineTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockRoutines_Stoks_StockID",
                        column: x => x.StockID,
                        principalTable: "Stoks",
                        principalColumn: "StockID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockRoutines_TestConsumables_TestConsumableID",
                        column: x => x.TestConsumableID,
                        principalTable: "TestConsumables",
                        principalColumn: "TestConsumableID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockRoutines_Treatments_TreatmentID",
                        column: x => x.TreatmentID,
                        principalTable: "Treatments",
                        principalColumn: "TreatmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArmyDivision_Name",
                table: "ArmyDivision",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ArmyServices_Name",
                table: "ArmyServices",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ArmyStatuses_Name",
                table: "ArmyStatuses",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ArmyUnits_ArmyDivisionID",
                table: "ArmyUnits",
                column: "ArmyDivisionID");

            migrationBuilder.CreateIndex(
                name: "IX_ArmyUnits_Name",
                table: "ArmyUnits",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

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
                name: "IX_AspNetUsers_DepartmentID",
                table: "AspNetUsers",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployeeGroupID",
                table: "AspNetUsers",
                column: "EmployeeGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_HospitalId",
                table: "AspNetUsers",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_BillStatusID",
                table: "Assignments",
                column: "BillStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_DoctorID",
                table: "Assignments",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_PatientID",
                table: "Assignments",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_PatientTypeID",
                table: "Assignments",
                column: "PatientTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ReferralStatusID",
                table: "Assignments",
                column: "ReferralStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_BillItems_BillItemTypeID",
                table: "BillItems",
                column: "BillItemTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_BillItems_HServiceID",
                table: "BillItems",
                column: "HServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_BillItems_ItemID",
                table: "BillItems",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_BillItems_Name",
                table: "BillItems",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BillItems_TestID",
                table: "BillItems",
                column: "TestID");

            migrationBuilder.CreateIndex(
                name: "IX_BillItemTypes_Name",
                table: "BillItemTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_BillStatusID",
                table: "Bills",
                column: "BillStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_PatientID",
                table: "Bills",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_BranchTypeID",
                table: "Branches",
                column: "BranchTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_HospitalD",
                table: "Branches",
                column: "HospitalD");

            migrationBuilder.CreateIndex(
                name: "IX_BranchTypes_Name",
                table: "BranchTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_BranchID",
                table: "Departments",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_DispenseRoutines_ItemID",
                table: "DispenseRoutines",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_DispenseRoutines_PatientID",
                table: "DispenseRoutines",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_DispenseRoutines_TreatmentID",
                table: "DispenseRoutines",
                column: "TreatmentID");

            migrationBuilder.CreateIndex(
                name: "IX_DispenseStatuses_Name",
                table: "DispenseStatuses",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeGroups_Name",
                table: "EmployeeGroups",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EntityTypes_Name",
                table: "EntityTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_AssignmentID",
                table: "Examinations",
                column: "AssignmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_BillID",
                table: "Examinations",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_BillStatusID",
                table: "Examinations",
                column: "BillStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_ExaminationStatusID",
                table: "Examinations",
                column: "ExaminationStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_EntityTypeID",
                table: "Hospitals",
                column: "EntityTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_StatusID",
                table: "Hospitals",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_HServices_Name",
                table: "HServices",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ApplicationUserId",
                table: "Items",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemTypeID",
                table: "Items",
                column: "ItemTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemUnitID",
                table: "Items",
                column: "ItemUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ModifiedByUserId",
                table: "Items",
                column: "ModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_Name",
                table: "Items",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Items_TestID",
                table: "Items",
                column: "TestID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSubGroups_ItemSuperTypeID",
                table: "ItemSubGroups",
                column: "ItemSuperTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSubGroups_Name",
                table: "ItemSubGroups",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ItemSuperTypes_Name",
                table: "ItemSuperTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_ItemSubGroupID",
                table: "ItemTypes",
                column: "ItemSubGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTypes_Name",
                table: "ItemTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ItemUnits_Name",
                table: "ItemUnits",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Mappings_HospitalID",
                table: "Mappings",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_Mappings_ModuleID",
                table: "Mappings",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_Name",
                table: "Modules",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NextOfKins_NOKRelationshipID",
                table: "NextOfKins",
                column: "NOKRelationshipID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ArmyStatusID",
                table: "Patients",
                column: "ArmyStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ArmyUnitID",
                table: "Patients",
                column: "ArmyUnitID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DepartmentID",
                table: "Patients",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_FamilyID",
                table: "Patients",
                column: "FamilyID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_HospitalID",
                table: "Patients",
                column: "HospitalID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_NextOfKinID",
                table: "Patients",
                column: "NextOfKinID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_OrganisationID",
                table: "Patients",
                column: "OrganisationID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_PatientTypeID",
                table: "Patients",
                column: "PatientTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_RankID",
                table: "Patients",
                column: "RankID");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_ServiceCodeID",
                table: "Patients",
                column: "ServiceCodeID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTypes_Name",
                table: "PatientTypes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PatientTypes_PatientTypeID1",
                table: "PatientTypes",
                column: "PatientTypeID1");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_ActivityID",
                table: "Permissions",
                column: "ActivityID");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_EmployeeGroupID",
                table: "Permissions",
                column: "EmployeeGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_BillID",
                table: "Procedures",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_ExaminationID",
                table: "Procedures",
                column: "ExaminationID");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_ExaminationStatusID",
                table: "Procedures",
                column: "ExaminationStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Procedures_TestID",
                table: "Procedures",
                column: "TestID");

            migrationBuilder.CreateIndex(
                name: "IX_Ranks_Name",
                table: "Ranks",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptRoutines_BillID",
                table: "ReceiptRoutines",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_BillID",
                table: "Receipts",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_ProcedureID",
                table: "Receipts",
                column: "ProcedureID");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_ReceiptNumber",
                table: "Receipts",
                column: "ReceiptNumber",
                unique: true,
                filter: "[ReceiptNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_TreatmentID",
                table: "Receipts",
                column: "TreatmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ReferralStatuses_Name",
                table: "ReferralStatuses",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Request_ItemID",
                table: "Request",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_RoutineType_Name",
                table: "RoutineType",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_Name",
                table: "Statuses",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_StockRoutines_ExaminationID",
                table: "StockRoutines",
                column: "ExaminationID");

            migrationBuilder.CreateIndex(
                name: "IX_StockRoutines_ItemID",
                table: "StockRoutines",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_StockRoutines_ProcedureID",
                table: "StockRoutines",
                column: "ProcedureID");

            migrationBuilder.CreateIndex(
                name: "IX_StockRoutines_RoutineTypeID",
                table: "StockRoutines",
                column: "RoutineTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_StockRoutines_StockID",
                table: "StockRoutines",
                column: "StockID");

            migrationBuilder.CreateIndex(
                name: "IX_StockRoutines_TestConsumableID",
                table: "StockRoutines",
                column: "TestConsumableID");

            migrationBuilder.CreateIndex(
                name: "IX_StockRoutines_TreatmentID",
                table: "StockRoutines",
                column: "TreatmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Stoks_DepartmentID",
                table: "Stoks",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Stoks_ItemID",
                table: "Stoks",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_TestConsumables_ItemID",
                table: "TestConsumables",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IX_TestConsumables_TestID",
                table: "TestConsumables",
                column: "TestID");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_DepartmentID",
                table: "Tests",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_Name",
                table: "Tests",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_AssignmentID",
                table: "Treatments",
                column: "AssignmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_BIllID",
                table: "Treatments",
                column: "BIllID");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_DispenseStatusID",
                table: "Treatments",
                column: "DispenseStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_ItemID",
                table: "Treatments",
                column: "ItemID");
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
                name: "BillItems");

            migrationBuilder.DropTable(
                name: "DispenseRoutines");

            migrationBuilder.DropTable(
                name: "Mappings");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "ReceiptRoutines");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "StockRoutines");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BillItemTypes");

            migrationBuilder.DropTable(
                name: "HServices");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Procedures");

            migrationBuilder.DropTable(
                name: "RoutineType");

            migrationBuilder.DropTable(
                name: "Stoks");

            migrationBuilder.DropTable(
                name: "TestConsumables");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "Examinations");

            migrationBuilder.DropTable(
                name: "DispenseStatuses");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "ExaminationStatuses");

            migrationBuilder.DropTable(
                name: "ItemTypes");

            migrationBuilder.DropTable(
                name: "ItemUnits");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ReferralStatuses");

            migrationBuilder.DropTable(
                name: "BillStatus");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "ItemSubGroups");

            migrationBuilder.DropTable(
                name: "EmployeeGroups");

            migrationBuilder.DropTable(
                name: "ArmyStatuses");

            migrationBuilder.DropTable(
                name: "ArmyUnits");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Families");

            migrationBuilder.DropTable(
                name: "NextOfKins");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropTable(
                name: "PatientTypes");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "ArmyServices");

            migrationBuilder.DropTable(
                name: "ItemSuperTypes");

            migrationBuilder.DropTable(
                name: "ArmyDivision");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "NOKRelationships");

            migrationBuilder.DropTable(
                name: "BranchTypes");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "EntityTypes");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
