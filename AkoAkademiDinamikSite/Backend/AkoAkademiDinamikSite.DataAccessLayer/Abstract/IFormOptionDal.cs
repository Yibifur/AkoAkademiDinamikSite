﻿using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DataAccessLayer.Abstract
{
    public interface IFormOptionDal : IGenericDal<FormOption>
    {
        List<FormOption> GetFormOptionsByFormElementId(int id);
    }
}
