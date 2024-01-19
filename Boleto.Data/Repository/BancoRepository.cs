using ControleBoleto.Domain.Interfaces;
using ControleBoleto.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBoleto.Data.Repository
{
    public class BancoRepository : Repository<Banco>, IBancoRepository
    {
        public BancoRepository(ApiDbContext db) : base(db)
        {

        }

        public async Task<Banco> ObterPorCodigo(string codigo)
        {
            return await Db.Bancos.FirstOrDefaultAsync(b => b.CodigoBanco.Equals(codigo));
        }
    }
}
