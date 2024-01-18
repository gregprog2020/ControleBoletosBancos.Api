using ControleBoleto.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBoleto.Domain.Models
{
    public class Banco : Entity
    {
        public string NomeBanco { get; private set; }
        public string CodigoBanco { get; private set; }
        public decimal PercentualJuros { get; private set; }
        public IList<Boleto> Boletos { get; private set; }
    }
}
