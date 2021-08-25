﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuranTinglaBot.Entity;

namespace QuranTinglaBot.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210823125924_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("QuranTinglaBot.Entity.Surah", b =>
                {
                    b.Property<string>("MessageId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ArabicName")
                        .HasColumnType("TEXT");

                    b.Property<string>("EnglishName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UzbekName")
                        .HasColumnType("TEXT");

                    b.HasKey("MessageId");

                    b.ToTable("Surahs");
                });
#pragma warning restore 612, 618
        }
    }
}
