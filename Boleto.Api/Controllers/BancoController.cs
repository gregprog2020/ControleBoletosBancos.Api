using AutoMapper;
using ControleBoleto.Api.Application.DTO;
using ControleBoleto.Api.Application.ViewModel;
using ControleBoleto.Core.Controllers;
using ControleBoleto.Domain.Interfaces;
using ControleBoleto.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ControleBoleto.Api.Controllers
{
    [Authorize]
    [Route("api/bancos")]
    public class BancoController : MainController
    {
        private readonly IBancoService _bancoService;
        private readonly IBancoRepository _bancoRepository;
        private readonly IMapper _mapper;

        public BancoController(IBancoService bancoService, IMapper mapper, IBancoRepository bancoRepository)
        {
            _bancoService = bancoService;
            _mapper = mapper;
            _bancoRepository = bancoRepository;
        }

        [HttpPost()]
        public async Task<ActionResult> Criar(BancoDto bancoDto)
        {
            return CustomResponse(await _bancoService.Adicionar(_mapper.Map<Banco>(bancoDto)));
        }


        [HttpGet()]
        public async Task<ActionResult> OBterTodos()
        {
            return CustomResponse(_mapper.Map<IEnumerable<BancoViewModel>>(await _bancoRepository.ObterTodos()));
        }

        [HttpGet("obterPorId")]
        public async Task<ActionResult> OBterPorId(Guid id)
        {
            return CustomResponse(_mapper.Map<BancoViewModel>(await _bancoRepository.ObterPorId(id)));
        }

        [HttpGet("obterPorCodigo")]
        public async Task<ActionResult> OBterPorId(string codigo)
        {
            return CustomResponse(_mapper.Map<BancoViewModel>(await _bancoRepository.ObterPorCodigo(codigo)));
        }
    }
}
