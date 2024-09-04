using AkoAkademiDinamikSite.DataAccessLayer.Abstract;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.DataAccessLayer.Repositories;
using AkoAkademiDinamikSite.DataAccessLayer.Repositories.FormElementElementRepository;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DataAccessLayer.EntityFramework
{
    public class EfFormElementDal : FormElementRepository, IFormElementDal
    {
        public EfFormElementDal(AkoContext context) : base(context)
        {
        }
    }
}
