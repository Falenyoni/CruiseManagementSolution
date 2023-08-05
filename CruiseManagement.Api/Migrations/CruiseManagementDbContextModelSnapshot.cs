﻿// <auto-generated />
using CruiseManagement.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CruiseManagement.Api.Migrations
{
    [DbContext(typeof(CruiseManagementDbContext))]
    partial class CruiseManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CruiseManagement.Api.Entities.AgentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AgentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Company"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Walk-In"
                        });
                });

            modelBuilder.Entity("CruiseManagement.Api.Entities.BookingAgent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AgentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AgentTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BookingAgents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AgentName = "Shearwater Adventures",
                            AgentTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            AgentName = "Veneto",
                            AgentTypeId = 2
                        });
                });

            modelBuilder.Entity("CruiseManagement.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A kit provided by Glossier, containing skin care, hair care and makeup products",
                            Name = "Ra Ikani",
                            Price = 100m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "A kit provided by Curology, containing skin care products",
                            Name = "River Odyssey",
                            Price = 50m
                        });
                });

            modelBuilder.Entity("CruiseManagement.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cruise"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tours"
                        });
                });

            modelBuilder.Entity("CruiseManagement.Api.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AgentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AgentId = 1,
                            FirstName = "Bongani",
                            LastName = "Nyoni",
                            MiddleName = "Fale",
                            Notes = "",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AgentId = 2,
                            FirstName = "Test 2",
                            LastName = "Test",
                            MiddleName = "Test",
                            Notes = "",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("CruiseManagement.Api.Entities.ReservationItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AdultPax")
                        .HasColumnType("int");

                    b.Property<int>("AdultPrice")
                        .HasColumnType("int");

                    b.Property<int>("ChildPax")
                        .HasColumnType("int");

                    b.Property<int>("ChildPrice")
                        .HasColumnType("int");

                    b.Property<int>("CompPax")
                        .HasColumnType("int");

                    b.Property<int>("CompPrice")
                        .HasColumnType("int");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PickupPoint")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<bool>("Travelled")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ReservationItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdultPax = 3,
                            AdultPrice = 40,
                            ChildPax = 2,
                            ChildPrice = 20,
                            CompPax = 1,
                            CompPrice = 16,
                            Destination = "Cruise",
                            PickupPoint = "Elephant Hills Hotel",
                            ProductId = 2,
                            ReservationId = 1,
                            Travelled = false
                        },
                        new
                        {
                            Id = 2,
                            AdultPax = 10,
                            AdultPrice = 60,
                            ChildPax = 5,
                            ChildPrice = 50,
                            CompPax = 4,
                            CompPrice = 30,
                            Destination = "Cruise",
                            PickupPoint = "Elephant Hills Hotel",
                            ProductId = 1,
                            ReservationId = 2,
                            Travelled = false
                        });
                });

            modelBuilder.Entity("CruiseManagement.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Emily"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Bongani"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
