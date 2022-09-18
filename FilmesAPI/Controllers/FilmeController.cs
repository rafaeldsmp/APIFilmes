using FilmesAPI.Data;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;//é o pacote necessário para o controlador
using Microsoft.EntityFrameworkCore;

//Controladores servem para lidar com as requisições recebidas e devolver uma resposta.
namespace FilmesAPI.Controllers
{
    [ApiController]//definindo essa classe como um controlador
    [Route("[controller]")] //quando eu chamar o nome do meu controlador /filme o controlador será chamado
    public class FilmeController : ControllerBase //extendeu o ControllerBase para dar todos os comportamentos bases de um controlador para extender esse comportamento 
    {
        private readonly FilmeContext _context;//agora para acessar uma informação e colocar no banco usaremos a filmecontext

        public FilmeController(FilmeContext context) //vamos inicializar via construtor 
        {
            _context = context;
        }

        //criando os endpoints
        [HttpGet]//trazer todos os filmes
        public async Task<ActionResult<List<Filme>>> Get()
        {
            var filmes = await _context.Filmes.ToListAsync();
            return filmes;
        }

        [HttpGet("{Id}")] //vai pegar um específico
        public async Task<ActionResult<List<Filme>>> Get(int Id)
        {
            var filmes = await _context.Filmes
                .Where(x => x.Id == Id)
                .ToListAsync();
            return Ok(filmes);
        }

        [HttpPost]
        public async Task<ActionResult<List<Filme>>> Create(Filme filme)//vai devolver uma lista de personargens a partir de quando eu devolver um personargem
        {
            _context.Filmes.Add(filme);//aqui é a intenção de adicionar
            await _context.SaveChangesAsync();//aqui efetivamente adiciona ao banco de dados

            return await Get(filme.Id);//aqui já vai trazer a lista de filmes atualizadaf
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<Filme>>> Delete(int Id)
        {
            var filme = await _context.Filmes.FindAsync(Id);
            if (filme == null)
            {
                return NotFound();
            }
            _context.Filmes.Remove(filme);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult> Put(int Id, [FromBody] Filme filme)
        {
            if (filme.Id != Id)
            {
                return BadRequest();
            }
            _context.Entry(filme).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
