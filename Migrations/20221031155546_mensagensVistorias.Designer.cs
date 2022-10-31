﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisTu.Data;

#nullable disable

namespace VisTu.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221031155546_mensagensVistorias")]
    partial class mensagensVistorias
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VisTu.Models.Avaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Grau")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeAvaria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TubulacaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TubulacaoId");

                    b.ToTable("Avarias");
                });

            modelBuilder.Entity("VisTu.Models.Mensagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TextoMensagem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Mensagens");
                });

            modelBuilder.Entity("VisTu.Models.Setor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeSetor")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Setores");
                });

            modelBuilder.Entity("VisTu.Models.Tubulacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomeTubulacao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Tubulacoes");
                });

            modelBuilder.Entity("VisTu.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Celular")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Salt")
                        .HasColumnType("longtext");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int>("SetorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SetorId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("VisTu.Models.Vistoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataReparo")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataVistoria")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Observação")
                        .HasColumnType("longtext");

                    b.Property<int>("TubulacaoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioVistoriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TubulacaoId");

                    b.HasIndex("UsuarioVistoriaId");

                    b.ToTable("Vistorias");
                });

            modelBuilder.Entity("VisTu.Models.Avaria", b =>
                {
                    b.HasOne("VisTu.Models.Tubulacao", "Tubulacao")
                        .WithMany("Avarias")
                        .HasForeignKey("TubulacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tubulacao");
                });

            modelBuilder.Entity("VisTu.Models.Usuario", b =>
                {
                    b.HasOne("VisTu.Models.Setor", "Setor")
                        .WithMany("Usuarios")
                        .HasForeignKey("SetorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Setor");
                });

            modelBuilder.Entity("VisTu.Models.Vistoria", b =>
                {
                    b.HasOne("VisTu.Models.Tubulacao", "Tubulacao")
                        .WithMany()
                        .HasForeignKey("TubulacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VisTu.Models.Usuario", "UsuarioVistoria")
                        .WithMany("Vistorias")
                        .HasForeignKey("UsuarioVistoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tubulacao");

                    b.Navigation("UsuarioVistoria");
                });

            modelBuilder.Entity("VisTu.Models.Setor", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("VisTu.Models.Tubulacao", b =>
                {
                    b.Navigation("Avarias");
                });

            modelBuilder.Entity("VisTu.Models.Usuario", b =>
                {
                    b.Navigation("Vistorias");
                });
#pragma warning restore 612, 618
        }
    }
}
