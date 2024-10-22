using Guilherme_Freitas.Data;
using Guilherme_Freitas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Guilherme_Freitas.Utils;

namespace Guilherme_Freitas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FolhaController : ControllerBase
    {
        private readonly ProvaDbContext _context;

        public FolhaController(ProvaDbContext context)
        {
            _context = context;
        }

        [HttpGet("listar")]
        public async Task<ActionResult<IEnumerable<Folha>>> GetFolhas()
        {
            return await _context.Folhas.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Folha>> GetFolha(int id)
        {
            var folha = await _context.Folhas.FindAsync(id);

            if (folha == null)
            {
                return NotFound();
            }

            return folha;
        }


        [HttpPost("cadastrar")]
        public async Task<ActionResult<Folha>> CreateFolha(Folha folha)
        {

            var funcionario =  await _context.Funcionarios.FindAsync(folha.FuncionarioId);
            if (funcionario == null) {
                return NotFound();
            }

            folha.SalarioBruto = folha.Quantidade * folha.Valor;


            folha.ImpostoIrrf = Imposto.ImpostoIrrf(folha.SalarioBruto);

           _context.Folhas.Add(folha);

            await _context.SaveChangesAsync();

            return folha;
        }
    }
}
