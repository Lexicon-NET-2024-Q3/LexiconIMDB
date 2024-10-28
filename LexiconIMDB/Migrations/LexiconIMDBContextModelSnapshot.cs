﻿// <auto-generated />
using System;
using LexiconIMDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LexiconIMDB.Migrations
{
    [DbContext(typeof(LexiconIMDBContext))]
    partial class LexiconIMDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LexiconIMDB.Models.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = 3,
                            Rating = 7.9f,
                            ReleaseDate = new DateTime(1997, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Titanic"
                        },
                        new
                        {
                            Id = 2,
                            Genre = 0,
                            Rating = 7.4f,
                            ReleaseDate = new DateTime(1997, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Scream"
                        },
                        new
                        {
                            Id = 3,
                            Genre = 0,
                            Rating = 8.4f,
                            ReleaseDate = new DateTime(1980, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = 4,
                            Genre = 4,
                            Rating = 7.6f,
                            ReleaseDate = new DateTime(2007, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "300"
                        },
                        new
                        {
                            Id = 5,
                            Genre = 3,
                            Rating = 8.7f,
                            ReleaseDate = new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Interstellar"
                        },
                        new
                        {
                            Id = 6,
                            Genre = 4,
                            Rating = 9.1f,
                            ReleaseDate = new DateTime(2008, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Dark Knight"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
