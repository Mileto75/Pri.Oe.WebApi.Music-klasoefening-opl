using AutoMapper;
using Pri.Oe.WebApi.Music.Api.Dtos.Albums;
using Pri.Oe.WebApi.Music.Core.Entities;

namespace Pri.Oe.WebApi.Music.Api.AutoMapper
{
    public class AlbumProfile : Profile
    {
        public AlbumProfile()
        {
            CreateMap<Album, AlbumResponseDto>()
                 .ForMember(dest => dest.ReleaseYear, opt => opt.MapFrom(src => src.ReleaseDate.Year));
        }
    }
}
