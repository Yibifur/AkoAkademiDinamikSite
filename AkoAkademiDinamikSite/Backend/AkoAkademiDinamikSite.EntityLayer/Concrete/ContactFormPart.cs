using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkoAkademiDinamikSite.EntityLayer.Concrete
{
    public class ContactFormPart
    {
        public int ContactFormId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string NameLabel { get; set; }
        public string NameSurname { get; set; }
        public string PhoneLabel { get; set; }
        public string Phone { get; set; }
        public string EmailLabel { get; set; }
        public string Email { get; set; }
        public string MessageLabel { get; set; }
        public string Message { get; set; }
    }
}
