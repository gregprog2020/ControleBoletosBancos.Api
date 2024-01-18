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
    public class BoletoServices : CommandHandler, IBoletoServices
    {
        private readonly IBoletoRepository _boletoRepository;

        public BoletoServices(IBoletoRepository boletoRepository)
        {
            _boletoRepository = boletoRepository;
        }

        public async Task<ValidationResult> Adicionar(Boleto boleto) 
        {
            if (!_boletoRepository.Buscar(b => b.Id == boleto.BancoId).Result.Any())
            {
                AdicionarErro("Banco não cadastrado!");
                return ValidationResult;
            }
            _boletoRepository.Adicionar(boleto);

            return await PersistirDados(_boletoRepository.UnitOfWork);
        }

        public Task<ValidationResult> Atualizar(Boleto boleto)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
