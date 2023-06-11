﻿// <auto-generated />
using DepremTirProjesi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DepremTirProjesi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230522174641_proje2")]
    partial class proje2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DepremTirProjesi.Models.Gorevli", b =>
                {
                    b.Property<int>("GorevliId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GorevliId"));

                    b.Property<string>("GorevliAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GorevliKayitNo")
                        .HasColumnType("int");

                    b.Property<string>("GorevliSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GorevliYasi")
                        .HasColumnType("int");

                    b.HasKey("GorevliId");

                    b.ToTable("Gorevlis");
                });

            modelBuilder.Entity("DepremTirProjesi.Models.Ilce", b =>
                {
                    b.Property<int>("IlceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IlceId"));

                    b.Property<string>("IlceAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.HasKey("IlceId");

                    b.HasIndex("SehirId");

                    b.ToTable("Ilces");
                });

            modelBuilder.Entity("DepremTirProjesi.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriId"));

                    b.Property<string>("KategoriAciklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriId");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("DepremTirProjesi.Models.Malzeme", b =>
                {
                    b.Property<int>("MalzemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MalzemeId"));

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("MalzemeAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MalzemeStok")
                        .HasColumnType("int");

                    b.HasKey("MalzemeId");

                    b.HasIndex("KategoriId");

                    b.ToTable("Malzemes");
                });

            modelBuilder.Entity("DepremTirProjesi.Models.Sehir", b =>
                {
                    b.Property<int>("SehirId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SehirId"));

                    b.Property<string>("SehirAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SehirId");

                    b.ToTable("Sehirs");
                });

            modelBuilder.Entity("DepremTirProjesi.Models.TirİcerikBilgisi", b =>
                {
                    b.Property<int>("TirId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TirId"));

                    b.Property<int>("IlceId")
                        .HasColumnType("int");

                    b.Property<int>("MalzemeId")
                        .HasColumnType("int");

                    b.Property<int>("SehirId")
                        .HasColumnType("int");

                    b.Property<string>("TirPlaka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TirId");

                    b.HasIndex("IlceId");

                    b.HasIndex("MalzemeId");

                    b.HasIndex("SehirId");

                    b.ToTable("TirİcerikBilgisis");
                });

            modelBuilder.Entity("DepremTirProjesi.Models.Ilce", b =>
                {
                    b.HasOne("DepremTirProjesi.Models.Sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("DepremTirProjesi.Models.Malzeme", b =>
                {
                    b.HasOne("DepremTirProjesi.Models.Kategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("DepremTirProjesi.Models.TirİcerikBilgisi", b =>
                {
                    b.HasOne("DepremTirProjesi.Models.Ilce", "Ilce")
                        .WithMany()
                        .HasForeignKey("IlceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DepremTirProjesi.Models.Malzeme", "Malzeme")
                        .WithMany()
                        .HasForeignKey("MalzemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DepremTirProjesi.Models.Sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilce");

                    b.Navigation("Malzeme");

                    b.Navigation("Sehir");
                });
#pragma warning restore 612, 618
        }
    }
}
