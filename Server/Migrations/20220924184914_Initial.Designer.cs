﻿// <auto-generated />
using System;
using CrudAssessment.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrudAssessment.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220924184914_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CrudAssessment.Shared.Models.UserInfo", b =>
                {
                    b.Property<int>("UserPk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserPk"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("CreationDate")
                        .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                    b.Property<long>("CreationDateStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("CreationTimeStamp")
                        .HasDefaultValueSql("(CONVERT([bigint],(0)))");

                    b.Property<int>("DeleteBy")
                        .HasColumnType("int")
                        .HasColumnName("DeleteBy");

                    b.Property<DateTime?>("DeleteDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("DeleteDate")
                        .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                    b.Property<long>("DeleteDateStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("DeleteDateStamp")
                        .HasDefaultValueSql("(CONVERT([bigint],(0)))");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Password");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("PasswordHash");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("PhoneNumber");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdateDate")
                        .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                    b.Property<long>("UpdateDateStamp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("UpdateDateStamp")
                        .HasDefaultValueSql("(CONVERT([bigint],(0)))");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("UserName");

                    b.HasKey("UserPk");

                    b.ToTable("Users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}