using AutoMapper;
using DotNet_API_29.Entities.DTOs;
using DotNet_API_29.Entities.Models;

namespace DotNet_API_29.Mapping
{
    public class PgMappingProfile:Profile
    {
       public PgMappingProfile()
        {
            CreateMap<Pg,GetAllPgDto>();
            CreateMap<Pg,GetByIdPgDto>();
            CreateMap<CreatePgDto, Pg>();
            CreateMap<UpdatePgDto,Pg>();
        }

    }
}
