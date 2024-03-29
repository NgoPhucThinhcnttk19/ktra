﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication9.Data;

#nullable disable

namespace WebApplication9.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240329081719_AddInitial")]
    partial class AddInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication9.Models.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"),
                            DateOfBirth = new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "J.K. Rowling"
                        },
                        new
                        {
                            Id = new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd"),
                            DateOfBirth = new DateTime(1952, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Walter Isaacson"
                        });
                });

            modelBuilder.Entity("WebApplication9.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subtitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("98474b8e-d713-401e-8aee-acb7353f97bb"),
                            AuthorId = new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"),
                            Description = "Harry Potter's life is miserable. His parents are dead and he's stuck with his heartless relatives, who force him to live in a tiny closet under the stairs.",
                            Genre = 0,
                            ISBN = "978-0439708180",
                            Publisher = "Scholastic; 1st Scholastic Td Ppbk Print., Sept.1999 edition (September 1, 1998)",
                            Rating = 5.0,
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Harry Potter and the Sorcerer's Stone"
                        },
                        new
                        {
                            Id = new Guid("bfe902af-3cf0-4a1c-8a83-66be60b028ba"),
                            AuthorId = new Guid("90d10994-3bdd-4ca2-a178-6a35fd653c59"),
                            Description = "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous that all Harry wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. ",
                            Genre = 0,
                            ISBN = "978-0439064873",
                            Publisher = "Scholastic Paperbacks; Reprint edition (September 1, 2000)",
                            Rating = 5.0,
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Harry Potter and the Chamber of Secrets"
                        },
                        new
                        {
                            Id = new Guid("150c81c6-2458-466e-907a-2df11325e2b8"),
                            AuthorId = new Guid("6ebc3dbe-2e7b-4132-8c33-e089d47694cd"),
                            Description = "Walter Isaacson’s “enthralling” (The New Yorker) worldwide bestselling biography of Apple cofounder Steve Jobs.",
                            Genre = 25,
                            ISBN = "978-1451648539",
                            Publisher = "Simon & Schuster; 1st edition (October 24, 2011)",
                            Rating = 4.5,
                            ReleaseDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Steve Jobs"
                        });
                });

            modelBuilder.Entity("WebApplication9.Models.Book", b =>
                {
                    b.HasOne("WebApplication9.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("WebApplication9.Models.Author", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
