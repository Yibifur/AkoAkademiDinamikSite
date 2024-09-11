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
        
        public DbSet<Page> Pages { get; set; }
        
        public DbSet<Layout> Layouts { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<FormElement> FormElements { get; set; }
        public DbSet<FormOption> FormOptions { get; set; }
        public DbSet<FormAnswer> FormAnswers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Form ile FormAnswer arasındaki ilişki
            modelBuilder.Entity<FormAnswer>()
                .HasOne(fa => fa.Form)
                .WithMany(f => f.FormAnswers)
                .HasForeignKey(fa => fa.FormId)
                .OnDelete(DeleteBehavior.NoAction); // Silme davranışını düzenledik

            // FormElement ile FormAnswer arasındaki bire bir ilişki
            //modelBuilder.Entity<FormAnswer>()
            //    .HasOne(fa => fa.FormElement)
            //    .WithOne() // FormElement üzerinde karşılık gelen bir koleksiyon veya navigasyon özelliği yok
            //    .HasForeignKey<FormAnswer>(fa => fa.FormElementId)
            //    .OnDelete(DeleteBehavior.NoAction); // Silme davranışını düzenledik
        }





    }
}
