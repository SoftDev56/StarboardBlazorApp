﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarboardNFT.Data;

namespace StarboardNFT.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210814012630_CreateFollowNFT")]
    partial class CreateFollowNFT
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StarboardNFT.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
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
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("StarboardNFT.Models.Auction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("CurrentBidPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("CurrentWinningUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("IncrementAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsAuctionOver")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFiveMinuteNotify")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReserveMet")
                        .HasColumnType("bit");

                    b.Property<decimal>("MaxBidPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ModifiedDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NFTDataId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CurrentWinningUserId");

                    b.HasIndex("NFTDataId");

                    b.ToTable("Auction");
                });

            modelBuilder.Entity("StarboardNFT.Models.AuctionBid", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid>("AuctionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("BidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BidStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("BidUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("EthBidAmount")
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal>("EthMaxBidAmount")
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal>("FiatBidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FiatMaxBidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsAutoBid")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBuyItNow")
                        .HasColumnType("bit");

                    b.Property<decimal>("MaxBidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ModifiedDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId");

                    b.HasIndex("BidUserId");

                    b.ToTable("AuctionBid");
                });

            modelBuilder.Entity("StarboardNFT.Models.AuctionBidQueue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<Guid>("AuctionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("BidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("BidUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<long>("CreateTimeInTicks")
                        .HasColumnType("bigint");

                    b.Property<decimal>("EthBidAmount")
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal>("EthMaxBidAmount")
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal>("FiatBidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FiatMaxBidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsAutoBid")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBuyItNow")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProcessed")
                        .HasColumnType("bit");

                    b.Property<decimal>("MaxBidAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ModifiedDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId");

                    b.HasIndex("BidUserId");

                    b.ToTable("AuctionBidQueue");
                });

            modelBuilder.Entity("StarboardNFT.Models.FollowNFT", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NFTDataId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("NFTDataId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("FollowNFT");
                });

            modelBuilder.Entity("StarboardNFT.Models.NFT", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FileContent")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId");

                    b.ToTable("NFT");
                });

            modelBuilder.Entity("StarboardNFT.Models.NFTData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("EthPurchaseAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("EthPurchaseAmount")
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal>("FiatBuyOutPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FiatReservePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("FiatStartPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("HasBuyoutPrice")
                        .HasColumnType("bit");

                    b.Property<bool>("HasReservePrice")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSaleEnded")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSaleStarted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NFTId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Royalty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("SaleEndtDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("SalePurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("SaleStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("USDPurchaseAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("NFTId");

                    b.ToTable("NFTData");
                });

            modelBuilder.Entity("StarboardNFT.Models.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NFTDataId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserProfileHeaderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("NFTDataId");

                    b.HasIndex("UserProfileHeaderId");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("StarboardNFT.Models.RecentViewNFT", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("NFTDataId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("NFTDataId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("RecentViewNFT");
                });

            modelBuilder.Entity("StarboardNFT.Models.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsBanNeeded")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNFTRemoved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReportedClosed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReportDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("ReportReason")
                        .HasColumnType("int");

                    b.Property<Guid>("ReportedUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReporterEmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReportedUserId");

                    b.ToTable("Report");
                });

            modelBuilder.Entity("StarboardNFT.Models.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("EthAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserProfileHeaderId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileHeaderId");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("StarboardNFT.Models.UserProfileHeader", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("AccountFreeze")
                        .HasColumnType("bit");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailNotification")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("FreezeTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SubscribedNewsletter")
                        .HasColumnType("bit");

                    b.Property<bool>("TermsAgree")
                        .HasColumnType("bit");

                    b.Property<byte[]>("UserBanner")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserOverview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("UserPhoto")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("UserSkills")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserProfileHeader");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("StarboardNFT.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("StarboardNFT.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StarboardNFT.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("StarboardNFT.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StarboardNFT.Models.Auction", b =>
                {
                    b.HasOne("StarboardNFT.Models.UserProfileHeader", "UserProfileHeader")
                        .WithMany()
                        .HasForeignKey("CurrentWinningUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StarboardNFT.Models.NFTData", "NFTData")
                        .WithMany()
                        .HasForeignKey("NFTDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NFTData");

                    b.Navigation("UserProfileHeader");
                });

            modelBuilder.Entity("StarboardNFT.Models.AuctionBid", b =>
                {
                    b.HasOne("StarboardNFT.Models.Auction", "Auction")
                        .WithMany("AuctionBids")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StarboardNFT.Models.UserProfileHeader", "UserProfileHeader")
                        .WithMany()
                        .HasForeignKey("BidUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("UserProfileHeader");
                });

            modelBuilder.Entity("StarboardNFT.Models.AuctionBidQueue", b =>
                {
                    b.HasOne("StarboardNFT.Models.Auction", "Auction")
                        .WithMany()
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StarboardNFT.Models.UserProfileHeader", "UserProfileHeader")
                        .WithMany()
                        .HasForeignKey("BidUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("UserProfileHeader");
                });

            modelBuilder.Entity("StarboardNFT.Models.FollowNFT", b =>
                {
                    b.HasOne("StarboardNFT.Models.NFTData", "NFTData")
                        .WithMany()
                        .HasForeignKey("NFTDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StarboardNFT.Models.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NFTData");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("StarboardNFT.Models.NFT", b =>
                {
                    b.HasOne("StarboardNFT.Models.UserProfile", "UserProfile")
                        .WithMany("NFTs")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("StarboardNFT.Models.NFTData", b =>
                {
                    b.HasOne("StarboardNFT.Models.NFT", "NFT")
                        .WithMany()
                        .HasForeignKey("NFTId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NFT");
                });

            modelBuilder.Entity("StarboardNFT.Models.Notification", b =>
                {
                    b.HasOne("StarboardNFT.Models.NFTData", "NFTData")
                        .WithMany()
                        .HasForeignKey("NFTDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StarboardNFT.Models.UserProfileHeader", "UserProfileHeader")
                        .WithMany()
                        .HasForeignKey("UserProfileHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NFTData");

                    b.Navigation("UserProfileHeader");
                });

            modelBuilder.Entity("StarboardNFT.Models.RecentViewNFT", b =>
                {
                    b.HasOne("StarboardNFT.Models.NFTData", "NFTData")
                        .WithMany()
                        .HasForeignKey("NFTDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StarboardNFT.Models.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NFTData");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("StarboardNFT.Models.Report", b =>
                {
                    b.HasOne("StarboardNFT.Models.UserProfileHeader", "UserProfileHeader")
                        .WithMany()
                        .HasForeignKey("ReportedUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfileHeader");
                });

            modelBuilder.Entity("StarboardNFT.Models.UserProfile", b =>
                {
                    b.HasOne("StarboardNFT.Models.UserProfileHeader", "UserProfileHeader")
                        .WithMany("UserProfiles")
                        .HasForeignKey("UserProfileHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfileHeader");
                });

            modelBuilder.Entity("StarboardNFT.Models.Auction", b =>
                {
                    b.Navigation("AuctionBids");
                });

            modelBuilder.Entity("StarboardNFT.Models.UserProfile", b =>
                {
                    b.Navigation("NFTs");
                });

            modelBuilder.Entity("StarboardNFT.Models.UserProfileHeader", b =>
                {
                    b.Navigation("UserProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
