﻿using AssistControl.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Sales.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet <Ticket> Tickets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasIndex(ticket => ticket.Id).IsUnique();
        }
    }
}
