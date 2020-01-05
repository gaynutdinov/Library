using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Library__MVC_.Models;
using Microsoft.EntityFrameworkCore;

namespace Library__MVC_.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Books");
            modelBuilder.Entity<Author>().ToTable("Authors");
            modelBuilder.Entity<Publisher>().ToTable("Publishers");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollments");
        }
    }
}