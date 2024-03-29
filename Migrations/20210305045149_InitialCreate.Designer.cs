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
    [Migration("20210305045149_InitialCreate")]
    partial class InitialCreate
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

                    b.Property<string>("Publisher")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("publisher");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("title");

                    b.Property<DateTime?>("YearPublished")
                        .HasColumnType("date")
                        .HasColumnName("year_published");

                    b.HasKey("Id")
                        .HasName("pk_books");

                    b.ToTable("books");
                });
#pragma warning restore 612, 618
        }
    }
}
