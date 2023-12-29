﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RGIS_WebApp;

#nullable disable

namespace RGIS_WebApp.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20231229180014_FIX2")]
    partial class FIX2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("ClassDiagramCODScout.Uporabnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Assists")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Deaths")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Geslo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsModerator")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPremium")
                        .HasColumnType("INTEGER");

                    b.Property<double>("KDR")
                        .HasColumnType("REAL");

                    b.Property<int>("Kills")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Losses")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Matches")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Wins")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("UporabnikDB");
                });
#pragma warning restore 612, 618
        }
    }
}
