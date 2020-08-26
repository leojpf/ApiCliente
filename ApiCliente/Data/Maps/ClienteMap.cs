using ApiCliente.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ApiCliente.Data.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.Id);            
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(30).HasColumnType("varchar(30)");
            builder.Property(x => x.Cpf).IsRequired().HasColumnType("varchar(15)");
            builder.Property(x => x.DataNasc).IsRequired().HasColumnType("Datetime");
            builder.HasMany(x => x.endereco).WithOne(x => x.cliente);
        }
    }
}
