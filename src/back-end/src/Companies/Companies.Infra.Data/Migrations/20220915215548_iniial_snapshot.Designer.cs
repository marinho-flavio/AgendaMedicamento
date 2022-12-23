﻿// <auto-generated />
using Bravo.Companies.Domain.Aggregates.CommonAgg.ValueObjects;
using Bravo.Companies.Infra.Data.Context;
using Bravo.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bravo.Companies.Infra.Data.Migrations
{
    [DbContext(typeof(CompaniesAggContext))]
    [Migration("20220915215548_iniial_snapshot")]
    partial class iniial_snapshot
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityAlwaysColumns(modelBuilder);

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.AddressesAgg.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro_Distrito")
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cidade_Localidade")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Logradouro")
                        .HasColumnType("text");

                    b.Property<string>("TipoLogradouro")
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

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<AutoSaveSettings>("AutoSaveSettings")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

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

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GrupoEmpresaId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("GrupoEmpresaId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityAlwaysColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Ativo")
                        .HasColumnType("boolean");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool?>("SetorProprio")
                        .HasColumnType("boolean");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.Property<string>("TipoTelefone")
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

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<ImageFileInfo>("Logo")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("WebSite")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("GrupoEmpresaConfiguracao");
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

                    b.Property<int>("EnderecoId")
                        .HasColumnType("integer");

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

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

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
                    b.HasOne("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa", "GrupoEmpresa")
                        .WithMany()
                        .HasForeignKey("GrupoEmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GrupoEmpresa");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaConfiguracao", b =>
                {
                    b.HasOne("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa", null)
                        .WithOne("GrupoEmpresaConfiguracao")
                        .HasForeignKey("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaConfiguracao", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaEndereco", b =>
                {
                    b.HasOne("Bravo.Companies.Domain.Aggregates.AddressesAgg.Entities.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa", null)
                        .WithOne("GrupoEmpresaEndereco")
                        .HasForeignKey("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresaEndereco", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("Bravo.Companies.Domain.Aggregates.CompaniesAgg.Entities.GrupoEmpresa", b =>
                {
                    b.Navigation("GrupoEmpresaConfiguracao")
                        .IsRequired();

                    b.Navigation("GrupoEmpresaEndereco")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
