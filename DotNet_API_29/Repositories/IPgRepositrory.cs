using DotNet_API_29.Entities.DTOs;
using DotNet_API_29.Entities.Models;

namespace DotNet_API_29.Repositories
{
    public interface IPgRepositrory
    {
        Task<IEnumerable<Pg>> GetAllPg();
        Task<Pg> GetPgById(int id);
        Task AddPg(Pg pg);
        void UpdatePg(int id, Pg pg);
        void DeletePg(int id);
        Task SaveChangesAsync();
    }
}
