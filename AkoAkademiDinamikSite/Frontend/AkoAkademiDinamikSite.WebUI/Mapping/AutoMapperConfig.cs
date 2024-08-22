using AkoAkademiDinamikSite.EntityLayer.ReelConcrete;
using AkoAkademiDinamikSite.WebUI.Dtos.ContentDtos;
using AutoMapper;

namespace AkoAkademiDinamikSite.WebUI.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            //Service mapping
            CreateMap<ResultContentDto, Content>().ReverseMap();
            //CreateMap<UpdateServiceDto, Service>().ReverseMap();
            //CreateMap<CreateServiceDto, Service>().ReverseMap();
            //Register mapping
            //CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            //CreateMap<CreateLoginDto, AppUser>().ReverseMap();
            //About mapping
            // CreateMap<UpdateAboutDto, About>().ReverseMap();
            // CreateMap<ResultAboutDto, About>().ReverseMap();


        }
    }
}
