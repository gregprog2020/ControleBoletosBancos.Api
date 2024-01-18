using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBoleto.Domain.Models;

namespace ControleBoleto.Data.Mappings
{
    public class BancoMappings : IEntityTypeConfiguration<Banco>
    {
        public void Configure(EntityTypeBuilder<Banco> builder)
        {
            
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("id");

            builder.Property(c => c.NomeBanco)
                    .HasColumnName("nomebanco")
                    .IsRequired();


            builder.Property(c => c.CodigoBanco)
                    .HasColumnName("codigobanco")
                    .IsRequired();

            builder.Property(c => c.PercentualJuros)
                    .HasColumnName("percentualjuros")
                    .IsRequired();

            builder.HasMany(c => c.Boletos)
                        .WithOne(c => c.Banco)
                        .HasForeignKey(c => c.BancoId);

            builder.ToTable("bancos");
        }
    }
}
