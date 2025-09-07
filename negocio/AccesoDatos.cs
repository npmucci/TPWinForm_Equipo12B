using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        //Modificar para el acceso a cada uno
        //mateo
        //private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        //narty
        private string connectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";



        // para leer
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        // consulta
        public void SetearConsulta(string query)
        {
            conexion = new SqlConnection(connectionString);
            comando = new SqlCommand(query, conexion);
        }

        // SELECT
        public void EjecutarLectura()
        {
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // INSERT/UPDATE/DELETE
        public void EjecutarAccion()
        {
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // limpiar recursos
        public void CerrarConexion()
        {
            if (lector != null)
                lector.Close();
            if (conexion != null)
                conexion.Close();
        }

        public void SetearParametro(string nombre, object valor) // uso object porque puede recibir cualquier valor
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public int EjecutarAccionEscalar()  // ejecuta la consulta y devuelve el primer valor de la primera fila,
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                object resultado = comando.ExecuteScalar();
                return Convert.ToInt32(resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}