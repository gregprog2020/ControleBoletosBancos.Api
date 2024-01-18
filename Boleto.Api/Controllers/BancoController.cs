using AutoMapper;
using ControleBoleto.Api.Application.DTO;
using ControleBoleto.Core.Controllers;
using ControleBoleto.Domain.Interfaces;
using ControleBoleto.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleBoleto.Api.Controllers
{
    [Route("api/bancos")]
    public class BancoController : MainController
    {
        private readonly IBancoService _bancoService;
        private readonly IMapper _mapper;

        public BancoController(IBancoService bancoService, IMapper mapper)
        {
            _bancoService = bancoService;
            _mapper = mapper;
        }

        [HttpPost()]
        public async Task<ActionResult> Criar(BancoDto bancoDto)
        {
            return CustomResponse(await _bancoService.Adicionar(_mapper.Map<Banco>(bancoDto)));
        }
    }
}
