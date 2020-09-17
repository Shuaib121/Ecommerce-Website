﻿// <auto-generated />
using System;
using PROG7311_TASK2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace PROG7311_TASK2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("CountryId");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<double>("Charge");

                    b.Property<int>("CityId");

                    b.Property<string>("Latitude")
                        .HasMaxLength(100);

                    b.Property<string>("Longditude")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.Property<string>("Pram")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<double>("Rate");

                    b.Property<string>("Remarks")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("DeliveryAddress")
                        .HasMaxLength(200);

                    b.Property<double>("DeliveryCharge");

                    b.Property<int>("LocationId");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Number")
                        .HasMaxLength(100);

                    b.Property<double>("OthersCharge");

                    b.Property<int>("PaymentMethodId");

                    b.Property<double>("Total");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2020, 7, 30, 0, 50, 26, 294, DateTimeKind.Local));

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("OrderId");

                    b.Property<int>("StatusId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.HasIndex("StatusId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("OrderStatus");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<string>("Processor");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("BrandId");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Code")
                        .HasMaxLength(100);

                    b.Property<string>("Description");

                    b.Property<int>("Discount");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<double>("Price");

                    b.Property<string>("Tag")
                        .HasMaxLength(200);

                    b.Property<int>("UnitId");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UnitId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.ProductComments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Comment")
                        .HasMaxLength(200);

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.Property<string>("UserId");

                    b.Property<int?>("UsersId1");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.HasIndex("UsersId1");

                    b.ToTable("ProductComments");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("ImagePath");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.Property<string>("Title")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.ProductLikes", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<string>("UserId");

                    b.Property<DateTime>("AddedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2020, 7, 30, 0, 50, 26, 277, DateTimeKind.Local));

                    b.Property<string>("UsersId");

                    b.HasKey("ProductId", "UserId");

                    b.HasIndex("UsersId");

                    b.ToTable("ProductLikes");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.ProductManual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("ManualName");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductManual");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.ProductStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("InQuantity");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("OutQuantity");

                    b.Property<int>("ProductId");

                    b.Property<string>("Remarks")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductStock");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Level")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.UserLoginHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("IpAddress");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("UserId");

                    b.Property<int?>("UsersId");

                    b.Property<string>("UsersId1");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.HasIndex("UsersId1");

                    b.ToTable("UserLoginHistory");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Address");

                    b.Property<int>("CityId");

                    b.Property<string>("Contact");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<string>("JoinIp");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("UserType");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.ApplicationRoles", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Description");

                    b.Property<string>("IpAddress");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.ApplicationUsers", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<int?>("CityId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Contact");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Gender");

                    b.Property<string>("JoinIp");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Refference");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Category", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.Category", "Categoris")
                        .WithMany("CategoriesList")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.City", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Location", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.City", "City")
                        .WithMany("Locations")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.OrderDetails", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.Orders", "Orders")
                        .WithOne("OrderDetails")
                        .HasForeignKey("PROG7311_TASK2.Models.Admin.OrderDetails", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PROG7311_TASK2.Models.Admin.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Orders", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.Location", "Location")
                        .WithMany("Orderses")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PROG7311_TASK2.Models.Admin.PaymentMethod", "PaymentMethod")
                        .WithMany("Orderses")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PROG7311_TASK2.Models.ApplicationUsers", "Users")
                        .WithMany("Orderses")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.OrderStatus", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.Orders", "Orders")
                        .WithOne("OrderStatus")
                        .HasForeignKey("PROG7311_TASK2.Models.Admin.OrderStatus", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PROG7311_TASK2.Models.Admin.Status", "Status")
                        .WithOne("OrderStatus")
                        .HasForeignKey("PROG7311_TASK2.Models.Admin.OrderStatus", "StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PROG7311_TASK2.Models.ApplicationUsers", "Users")
                        .WithMany("OrderStatuses")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Product", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PROG7311_TASK2.Models.Admin.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PROG7311_TASK2.Models.Admin.Unit", "Unit")
                        .WithMany("Products")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.ProductComments", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.Product", "Product")
                        .WithMany("ProductCommentses")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PROG7311_TASK2.Models.ApplicationUsers", "Users")
                        .WithMany("ProductCommentses")
                        .HasForeignKey("UserId");

                    b.HasOne("PROG7311_TASK2.Models.Admin.Users")
                        .WithMany("ProductCommentses")
                        .HasForeignKey("UsersId1");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.ProductImage", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.ProductLikes", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PROG7311_TASK2.Models.ApplicationUsers", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.ProductManual", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.Product", "Product")
                        .WithOne("ProductManual")
                        .HasForeignKey("PROG7311_TASK2.Models.Admin.ProductManual", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.ProductStock", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.Product", "Product")
                        .WithMany("ProductStocks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.UserLoginHistory", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.Users")
                        .WithMany("UserLoginHistories")
                        .HasForeignKey("UsersId");

                    b.HasOne("PROG7311_TASK2.Models.ApplicationUsers", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId1");
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.Admin.Users", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PROG7311_TASK2.Models.ApplicationUsers", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.Admin.City", "City")
                        .WithMany("Users")
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.ApplicationRoles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.ApplicationRoles")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PROG7311_TASK2.Models.ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PROG7311_TASK2.Models.ApplicationUsers")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
