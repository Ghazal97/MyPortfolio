﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
   public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            //modelBuilder.Entity<PortfolioItem>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            // seed data 
            modelBuilder.Entity<Owner>().HasData(
            
                new Owner
                {
                    Id = 1,
                    FullName = "Ghazal Daoun",
                    Avatar = "avatar.jpg",
                    Portfolio = ".NET Back_End Developer"
                }
            
            );
        }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<PortfolioItem> PortfolioItems { get; set; }
    }
}