﻿using Microsoft.EntityFrameworkCore;
using Siparis.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siparis.DAL.EF.Contexts
{
    public class SqlDbcontext : DbContext
    {
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategory> Kategoriler { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<SiparisMaster> SiparisMaster { get; set; }
        public DbSet<SiparisDetay> SiparisDetay { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=.;
                                        Database=SiparisYonetimi;
                                        User Id=sa;
                                        password=123");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Musteri>()
                .Property(p => p.MusteriKodu)
                .HasDefaultValue("0000")
                .HasMaxLength(50)
                .IsRequired(true);

            modelBuilder.Entity<Musteri>()
                .Property(p => p.Email)
                .HasMaxLength(80)
                .IsRequired(true);

            modelBuilder.Entity<Musteri>()
                .Property(p => p.Gsm)
                .HasDefaultValue("")
                .HasMaxLength(20);
        }


    }
}
