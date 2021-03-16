﻿// <auto-generated />
using System;
using IfsParticipe.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IfsParticipe.Migrations
{
    [DbContext(typeof(IfsParticipeContext))]
    [Migration("20210315183524_relacionamentos")]
    partial class relacionamentos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IfsParticipe.Models.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int>("IdDemanda");

                    b.Property<int>("IdUsuario");

                    b.HasKey("Id");

                    b.HasIndex("IdDemanda");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("IfsParticipe.Models.Demanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Categoria")
                        .IsRequired();

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int?>("IdDemanda");

                    b.Property<int>("IdPDI");

                    b.Property<int>("IdUsuario");

                    b.Property<int?>("Situacao");

                    b.Property<string>("Titulo")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdDemanda");

                    b.ToTable("Demanda");
                });

            modelBuilder.Entity("IfsParticipe.Models.PDI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAtualizacao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime?>("DataFimRecDem");

                    b.Property<DateTime?>("DataFimVig")
                        .IsRequired();

                    b.Property<DateTime?>("DataIniRecDem");

                    b.Property<DateTime?>("DataIniVig")
                        .IsRequired();

                    b.Property<int>("IdUsuario");

                    b.Property<int?>("Situacao")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("PDI");
                });

            modelBuilder.Entity("IfsParticipe.Models.Comentario", b =>
                {
                    b.HasOne("IfsParticipe.Models.Demanda", "DemandaPDI")
                        .WithMany()
                        .HasForeignKey("IdDemanda")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IfsParticipe.Models.Demanda", b =>
                {
                    b.HasOne("IfsParticipe.Models.PDI", "Pdi")
                        .WithMany()
                        .HasForeignKey("IdDemanda");
                });
#pragma warning restore 612, 618
        }
    }
}
