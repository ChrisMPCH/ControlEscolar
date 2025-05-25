using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlEscolarCore.Utilities;
using NLog;
using Npgsql;
using NpgsqlTypes;

namespace ControlEscolarCore.Data
{
    public class PosgresSQLAccess
    {
        //Clase que maneja la conexión a la base de datos en PostgreSQL, incluyendo las operaciones de consulta, inserción,
        //actualización y eliminación de registros

        //Logger usando el LoggingManager
        private static readonly Logger _logger = LoggingManager.GetLogger("ControlEscolar.Data.PostgreSQLDataAccess");

        //Cadena de conexión desde App.config
        //private static readonly string _ConnectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;

        // Campo estático para almacenar la cadena de conexión
        private static string _connectionString;

        private NpgsqlConnection _connection;
        private static PosgresSQLAccess? _instance;

        // Propiedad para establecer la cadena de conexión desde el API
        public static string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    try
                    {
                        // Intenta obtener desde ConfigurationManager (Windows Forms)
                        _connectionString = ConfigurationManager.ConnectionStrings["ConexionBD"]?.ConnectionString;
                    }
                    catch (Exception ex)
                    {
                        _logger.Warn(ex, "No se pudo obtener la cadena de conexión desde ConfigurationManager");
                    }
                }
                return _connectionString;
            }
            set { _connectionString = value; }
        }


        //Constructor privado para evitar instanciación directa
        private PosgresSQLAccess()
        {
            try
            {
                _connection = new NpgsqlConnection(_connectionString);
                _logger.Info("Instancia de acceso a datos creada correctamente");
            }
            catch (Exception ex)
            {
                _logger.Fatal("Error al intentar conectar a la base de datos");
                throw; //El throw sin argumentos mantiene la excepción original
            }

        }

        //Método para obtener la instancia de la clase y asegurar que solo exista una
        public static PosgresSQLAccess GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PosgresSQLAccess();
            }
            return _instance;
        }


        //Método para abrir la conexión a la base de datos
        public bool Connect()
        {
            try
            {
                if (_connection.State != ConnectionState.Open)
                {
                    _connection.Open();
                    _logger.Info("Conexión a la base de datos abierta");
                }
                return true;
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Error al intentar conectar a la base de datos");
                throw;
            }
        }

        //Método para cerrar la conexión a la base de datos
        public bool Disconnect()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                    _logger.Info("Conexión a la base de datos se ha cerrado");
                }
                return true;
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, "Error al intentar cerrar la conexión");
                throw;
            }
        }
        public DataTable ExecuteQuery_Reader(string query, params NpgsqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                _logger.Debug($"Ejecutando consulta: {query}");
                using (NpgsqlCommand command = CreateCommand(query, parameters))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        _logger.Debug($"Consulta ejecutada correctamente: {query}");
                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al ejecutar una consulta en la base de datos:{query} ");
                throw;
            }
        }

        public int ExecuteNonQuery(string query, params NpgsqlParameter[] parameters)
        {
            try
            {
                _logger.Debug($"Ejecutando operación: {query}");
                using (NpgsqlCommand command = CreateCommand(query, parameters))
                {
                    int result = command.ExecuteNonQuery();
                    _logger.Debug($"Operación ejecutada exitosamente. ID afectado: {result}");
                    return result;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al ejecutar la operación: {query}");
                throw;
            }
        }

        public object ExecuteScalar(string query, params NpgsqlParameter[] parameters)
        {
            try
            {
                _logger.Debug($"Ejecutando operación: {query}");
                using (NpgsqlCommand command = CreateCommand(query, parameters))
                {
                    object? result = command.ExecuteScalar();
                    _logger.Debug($"Operación ejecutada exitosamente. Filas afectadas: {result}");
                    return result;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al ejecutar la operación: {query}");
                throw;
            }
        }

        private NpgsqlCommand CreateCommand(string query, NpgsqlParameter[] parameters)
        {
            NpgsqlCommand command = new NpgsqlCommand(query, _connection);

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
                foreach (var param in parameters)
                {
                    _logger.Trace($"Parámetro: {param.ParameterName} = {param.Value ?? "NULL"}");
                }
                Connect();
            }
            return command;
        }

        // === METODOS PARA EJECUTAR PROCEDIMIENTOS ALMACENADOS ===

        public NpgsqlParameter CreateParameter(string name, object value)
        {
            return new NpgsqlParameter(name, value ?? DBNull.Value);
        }

        /// <summary>
        /// Crea un parametro de salida OUTPUT para un procedimiento almacenado
        /// </summary>

        public NpgsqlParameter CreateOutputParameter(string name, NpgsqlDbType type)
        {
            NpgsqlParameter parameter = new NpgsqlParameter(name, type);
            parameter.Direction = ParameterDirection.Output;
            return parameter;
        }
    }
}
