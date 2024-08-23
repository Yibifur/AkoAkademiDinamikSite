using AkoAkademiDinamikSite.DtoLayer.Dtos.ContentDtos;
using AkoAkademiDinamikSite.DtoLayer.Dtos.FormDtos;
using AkoAkademiDinamikSite.DtoLayer.Dtos.LayoutDtos;
using AkoAkademiDinamikSite.DtoLayer.Dtos.MediaDtos;
using AkoAkademiDinamikSite.DtoLayer.Dtos.PageDtos;
using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using AutoMapper;

namespace AkoAkademiDinamikSite.WebApi.Mapping
{
    public class AutoMapperConfigWebApi:Profile
    {
        public AutoMapperConfigWebApi()
        {
            //Content Mapping
            CreateMap<Content,CreateContentDto>().ReverseMap();
            CreateMap<Content,UpdateContentDto>().ReverseMap();
            //Form Mapping
            CreateMap<Form, CreateFormDto>().ReverseMap();
            CreateMap<Form, UpdateFormDto>().ReverseMap();
            //Media Mapping
            CreateMap<Media,CreateMediaDto>().ReverseMap();
            CreateMap<Media,UpdateMediaDto>().ReverseMap();
            //Page Mapping
            CreateMap<Page, CreatePageDto>().ReverseMap();
            CreateMap<Page, UpdatePageDto>().ReverseMap();
            //Layout Mapping
            CreateMap<Layout, CreateLayoutDto>().ReverseMap();
            CreateMap<Layout, UpdateLayoutDto>().ReverseMap();





        }
    }
}
