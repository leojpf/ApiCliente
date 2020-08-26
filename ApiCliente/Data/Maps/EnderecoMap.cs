using ApiCliente.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCliente.Data.Maps
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(50).HasColumnType("varchar(50)");
            builder.Property(x => x.Bairro).IsRequired().HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(20).HasColumnType("varchar(20)");
            builder.Property(x => x.Estado).IsRequired().HasMaxLength(20).HasColumnType("varchar(20)");
        }
    }
}
