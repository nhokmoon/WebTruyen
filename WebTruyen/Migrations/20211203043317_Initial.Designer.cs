﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTruyen.Models;

#nullable disable

namespace WebTruyen.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211203043317_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebTruyen.Models.Truyen", b =>
                {
                    b.Property<int>("TruyenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TruyenId"), 1L, 1);

                    b.Property<string>("ChuThich")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoChuong")
                        .HasColumnType("int");

                    b.Property<string>("TenTruyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TheLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TruyenId");

                    b.ToTable("Truyens");
                });
#pragma warning restore 612, 618
        }
    }
}