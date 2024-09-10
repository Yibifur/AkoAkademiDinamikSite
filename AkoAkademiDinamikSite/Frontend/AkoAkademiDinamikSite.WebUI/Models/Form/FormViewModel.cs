namespace AkoAkademiDinamikSite.WebUI.Models.Form
{
    public class FormViewModel
    {
        public int FormId { get; set; }
        public string Title { get; set; }
        public bool ShowTitle { get; set; }
        public string FormType { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
