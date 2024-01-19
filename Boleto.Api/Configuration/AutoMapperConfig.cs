using AutoMapper;
using ControleBoleto.Api.Application.DTO;
using ControleBoleto.Api.Application.ViewModel;
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

            //Leitura
            CreateMap<Boleto, BoletoViewModel>();
            CreateMap<Banco, BancoViewModel>();
        }
    }
}
