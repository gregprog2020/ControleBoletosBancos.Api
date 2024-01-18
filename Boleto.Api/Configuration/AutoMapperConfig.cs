using AutoMapper;
using ControleBoleto.Api.Application.DTO;
using ControleBoleto.Domain.Models;

namespace ControleBoleto.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            //Escrita
            CreateMap<BoletoDto, Boleto>();
            CreateMap<BancoDto, Banco>();
        }
    }
}
