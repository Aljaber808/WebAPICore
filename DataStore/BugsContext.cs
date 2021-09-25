using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore
{
    public class BugsContext : DbContext
    {
       public BugsContext(DbContextOptions options) :base(options)
        {

        }
        public DbSet<Project> Projects { get; set; }
        public  DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Tickets)
                .WithOne(t => t.Project)
                .HasForeignKey(t => t.ProjectId);// this is for sql server only - inMemory will not work.

            //seeding
            modelBuilder.Entity<Project>().HasData(
                new Project { ProjectId = 1, Name ="Project 1"},
                new Project { ProjectId = 2, Name = "Project 2" }
                );

            modelBuilder.Entity<Ticket>().HasData(
                new Ticket {TicketId = 1, Title = "issue #1 for project 1" , ProjectId=1},
                new Ticket { TicketId = 2, Title = "issue #2 for project 2", ProjectId = 1 },
                new Ticket { TicketId = 3, Title = "issue #1 for project 1 ", ProjectId = 2 }
                );
        }
    }
}
