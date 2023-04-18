using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilmes.Modelo
{
    public class Filme
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Máximo de 100 Caracteres!")]
       
        public string Titulo { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        
        [Required(ErrorMessage ="Digite o Gênero do Filme!")]
        [StringLength(30, MinimumLength = 3)]
        public string Genero { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18x2)*")]
        public decimal Preco { get; set; }

        [Range(0,5)]
        public int Pontos { get; set; } = 0;
    }
}
