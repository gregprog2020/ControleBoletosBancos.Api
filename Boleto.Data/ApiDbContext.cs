using ControleBoleto.Domain.Interfaces;
using ControleBoleto.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBoleto.Data
{
    public class ApiDbContext : DbContext, IUnitOfWork

    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options)
            : base(options)
        { }

        public DbSet<Boleto> Boletos { get; set; }
        public DbSet<Banco> Bancos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(
                e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApiDbContext).Assembly);
        }

        public async Task<bool> Commit()
        {
            var sucesso = await base.SaveChangesAsync() > 0;
            return sucesso;
        }
    }
}
