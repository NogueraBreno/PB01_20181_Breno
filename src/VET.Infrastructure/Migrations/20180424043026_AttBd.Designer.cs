﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using VET.Infrastructure.Data;

namespace VET.Infrastructure.Migrations
{
    [DbContext(typeof(ClienteContext))]
    [Migration("20180424043026_AttBd")]
    partial class AttBd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VET.ApplicationCore.Entity.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("EnderecoId");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("VET.ApplicationCore.Entity.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<int>("ClienteId");

                    b.Property<int?>("ClienteId1");

                    b.Property<string>("Logradouro")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Numero")
                        .HasColumnType("varchar(10)");

                    b.HasKey("EnderecoId");

                    b.HasIndex("ClienteId1");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("VET.ApplicationCore.Entity.Endereco", b =>
                {
                    b.HasOne("VET.ApplicationCore.Entity.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId1");
                });
#pragma warning restore 612, 618
        }
    }
}
