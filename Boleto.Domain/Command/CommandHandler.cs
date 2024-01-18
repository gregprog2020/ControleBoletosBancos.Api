using ControleBoleto.Domain.Interfaces;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBoleto.Domain.Command
{
    public abstract class CommandHandler
    {
        protected ValidationResult ValidationResult;

        protected CommandHandler()
        {
            ValidationResult = new ValidationResult();
        }

        protected void AdicionarErro(string mensagem)
        {
            ValidationResult.Errors.Add(new ValidationFailure(string.Empty, mensagem));
        }

        protected async Task<ValidationResult> PersistirDados(IUnitOfWork uow)
        {
            if (!await uow.Commit()) AdicionarErro("Houve um erro ao persistir os dados");

            return ValidationResult;
        }
    }
}
