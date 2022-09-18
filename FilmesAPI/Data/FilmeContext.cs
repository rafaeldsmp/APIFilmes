using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data
{
    public class FilmeContext : DbContext//para falar que ele é efetivamente um context extendemos ele para Dbcontext
    {//DbContext Abstrair a lógica de acesso ao banco de dados. Dessa maneira, nosso esforço de acessar o banco de dados é reduzido
        public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
        {

        }
        public DbSet <Filme> Filmes { get; set; }//esse DbSet é um conjunto de dados do banco que iremos conseguir de maneira encapsulada o acesso aos dados do banco
       
    }
}
  