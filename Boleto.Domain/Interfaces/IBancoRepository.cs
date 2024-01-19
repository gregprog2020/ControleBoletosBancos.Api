using ControleBoleto.Core.DomainObjects;
using ControleBoleto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBoleto.Domain.Interfaces
{
    public interface IBancoRepository : IRepository<Banco>
    {
        Task<Banco> ObterPorCodigo(string codigo);
    }
}
