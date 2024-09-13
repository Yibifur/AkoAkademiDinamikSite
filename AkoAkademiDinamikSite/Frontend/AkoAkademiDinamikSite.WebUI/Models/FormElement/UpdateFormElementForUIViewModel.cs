namespace AkoAkademiDinamikSite.WebUI.Models.FormElement
{
    public class UpdateFormElementForUIViewModel
    {
        public int FormElementId { get; set; }
        public string Title { get; set; }
        public bool IsRequired { get; set; }
        public int Order { get; set; }
    }
}
