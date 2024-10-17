﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20241017115530_ArrumandoModels4")]
    partial class ArrumandoModels4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("API.Models.AreaEspecializacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AreasEspecializacao");
                });

            modelBuilder.Entity("API.Models.Arqueologo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnosExperiencia")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<int>("FormacaoAcademicaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdRegistroProfissional")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FormacaoAcademicaId");

                    b.ToTable("Arqueologos");
                });

            modelBuilder.Entity("API.Models.Artefato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CivilizacaoOrigem")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dimensao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Funcionalidade")
                        .HasColumnType("TEXT");

                    b.Property<string>("Material")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Periodo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Artefatos");
                });

            modelBuilder.Entity("API.Models.FormacaoAcademica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FormacoesAcademicas");
                });

            modelBuilder.Entity("API.Models.Fossil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CondicaoPreservacao")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("EpocaGeologica")
                        .HasColumnType("TEXT");

                    b.Property<string>("EspeciaOrganismo")
                        .HasColumnType("TEXT");

                    b.Property<string>("LocalizacaoDescoberta")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeCientifico")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoFossil")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Fosseis");
                });

            modelBuilder.Entity("API.Models.Paleontologo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnosExperiencia")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AreaEspecializacaoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdMatricula")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AreaEspecializacaoId");

                    b.ToTable("Paleontologos");
                });

            modelBuilder.Entity("API.Models.Arqueologo", b =>
                {
                    b.HasOne("API.Models.FormacaoAcademica", "FormacaoAcademica")
                        .WithMany()
                        .HasForeignKey("FormacaoAcademicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormacaoAcademica");
                });

            modelBuilder.Entity("API.Models.Paleontologo", b =>
                {
                    b.HasOne("API.Models.AreaEspecializacao", "AreaEspecializacao")
                        .WithMany()
                        .HasForeignKey("AreaEspecializacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AreaEspecializacao");
                });
#pragma warning restore 612, 618
        }
    }
}
