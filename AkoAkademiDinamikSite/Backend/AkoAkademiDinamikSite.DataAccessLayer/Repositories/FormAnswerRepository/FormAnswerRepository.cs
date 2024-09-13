using AkoAkademiDinamikSite.DataAccessLayer.Abstract;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DataAccessLayer.Repositories.FormAnswerRepository
{
    internal class FormAnswerRepository:IFormAnswerDal
    {
        private readonly AkoContext context;
        public FormAnswerRepository(AkoContext context)
        {
            this.context = context;
        }
        public void Delete(int id)
        {
            var values = context.FormAnswers.Find(id);
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), "Entity not found");
            }
            context.FormAnswers.Remove(values);
            context.SaveChanges();
        }

        public List<FormAnswer> GetAll()
        {
            var values = context.FormAnswers.Include(x => x.FormElements).ToList();
            return values;
        }

       

        public FormAnswer GetById(int id)
        {
            var value = context.FormAnswers.Include(x => x.FormElements).FirstOrDefault(x => x.FormAnswerId == id);
            return value;
        }

        public void Insert(FormAnswer entity)
        {
            context.FormAnswers.Add(entity);
            context.SaveChanges();
        }

        public void Update(FormAnswer entity)
        {
            context.FormAnswers.Update(entity);
            context.SaveChanges();
        }
    }
}
