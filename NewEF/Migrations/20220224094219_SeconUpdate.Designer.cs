﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewEF.Data;

namespace NewEF.Migrations
{
    [DbContext(typeof(DbContexts))]
    [Migration("20220224094219_SeconUpdate")]
    partial class SeconUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewEF.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Moldava",
                            ShortName = "Md"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Moskva",
                            ShortName = "Ru"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Uzbekistan",
                            ShortName = "Uz"
                        });
                });

            modelBuilder.Entity("NewEF.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Raiting")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "ShriLanka",
                            CountryId = 1001100,
                            Name = "GlobalHotel",
                            Raiting = 7.0
                        },
                        new
                        {
                            Id = 2,
                            Country = "Bobil",
                            CountryId = 1001111,
                            Name = "WorldEnjoy",
                            Raiting = 2.0
                        },
                        new
                        {
                            Id = 3,
                            Country = "Rim",
                            CountryId = 1001111,
                            Name = "MoreMore",
                            Raiting = 1.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
