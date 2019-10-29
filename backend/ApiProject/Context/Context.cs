﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProject.Models;

namespace ApiProject.Context
{
    public class Context : DbContext
    {


        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=CoffeeTesting;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                    new Album(1, "East Atlanta Santa", "image", "label", 1));




            modelBuilder.Entity<Song>().HasData(
                    new Song(1, "Don't Count Me Out","link", "time", 1, 1));

            modelBuilder.Entity<Artist>().HasData(
                    new Artist(1, "Guccie Mane", "image"));
        }

            

    }

    }
        
