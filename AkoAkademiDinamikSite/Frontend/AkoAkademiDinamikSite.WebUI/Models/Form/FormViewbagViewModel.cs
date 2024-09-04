using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;

namespace AkoAkademiDinamikSite.WebUI.Models.Form
{
    public class FormViewbagViewModel
    {
        public int? FormId { get; set; }
        public string? Title { get; set; }
        public bool? ShowTitle { get; set; }
        public string? FormType { get; set; }
        public string? Description { get; set; }
        //public List<FormElement>? FormElements { get; set; }
       
    }
}
