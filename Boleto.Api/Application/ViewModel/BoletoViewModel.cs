using ControleBoleto.Domain.Models;

namespace ControleBoleto.Api.Application.ViewModel
{
    public class BoletoViewModel
    {
        public Guid Id { get; private set; }
        public string NomePagador { get; private set; }
        public string CpfCnpjPagador { get; private set; }
        public string NomeBeneficiario { get; private set; }
        public string CpfCnpjBeneficiario { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public string Observacao { get; private set; }
        public Guid BancoId { get; private set; }
    }
}
