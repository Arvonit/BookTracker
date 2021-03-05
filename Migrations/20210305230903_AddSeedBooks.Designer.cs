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
    [Migration("20210305230903_AddSeedBooks")]
    partial class AddSeedBooks
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

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Mark Twain",
                            Isbn = "0142437174",
                            PublicationDate = new DateTime(1884, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Penguin Classics",
                            Title = "The Adventures of Huckleberry Finn"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Harper Lee",
                            Isbn = "0123456789",
                            PublicationDate = new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Harper Perennial Modern Classics",
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Charles Petzold",
                            Isbn = "9781572319950",
                            PublicationDate = new DateTime(1998, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Publisher = "Microsoft Press",
                            Title = "Programming Windows"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
