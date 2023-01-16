﻿// <auto-generated />
using CalendarFormula1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CalendarFormula1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230116142308_pretfix")]
    partial class pretfix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CalendarFormula1.Models.Cursa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategorieCircuit")
                        .HasColumnType("int");

                    b.Property<double>("DataCursa")
                        .HasColumnType("float");

                    b.Property<string>("Descriere")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeCursa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Pret")
                        .HasColumnType("float");

                    b.Property<int>("TaraId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TaraId");

                    b.ToTable("Cursaa");
                });

            modelBuilder.Entity("CalendarFormula1.Models.Piloti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Echipa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumarPilot")
                        .HasColumnType("int");

                    b.Property<string>("NumePilot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pilotii");
                });

            modelBuilder.Entity("CalendarFormula1.Models.Piloti_Cursa", b =>
                {
                    b.Property<int>("PilotiId")
                        .HasColumnType("int");

                    b.Property<int>("CursaId")
                        .HasColumnType("int");

                    b.HasKey("PilotiId", "CursaId");

                    b.HasIndex("CursaId");

                    b.ToTable("Pilotii_Cursaa");
                });

            modelBuilder.Entity("CalendarFormula1.Models.Tara", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NumeTara")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oras")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Taraa");
                });

            modelBuilder.Entity("CalendarFormula1.Models.Cursa", b =>
                {
                    b.HasOne("CalendarFormula1.Models.Tara", "Tara")
                        .WithMany("Cursaa")
                        .HasForeignKey("TaraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tara");
                });

            modelBuilder.Entity("CalendarFormula1.Models.Piloti_Cursa", b =>
                {
                    b.HasOne("CalendarFormula1.Models.Cursa", "Cursa")
                        .WithMany("Pilotii_Cursaa")
                        .HasForeignKey("CursaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CalendarFormula1.Models.Piloti", "Piloti")
                        .WithMany("Pilotii_Cursaa")
                        .HasForeignKey("PilotiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cursa");

                    b.Navigation("Piloti");
                });

            modelBuilder.Entity("CalendarFormula1.Models.Cursa", b =>
                {
                    b.Navigation("Pilotii_Cursaa");
                });

            modelBuilder.Entity("CalendarFormula1.Models.Piloti", b =>
                {
                    b.Navigation("Pilotii_Cursaa");
                });

            modelBuilder.Entity("CalendarFormula1.Models.Tara", b =>
                {
                    b.Navigation("Cursaa");
                });
#pragma warning restore 612, 618
        }
    }
}
