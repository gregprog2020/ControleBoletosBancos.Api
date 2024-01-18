using ControleBoleto.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBoleto.Data.Mappings
{
    public class BoletoMappings : IEntityTypeConfiguration<Boleto>
    {
        public void Configure(EntityTypeBuilder<Boleto> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("id");
            
            builder.Property(c => c.NomePagador)
                .HasColumnName("nomepagador")
                .IsRequired();


            builder.Property(c => c.CpfCnpjPagador)
                .HasColumnName("cpfcnpjpagador")
                .IsRequired();

            builder.Property(c => c.NomeBeneficiario)
                .HasColumnName("nomebeneficiario")
                .IsRequired();

            builder.Property(c => c.CpfCnpjBeneficiario)
                .HasColumnName("cpfcnpjbeneficiario")
                .IsRequired();

            builder.Property(c => c.Valor)
                .HasColumnName("valor")
                .IsRequired();

            builder.Property(c => c.DataVencimento)
                .HasColumnName("datavencimento")
                .IsRequired();

            builder.Property(c => c.Observacao)
                .HasColumnName("observacao");

            builder.Property(c => c.BancoId)
                .HasColumnName("bancoid");

            builder.HasOne(c => c.Banco)
                .WithMany(c => c.Boletos);

            builder.ToTable("boletos");
        }
    }
}
