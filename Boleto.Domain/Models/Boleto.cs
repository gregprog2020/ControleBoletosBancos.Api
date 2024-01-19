using ControleBoleto.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBoleto.Domain.Models
{
    public class Boleto : Entity
    {
        public string NomePagador { get; private set; }
        public string CpfCnpjPagador { get; private set; }
        public string NomeBeneficiario { get; private set; }
        public string CpfCnpjBeneficiario { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public string Observacao { get; private set; }
        public Guid BancoId { get; private set; }
        public Banco Banco { get; set; }

        public void CalcularValorComJuros(decimal valorBoleto, DateTime dataVencimento, decimal taxaJuros)
        {
            // Verifica se a data atual é após a data de vencimento
            if (DateTime.Now > dataVencimento)
            {
                // Calcula o valor do boleto com juros
                decimal juros = valorBoleto * taxaJuros / 100;
                Valor = valorBoleto + juros;
            }
            
        }
    }

    
}
