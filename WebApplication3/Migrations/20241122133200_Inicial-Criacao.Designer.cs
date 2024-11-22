﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Models;

#nullable disable

namespace WebApplication3.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241122133200_Inicial-Criacao")]
    partial class InicialCriacao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication3.Models.Itens", b =>
                {
                    b.Property<Guid>("notaFiscalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("cnpjDestinatarioNf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cnpjDestinatarioNf");

                    b.Property<string>("cnpjEmissorNf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("cnpfEmissorNf");

                    b.Property<string>("dataNf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("dataNf");

                    b.Property<string>("numeroNf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("numeroNf");

                    b.Property<float>("valorTotal")
                        .HasColumnType("real")
                        .HasColumnName("valorTotal");

                    b.HasKey("notaFiscalId");

                    b.ToTable("Notas Fiscais");
                });
#pragma warning restore 612, 618
        }
    }
}