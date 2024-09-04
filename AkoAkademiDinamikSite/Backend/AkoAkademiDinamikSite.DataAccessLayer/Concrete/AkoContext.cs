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


        
    }
}
