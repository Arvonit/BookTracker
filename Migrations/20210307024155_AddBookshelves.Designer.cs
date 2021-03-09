﻿// <auto-generated />
using System;
using BookTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BookTracker.Migrations
{
    [DbContext(typeof(BookTrackerContext))]
    [Migration("20210307024155_AddBookshelves")]
    partial class AddBookshelves
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BookTracker.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Author")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("author");

                    b.Property<int>("BookshelfId")
                        .HasColumnType("integer")
                        .HasColumnName("bookshelf_id");

                    b.Property<string>("Isbn")
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)")
                        .HasColumnName("isbn");

                    b.Property<DateTime?>("PublicationDate")
                        .HasColumnType("date")
                        .HasColumnName("publication_date");

                    b.Property<string>("Publisher")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("publisher");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_books");

                    b.HasIndex("BookshelfId")
                        .HasDatabaseName("ix_books_bookshelf_id");

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Mark Twain",
                            BookshelfId = 1,
                            Isbn = "0142437174",
                            PublicationDate = new DateTime(1884, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Penguin Classics",
                            Title = "The Adventures of Huckleberry Finn"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Harper Lee",
                            BookshelfId = 2,
                            Isbn = "0123456789",
                            PublicationDate = new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Harper Perennial Modern Classics",
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Charles Petzold",
                            BookshelfId = 3,
                            Isbn = "9781572319950",
                            PublicationDate = new DateTime(1998, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Microsoft Press",
                            Title = "Programming Windows"
                        });
                });

            modelBuilder.Entity("BookTracker.Models.Bookshelf", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_bookshelves");

                    b.ToTable("bookshelves");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Want to Read"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Currently Reading"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Read"
                        });
                });

            modelBuilder.Entity("BookTracker.Models.Book", b =>
                {
                    b.HasOne("BookTracker.Models.Bookshelf", "Bookshelf")
                        .WithMany("Books")
                        .HasForeignKey("BookshelfId")
                        .HasConstraintName("fk_books_bookshelves_bookshelf_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bookshelf");
                });

            modelBuilder.Entity("BookTracker.Models.Bookshelf", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
