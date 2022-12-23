﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Bravo.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Bravo.Partners.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Bravo.Partners.Infra.Data.Migrations
{
    [DbContext(typeof(PartnersAggContext))]
    [Migration("20221124185417_remove_id_fornecedor")]
    partial class remove_id_fornecedor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Bravo.Partners.Domain.Aggregates.PartnersAgg.Entities.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Classificacao")
                        .HasColumnType("text");

                    b.Property<string>("Cnpj")
                        .HasColumnType("text");

                    b.Property<string>("Cpf")
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

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("NomeContato")
                        .HasColumnType("text");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.Property<int?>("Tipo")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("Bravo.Partners.Domain.Aggregates.PartnersAgg.Entities.Publicitario", b =>
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

                    b.Property<int>("FornecedorId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<int?>("Tipo")
                        .HasColumnType("integer");

                    b.Property<int?>("TipoValorRepasse")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Publicitario");
                });

            modelBuilder.Entity("Bravo.Partners.Domain.Aggregates.PartnersAgg.Entities.Publicitario", b =>
                {
                    b.HasOne("Bravo.Partners.Domain.Aggregates.PartnersAgg.Entities.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });
#pragma warning restore 612, 618
        }
    }
}