﻿// <auto-generated />
using System;
using Gold.Infrastructure.GoldDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gold.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("ApplicationUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("ApplicationUserToken", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Assets.UserGoldAsset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("EarnedTotalCash")
                        .HasColumnType("float");

                    b.Property<double>("GoldAmount")
                        .HasColumnType("float");

                    b.Property<double>("PayedTotalCash")
                        .HasColumnType("float");

                    b.Property<string>("ToAppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("TotalCashAsset")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ToAppUserId");

                    b.ToTable("UserGoldAssets");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.SystemCashToGold", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("EarnedGoldWeight")
                        .HasColumnType("float");

                    b.Property<long>("GoldUnitPrice")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOver")
                        .HasColumnType("bit");

                    b.Property<long>("SpentCash")
                        .HasColumnType("bigint");

                    b.Property<long?>("TotalCash")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("SystemCashToGolds");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.SystemGoldToCash", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("EarnedCash")
                        .HasColumnType("bigint");

                    b.Property<double>("GoldWeight")
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOver")
                        .HasColumnType("bit");

                    b.Property<double>("SoldGoldWeight")
                        .HasColumnType("float");

                    b.Property<long>("TotalBoughtPrice")
                        .HasColumnType("bigint");

                    b.Property<long>("UnitSellPrice")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("SystemGoldToCashs");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.UserCashToGold", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("CashAmount")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<long?>("GoldUnitPrice")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPayed")
                        .HasColumnType("bit");

                    b.Property<string>("ToAppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("ToGoldAssetId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ToAppUserId");

                    b.HasIndex("ToGoldAssetId");

                    b.ToTable("UserCashGolds");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.UserGoldToCash", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("GoldAmount")
                        .HasColumnType("float");

                    b.Property<long?>("GoldUnitPrice")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPayed")
                        .HasColumnType("bit");

                    b.Property<string>("ToAppUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("ToGoldAssetId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ToAppUserId");

                    b.HasIndex("ToGoldAssetId");

                    b.ToTable("UserGoldCashs");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.UserSystemCashToGoldBill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("CashAmount")
                        .HasColumnType("bigint");

                    b.Property<double>("GoldAmount")
                        .HasColumnType("float");

                    b.Property<string>("ToSystemCashToGoldId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ToUserCashToGoldId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ToSystemCashToGoldId");

                    b.HasIndex("ToUserCashToGoldId");

                    b.ToTable("UserSystemCashToGoldBills");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.UserSystemGoldToCashBill", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<long>("CashAmount")
                        .HasColumnType("bigint");

                    b.Property<double>("GoldAmount")
                        .HasColumnType("float");

                    b.Property<string>("ToSystemGoldToCashId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ToUserGoldToCashId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ToSystemGoldToCashId");

                    b.HasIndex("ToUserGoldToCashId");

                    b.ToTable("UserSystemGoldToCashBills");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Product.GoldPrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("GoldPrices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2b81eabb-c2c9-4ca9-9d38-d03f2c9b5f93"),
                            DateTime = new DateTime(2023, 5, 10, 19, 34, 6, 967, DateTimeKind.Local).AddTicks(6974),
                            Price = 105000.0
                        });
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Product.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("769768db-d89e-461c-8437-45bc36caf848"),
                            Name = "Gold",
                            UnitName = "گرم"
                        });
                });

            modelBuilder.Entity("Gold.Core.Domain.IdentityEntities.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ad6151ed16984999b3ff121c5c0bfd96",
                            ConcurrencyStamp = "1",
                            Name = "MainAdmin",
                            NormalizedName = "MainAdmin"
                        });
                });

            modelBuilder.Entity("Gold.Core.Domain.IdentityEntities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PhoneNumber")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8c72dff883b3403e81dc7bf88ce26b8a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6f4e8945-64a3-44b2-9e95-6635e0d636c0",
                            CreatDateTime = new DateTime(2023, 5, 10, 19, 34, 6, 953, DateTimeKind.Local).AddTicks(8467),
                            EmailConfirmed = false,
                            FirstName = "Mahdi",
                            LastName = "Montazeri",
                            LockoutEnabled = false,
                            PhoneNumber = "09125850371",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "MainAdmin"
                        });
                });

            modelBuilder.Entity("Gold.Core.Domain.IdentityEntities.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Gold.Core.Domain.IdentityEntities.ApplicationUserRole", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            RoleId = "ad6151ed16984999b3ff121c5c0bfd96",
                            UserId = "8c72dff883b3403e81dc7bf88ce26b8a"
                        });
                });

            modelBuilder.Entity("ApplicationRoleClaim", b =>
                {
                    b.HasOne("Gold.Core.Domain.IdentityEntities.ApplicationRole", "Role")
                        .WithMany("RoleClaims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ApplicationUserLogin", b =>
                {
                    b.HasOne("Gold.Core.Domain.IdentityEntities.ApplicationUser", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApplicationUserToken", b =>
                {
                    b.HasOne("Gold.Core.Domain.IdentityEntities.ApplicationUser", "User")
                        .WithMany("Tokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Assets.UserGoldAsset", b =>
                {
                    b.HasOne("Gold.Core.Domain.IdentityEntities.ApplicationUser", "ToAppUser")
                        .WithMany()
                        .HasForeignKey("ToAppUserId");

                    b.Navigation("ToAppUser");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.UserCashToGold", b =>
                {
                    b.HasOne("Gold.Core.Domain.IdentityEntities.ApplicationUser", "ToAppUser")
                        .WithMany()
                        .HasForeignKey("ToAppUserId");

                    b.HasOne("Gold.Core.Domain.Entities.Assets.UserGoldAsset", "ToGoldAsset")
                        .WithMany("ToCashGolds")
                        .HasForeignKey("ToGoldAssetId");

                    b.Navigation("ToAppUser");

                    b.Navigation("ToGoldAsset");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.UserGoldToCash", b =>
                {
                    b.HasOne("Gold.Core.Domain.IdentityEntities.ApplicationUser", "ToAppUser")
                        .WithMany()
                        .HasForeignKey("ToAppUserId");

                    b.HasOne("Gold.Core.Domain.Entities.Assets.UserGoldAsset", "ToGoldAsset")
                        .WithMany("ToGoldCashs")
                        .HasForeignKey("ToGoldAssetId");

                    b.Navigation("ToAppUser");

                    b.Navigation("ToGoldAsset");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.UserSystemCashToGoldBill", b =>
                {
                    b.HasOne("Gold.Core.Domain.Entities.Finance.SystemCashToGold", "ToSystemCashToGold")
                        .WithMany("ToUserSystemCashToGoldBills")
                        .HasForeignKey("ToSystemCashToGoldId");

                    b.HasOne("Gold.Core.Domain.Entities.Finance.UserCashToGold", "ToUserCashToGold")
                        .WithMany("To2UserSystemCashToGoldBills")
                        .HasForeignKey("ToUserCashToGoldId");

                    b.Navigation("ToSystemCashToGold");

                    b.Navigation("ToUserCashToGold");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.UserSystemGoldToCashBill", b =>
                {
                    b.HasOne("Gold.Core.Domain.Entities.Finance.SystemGoldToCash", "ToSystemGoldToCash")
                        .WithMany("ToUserSystemGoldToCashBills")
                        .HasForeignKey("ToSystemGoldToCashId");

                    b.HasOne("Gold.Core.Domain.Entities.Finance.UserGoldToCash", "ToUserGoldToCash")
                        .WithMany("To2UserSystemGoldToCashBills")
                        .HasForeignKey("ToUserGoldToCashId");

                    b.Navigation("ToSystemGoldToCash");

                    b.Navigation("ToUserGoldToCash");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Product.GoldPrice", b =>
                {
                    b.HasOne("Gold.Core.Domain.Entities.Product.Product", null)
                        .WithMany("ToGoldPrices")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Gold.Core.Domain.IdentityEntities.ApplicationUserClaim", b =>
                {
                    b.HasOne("Gold.Core.Domain.IdentityEntities.ApplicationUser", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gold.Core.Domain.IdentityEntities.ApplicationUserRole", b =>
                {
                    b.HasOne("Gold.Core.Domain.IdentityEntities.ApplicationRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gold.Core.Domain.IdentityEntities.ApplicationUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Assets.UserGoldAsset", b =>
                {
                    b.Navigation("ToCashGolds");

                    b.Navigation("ToGoldCashs");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.SystemCashToGold", b =>
                {
                    b.Navigation("ToUserSystemCashToGoldBills");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.SystemGoldToCash", b =>
                {
                    b.Navigation("ToUserSystemGoldToCashBills");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.UserCashToGold", b =>
                {
                    b.Navigation("To2UserSystemCashToGoldBills");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Finance.UserGoldToCash", b =>
                {
                    b.Navigation("To2UserSystemGoldToCashBills");
                });

            modelBuilder.Entity("Gold.Core.Domain.Entities.Product.Product", b =>
                {
                    b.Navigation("ToGoldPrices");
                });

            modelBuilder.Entity("Gold.Core.Domain.IdentityEntities.ApplicationRole", b =>
                {
                    b.Navigation("RoleClaims");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Gold.Core.Domain.IdentityEntities.ApplicationUser", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Logins");

                    b.Navigation("Tokens");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
