﻿using AkoAkademiDinamikSite.DataAccessLayer.Abstract;
using AkoAkademiDinamikSite.DataAccessLayer.Concrete;
using AkoAkademiDinamikSite.DataAccessLayer.Repositories;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DataAccessLayer.EntityFramework
{
    public class EfFormOptionDal : GenericRepository<FormOption>, IFormOptionDal
    {
        public EfFormOptionDal(AkoContext context) : base(context)
        {
        }
    }
}
