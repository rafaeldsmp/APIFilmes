/*
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;//é o pacote necessário para o controlador

//Controladores servem para lidar com as requisições recebidas e devolver uma resposta.
namespace FilmesAPI.Controllers
{
    [ApiController]//definindo essa classe como um controlador
    [Route("[controller]")] //quando eu chamar o nome do meu controlador /filme o controlador será chamado
    public class FilmeControllerSemSQLManual : ControllerBase //extendeu o ControllerBase para dar todos os comportamentos bases de um controlador para extender esse comportamento 
    {
        private static List<Filme> Filmes = new List<Filme>(); //criando uma lista na nossa classe   removidos ao fazer a conexão com o sqlserver
        private static int id = 1;
        [HttpPost] //indicando que estamos criando um recuros novo no sistema que irá adicionar
        public IActionResult AdicionaFilme([FromBody] Filme filme) //From body está dizendo que o filme que está recebendo vem do corpo da minha requisição
        {
            filme.Id = id++; 
            Filmes.Add(filme);

            return CreatedAtAction(nameof(RecuperaFilmesPorId), new { Id = filme.Id }, filme); //No CreatedAtAction irá mostrar aonde esse recurso foi criado essa é boa pratica e esse é o padrão nos parenteses passamos qual é o método que queremos executar
            //createCreatedAtAction ==qual é a ação que criou esse recurso, o nome dessa ação foi de recuperaFilmesPorId, no segundo parametro estamos passando um Id que é igual ao filme id que acabamos de criar e por ultimo tratamos o filme
            //então quando estamos criando um filme estamos falando que ele pode ser recuperado atraves da action recuperafilmesporid com esse id passado e gerado a ele com o recurso de filme assim seguindo as boas práticas.
            //Quando criamos um recurso novo no sistema através do verbo POST devemos retornar o 201 (Created) e a localização de onde o recurso pode ser acessado no nosso sistema.
        }

        //em List com o cltr + click esquerdo vemos umas interfaces que o List implementa uma delas é o IEnumerable<T>
        [HttpGet]//get para recuperar uma informação
        public IActionResult RecuperaFilmes() //na execução não vai mudar nada, mas se algum momento não estiver mais retornando uma lista de filme isso em alguma outra classe que implementa essa interface o método não irá quebrar
        {//usando os conceitos de polimorfismo iremos dizer que naõ iremos relamente retornar uma lista de filmes e sim um IEnumarable de filmes
            return Ok();
        }

        [HttpGet("{id}")]//abrindo parenteses e colocando entre chaves terá dizendo que recebe como parametro um Id e irá buscar por ele
        public IActionResult RecuperaFilmesPorId(int id) //vai ser IActionResult por que queremos o retorno do object result
        {
            //foreach(Filme filme in Filmes)//para cara filme do tipo Filme na nossa lista de filme
            //{
            //    if(filme.Id == id)
            //    {
            //        return filme;
            //    }
            //}
            //return null;

            //IREMOS UTILIZAR A SINTAXE CSHARP PARA MELHORAR A O CÓDIGO ACIMA
            Filme filme = Filmes.FirstOrDefault(Filme => Filme.Id == id);//da nossa lista de filmes queremos encontra o primeiro elemento ou algum padrão, onde esse elemento é um filme e que ele tem o Id igual ao passado
            if (filme != null)
            {
                Ok(filme);//retorna status 200
            }
            return NotFound();

        }
    }
}*/