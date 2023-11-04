using AutoMapper;
using DatesApp.Dto;
using DatesApp.Entities;

namespace DatesApp.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, MemberDto>()
                .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain)!.Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.GetAge()));
            CreateMap<Photo, PhotoDto>();
        }
    }
}
