namespace AkoAkademiDinamikSite.WebUI.Models.FormOption
{
    public class FormOptionViewModel
    {
        public int FormOptionId { get; set; }
        public int FormElementId { get; set; }
        //ListeliSeçim
        public string? Name { get; set; }
        public string? Value { get; set; }
        public int? Order { get; set; }
        //public bool? IsSelected { get; set; } // Varsayılan olarak seçili olup olmadığını belirler
    }
}
