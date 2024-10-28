﻿// <auto-generated />
using System;
using HealFit.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HealFit.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241028112843_correcao")]
    partial class correcao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("HealFit.Models.Consumo", b =>
                {
                    b.Property<int>("ConsumoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ConsumoId"));

                    b.Property<decimal>("AddedSugars")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Calcium")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Calories")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Carbohydrate")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Cholesterol")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Fat")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Fiber")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Iron")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("MeasurementDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("MetricServingAmount")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("MetricServingUnit")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<decimal>("MonounsaturatedFat")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("NumberOfUnits")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("varchar(8)");

                    b.Property<decimal>("PolyunsaturatedFat")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Potassium")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Produto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("Protein")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<double>("Quantidade")
                        .HasColumnType("double");

                    b.Property<decimal>("SaturatedFat")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("ServingDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("ServingId")
                        .HasColumnType("int");

                    b.Property<decimal>("Sodium")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Sugar")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("TransFat")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("UsuarioId")
                        .HasMaxLength(8)
                        .HasColumnType("int");

                    b.Property<decimal>("VitaminA")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("VitaminC")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("VitaminD")
                        .HasMaxLength(8)
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ConsumoId");

                    b.ToTable("Consumo");
                });

            modelBuilder.Entity("HealFit.Models.DadosPessoais", b =>
                {
                    b.Property<int>("DadosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("DadosId"));

                    b.Property<double?>("Altura")
                        .HasColumnType("double");

                    b.Property<string>("Bairro")
                        .HasColumnType("longtext");

                    b.Property<int?>("Cep")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Complemento")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<double?>("Peso")
                        .HasColumnType("double");

                    b.Property<string>("Rua")
                        .HasColumnType("longtext");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("DadosId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("DadosPessoais");
                });

            modelBuilder.Entity("HealFit.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("HealFit.Models.DadosPessoais", b =>
                {
                    b.HasOne("HealFit.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
