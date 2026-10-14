using System;
using Microsoft.EntityFrameworkCore;
using DemirbasApp.Models;

namespace DemirbasApp.Data
{
    public class UygulamaDbContext : DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options)
        {
        }

        public DbSet<Cihaz> Cihazlar { get; set; } = null!;
        public DbSet<Zimmet> Zimmetler { get; set; } = null!;
    }
}