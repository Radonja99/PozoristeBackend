﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PozoristeProjekat.Models;

namespace PozoristeProjekat.Migrations
{
    [DbContext(typeof(PozoristeContext))]
    [Migration("20220609200355_Cascade")]
    partial class Cascade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PozoristeProjekat.Models.Izvedba", b =>
                {
                    b.Property<Guid>("IzvedbaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BrojSlobodnihMesta")
                        .HasColumnType("int");

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumPrikazivanja")
                        .HasColumnType("datetime2");

                    b.Property<bool>("GostujucaPredstava")
                        .HasColumnType("bit");

                    b.Property<Guid?>("PredstavaID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SalaID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IzvedbaID");

                    b.HasIndex("PredstavaID");

                    b.HasIndex("SalaID");

                    b.ToTable("Izvedba");
                });

            modelBuilder.Entity("PozoristeProjekat.Models.Korisnik", b =>
                {
                    b.Property<Guid>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BrojRezervacija")
                        .HasColumnType("int");

                    b.Property<string>("ImeKorisnika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaKorisnika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrezimeKorisnika")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("KorisnikID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("PozoristeProjekat.Models.Pozoriste", b =>
                {
                    b.Property<Guid>("PozoristeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazivPozorista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UrednikID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PozoristeID");

                    b.HasIndex("UrednikID");

                    b.ToTable("Pozoriste");
                });

            modelBuilder.Entity("PozoristeProjekat.Models.Predstava", b =>
                {
                    b.Property<Guid>("PredstavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BrojIzvodjenja")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumPremijere")
                        .HasColumnType("datetime2");

                    b.Property<string>("NazivPredstave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zanr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PredstavaID");

                    b.ToTable("Predstava");
                });

            modelBuilder.Entity("PozoristeProjekat.Models.Rezervacija", b =>
                {
                    b.Property<Guid>("RezervacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BrojMesta")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumIstekaRezervacije")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumKreiranjaRezervacije")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IzvedbaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KorisnikID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Placeno")
                        .HasColumnType("bit");

                    b.Property<int>("UkupnaCenaRezervacije")
                        .HasColumnType("int");

                    b.HasKey("RezervacijaID");

                    b.HasIndex("IzvedbaID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("PozoristeProjekat.Models.Sala", b =>
                {
                    b.Property<Guid>("SalaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NazivSale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PozoristeID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UkupanBrojMesta")
                        .HasColumnType("int");

                    b.HasKey("SalaID");

                    b.HasIndex("PozoristeID");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("PozoristeProjekat.Models.Sediste", b =>
                {
                    b.Property<Guid>("SedisteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BrojReda")
                        .HasColumnType("int");

                    b.Property<int>("BrojSedista")
                        .HasColumnType("int");

                    b.Property<Guid?>("SalaID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Sektor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SedisteID");

                    b.HasIndex("SalaID");

                    b.ToTable("Sediste");
                });

            modelBuilder.Entity("PozoristeProjekat.Models.Urednik", b =>
                {
                    b.Property<Guid>("UrednikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImeUrednika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBGUrednika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoImeUrednika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaUrednika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrezimeUrednika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UrednikID");

                    b.ToTable("Urednik");
                });

            modelBuilder.Entity("PozoristeProjekat.Models.Izvedba", b =>
                {
                    b.HasOne("PozoristeProjekat.Models.Predstava", "Predstava")
                        .WithMany()
                        .HasForeignKey("PredstavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PozoristeProjekat.Models.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Predstava");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("PozoristeProjekat.Models.Pozoriste", b =>
                {
                    b.HasOne("PozoristeProjekat.Models.Urednik", "Urednik")
                        .WithMany()
                        .HasForeignKey("UrednikID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Urednik");
                });

            modelBuilder.Entity("PozoristeProjekat.Models.Rezervacija", b =>
                {
                    b.HasOne("PozoristeProjekat.Models.Izvedba", "Izvedba")
                        .WithMany()
                        .HasForeignKey("IzvedbaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PozoristeProjekat.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Izvedba");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("PozoristeProjekat.Models.Sala", b =>
                {
                    b.HasOne("PozoristeProjekat.Models.Pozoriste", "Pozoriste")
                        .WithMany()
                        .HasForeignKey("PozoristeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pozoriste");
                });

            modelBuilder.Entity("PozoristeProjekat.Models.Sediste", b =>
                {
                    b.HasOne("PozoristeProjekat.Models.Sala", "Sala")
                        .WithMany()
                        .HasForeignKey("SalaID");

                    b.Navigation("Sala");
                });
#pragma warning restore 612, 618
        }
    }
}
