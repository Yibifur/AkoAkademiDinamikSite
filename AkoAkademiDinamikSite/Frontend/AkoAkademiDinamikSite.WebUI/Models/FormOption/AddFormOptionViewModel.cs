namespace AkoAkademiDinamikSite.WebUI.Models.FormOption
{
    public class AddFormOptionViewModel
    {

        public int FormElementId { get; set; }
        //ListeliSeçim
        public string? Name { get; set; }
        public string? Value { get; set; }
        public int? Order { get; set; }
    }
}
