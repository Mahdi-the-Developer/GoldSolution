using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gold.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class rebuild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemCashToGolds",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalCash = table.Column<long>(type: "bigint", nullable: true),
                    GoldUnitPrice = table.Column<long>(type: "bigint", nullable: false),
                    EarnedGoldWeight = table.Column<double>(type: "float", nullable: false),
                    SpentCash = table.Column<long>(type: "bigint", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOver = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemCashToGolds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemGoldToCashs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GoldWeight = table.Column<double>(type: "float", nullable: false),
                    TotalBoughtPrice = table.Column<long>(type: "bigint", nullable: false),
                    UnitSellPrice = table.Column<long>(type: "bigint", nullable: false),
                    SoldGoldWeight = table.Column<double>(type: "float", nullable: false),
                    EarnedCash = table.Column<long>(type: "bigint", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOver = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemGoldToCashs", x => x.Id);
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
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.RoleId, x.UserId });
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
                name: "UserGoldAssets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoldAmount = table.Column<double>(type: "float", nullable: false),
                    PayedTotalCash = table.Column<double>(type: "float", nullable: false),
                    EarnedTotalCash = table.Column<double>(type: "float", nullable: false),
                    TotalCashAsset = table.Column<double>(type: "float", nullable: false),
                    ToAppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGoldAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGoldAssets_AspNetUsers_ToAppUserId",
                        column: x => x.ToAppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GoldPrices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldPrices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoldPrices_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserCashGolds",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CashAmount = table.Column<long>(type: "bigint", nullable: false),
                    GoldUnitPrice = table.Column<long>(type: "bigint", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPayed = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ToGoldAssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ToAppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCashGolds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCashGolds_AspNetUsers_ToAppUserId",
                        column: x => x.ToAppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCashGolds_UserGoldAssets_ToGoldAssetId",
                        column: x => x.ToGoldAssetId,
                        principalTable: "UserGoldAssets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserGoldCashs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GoldAmount = table.Column<double>(type: "float", nullable: false),
                    GoldUnitPrice = table.Column<long>(type: "bigint", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPayed = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ToGoldAssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ToAppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGoldCashs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGoldCashs_AspNetUsers_ToAppUserId",
                        column: x => x.ToAppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserGoldCashs_UserGoldAssets_ToGoldAssetId",
                        column: x => x.ToGoldAssetId,
                        principalTable: "UserGoldAssets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserSystemCashToGoldBills",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CashAmount = table.Column<long>(type: "bigint", nullable: false),
                    GoldAmount = table.Column<double>(type: "float", nullable: false),
                    ToUserCashToGoldId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ToSystemCashToGoldId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSystemCashToGoldBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSystemCashToGoldBills_SystemCashToGolds_ToSystemCashToGoldId",
                        column: x => x.ToSystemCashToGoldId,
                        principalTable: "SystemCashToGolds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserSystemCashToGoldBills_UserCashGolds_ToUserCashToGoldId",
                        column: x => x.ToUserCashToGoldId,
                        principalTable: "UserCashGolds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserSystemGoldToCashBills",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CashAmount = table.Column<long>(type: "bigint", nullable: false),
                    GoldAmount = table.Column<double>(type: "float", nullable: false),
                    ToUserGoldToCashId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ToSystemGoldToCashId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSystemGoldToCashBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSystemGoldToCashBills_SystemGoldToCashs_ToSystemGoldToCashId",
                        column: x => x.ToSystemGoldToCashId,
                        principalTable: "SystemGoldToCashs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserSystemGoldToCashBills_UserGoldCashs_ToUserGoldToCashId",
                        column: x => x.ToUserGoldToCashId,
                        principalTable: "UserGoldCashs",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "ad6151ed16984999b3ff121c5c0bfd96", "1", null, "MainAdmin", "MainAdmin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatDateTime", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8c72dff883b3403e81dc7bf88ce26b8a", 0, "6f4e8945-64a3-44b2-9e95-6635e0d636c0", new DateTime(2023, 5, 10, 19, 34, 6, 953, DateTimeKind.Local).AddTicks(8467), null, false, "Mahdi", "Montazeri", false, null, null, null, null, "09125850371", false, null, false, "MainAdmin" });

            migrationBuilder.InsertData(
                table: "GoldPrices",
                columns: new[] { "Id", "DateTime", "Price", "ProductId" },
                values: new object[] { new Guid("2b81eabb-c2c9-4ca9-9d38-d03f2c9b5f93"), new DateTime(2023, 5, 10, 19, 34, 6, 967, DateTimeKind.Local).AddTicks(6974), 105000.0, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "UnitName" },
                values: new object[] { new Guid("769768db-d89e-461c-8437-45bc36caf848"), "Gold", "گرم" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad6151ed16984999b3ff121c5c0bfd96", "8c72dff883b3403e81dc7bf88ce26b8a" });

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
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PhoneNumber",
                table: "AspNetUsers",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GoldPrices_ProductId",
                table: "GoldPrices",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCashGolds_ToAppUserId",
                table: "UserCashGolds",
                column: "ToAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCashGolds_ToGoldAssetId",
                table: "UserCashGolds",
                column: "ToGoldAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGoldAssets_ToAppUserId",
                table: "UserGoldAssets",
                column: "ToAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGoldCashs_ToAppUserId",
                table: "UserGoldCashs",
                column: "ToAppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGoldCashs_ToGoldAssetId",
                table: "UserGoldCashs",
                column: "ToGoldAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSystemCashToGoldBills_ToSystemCashToGoldId",
                table: "UserSystemCashToGoldBills",
                column: "ToSystemCashToGoldId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSystemCashToGoldBills_ToUserCashToGoldId",
                table: "UserSystemCashToGoldBills",
                column: "ToUserCashToGoldId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSystemGoldToCashBills_ToSystemGoldToCashId",
                table: "UserSystemGoldToCashBills",
                column: "ToSystemGoldToCashId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSystemGoldToCashBills_ToUserGoldToCashId",
                table: "UserSystemGoldToCashBills",
                column: "ToUserGoldToCashId");
        }

        /// <inheritdoc />
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
                name: "GoldPrices");

            migrationBuilder.DropTable(
                name: "UserSystemCashToGoldBills");

            migrationBuilder.DropTable(
                name: "UserSystemGoldToCashBills");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SystemCashToGolds");

            migrationBuilder.DropTable(
                name: "UserCashGolds");

            migrationBuilder.DropTable(
                name: "SystemGoldToCashs");

            migrationBuilder.DropTable(
                name: "UserGoldCashs");

            migrationBuilder.DropTable(
                name: "UserGoldAssets");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
