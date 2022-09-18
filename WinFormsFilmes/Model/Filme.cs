using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsFilmes.Model
{
    public class Filme
    {
        public int Id { get; set; } = 0;       
        public string Titulo { get; set; } = string.Empty;   
        public string Diretor { get; set; } = string.Empty;        
        public string Genero { get; set; } = string.Empty;
        public int Duracao { get; set; } = 600;
    }
}
