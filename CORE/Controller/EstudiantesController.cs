using ControlEscolarCore.Data;
using ControlEscolarCore.Model;
using NLog;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEscolarCore.Controller
{
    public class EstudiantesController
    {
        private static readonly Logger _logger = LogManager.GetLogger("DiseñoForms.Controller.EstudiantesController");
        private readonly EstudiantesDataAccess _estudiantesData;
        private readonly PersonasDataAccess _personasData;

        public EstudiantesController()
        {
            try
            {
                _estudiantesData = new EstudiantesDataAccess();
                _personasData = new PersonasDataAccess();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al crear la conexión a la base de datos");
                throw;
            }
        }
        public List<Estudiantes> ObtnerTodosLosEstudiantes(bool soloActivos = true, int tipofecha = 0,
                                                            DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            try
            {
                //Obtener los estudiantes de la capa de acceso a datos
                var estudiantes = _estudiantesData.ObtenerTodosLosEstudiantes(soloActivos, tipofecha, fechaInicio);
                _logger.Info($"Se obtuvieron {estudiantes.Count} estudiantes correctamente");
                return estudiantes;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener la lista de los estudiantes");
                throw; //Propagar la excepción
            }
        }

        /// <summary>
        /// Registra un nuevo estudiante en el sistema
        /// </summary>
        /// <param name="estudiante">Objeto Estudiante con todos los datos para registro</param>
        /// <returns>Tupla con (id del estudiante, mensaje de resultado)</returns>
        public (int id, string mensaje) RegistrarEstudiante(Estudiantes estudiante)
        {
            try
            {
                // Verificar si la matrícula ya existe
                if (_estudiantesData.ExisteMatricula(estudiante.Matricula))
                {
                    _logger.Warn($"Intento de registrar estudiante con matrícula duplicada: {estudiante.Matricula}");
                    return (-3, $"La matrícula {estudiante.Matricula} ya está registrada en el sistema");
                }

                // Verificar si el CURP ya existe
                if (_personasData.ExisteCurp(estudiante.DatosPersonales.Curp))
                {
                    _logger.Warn($"Intento de registrar estudiante con CURP duplicado: {estudiante.DatosPersonales.Curp}");
                    return (-2, $"El CURP {estudiante.DatosPersonales.Curp} ya está registrado en el sistema");
                }

                // Registrar el estudiante
                _logger.Info($"Registrando nuevo estudiante: {estudiante.DatosPersonales.NombreCompleto}, Matrícula: {estudiante.Matricula}");
                int idEstudiante = _estudiantesData.InsertarEstudiante(estudiante);

                if (idEstudiante <= 0)
                {
                    return (-4, "Error al registrar el estudiante en la base de datos");
                }

                _logger.Info($"Estudiante registrado exitosamente con ID: {idEstudiante}");
                return (idEstudiante, "Estudiante registrado exitosamente");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al registrar estudiante: {estudiante.DatosPersonales?.NombreCompleto ?? "Sin nombre"}, Matrícula: {estudiante.Matricula}");
                return (-5, $"Error inesperado: {ex.Message}");
            }
        }

        public Estudiantes? ObtenerDetalleEstudiante(int idEstudiante)
        {
            try
            {
                _logger.Debug($"Solicitando detalle del estudiante con ID: {idEstudiante}");
                return _estudiantesData.ObtenerEstudiantePorId(idEstudiante);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener los detalles del estudiante con ID: {idEstudiante}");
                throw;
            }
        }


        public (bool exito, string mensaje) ActualizarNombreEstudiante(int idestudiante, string nuevo_nombre)
        {
            try
            {


                // Verificar si el estudiante existe
                Estudiantes? estudianteExistente = _estudiantesData.ObtenerEstudiantePorId(idestudiante);
                if (estudianteExistente == null)
                {
                    return (false, $"No se encontró el estudiante con ID {idestudiante}");
                }

                estudianteExistente.DatosPersonales.NombreCompleto = nuevo_nombre;


                bool resultado = _estudiantesData.ActualizarEstudiante(estudianteExistente);
                
                if (!resultado)
                {
                    _logger.Error($"Error al actualizar el estudiante con ID {idestudiante}");
                    return (false, "Error al actualizar el estudiante en la base de datos");
                }

                _logger.Info($"Estudiante con ID {idestudiante} actualizado exitosamente");
                return (true, "Estudiante actualizado exitosamente");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error inesperado al actualizar estudiante con ID {idestudiante}");
                return (false, $"Error inesperado: {ex.Message}");
            }
        }

    }
}
