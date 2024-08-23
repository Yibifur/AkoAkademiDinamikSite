using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using AkoAkademiDinamikSite.WebUI.Dtos.ContentDtos;
using AkoAkademiDinamikSite.WebUI.Models.Content;
using AkoAkademiDinamikSite.WebUI.Models.Layout;
using AkoAkademiDinamikSite.WebUI.Models.Page;
using AutoMapper;

namespace AkoAkademiDinamikSite.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            
            //Page Mapping
            CreateMap<Page, UpdatePageViewModel>().ReverseMap();
            CreateMap<Page, PageViewModel>().ReverseMap();
            CreateMap<Page, AddPageViewModel>().ReverseMap();
            //Content Mapping
            CreateMap<Content, UpdateContentViewModel>().ReverseMap();
            CreateMap<Content, ContentViewModel>().ReverseMap();
            CreateMap<Content, AddContentViewModel>().ReverseMap();
            //Layout Mapping
            CreateMap<Layout, UpdateLayoutViewModel>().ReverseMap();
            CreateMap<Layout, LayoutViewModel>().ReverseMap();
            CreateMap<Layout, AddLayoutViewModel>().ReverseMap();

        }
    }
}
