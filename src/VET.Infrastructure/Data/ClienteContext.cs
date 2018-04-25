using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VET.ApplicationCore.Entity;

namespace VET.Infrastructure.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Endereco>().ToTable("Endereco");

            #region Cliente

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.ClienteId);

            modelBuilder.Entity<Cliente>()
               .HasOne(c => c.Endereco)
               .WithOne(c => c.Cliente);

            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();
            #endregion

            #region Endereco
            modelBuilder.Entity<Endereco>().Property(e => e.CEP)
                .HasColumnType("varchar(11)")
                .IsRequired();

            modelBuilder.Entity<Endereco>().Property(e => e.Bairro)
                .HasColumnType("varchar(50)");

            modelBuilder.Entity<Endereco>().Property(e => e.Logradouro)
                .HasColumnType("varchar(50)");

            modelBuilder.Entity<Endereco>().Property(e => e.Numero)
                .HasColumnType("varchar(10)");

            #endregion

        }

    }
}
