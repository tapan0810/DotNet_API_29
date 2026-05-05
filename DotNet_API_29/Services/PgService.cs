using AutoMapper;
using DotNet_API_29.Entities.DTOs;
using DotNet_API_29.Entities.Models;
using DotNet_API_29.Exceptions;
using DotNet_API_29.Repositories;

namespace DotNet_API_29.Services
{
    public class PgService : IPgService
    {
        private readonly IPgRepositrory _repository;
        private readonly IMapper _mapper;

        public PgService(IPgRepositrory repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // ✅ ADD PG
        public async Task AddPg(CreatePgDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.PgName))
                throw new ValidationException("PG name cannot be empty.");

            var entity = _mapper.Map<Pg>(dto);

            await _repository.AddPg(entity);
            await _repository.SaveChangesAsync();
        }

        // ✅ DELETE PG
        public async Task DeletePg(int id)
        {
            var pg = await _repository.GetPgById(id);

            if (pg is null)
                throw new PgNotFoundException(id);

            _repository.DeletePg(id);   // ✅ pass entity
            await _repository.SaveChangesAsync();
        }

        // ✅ GET ALL
        public async Task<IEnumerable<GetAllPgDto>> GetAllPg()
        {
            var pgs = await _repository.GetAllPg();
            return _mapper.Map<IEnumerable<GetAllPgDto>>(pgs);
        }

        // ✅ GET BY ID
        public async Task<GetByIdPgDto> GetPgById(int id)
        {
            var pg = await _repository.GetPgById(id);

            if (pg is null)
                throw new PgNotFoundException(id);

            return _mapper.Map<GetByIdPgDto>(pg);
        }

        // ✅ UPDATE PG
        public async Task UpdatePg(int id, UpdatePgDto dto)
        {
            var existingPg = await _repository.GetPgById(id);

            if (existingPg is null)
                throw new PgNotFoundException(id);

            // Map new values into existing entity
            _mapper.Map(dto, existingPg);

            _repository.UpdatePg(id,existingPg);
            await _repository.SaveChangesAsync();
        }
    }
}