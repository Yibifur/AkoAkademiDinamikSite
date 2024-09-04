namespace AkoAkademiDinamikSite.WebUI.Models.FormOption
{
    public class UpdateFormOptionViewModel
    {
        public int FormElementId { get; set; }
        //ListeliSeçim
        public string? Name { get; set; }
        public string? Value { get; set; }
        public int? Order { get; set; }
    }
}
