﻿namespace AkoAkademiDinamikSite.WebUI.Models.FormElement
{
    public class AddFormElementViewModel
    {
     
        public string? Title { get; set; }
        public bool IsRequired { get; set; }
        public int? Order { get; set; }
        public string? ControlType { get; set; }
        public int? FormId { get; set; }
        
    }
}
