using System.ComponentModel.DataAnnotations;

namespace ControleBoleto.Api.Application.DTO
{
    public class BancoDto
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string NomeBanco { get;  set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CodigoBanco { get;  set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal PercentualJuros { get;  set; }
    }
}
