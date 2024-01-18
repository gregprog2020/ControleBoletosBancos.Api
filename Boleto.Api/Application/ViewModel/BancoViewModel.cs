using ControleBoleto.Domain.Models;

namespace ControleBoleto.Api.Application.ViewModel
{
    public class BancoViewModel
    {
        public Guid Id { get; private set; }
        public string NomeBanco { get; private set; }
        public string CodigoBanco { get; private set; }
        public decimal PercentualJuros { get; private set; }
        public IList<Boleto> Boletos { get; private set; }
    }
}
