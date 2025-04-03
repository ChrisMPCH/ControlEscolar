using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlEscolar.Model;
using ControlEscolar.Utilities;
using NLog;
using Npgsql;

namespace ControlEscolar.Data
{
    class EstudiantesDataAccess
    {
        //Logger usando el LoggingManager
        private static readonly Logger _logger = LoggingManager.GetLogger("ControlEscolar.Data.EstudianteDataAccess");

        private readonly PosgresSQLAccess _dbAccess = null;

        private readonly PersonasDataAccess _personasDataAccess;

        public EstudiantesDataAccess()
        {
            try
            {
                //Obtener instancia de PosgresSQLAccess atraves de su método GetInstance
                _dbAccess = PosgresSQLAccess.GetInstance();
                _personasDataAccess = new PersonasDataAccess();
            }
            catch(Exception ex)
            {
                _logger.Error(ex, "Error al intentar crear instancia de EstudiantesDataAccess");
                throw;
            }
        }

        public List<Estudiantes> ObtenerTodosLosEstudiantes(bool soloActivos = true, int tipoFecha = 0, DateTime? fechaInicio = null, DateTime? fechaFinal = null)
        {
            List<Estudiantes> estudiantes = new List<Estudiantes>();
            try
            {
                string query = @"
                    SELECT e.id, e.matricula, e.semestre, e.fecha_alta, e.fecha_baja, e.estatus,
	                CASE
		                WHEN e.estatus = 0 THEN 'Baja'
		                WHEN e.estatus = 0 THEN 'Activo'
		                WHEN e.estatus = 0 THEN 'Baja temporal'
	                ELSE
		                'Desconocido'
	                END AS descestatus_estudiante,
	                e.id_persona, p.nombre_completo, p.correo, p.telefono, p.fecha_nacimiento, p.curp, p.estatus as estatus_persona
                    FROM escolar.estudiantes e
                    INNER JOIN seguridad.personas p ON e.id_persona = p.id
                    WHERE 1=1"; //1=1 es una técnica para no tener que validar si se agrega un AND en el query

                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>();

                //filtro solo activos
                if (soloActivos)
                {
                    query += " AND e.estatus = 1";
                }

                //Filtro por fecha
                if (fechaInicio != null && fechaFinal != null)
                {
                    switch (tipoFecha)
                    {
                        case 1:
                            query += " AND e.fecha_nacimiento BETWEEN @fechaInicio AND @fechaFinal";
                            break;
                        case 2:
                            query += " AND e.fecha_alta BETWEEN @fechaInicio AND @fechaFinal";
                            break;
                        case 3:
                            query += " AND e.fecha_baja BETWEEN @fechaInicio AND @fechaFinal";
                            break;
                    }
                    parameters.Add(_dbAccess.CreateParameter(@"fechaInicio", fechaInicio.Value));
                    parameters.Add(_dbAccess.CreateParameter(@"fechaFin", fechaInicio.Value));
                }
                //Ordenar por id
                query += " ORDER BY e.id";

                //Conectar a la base de datos
                _dbAccess.Connect();

                //Ejecutar la consulta con los parametros
                DataTable result = _dbAccess.ExecuteQuery_Reader(query, parameters.ToArray());

                //Convertir los resultados a objetos de tipo Estudiantes
                foreach (DataRow row in result.Rows)
                {
                    Personas personas = new Personas(
                        Convert.ToInt32(row["id_persona"]),
                        row["nombre_completo"].ToString() ?? "",
                        row["correo"].ToString() ?? "",
                        row["telefono"].ToString() ?? "",
                        row["curp"].ToString() ?? "",
                        row["fecha_nacimiento"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_nacimiento"]) : null,
                        Convert.ToBoolean(row["estatus_persona"])
                    );

                    Estudiantes estudiante = new Estudiantes(
                        Convert.ToInt32(row["id"]),
                        Convert.ToInt32(row["id_persona"]),
                        row["matricula"].ToString() ?? "",
                        row["semestre"].ToString() ?? "",
                        Convert.ToDateTime(row["fecha_alta"]),
                        row["fecha_baja"] == DBNull.Value ? (DateTime?)Convert.ToDateTime(row["fecha_baja"]) : null,
                        Convert.ToInt32(row["estatus"]),
                        row["descestatus_estudiante"].ToString() ?? "",
                        personas
                    );
                    estudiantes.Add(estudiante);
                }

                _logger.Debug($"Se obtuvieron {estudiantes.Count} registros de estudiantes");
                return estudiantes;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al intentar obtener la lista de estudiantes de la base de datos");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
    }
}
