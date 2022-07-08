﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NOVAASSIST.DAL;

#nullable disable

namespace NOVAASSIST.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("NOVAASSIST.Entidades.Areas", b =>
                {
                    b.Property<int>("AreaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<float>("Descuento")
                        .HasColumnType("REAL");

                    b.Property<string>("Horario")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<float>("SueldoPorHora")
                        .HasColumnType("REAL");

                    b.Property<float>("SueldoTotal")
                        .HasColumnType("REAL");

                    b.HasKey("AreaId");

                    b.ToTable("Areas");

                    b.HasData(
                        new
                        {
                            AreaId = 1,
                            Descripcion = "Contable",
                            Descuento = 10f,
                            Horario = "Noche",
                            Nombre = "Contabilidad",
                            SueldoPorHora = 100f,
                            SueldoTotal = 1000f
                        },
                        new
                        {
                            AreaId = 2,
                            Descripcion = "Programador",
                            Descuento = 10f,
                            Horario = "Tarde",
                            Nombre = "Sistemas",
                            SueldoPorHora = 100f,
                            SueldoTotal = 1000f
                        });
                });

            modelBuilder.Entity("NOVAASSIST.Entidades.Asistencias", b =>
                {
                    b.Property<int>("AsistenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha_Entrada")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha_Salida")
                        .HasColumnType("TEXT");

                    b.Property<string>("HuellaEmpleado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("cedula")
                        .HasColumnType("TEXT");

                    b.HasKey("AsistenciaId");

                    b.ToTable("Asistencias");
                });

            modelBuilder.Entity("NOVAASSIST.Entidades.Empleados", b =>
                {
                    b.Property<int>("EmpleadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Area")
                        .HasColumnType("INTEGER");

                    b.Property<string>("AreaDescripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaveAcceso")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaveUsuarios")
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("EmpleadoEliminado")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("Estado")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("Genero")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<int>("Vacaciones")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VacacionesDescripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("contador")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmpleadoId");

                    b.ToTable("Empleados");

                    b.HasData(
                        new
                        {
                            EmpleadoId = 1,
                            Area = 1,
                            AreaDescripcion = "Contabilidad",
                            Cedula = "123",
                            ClaveAcceso = "123",
                            ClaveUsuarios = "12345",
                            Direccion = "Piantini",
                            Email = "jfasnfn@gmail.com",
                            EmpleadoEliminado = false,
                            FechaNacimiento = new DateTime(2010, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = 1,
                            Nombre = "Luisa",
                            Telefono = "8093",
                            Vacaciones = 1,
                            VacacionesDescripcion = "Vacaciones diciembre",
                            contador = 0
                        },
                        new
                        {
                            EmpleadoId = 2,
                            Area = 2,
                            AreaDescripcion = "Informatica",
                            Cedula = "1234",
                            ClaveAcceso = "12",
                            ClaveUsuarios = "1234",
                            Direccion = "Pimentel",
                            Email = "jf@gmail.com",
                            EmpleadoEliminado = false,
                            FechaNacimiento = new DateTime(2015, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = 2,
                            Nombre = "pedro",
                            Telefono = "80934",
                            Vacaciones = 2,
                            VacacionesDescripcion = "Vacaciones diciembre",
                            contador = 0
                        },
                        new
                        {
                            EmpleadoId = 3,
                            Area = 1,
                            AreaDescripcion = "Contabilidad",
                            Cedula = "1235",
                            ClaveAcceso = "124",
                            ClaveUsuarios = "123",
                            Direccion = "Santo Domingo",
                            Email = "mm@gmail.com",
                            EmpleadoEliminado = false,
                            FechaNacimiento = new DateTime(2017, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = 1,
                            Nombre = "maria",
                            Telefono = "80939",
                            Vacaciones = 1,
                            VacacionesDescripcion = "Vacaciones diciembre",
                            contador = 0
                        },
                        new
                        {
                            EmpleadoId = 4,
                            Area = 2,
                            AreaDescripcion = "Informatica",
                            Cedula = "1236",
                            ClaveAcceso = "126",
                            ClaveUsuarios = "12",
                            Direccion = "Samana",
                            Email = "zz@gmail.com",
                            EmpleadoEliminado = false,
                            FechaNacimiento = new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genero = 2,
                            Nombre = "mario",
                            Telefono = "80938",
                            Vacaciones = 2,
                            VacacionesDescripcion = "Vacaciones diciembre",
                            contador = 0
                        });
                });

            modelBuilder.Entity("NOVAASSIST.Entidades.Horarios", b =>
                {
                    b.Property<int>("HorarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dias")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fecha_Entrada")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fecha_Salida")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("HorarioEliminado")
                        .HasColumnType("INTEGER");

                    b.HasKey("HorarioId");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("NOVAASSIST.Entidades.Vacaciones", b =>
                {
                    b.Property<int>("VacacionesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha_Fin")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha_Inicio")
                        .HasColumnType("TEXT");

                    b.HasKey("VacacionesId");

                    b.ToTable("Vacaciones");

                    b.HasData(
                        new
                        {
                            VacacionesId = 1,
                            Descripcion = "Vacaciones diciembre",
                            Fecha_Fin = new DateTime(2010, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fecha_Inicio = new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            VacacionesId = 2,
                            Descripcion = "Vacaciones Semana Santa",
                            Fecha_Fin = new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fecha_Inicio = new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
