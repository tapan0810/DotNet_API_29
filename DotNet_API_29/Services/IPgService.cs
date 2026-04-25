using DotNet_API_29.Entities.DTOs;

namespace DotNet_API_29.Services
{
    public interface IPgService
    {
        public Task<IEnumerable<GetAllPgDto>> GetAllPg();
        public Task<GetAllPgDto> GetPgById(int id);
        public Task AddPg(CreatePgDto pg);
        public Task UpdatePg(int id, UpdatePgDto pg);
        public Task DeletePg(int id);
    }
}
