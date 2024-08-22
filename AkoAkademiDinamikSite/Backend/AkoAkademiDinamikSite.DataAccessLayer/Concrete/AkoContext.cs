using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DataAccessLayer.Concrete
{
    public class AkoContext:DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Trusted_Connection = True;TrustServerCertificate=True
            optionsBuilder.UseSqlServer(@"Server = YIGITMONSTER\SQLEXPRESS;initial catalog=AkoAkademikDb;integrated security=true");
        }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Page> Pages { get; set; }


        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

                modelBuilder.Entity<Page>()
                .HasOne(p => p.Content) // Page bir Content'e sahiptir
                .WithMany(c => c.Pages) // Content birden fazla Page'e sahip olabilir
                .HasForeignKey(p => p.ContentId) // Page üzerindeki foreign key ContentId'dir
                .OnDelete(DeleteBehavior.Cascade); // Eğer bir Content silinirse, ona bağlı tüm Page'ler de silinir

            base.OnModelCreating(modelBuilder);
            // Content ve Page arasındaki ilişkiyi tanımlama
             // Eğer bir Content silinirse, ona bağlı tüm Page'ler de silinir

            // Page ve ParentPage arasındaki self-referencing ilişkiyi tanımlama
            modelBuilder.Entity<Page>()
                .HasOne()
                .WithMany(p => p.ChildPages) // ParentPage birden fazla ChildPage'e sahip olabilir
                .HasForeignKey(p => p.ParentPageId) // Page üzerindeki foreign key ParentPageId'dir
                .OnDelete(DeleteBehavior.Restrict); // Eğer bir ParentPage silinirse, ChildPages silinmez

            // Diğer gerekli kurallar ve kısıtlamalar burada eklenebilir.
        }*/
    }
}
