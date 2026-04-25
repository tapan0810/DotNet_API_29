using DotNet_API_29.Data;
using DotNet_API_29.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DotNet_API_29.Repositories
{
    public class PgRepository (PgDbContext _context): IPgRepositrory
    {
        public async Task AddPg(Pg pg)
        {
            await _context.Pgs.AddAsync(pg);
        }

        public void DeletePg(int id)
        {
            var pg = _context.Pgs.FirstOrDefault(x => x.Id == id);
            _context.Pgs.Remove(pg);
        }

        public async Task<IEnumerable<Pg>> GetAllPg()
        {
            return await _context.Pgs.ToListAsync();
        }

        public async Task<Pg> GetPgById(int id)
        {
            return await _context.Pgs.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void UpdatePg(int id, Pg pg)
        {
           _context.Pgs.Update(pg);
        }
    }
}
