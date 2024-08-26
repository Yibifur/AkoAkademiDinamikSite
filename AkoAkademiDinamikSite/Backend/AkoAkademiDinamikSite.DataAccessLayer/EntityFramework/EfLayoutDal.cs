using AkoAkademiDinamikSite.DataAccessLayer.Abstract;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.DataAccessLayer.Repositories;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DataAccessLayer.EntityFramework
{
    public class EfLayoutDal : GenericRepository<Layout>, ILayoutDal
    {
       private readonly  AkoContext _context;
        public EfLayoutDal(AkoContext context) : base(context)
        {
            _context = context;
        }

        public Layout GetDefaultlayout()
        {
            return _context.Set<Layout>().FirstOrDefault(l => l.IsDefault);
        }
    }
}
