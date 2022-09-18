//Models: classe que teremos nosssos modelos
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }        
        public string Titulo { get; set; } = string.Empty;
        public string Diretor { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        [Range (1, 600, ErrorMessage = "Duração deve ter no mínimo 1 e no máximo 600 minutos")]
        public int Duracao { get; set; }                
    }
}
