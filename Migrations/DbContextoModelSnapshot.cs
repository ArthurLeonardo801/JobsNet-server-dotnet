﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projeto_jobs_net.Servicos;

namespace projeto_jobs_net.Migrations
{
    [DbContext(typeof(DbContexto))]
    partial class DbContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("projeto_jobs_net.Models.Curriculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("text")
                        .HasColumnName("cargo");

                    b.Property<string>("Escolaridade")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("escolaridade");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("Sobre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("text")
                        .HasColumnName("sobre");

                    b.HasKey("Id");

                    b.ToTable("curriculos");
                });

            modelBuilder.Entity("projeto_jobs_net.Models.Dado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("login");

                    b.Property<string>("Passwd")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("passwd");

                    b.HasKey("Id");

                    b.ToTable("dados");
                });

            modelBuilder.Entity("projeto_jobs_net.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("bairro");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("cidade");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("estado");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("logradouro");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("numero");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("usuario_id");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");


                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("pais");

                    b.HasKey("Id");

                    b.ToTable("enderecos");
                });

            modelBuilder.Entity("projeto_jobs_net.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("cpf");


                    b.Property<int>("DadoId")
                        .HasColumnType("int")
                        .HasColumnName("dado_id");


                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("email");


                    b.Property<int>("EnderecoId")
                        .HasColumnType("int")
                        .HasColumnName("endereco_id");

                    b.Property<string>("EstadoCivil")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("estadoCivil");


                    b.Property<string>("Genero")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("genero");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("date")
                        .HasColumnName("nascimento");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<string>("PossuiHabilitacao")
                        .HasColumnType("varchar")
                        .HasColumnName("possuiHabilitacao");

                    b.Property<string>("PossuiVeiculo")
                        .HasColumnType("varchar")
                        .HasColumnName("possuiVeiculo");


                    b.Property<string>("Profissao")
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("profissao");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("rg");

                    b.Property<string>("Telefone")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("telefone");

                    b.Property<string>("Telefone2")
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("telefone2");

                    b.HasKey("Id");


                    b.HasIndex("DadoId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("projeto_jobs_net.Models.Vaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("local");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<double>("Salario")
                        .HasColumnType("float")
                        .HasColumnName("salario");

                    b.HasKey("Id");

                    b.ToTable("vagas");
                });

            modelBuilder.Entity("projeto_jobs_net.Models.Endereco", b =>
                {
                    b.HasOne("projeto_jobs_net.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("projeto_jobs_net.Models.Usuario", b =>
                {
                    b.HasOne("projeto_jobs_net.Models.Dado", "Dado")
                        .WithMany()
                        .HasForeignKey("DadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dado");
                    
            modelBuilder.Entity("projeto_jobs_net.Models.Usuario", b =>
                {
                    b.HasOne("projeto_jobs_net.Models.Endereco", "Endereco")
                        .WithMany("Usuario")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("projeto_jobs_net.Models.Endereco", b =>
                {
                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
