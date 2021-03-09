using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace wh4Shop.DataEntity.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "wh4shop");

            migrationBuilder.CreateTable(
                name: "AppRoles",
                schema: "wh4shop",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    LegalEntityId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                schema: "wh4shop",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    ClientType = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ccounts",
                schema: "wh4shop",
                columns: table => new
                {
                    CntId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CcountCode = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    CcountType = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    CcountStatus = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    OrganizationId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Attribute1 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute2 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute3 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute4 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute5 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CreationBy = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateBy = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ccounts", x => x.CntId);
                });

            migrationBuilder.CreateTable(
                name: "InvOnHands",
                schema: "wh4shop",
                columns: table => new
                {
                    Itemcode = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    Sku = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    OrganizationId = table.Column<long>(type: "bigint", nullable: false),
                    Attribute1 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute2 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute3 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute4 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute5 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    OnHandRunDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastTransactionId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvOnHands", x => new { x.Itemcode, x.Sku });
                });

            migrationBuilder.CreateTable(
                name: "InvTransactions",
                schema: "wh4shop",
                columns: table => new
                {
                    TransactionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TransactionSetId = table.Column<long>(type: "bigint", nullable: false),
                    FromOrganization = table.Column<long>(type: "bigint", nullable: false),
                    OwnerOrganization = table.Column<long>(type: "bigint", nullable: false),
                    TransactionQuantity = table.Column<decimal>(type: "numeric", nullable: false),
                    TransactionStatus = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    TransactionAction = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    TransactionType = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    Uom = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Attribute1 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute2 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute3 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute4 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute5 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CreationBy = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateBy = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvTransactions", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "LegalProfiles",
                schema: "wh4shop",
                columns: table => new
                {
                    LegalEntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LegalType = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    LegalName = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: true),
                    LegalAddress = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Attribute1 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute2 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute3 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute4 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute5 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreationBy = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateBy = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalProfiles", x => x.LegalEntityId);
                });

            migrationBuilder.CreateTable(
                name: "LicenceProfiles",
                schema: "wh4shop",
                columns: table => new
                {
                    LicenceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LicenceKey = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    LicenceType = table.Column<string>(type: "text", nullable: true),
                    MaxUser = table.Column<int>(type: "integer", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ExpiredDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenceProfiles", x => x.LicenceId);
                });

            migrationBuilder.CreateTable(
                name: "MasterItems",
                schema: "wh4shop",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ItemCode = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: true),
                    ItemName = table.Column<string>(type: "text", nullable: true),
                    ItemSku = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ItemCost = table.Column<decimal>(type: "numeric", nullable: false),
                    Unit = table.Column<string>(type: "text", nullable: true),
                    LegalEntityId = table.Column<long>(type: "bigint", nullable: false),
                    OrganizationId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Attribute1 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute2 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute3 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute4 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute5 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CreationBy = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateBy = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                schema: "wh4shop",
                columns: table => new
                {
                    OrganizationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrganizationCode = table.Column<string>(type: "character varying(35)", maxLength: 35, nullable: true),
                    OrganizationName = table.Column<string>(type: "character varying(125)", maxLength: 125, nullable: true),
                    OrganizationType = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    OrganizationAddress = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    LegalEntityId = table.Column<long>(type: "bigint", nullable: false),
                    Description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Attribute1 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute2 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute3 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute4 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute5 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CreationBy = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateBy = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.OrganizationId);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaim",
                schema: "wh4shop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                schema: "wh4shop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                schema: "wh4shop",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: true),
                    ProviderKey = table.Column<string>(type: "text", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "wh4shop",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                schema: "wh4shop",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CcountLines",
                schema: "wh4shop",
                columns: table => new
                {
                    CntLineId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CntId = table.Column<long>(type: "bigint", nullable: false),
                    ItemCode = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    Sku = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: true),
                    InventoryQuantity = table.Column<decimal>(type: "numeric", nullable: false),
                    Attribute1 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute2 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute3 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute4 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Attribute5 = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CreationBy = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastUpdateBy = table.Column<Guid>(type: "uuid", maxLength: 60, nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CcountLines", x => x.CntLineId);
                    table.ForeignKey(
                        name: "FK_CcountLines_Ccounts_CntId",
                        column: x => x.CntId,
                        principalSchema: "wh4shop",
                        principalTable: "Ccounts",
                        principalColumn: "CntId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CcountLines_CntId",
                schema: "wh4shop",
                table: "CcountLines",
                column: "CntId");

            migrationBuilder.CreateIndex(
                name: "IX_CcountLines_CreationDate",
                schema: "wh4shop",
                table: "CcountLines",
                column: "CreationDate");

            migrationBuilder.CreateIndex(
                name: "IX_CcountLines_LastUpdateDate",
                schema: "wh4shop",
                table: "CcountLines",
                column: "LastUpdateDate");

            migrationBuilder.CreateIndex(
                name: "IX_Ccounts_CreationDate",
                schema: "wh4shop",
                table: "Ccounts",
                column: "CreationDate");

            migrationBuilder.CreateIndex(
                name: "IX_Ccounts_LastUpdateDate",
                schema: "wh4shop",
                table: "Ccounts",
                column: "LastUpdateDate");

            migrationBuilder.CreateIndex(
                name: "IX_InvOnHands_OnHandRunDate",
                schema: "wh4shop",
                table: "InvOnHands",
                column: "OnHandRunDate");

            migrationBuilder.CreateIndex(
                name: "IX_InvTransactions_CreationDate",
                schema: "wh4shop",
                table: "InvTransactions",
                column: "CreationDate");

            migrationBuilder.CreateIndex(
                name: "IX_InvTransactions_LastUpdateDate",
                schema: "wh4shop",
                table: "InvTransactions",
                column: "LastUpdateDate");

            migrationBuilder.CreateIndex(
                name: "IX_InvTransactions_TransactionId_TransactionSetId",
                schema: "wh4shop",
                table: "InvTransactions",
                columns: new[] { "TransactionId", "TransactionSetId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LegalProfiles_CreationDate",
                schema: "wh4shop",
                table: "LegalProfiles",
                column: "CreationDate");

            migrationBuilder.CreateIndex(
                name: "IX_LegalProfiles_LastUpdateDate",
                schema: "wh4shop",
                table: "LegalProfiles",
                column: "LastUpdateDate");

            migrationBuilder.CreateIndex(
                name: "IX_LicenceProfiles_ExpiredDate",
                schema: "wh4shop",
                table: "LicenceProfiles",
                column: "ExpiredDate");

            migrationBuilder.CreateIndex(
                name: "IX_LicenceProfiles_IssueDate",
                schema: "wh4shop",
                table: "LicenceProfiles",
                column: "IssueDate");

            migrationBuilder.CreateIndex(
                name: "IX_LicenceProfiles_LicenceKey",
                schema: "wh4shop",
                table: "LicenceProfiles",
                column: "LicenceKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterItems_CreationDate",
                schema: "wh4shop",
                table: "MasterItems",
                column: "CreationDate");

            migrationBuilder.CreateIndex(
                name: "IX_MasterItems_ItemCode_ItemSku",
                schema: "wh4shop",
                table: "MasterItems",
                columns: new[] { "ItemCode", "ItemSku" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterItems_ItemCode_OrganizationId",
                schema: "wh4shop",
                table: "MasterItems",
                columns: new[] { "ItemCode", "OrganizationId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterItems_LastUpdateDate",
                schema: "wh4shop",
                table: "MasterItems",
                column: "LastUpdateDate");

            migrationBuilder.CreateIndex(
                name: "IX_MasterItems_LegalEntityId_OrganizationId",
                schema: "wh4shop",
                table: "MasterItems",
                columns: new[] { "LegalEntityId", "OrganizationId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_CreationDate",
                schema: "wh4shop",
                table: "Organizations",
                column: "CreationDate");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_LastUpdateDate",
                schema: "wh4shop",
                table: "Organizations",
                column: "LastUpdateDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoles",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "AppUsers",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "CcountLines",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "InvOnHands",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "InvTransactions",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "LegalProfiles",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "LicenceProfiles",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "MasterItems",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "Organizations",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "RoleClaim",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "UserClaim",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "UserLogin",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "UserToken",
                schema: "wh4shop");

            migrationBuilder.DropTable(
                name: "Ccounts",
                schema: "wh4shop");
        }
    }
}
