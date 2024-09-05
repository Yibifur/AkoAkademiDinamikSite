using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.BusinessLayer.Abstract
{
    public interface IFormOptionService : IGenericService<FormOption>
    {
        List<FormOption> TGetFormOptionsByFormElementId(int id);  
    }
}
