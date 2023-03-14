using Cadastro_Membros_IPCS.Data;
using Cadastro_Membros_IPCS.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Membros_IPCS.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class MembroController : ControllerBase
    {
        private MembroContext _context;

    public MembroController(MembroContext context)
    {
        _context = context;
    }

    [HttpPost]
        public IActionResult AdicionarMembro([FromBody] Membro membro)
        {
        //membro.Id = id++;
        //membros.Add(membro);
        _context.Membros.Add(membro);
        _context.SaveChanges();
        return CreatedAtAction(nameof(ListarMembrosPorId), new { id = membro.Id }, membro);
        }

        [HttpGet]
        public IEnumerable<Membro> ListarMembros([FromQuery] int skip = 0, [FromQuery] int take = 2)
        {
        //return membros.Skip(skip).Take(2);
            return _context.Membros.Skip(skip).Take(2);
        }

        [HttpGet("{id}")]
        public IActionResult ListarMembrosPorId(int id)
        {
            var membro = _context.Membros.FirstOrDefault(membro => membro.Id == id);
            if (membro == null) return NotFound();
            return Ok(membro);
        }
        
    }