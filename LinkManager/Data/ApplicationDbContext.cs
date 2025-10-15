using LinkManager.Models;
using Microsoft.EntityFrameworkCore;

namespace LinkManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<DataItem> DataItems { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentList> DocumentLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DataItem>()
                .HasOne(d => d.DocumentList)
                .WithMany(dl => dl.DataItems)
                .HasForeignKey(d => d.DocumentListID);

            modelBuilder.Entity<Document>()
                .HasOne(d => d.DocumentList)
                .WithMany(dl => dl.Documents)
                .HasForeignKey(d => d.DocumentListID);
        }
    }
}