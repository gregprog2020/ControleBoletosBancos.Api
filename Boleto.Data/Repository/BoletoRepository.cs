using ControleBoleto.Domain.Interfaces;
using ControleBoleto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBoleto.Data.Repository
{
    public class BoletoRepository : Repository<Boleto>, IBoletoRepository
    {
        public BoletoRepository(ApiDbContext db) : base(db)
        {

        }
    }
}
