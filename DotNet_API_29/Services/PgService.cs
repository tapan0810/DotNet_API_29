using AutoMapper;
using DotNet_API_29.Entities.DTOs;
using DotNet_API_29.Entities.Models;
using DotNet_API_29.Exceptions;
using DotNet_API_29.Repositories;

namespace DotNet_API_29.Services
{
    public class PgService(IPgRepositrory repositrory,IMapper mapper) : IPgService
    {
        public async Task AddPg(CreatePgDto pg)
        {
            if(string.IsNullOrWhiteSpace(pg.PgName))
            {
                throw new ValidationException("Pg name cannot be null or empty.");
            }

            var pg = await mapper.Map<Pg>(CreatePgDto);
        }

        public async Task DeletePg(int id)
        {
            var pg = await repositrory.GetPgById(id);

            if(pg is null)
                throw new PgNotFoundException(id);

            repositrory.DeletePg(id);
            await repositrory.SaveChangesAsync();
        }

        public async Task<IEnumerable<GetAllPgDto>> GetAllPg()
        {
            var pgs = await repositrory.GetAllPg();

            return mapper.Map<IEnumerable<GetAllPgDto>>(pgs);
        }

        public async Task<GetByIdPgDto> GetPgById(int id)
        {
            var pg = await repositrory.GetPgById(id);

            if(pg is null)
            {
                throw new PgNotFoundException(id);
            }
            return mapper.Map<GetByIdPgDto>(pg);
        }

        public Task UpdatePg(int id, UpdatePgDto pg)
        {
            throw new NotImplementedException();
        }
    }
}
