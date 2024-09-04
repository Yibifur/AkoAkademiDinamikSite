using AkoAkademiDinamikSite.DataAccessLayer.Abstract;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DataAccessLayer.Repositories.FormRepository
{
    public class FormRepository : IFormDal
    {
        private readonly AkoContext context;
        public FormRepository(AkoContext context)
        {
            this.context = context;
        }
        public void Delete(int id)
        {
            var values = context.Forms.Find(id);
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), "Entity not found");
            }
            context.Forms.Remove(values);
            context.SaveChanges();
        }

        public List<Form> GetAll()
        {
            var values = context.Forms.Include(x=>x.FormElements).ThenInclude(x=>x.FormOptions).ToList();
            return values;
        }

        public Form GetById(int id)
        {
            var value = context.Forms.Include(x => x.FormElements).ThenInclude(x => x.FormOptions).FirstOrDefault(f => f.FormId == id); ;  
            return value;
        }

        public void Insert(Form entity)
        {
            context.Forms.Add(entity);
            context.SaveChanges();
        }

        public void Update(Form entity)
        {
            context.Forms.Update(entity);
            context.SaveChanges();
        }
    }
}
