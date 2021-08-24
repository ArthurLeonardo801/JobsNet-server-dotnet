using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto_jobs_net.ModelViews;
using projeto_jobs_net.Models;
using projeto_jobs_net.Servicos;

namespace projeto_jobs_net.Controllers
{
    [ApiController]
    
    public class VagasController : ControllerBase
    {
        private readonly DbContexto _context;

        public VagasController(DbContexto context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("/Vagas")]
        public async Task<IActionResult> Index()
        {
            return StatusCode(200, await _context.Vagas.ToListAsync());
        }

        [HttpPost]
        [Route("/Vagas/buscar")] 
        public async Task<IActionResult> Nome([FromBody] AdmVagaView vaga)
        {
            var buscar = await _context.Vagas.Where(a => a.Nome == vaga.Nome).FirstOrDefaultAsync();
            if (buscar != null) 
            {
                return StatusCode(200, new{
                    Id = buscar.Id,
                    Nome = buscar.Nome,
                    Descricao = buscar.Descricao,
                    Local = buscar.Local,
                    Salario = buscar.Salario,  
                });
            }
            return StatusCode(401, new {
                Mensagem = "Não encontrado",
            });
        }

        [HttpGet]
        [Route("/Vagas/filtro")]
        public async Task<IActionResult> Index1()
        {
            return StatusCode(200, await _context.Vagas.Take(6).ToListAsync());
        }

        [HttpPost]
        [Route("/Vagas")]
        public async Task<IActionResult> Create([Bind("Id,Nome,descricao,Local,Salario")] Vaga vaga)
        {
            _context.Add(vaga);
            await _context.SaveChangesAsync();
            return StatusCode(201, vaga);
        }

        [HttpPut]
        [Route("/Vagas/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,descricao,Local,Salario")] Vaga vaga)
        {
            if (id != vaga.Id)
            {
                return NotFound();
            }

            try
            {
                _context.Update(vaga);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VagaExists(vaga.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return StatusCode(200, vaga);
        }

        [HttpDelete]
        [Route("/vagas/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var vaga = await _context.Vagas.FindAsync(id);
            _context.Vagas.Remove(vaga);
            await _context.SaveChangesAsync();
            return StatusCode(204);
        }

        private bool VagaExists(int id)
        {
            return _context.Vagas.Any(e => e.Id == id);
        }
    }
}
