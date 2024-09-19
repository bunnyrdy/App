﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.DataAccess.Data;

#nullable disable

namespace Web.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240919074814_Productstoadd")]
    partial class Productstoadd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Web.Models.Models.Category", b =>
                {
                    b.Property<int>("Category_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Category_Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Category_Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Category_Id = 1,
                            DisplayOrder = 1,
                            Name = "action"
                        },
                        new
                        {
                            Category_Id = 2,
                            DisplayOrder = 2,
                            Name = "scifi"
                        },
                        new
                        {
                            Category_Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("Web.Models.Models.Product", b =>
                {
                    b.Property<int>("Product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Product_Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("ListPrice")
                        .HasColumnType("double");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<double>("Price100")
                        .HasColumnType("double");

                    b.Property<double>("Price50")
                        .HasColumnType("double");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Product_Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Product_Id = 1,
                            Author = "Vyasadu",
                            Description = "King of Books",
                            ISBN = "MB123456",
                            ListPrice = 400.0,
                            Price = 0.0,
                            Price100 = 200.0,
                            Price50 = 300.0,
                            Title = "Mahabarath"
                        },
                        new
                        {
                            Product_Id = 2,
                            Author = "Vyasudu",
                            Description = "Teaches the way of life",
                            ISBN = "BG3431234",
                            ListPrice = 300.0,
                            Price = 0.0,
                            Price100 = 150.0,
                            Price50 = 200.0,
                            Title = "BagavithGetha"
                        },
                        new
                        {
                            Product_Id = 3,
                            Author = "Chethan Bagath",
                            Description = "The the life of the indian girl",
                            ISBN = "IG8493793",
                            ListPrice = 100.0,
                            Price = 0.0,
                            Price100 = 50.0,
                            Price50 = 70.0,
                            Title = "One indian girl"
                        },
                        new
                        {
                            Product_Id = 4,
                            Author = "Bagath",
                            Description = "love story",
                            ISBN = "HG53827283",
                            ListPrice = 150.0,
                            Price = 0.0,
                            Price100 = 80.0,
                            Price50 = 100.0,
                            Title = "Half girlfriend"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
