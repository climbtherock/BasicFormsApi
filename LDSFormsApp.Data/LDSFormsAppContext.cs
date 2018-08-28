using LDSFormsApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LDSFormsApp.Data
{
    public class LDSFormsAppContext : DbContext
    {
        public LDSFormsAppContext(DbContextOptions<LDSFormsAppContext> options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>()
                .HasMany(x => x.AgendaItems)
                .WithOne(x => x.Meeting)
                .HasForeignKey(x => x.MeetingId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public DbSet<AgendaItem> AgendaItems { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Member> Members { get; set; }
    }


}
