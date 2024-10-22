﻿using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.DataAccessLayer.Abstract
{
    public interface IFormElementDal : IGenericDal<FormElement>
    {
        List<FormElement> GetAllFormElementsByFormId(int id);
    }
}
