﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finalMVC.Models;

#nullable disable

namespace finalMVC.Migrations
{
    [DbContext(typeof(SchoolCoreDBContext))]
    [Migration("20230608065114_third")]
    partial class third
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("finalMVC.Models.Apprenant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("NomComplet")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("ID");

                    b.ToTable("Apprenant", (string)null);
                });

            modelBuilder.Entity("finalMVC.Models.Filiere", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int>("sectionID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("sectionID");

                    b.ToTable("Filiere", (string)null);
                });

            modelBuilder.Entity("finalMVC.Models.Formation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Dateformation")
                        .HasMaxLength(128)
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Lieu")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("ThumbnailPath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int>("sectionID")
                        .HasColumnType("int");

                    b.HasKey("ID")
                        .HasName("PK_Formation");

                    b.HasIndex("sectionID");

                    b.ToTable("Formation", (string)null);
                });

            modelBuilder.Entity("finalMVC.Models.Matiere", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int>("filiereID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("filiereID");

                    b.ToTable("Matiere", (string)null);
                });

            modelBuilder.Entity("finalMVC.Models.Preinscription", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("apprenantID")
                        .HasColumnType("int");

                    b.Property<DateTime>("datepreinscription")
                        .HasMaxLength(128)
                        .HasColumnType("datetime(6)");

                    b.Property<int>("formationID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("apprenantID");

                    b.HasIndex("formationID");

                    b.ToTable("Preinscription", (string)null);
                });

            modelBuilder.Entity("finalMVC.Models.Section", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ThumbnailPath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("ID");

                    b.ToTable("Section", (string)null);
                });

            modelBuilder.Entity("finalMVC.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("NomComplet")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("ID");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("finalMVC.Models.Visiteur", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Datevisite")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("IPaddress")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("ID");

                    b.ToTable("Visiteur", (string)null);
                });

            modelBuilder.Entity("finalMVC.Models.Filiere", b =>
                {
                    b.HasOne("finalMVC.Models.Section", "section")
                        .WithMany()
                        .HasForeignKey("sectionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("section");
                });

            modelBuilder.Entity("finalMVC.Models.Formation", b =>
                {
                    b.HasOne("finalMVC.Models.Section", "section")
                        .WithMany()
                        .HasForeignKey("sectionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("section");
                });

            modelBuilder.Entity("finalMVC.Models.Matiere", b =>
                {
                    b.HasOne("finalMVC.Models.Filiere", "filiere")
                        .WithMany()
                        .HasForeignKey("filiereID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("filiere");
                });

            modelBuilder.Entity("finalMVC.Models.Preinscription", b =>
                {
                    b.HasOne("finalMVC.Models.Apprenant", "apprenant")
                        .WithMany()
                        .HasForeignKey("apprenantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("finalMVC.Models.Formation", "formation")
                        .WithMany()
                        .HasForeignKey("formationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("apprenant");

                    b.Navigation("formation");
                });
#pragma warning restore 612, 618
        }
    }
}
