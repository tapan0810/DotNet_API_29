using DotNet_API_29.Entities.DTOs;
using DotNet_API_29.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_API_29.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PgController : ControllerBase
    {
        private readonly IPgService _service;

        public PgController(IPgService service)
        {
            _service = service;
        }

        // ✅ GET ALL
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllPg();
            return Ok(result);
        }

        // ✅ GET BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetPgById(id);
            return Ok(result);
        }

        // ✅ CREATE PG
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePgDto dto)
        {
            await _service.AddPg(dto);

            return Ok(new
            {
                message = "PG created successfully"
            });
        }

        // ✅ UPDATE PG
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdatePgDto dto)
        {
            await _service.UpdatePg(id, dto);

            return Ok(new
            {
                message = "PG updated successfully"
            });
        }

        // ✅ DELETE PG
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeletePg(id);

            return Ok(new
            {
                message = "PG deleted successfully"
            });
        }
    }
}