﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolarCore.Model
{
    public class Personas
    {
        public int Id { get; }

        /// <summary>
        /// Nombre completo de la persona
        /// </summary>
        public string NombreCompleto { get; set; }

        /// <summary>
        /// Correo electrónico de la persona
        /// </summary>
        public string Correo { get; set; }

        /// <summary>
        /// Número de teléfono de la persona
        /// </summary>
        public string Telefono { get; set; }

        /// <summary>
        /// CURP (Clave Única de Registro de Población) de la persona
        /// </summary>
        public string Curp { get; set; }

        /// <summary>
        /// Fecha de nacimiento de la persona
        /// </summary>
        public DateTime? FechaNacimiento { get; set; }

        /// <summary>
        /// Indica si la persona está activa en el sistema
        /// </summary>
        public bool Estatus { get; set; }


        //Constructores
        public Personas()
        {
            Id = 0;
            NombreCompleto = string.Empty;
            Correo = string.Empty;
            Telefono = string.Empty;
            Curp = string.Empty;
            FechaNacimiento = null;
            Estatus = true; //vacío
        }

        public Personas(string nombreCompleto, string correo, string telefono, string curp)
        {
            NombreCompleto = nombreCompleto;
            Correo = correo;
            Telefono = telefono;
            Curp = curp;
        }

        public Personas(int id, string nombreCompleto, string correo, string telefono, string curp, DateTime? fechaNacimiento, bool estatus)
        {
            Id = id;
            NombreCompleto = nombreCompleto;
            Correo = correo;
            Telefono = telefono;
            Curp = curp;
            FechaNacimiento = fechaNacimiento;
            Estatus = estatus; //datos obligatorios
        }

    }
}
