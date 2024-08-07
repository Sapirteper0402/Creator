﻿// <auto-generated />
using System;
using FinalProject_SapirTeper_OfirEinhoren.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalProject_SapirTeper_OfirEinhoren.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220322104338_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("FinalProject_SapirTeper_OfirEinhoren.Shared.Entities.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlockID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Introduction")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rank")
                        .HasColumnType("TEXT");

                    b.Property<string>("SoftwareName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
