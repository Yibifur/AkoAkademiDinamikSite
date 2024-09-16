using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.BusinessLayer.Abstract
{
    public interface IFormAnswerService : IGenericService<FormAnswer>
    {
        List<FormAnswer> TGetAllFormAnswersByFormElementId(int formElementId);
    }
}
