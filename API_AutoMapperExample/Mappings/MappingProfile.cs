using API_AutoMapperExample.DTO;
using API_AutoMapperExample.Models;
using AutoMapper;
namespace API_AutoMapperExample.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserOutPutDTO>()
                .ForMember(dest => dest.City,
                    opts => opts.MapFrom(src => src.Address.City)).ReverseMap();

            CreateMap<UserInputDTO, User>().ReverseMap();

            CreateMap<AddressInputDTO, Address>().ReverseMap();
        }
    }
}
