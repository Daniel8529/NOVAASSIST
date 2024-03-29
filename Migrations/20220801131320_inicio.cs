﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NOVAASSIST.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    SueldoPorHora = table.Column<float>(type: "REAL", nullable: false),
                    Descuento = table.Column<float>(type: "REAL", nullable: false),
                    SueldoTotal = table.Column<float>(type: "REAL", nullable: false),
                    Horario = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "Asistencias",
                columns: table => new
                {
                    AsistenciaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false),
                    cedula = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha_Entrada = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fecha_Salida = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: true),
                    HuellaEmpleado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencias", x => x.AsistenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    ClaveUsuarios = table.Column<string>(type: "TEXT", nullable: true),
                    ClaveAcceso = table.Column<string>(type: "TEXT", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Cedula = table.Column<string>(type: "TEXT", nullable: true),
                    Genero = table.Column<string>(type: "TEXT", nullable: true),
                    Area = table.Column<int>(type: "INTEGER", nullable: false),
                    AreaDescripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Vacaciones = table.Column<int>(type: "INTEGER", nullable: false),
                    VacacionesDescripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Direccion = table.Column<string>(type: "TEXT", nullable: true),
                    contador = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: true),
                    EmpleadoEliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "Excepciones",
                columns: table => new
                {
                    ExcepcionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha_Creacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Descuento = table.Column<float>(type: "REAL", nullable: false),
                    ExcepcionEliminada = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Excepciones", x => x.ExcepcionId);
                });

            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    HorarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha_Entrada = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha_Salida = table.Column<string>(type: "TEXT", nullable: true),
                    Dias = table.Column<string>(type: "TEXT", nullable: true),
                    HorarioEliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.HorarioId);
                });

            migrationBuilder.CreateTable(
                name: "Vacaciones",
                columns: table => new
                {
                    VacacionesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha_Inicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacaciones", x => x.VacacionesId);
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaId", "Descripcion", "Descuento", "Horario", "Nombre", "SueldoPorHora", "SueldoTotal" },
                values: new object[] { 1, "Contable", 10f, "Noche", "Contabilidad", 100f, 1000f });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "AreaId", "Descripcion", "Descuento", "Horario", "Nombre", "SueldoPorHora", "SueldoTotal" },
                values: new object[] { 2, "Programador", 10f, "Tarde", "Sistemas", 100f, 1000f });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "EmpleadoId", "Area", "AreaDescripcion", "Cedula", "ClaveAcceso", "ClaveUsuarios", "Direccion", "Email", "EmpleadoEliminado", "Estado", "FechaNacimiento", "Genero", "Nombre", "Telefono", "Vacaciones", "VacacionesDescripcion", "contador" },
                values: new object[] { 1, 1, "Contabilidad", "123", "123", "12345", "Piantini", "jfasnfn@gmail.com", false, null, new DateTime(2010, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "Luisa", "8093", 1, "Vacaciones diciembre", 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "EmpleadoId", "Area", "AreaDescripcion", "Cedula", "ClaveAcceso", "ClaveUsuarios", "Direccion", "Email", "EmpleadoEliminado", "Estado", "FechaNacimiento", "Genero", "Nombre", "Telefono", "Vacaciones", "VacacionesDescripcion", "contador" },
                values: new object[] { 2, 2, "Informatica", "1234", "12", "1234", "Pimentel", "jf@gmail.com", false, null, new DateTime(2015, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "pedro", "80934", 2, "Vacaciones diciembre", 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "EmpleadoId", "Area", "AreaDescripcion", "Cedula", "ClaveAcceso", "ClaveUsuarios", "Direccion", "Email", "EmpleadoEliminado", "Estado", "FechaNacimiento", "Genero", "Nombre", "Telefono", "Vacaciones", "VacacionesDescripcion", "contador" },
                values: new object[] { 3, 1, "Contabilidad", "1235", "124", "123", "Santo Domingo", "mm@gmail.com", false, null, new DateTime(2017, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Femenino", "maria", "80939", 1, "Vacaciones diciembre", 0 });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "EmpleadoId", "Area", "AreaDescripcion", "Cedula", "ClaveAcceso", "ClaveUsuarios", "Direccion", "Email", "EmpleadoEliminado", "Estado", "FechaNacimiento", "Genero", "Nombre", "Telefono", "Vacaciones", "VacacionesDescripcion", "contador" },
                values: new object[] { 4, 2, "Informatica", "1236", "126", "12", "Samana", "zz@gmail.com", false, null, new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Masculino", "mario", "80938", 2, "Vacaciones diciembre", 0 });

            migrationBuilder.InsertData(
                table: "Vacaciones",
                columns: new[] { "VacacionesId", "Descripcion", "Fecha_Fin", "Fecha_Inicio" },
                values: new object[] { 1, "Vacaciones diciembre", new DateTime(2010, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Vacaciones",
                columns: new[] { "VacacionesId", "Descripcion", "Fecha_Fin", "Fecha_Inicio" },
                values: new object[] { 2, "Vacaciones Semana Santa", new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Asistencias");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Excepciones");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Vacaciones");
        }
    }
}
