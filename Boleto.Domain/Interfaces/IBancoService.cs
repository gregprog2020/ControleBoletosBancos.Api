using ControleBoleto.Domain.Models;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBoleto.Domain.Interfaces
{
    public interface IBancoService
    {
        Task<ValidationResult> Adicionar(Banco banco);
        Task<ValidationResult> Atualizar(Banco banco);
        Task<ValidationResult> Remover(Guid id);
    }
}
