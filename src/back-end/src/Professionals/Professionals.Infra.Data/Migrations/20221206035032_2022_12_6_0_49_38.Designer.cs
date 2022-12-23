﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Bravo.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Bravo.Professionals.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bravo.Professionals.Infra.Data.Migrations
{
    [DbContext(typeof(ProfessionalsAggContext))]
    [Migration("20221206035032_2022_12_6_0_49_38")]
    partial class _202212604938
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedAt")
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

                    b.HasKey("Id");

                    b.ToTable("Empresa", t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities.Cbo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Codigo")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedAt")
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

                    b.Property<string>("Tipo")
                        .HasColumnType("text");

                    b.Property<string>("Titulos")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Cbo");
                });

            modelBuilder.Entity("Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities.Funcionario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<string>("Cargos")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CboId")
                        .HasColumnType("integer");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CodigoCnes")
                        .HasColumnType("text");

                    b.Property<string>("CodigoSus")
                        .HasColumnType("text");

                    b.Property<string>("Convenio")
                        .HasColumnType("text");

                    b.Property<string>("CorpoClinico")
                        .HasColumnType("text");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("DataNascimento")
                        .HasColumnType("date");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("integer");

                    b.Property<int>("Escolaridade")
                        .HasColumnType("integer");

                    b.Property<string>("Especialidade")
                        .HasColumnType("text");

                    b.Property<List<EventsHistory>>("EventsHistory")
                        .HasColumnType("jsonb");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Funcao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Genero")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomeSocial")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SubEspecialidade")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UsuarioLogin")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CboId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities.ProfessionalsAggSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<AutoSaveSettings>("AutoSaveSettings")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<DateTime?>("CreatedAt")
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

                    b.ToTable("ProfessionalsAggSettings");
                });

            modelBuilder.Entity("Bravo.Professionals.Domain.Aggregates.UsersAgg.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedAt")
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

                    b.HasKey("Id");

                    b.ToTable("AspNetUsers", t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities.Funcionario", b =>
                {
                    b.HasOne("Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities.Cbo", "Cbo")
                        .WithMany()
                        .HasForeignKey("CboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bravo.Professionals.Domain.Aggregates.CompaniesAgg.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cbo");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("Bravo.Professionals.Domain.Aggregates.ProfessionalsAgg.Entities.ProfessionalsAggSettings", b =>
                {
                    b.HasOne("Bravo.Professionals.Domain.Aggregates.UsersAgg.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
