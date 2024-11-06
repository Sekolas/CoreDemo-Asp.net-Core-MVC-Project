using EntityLayer.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-I0QS5ARU;initial Catalog=CoreDb;integrated Security=true;TrustServerCertificate=True");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mesajlar>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.WriterSender)
                .HasForeignKey(z => z.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Mesajlar>()
               .HasOne(x => x.ReceiverUser)
               .WithMany(y => y.WriterReceiver)
               .HasForeignKey(z => z.ReceiverId)
               .OnDelete(DeleteBehavior.ClientSetNull);
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRayting> BlogRaytings{ get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Mesajlar> Mesajlar { get; set; }








    }
}
