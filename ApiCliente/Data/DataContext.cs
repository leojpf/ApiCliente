using ApiCliente.Data.Maps;
using ApiCliente.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCliente.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6IBDL1T\SQLEXPRESS;Database=ApiClientes;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClienteMap());
            builder.ApplyConfiguration(new EnderecoMap());
        }
    }
}
