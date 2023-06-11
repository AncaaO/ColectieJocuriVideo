using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ColectieJocuriVideo.Models;

namespace ColectieJocuriVideo.Data
{
    public class ColectieJocuriVideoContext : DbContext
    {
        public ColectieJocuriVideoContext (DbContextOptions<ColectieJocuriVideoContext> options)
            : base(options)
        {
        }

        public DbSet<ColectieJocuriVideo.Models.Review> Review { get; set; }
        public DbSet<ColectieJocuriVideo.Models.Game> Game { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().ToTable("Review");
            modelBuilder.Entity<Game>().ToTable("Game");
        }
    }
}
