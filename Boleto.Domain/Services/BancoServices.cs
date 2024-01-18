using ControleBoleto.Domain.Command;
using ControleBoleto.Domain.Interfaces;
using ControleBoleto.Domain.Models;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBoleto.Domain.Services
{
    public class BancoServices : CommandHandler, IBancoService
    {
        private readonly IBancoRepository _bancoRepository;

        public BancoServices(IBancoRepository bancoRepository)
        {
            _bancoRepository = bancoRepository;
        }
        public Task<ValidationResult> Adicionar(Banco banco)
        {
            if (!_bancoRepository.Buscar(b => b.Id == boleto.BancoId).Result.Any())
            {
                AdicionarErro("Banco não cadastrado!");
                return ValidationResult;
            }
            _bancoRepository.Adicionar(banco);

            return await PersistirDados(_bancoRepository.UnitOfWork);
        }

        public Task<ValidationResult> Atualizar(Banco banco)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
