using ControleBoleto.Domain.Models;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBoleto.Domain.Interfaces
{
    public interface IBoletoServices
    {
        Task<ValidationResult> Adicionar(Boleto boleto);
        Task<ValidationResult> Atualizar(Boleto boleto);
        Task<ValidationResult> Remover(Guid id);
        Task<List<Boleto>> ObterTodosBoletos();
        Task<Boleto> ObterBoletoPorId(Guid id);
    }
}
