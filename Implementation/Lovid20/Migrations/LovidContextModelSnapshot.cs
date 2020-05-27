﻿// <auto-generated />
using System;
using Lovid20.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lovid20.Migrations
{
    [DbContext(typeof(LovidContext))]
    partial class LovidContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lovid20.Models.AdministratorDB", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("Lovid20.Models.ChatDB", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("id");

                    b.ToTable("Chat");
                });

            modelBuilder.Entity("Lovid20.Models.KorisnikUChatu", b =>
                {
                    b.Property<int>("chatID")
                        .HasColumnType("int");

                    b.Property<int>("korisnikID")
                        .HasColumnType("int");

                    b.HasIndex("chatID");

                    b.HasIndex("korisnikID");

                    b.ToTable("KorisnikUChatu");
                });

            modelBuilder.Entity("Lovid20.Models.PorukaDB", b =>
                {
                    b.Property<int>("chatID")
                        .HasColumnType("int");

                    b.Property<DateTime>("datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("tekst")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("chatID");

                    b.ToTable("Poruka");
                });

            modelBuilder.Entity("Lovid20.Models.Pratitelji", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<int>("pratitelji")
                        .HasColumnType("int");

                    b.ToTable("Pratitelji");
                });

            modelBuilder.Entity("Lovid20.Models.PrijavaDB", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datum")
                        .HasColumnType("datetime2");

                    b.Property<string>("razlog")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Prijava");
                });

            modelBuilder.Entity("Lovid20.Models.RecenzijaDB", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("korisnik")
                        .HasColumnType("int");

                    b.Property<int>("ocjena")
                        .HasColumnType("int");

                    b.Property<string>("tekst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("korisnik")
                        .IsUnique();

                    b.ToTable("Recenzija");
                });

            modelBuilder.Entity("Lovid20.Models.RegistrovaniKorisnikDB", b =>
                {
                    b.Property<int?>("id")
                        .HasColumnType("int");

                    b.Property<string>("biografija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("drzava")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("grad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idKorisnika")
                        .HasColumnType("int");

                    b.Property<string>("ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("pratitelji")
                        .HasColumnType("int");

                    b.Property<string>("prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("spol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stanje")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("trajanjeVIP")
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("RegistrovaniKorisnik");
                });

            modelBuilder.Entity("Lovid20.Models.TipKorisnika", b =>
                {
                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<string>("naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TipKorisnika");
                });

            modelBuilder.Entity("Lovid20.Models.KorisnikUChatu", b =>
                {
                    b.HasOne("Lovid20.Models.ChatDB", "Chat")
                        .WithMany()
                        .HasForeignKey("chatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lovid20.Models.RegistrovaniKorisnikDB", "Korisnik")
                        .WithMany()
                        .HasForeignKey("korisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lovid20.Models.PorukaDB", b =>
                {
                    b.HasOne("Lovid20.Models.ChatDB", "Chat")
                        .WithMany()
                        .HasForeignKey("chatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lovid20.Models.RecenzijaDB", b =>
                {
                    b.HasOne("Lovid20.Models.RegistrovaniKorisnikDB", "Korisnik")
                        .WithOne("Recenzija")
                        .HasForeignKey("Lovid20.Models.RecenzijaDB", "korisnik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lovid20.Models.RegistrovaniKorisnikDB", b =>
                {
                    b.HasOne("Lovid20.Models.PrijavaDB", "Prijava")
                        .WithMany("Korisnici")
                        .HasForeignKey("id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lovid20.Models.TipKorisnika", b =>
                {
                    b.HasOne("Lovid20.Models.RegistrovaniKorisnikDB", "Korisnik")
                        .WithOne("Tip")
                        .HasForeignKey("Lovid20.Models.TipKorisnika", "id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
