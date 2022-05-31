﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using siparis.DAL.EF.Contexts;

namespace siparis.DAL.Migrations
{
    [DbContext(typeof(SqlDbcontext))]
    partial class SqlDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Siparis.Entity.Concrete.Kategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("Getdate()");

                    b.Property<string>("KategoriKodu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aciklama = "Elektronik",
                            CreateDate = new DateTime(2022, 5, 31, 12, 27, 35, 203, DateTimeKind.Local).AddTicks(1730),
                            KategoriKodu = "001",
                            Name = "Elektronik"
                        },
                        new
                        {
                            Id = 2,
                            Aciklama = "Bilgisayar",
                            CreateDate = new DateTime(2022, 5, 31, 12, 27, 35, 203, DateTimeKind.Local).AddTicks(2283),
                            KategoriKodu = "002",
                            Name = "Bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            Aciklama = "Cep Telefonu",
                            CreateDate = new DateTime(2022, 5, 31, 12, 27, 35, 203, DateTimeKind.Local).AddTicks(2286),
                            KategoriKodu = "003",
                            Name = "Cep Telefonu"
                        },
                        new
                        {
                            Id = 4,
                            Aciklama = "Beyaz Esya",
                            CreateDate = new DateTime(2022, 5, 31, 12, 27, 35, 203, DateTimeKind.Local).AddTicks(2289),
                            KategoriKodu = "004",
                            Name = "Beyaz Esya"
                        });
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gsm")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MusteriKodu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.SiparisDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Adet")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Indirim")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SiparisMasterId")
                        .HasColumnType("int");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SiparisMasterId");

                    b.HasIndex("UrunId");

                    b.ToTable("SiparisDetay");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.SiparisMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KategoryId")
                        .HasColumnType("int");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoryId");

                    b.HasIndex("MusteriId");

                    b.HasIndex("PersonelId");

                    b.ToTable("SiparisMaster");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunKodu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.SiparisDetay", b =>
                {
                    b.HasOne("Siparis.Entity.Concrete.SiparisMaster", "SiparisMaster")
                        .WithMany("SiparisDetay")
                        .HasForeignKey("SiparisMasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Siparis.Entity.Concrete.Urun", "Urun")
                        .WithMany()
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SiparisMaster");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.SiparisMaster", b =>
                {
                    b.HasOne("Siparis.Entity.Concrete.Kategory", null)
                        .WithMany("Siparisler")
                        .HasForeignKey("KategoryId");

                    b.HasOne("Siparis.Entity.Concrete.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Siparis.Entity.Concrete.Personel", "Personel")
                        .WithMany("Siparisler")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.Urun", b =>
                {
                    b.HasOne("Siparis.Entity.Concrete.Kategory", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.Kategory", b =>
                {
                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.Personel", b =>
                {
                    b.Navigation("Siparisler");
                });

            modelBuilder.Entity("Siparis.Entity.Concrete.SiparisMaster", b =>
                {
                    b.Navigation("SiparisDetay");
                });
#pragma warning restore 612, 618
        }
    }
}