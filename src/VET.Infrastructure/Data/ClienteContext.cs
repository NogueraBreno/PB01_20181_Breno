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
            modelBuilder.Entity<Consulta>().ToTable("Consulta");
            modelBuilder.Entity<Especie>().ToTable("Especie");
            modelBuilder.Entity<Animal>().ToTable("Animal");
            
            #region Cliente

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.ClienteId);

            modelBuilder.Entity<Cliente>()
               .HasOne(c => c.Endereco)
               .WithOne(c => c.Cliente);

            modelBuilder.Entity<Cliente>()
                .HasMany(a => a.Animais)
                .WithOne(a => a.Cliente);

               

            modelBuilder.Entity<Cliente>().Property(e => e.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(e => e.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();
            #endregion

            #region Endereco

            modelBuilder.Entity<Endereco>()
                .HasKey(e => e.EnderecoId);

            modelBuilder.Entity<Endereco>()
                .HasOne(e => e.Cliente)
                .WithOne(e => e.Endereco);


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

            #region Consulta

            modelBuilder.Entity<Consulta>()
                .HasKey(c => c.ConsultaId);

            modelBuilder.Entity<Consulta>()
                .HasOne(c => c.Animal)
                .WithMany(c => c.Consultas);




            modelBuilder.Entity<Consulta>().Property(c => c.Observacao)
                .HasColumnType("varchar(1000)")
                .IsRequired();

            #endregion

            #region Especie

            modelBuilder.Entity<Especie>()
                .HasKey(e => e.EspecieId);

            modelBuilder.Entity<Especie>()
                .HasOne(e => e.Animal)
                .WithOne(e => e.Especie);

            modelBuilder.Entity<Especie>().Property(e => e.Descricao)
                .HasColumnType("varchar(50)")
                .IsRequired();

            #endregion

            #region Animal

            modelBuilder.Entity<Animal>()
            .HasKey(a => a.AnimalId);


            modelBuilder.Entity<Animal>()
                .HasMany(a => a.Consultas)
                .WithOne(a => a.Animal);


            modelBuilder.Entity<Animal>().Property(a => a.Genero)
                .HasColumnType("varchar(2)")
                .IsRequired();

            modelBuilder.Entity<Animal>().Property(a => a.Nome)
              .HasColumnType("varchar(25)")
              .IsRequired();

            #endregion



        }

    }
}
