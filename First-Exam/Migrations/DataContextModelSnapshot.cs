﻿// <auto-generated />
using System;
using First_Exam.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace First_Exam.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("First_Exam.Data.Entities.Entrance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Entrances");
                });

            modelBuilder.Entity("First_Exam.Data.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("EntranceId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("WasUsed")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EntranceId");

                    b.HasIndex("Id", "EntranceId")
                        .IsUnique()
                        .HasFilter("[EntranceId] IS NOT NULL");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("First_Exam.Data.Entities.Ticket", b =>
                {
                    b.HasOne("First_Exam.Data.Entities.Entrance", "Entrance")
                        .WithMany("tickets")
                        .HasForeignKey("EntranceId");

                    b.Navigation("Entrance");
                });

            modelBuilder.Entity("First_Exam.Data.Entities.Entrance", b =>
                {
                    b.Navigation("tickets");
                });
#pragma warning restore 612, 618
        }
    }
}