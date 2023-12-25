﻿// <auto-generated />
using System;
using Diary.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Diary.Migrations
{
    [DbContext(typeof(DiaryDatabase))]
    [Migration("20231225002019_Changes in DiaryModel.")]
    partial class ChangesinDiaryModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Diary.Models.DiaryModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaryData")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PostStamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Diaries");
                });
#pragma warning restore 612, 618
        }
    }
}