namespace AkoAkademiDinamikSite.WebUI.Models.Layout
{
    public class UpdateLayoutViewModel
    {
        public int LayoutId { get; set; }
        public string Title { get; set; }
        public string? FooterPartial { get; set; }
        public string? HeaderPartial { get; set; }
        public string? HeadPartial { get; set; }
        public string? ScriptPartial { get; set; }
        public bool IsDefault { get; set; }
    }
}
