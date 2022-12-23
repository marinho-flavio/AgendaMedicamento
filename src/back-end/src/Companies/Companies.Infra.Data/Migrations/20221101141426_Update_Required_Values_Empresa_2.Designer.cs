﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Bravo.Companies.Domain.Aggregates.CommonAgg.ValueObjects;
using Bravo.Companies.Infra.Data.Context;
using Bravo.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bravo.Companies.Infra.Data.Migrations
{
    [DbContext(typeof(CompaniesAggContext))]
    [Migration("20221101141426_Update_Required_Values_Empresa_2")]
    partial class Update_Required_Values_Empresa_2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.AddressesAgg.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro_Distrito")
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .HasColumnType("text");

                    b.Property<string>("Cidade_Localidade")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<List<EventsHistory>>("EventsHistory")
                        .HasColumnType("jsonb");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Logradouro")
                        .HasColumnType("text");

                    b.Property<string>("UF")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Endereco", t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.CompaniesAggSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<AutoSaveSettings>("AutoSaveSettings")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<List<EventsHistory>>("EventsHistory")
                        .HasColumnType("jsonb");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CompaniesAggSettings");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ANS")
                        .HasColumnType("text");

                    b.Property<bool?>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("CNES")
                        .HasColumnType("text");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CodigoSUS")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CurrentStep")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<List<EventsHistory>>("EventsHistory")
                        .HasColumnType("jsonb");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("GrupoEmpresaId")
                        .HasColumnType("integer");

                    b.Property<int>("InstituicaoType")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsFilial")
                        .HasColumnType("boolean");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Terceirizado")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("GrupoEmpresaId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.EmpresaConfiguracao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<List<EventsHistory>>("EventsHistory")
                        .HasColumnType("jsonb");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<ImageFileInfo>("Logo")
                        .HasColumnType("jsonb");

                    b.Property<bool?>("SetorProprio")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("EmpresaConfiguracao");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.EmpresaContacts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<List<EventsHistory>>("EventsHistory")
                        .HasColumnType("jsonb");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.Property<string>("TipoTelefone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("WebSite")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EmpresaContacts");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.EmpresaEndereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("integer");

                    b.Property<List<EventsHistory>>("EventsHistory")
                        .HasColumnType("jsonb");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Numero")
                        .HasColumnType("text");

                    b.Property<string>("Referencia")
                        .HasColumnType("text");

                    b.Property<string>("TipoEndereco")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("EmpresaEndereco");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CurrentStep")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<List<EventsHistory>>("EventsHistory")
                        .HasColumnType("jsonb");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("InstituicaoType")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("GrupoEmpresa");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaConfiguracao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<List<EventsHistory>>("EventsHistory")
                        .HasColumnType("jsonb");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<ImageFileInfo>("Logo")
                        .HasColumnType("jsonb");

                    b.Property<bool?>("SetorProprio")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("GrupoEmpresaConfiguracao");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaContacts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<List<EventsHistory>>("EventsHistory")
                        .HasColumnType("jsonb");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.Property<string>("TipoTelefone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("WebSite")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GrupoEmpresaContacts");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaEndereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("integer");

                    b.Property<List<EventsHistory>>("EventsHistory")
                        .HasColumnType("jsonb");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GrupoEmpresaId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Numero")
                        .HasColumnType("text");

                    b.Property<string>("Referencia")
                        .HasColumnType("text");

                    b.Property<string>("TipoEndereco")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("GrupoEmpresaEndereco");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.UsersAgg.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<EventsHistory>>("EventsHistory")
                        .HasColumnType("jsonb");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AspNetUsers", t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.CompaniesAggSettings", b =>
                {
                    b.HasOne("Bravo.Companies.Domain.Aggregates.UsersAgg.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.Empresa", b =>
                {
                    b.HasOne("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.Empresa", null)
                        .WithMany("Empresas")
                        .HasForeignKey("EmpresaId");

                    b.HasOne("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa", "GrupoEmpresa")
                        .WithMany()
                        .HasForeignKey("GrupoEmpresaId");

                    b.Navigation("GrupoEmpresa");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.EmpresaConfiguracao", b =>
                {
                    b.HasOne("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.Empresa", null)
                        .WithOne("Configuracao")
                        .HasForeignKey("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.EmpresaConfiguracao", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.EmpresaContacts", b =>
                {
                    b.HasOne("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.Empresa", null)
                        .WithOne("Contacts")
                        .HasForeignKey("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.EmpresaContacts", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.EmpresaEndereco", b =>
                {
                    b.HasOne("Bravo.Companies.Domain.Aggregates.AddressesAgg.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.Empresa", null)
                        .WithOne("Endereco")
                        .HasForeignKey("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.EmpresaEndereco", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaConfiguracao", b =>
                {
                    b.HasOne("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa", null)
                        .WithOne("GrupoEmpresaConfiguracao")
                        .HasForeignKey("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaConfiguracao", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaContacts", b =>
                {
                    b.HasOne("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa", null)
                        .WithOne("Contacts")
                        .HasForeignKey("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaContacts", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaEndereco", b =>
                {
                    b.HasOne("Bravo.Companies.Domain.Aggregates.AddressesAgg.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa", null)
                        .WithOne("GrupoEmpresaEndereco")
                        .HasForeignKey("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaEndereco", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.Empresa", b =>
                {
                    b.Navigation("Configuracao")
                        .IsRequired();

                    b.Navigation("Contacts")
                        .IsRequired();

                    b.Navigation("Empresas");

                    b.Navigation("Endereco")
                        .IsRequired();
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa", b =>
                {
                    b.Navigation("Contacts")
                        .IsRequired();

                    b.Navigation("GrupoEmpresaConfiguracao")
                        .IsRequired();

                    b.Navigation("GrupoEmpresaEndereco")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
