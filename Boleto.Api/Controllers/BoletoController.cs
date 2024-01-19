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
    [Route("api/boletos")]
    public class BoletoController : MainController
    {
        private readonly IBoletoServices _boletoService;
        private readonly IMapper _mapper;

        public BoletoController(IBoletoServices boletoService, IMapper mapper)
        {
            _boletoService = boletoService;
            _mapper = mapper;
        }

        [HttpPost()]
        public async Task<ActionResult> Criar(BoletoDto boletoDto)
        {
            return CustomResponse(await _boletoService.Adicionar(_mapper.Map<Boleto>(boletoDto)));
        }

        [HttpGet()]
        public async Task<ActionResult> OBterTodos()
        {            
            return CustomResponse(_mapper.Map<IEnumerable<BoletoViewModel>>(await _boletoService.ObterTodosBoletos()));
        }

        [HttpGet("obterPorId")]
        public async Task<ActionResult> OBterPorId(Guid id)
        {
            return CustomResponse(_mapper.Map<BoletoViewModel>(await _boletoService.ObterBoletoPorId(id)));
        }
    }
}
