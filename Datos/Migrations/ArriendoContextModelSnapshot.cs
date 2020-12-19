﻿// <auto-generated />
using Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datos.Migrations
{
    [DbContext(typeof(ArriendoContext))]
    partial class ArriendoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entidad.ArriendoInmueble", b =>
                {
                    b.Property<string>("MatriculaInmueble")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdentificacionArrendatario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MesesAlquiler")
                        .HasColumnType("int");

                    b.Property<string>("NombreArrendatario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ValorDeposito")
                        .HasColumnType("real");

                    b.HasKey("MatriculaInmueble");

                    b.ToTable("ArriendosInmuebles");
                });

            modelBuilder.Entity("Entidad.Inmueble", b =>
                {
                    b.Property<string>("MatriculaInmobiliaria")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("ValorArriendo")
                        .HasColumnType("real");

                    b.HasKey("MatriculaInmobiliaria");

                    b.ToTable("Inmuebles");
                });
#pragma warning restore 612, 618
        }
    }
}
