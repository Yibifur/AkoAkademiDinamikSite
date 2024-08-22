using AkoAkademiDinamikSite.DataAccessLayer.Abstract;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DataAccessLayer.Repositories
{
    
        public class GenericRepository<T> : IGenericDal<T> where T : class
        {
            private readonly AkoContext context;
            public GenericRepository(AkoContext context)
            {
                this.context = context;
            }

        public  void Delete(int id)
        {
            var values = context.Set<T>().Find(id);
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), "Entity not found");
            }
            context.Set<T>().Remove(values);
            context.SaveChanges();
        }

        public  List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public  T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public  void Insert(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public  void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
    }

