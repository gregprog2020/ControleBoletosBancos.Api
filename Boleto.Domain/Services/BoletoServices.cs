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
        private readonly IBancoRepository _bancoRepository;

        public BoletoServices(IBoletoRepository boletoRepository, IBancoRepository bancoRepository)
        {
            _boletoRepository = boletoRepository;
            _bancoRepository = bancoRepository;
        }

        public async Task<ValidationResult> Adicionar(Boleto boleto) 
        {
            if (!_bancoRepository.Buscar(b => b.Id == boleto.BancoId).Result.Any())
            {
                AdicionarErro("Banco não cadastrado!");
                return ValidationResult;
            }
            await _boletoRepository.Adicionar(boleto);

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

        public async Task<List<Boleto>> ObterTodosBoletos()
        {
            var boletos = await _boletoRepository.ObterTodos();

            List<Boleto> listBoletos = new List<Boleto>();
            Boleto boleto;


            //Laço para calcular o valor de juros de cada boleto
            foreach (var item in boletos)
            {
                var banco = await _bancoRepository.ObterPorId(item.BancoId);
                boleto = item;
                boleto.CalcularValorComJuros(item.Valor, item.DataVencimento, banco.PercentualJuros);
                listBoletos.Add(boleto);
            }
            return listBoletos;
        }

        public async Task<Boleto> ObterBoletoPorId(Guid id)
        {
            var boleto = await _boletoRepository.ObterPorId(id);
            var banco = await _bancoRepository.ObterPorId(boleto.BancoId);
            boleto.CalcularValorComJuros(boleto.Valor, boleto.DataVencimento, banco.PercentualJuros);

            return boleto;
        }
    }
}
