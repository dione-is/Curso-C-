﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sistemaWeb.Models;

namespace sistemaWeb.Migrations
{
    [DbContext(typeof(sistemaWebContext))]
    partial class sistemaWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("sistemaWeb.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("sistemaWeb.Models.RegistroVendas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("Status");

                    b.Property<double>("Valor");

                    b.Property<int?>("VendedorId");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId");

                    b.ToTable("RegistroVendas");
                });

            modelBuilder.Entity("sistemaWeb.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int>("DepartamentoId");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<double>("SalarioBase");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("sistemaWeb.Models.RegistroVendas", b =>
                {
                    b.HasOne("sistemaWeb.Models.Vendedor", "Vendedor")
                        .WithMany("listaVendas")
                        .HasForeignKey("VendedorId");
                });

            modelBuilder.Entity("sistemaWeb.Models.Vendedor", b =>
                {
                    b.HasOne("sistemaWeb.Models.Departamento", "Departamento")
                        .WithMany("listaVendedores")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
