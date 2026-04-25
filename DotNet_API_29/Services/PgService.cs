using DotNet_API_29.Entities.DTOs;
using DotNet_API_29.Repositories;

namespace DotNet_API_29.Services
{
    public class PgService(IPgRepositrory repositrory) : IPgService
    {
        public Task AddPg(CreatePgDto pg)
        {
            throw new NotImplementedException();
        }

        public Task DeletePg(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetAllPgDto>> GetAllPg()
        {
            throw new NotImplementedException();
        }

        public Task<GetAllPgDto> GetPgById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePg(int id, UpdatePgDto pg)
        {
            throw new NotImplementedException();
        }
    }
}
