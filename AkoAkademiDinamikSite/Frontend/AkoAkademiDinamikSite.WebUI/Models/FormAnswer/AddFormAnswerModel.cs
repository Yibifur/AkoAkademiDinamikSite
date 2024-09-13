namespace AkoAkademiDinamikSite.WebUI.Models.FormAnswer
{
    public class AddFormAnswerModel
    {
        public int FormAnswerId { get; set; }
        public int FormId { get; set; }
        
        public int FormElementId { get; set; }
        
        public string Value { get; set; }
    }
}
