using System.ComponentModel.DataAnnotations;

namespace ControleBoleto.Api.Application.DTO
{
    public class BoletoDto
    {
     
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter mais que {2} caracteres", MinimumLength = 2)]
        public string NomePagador { get;  set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CpfCnpjPagador { get;  set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string NomeBeneficiario { get;  set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CpfCnpjBeneficiario { get;  set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get;  set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataVencimento { get;  set; }

        public string Observacao { get;  set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid BancoId { get;  set; }
    }
}
