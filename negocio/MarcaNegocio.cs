using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class MarcaNegocio
    {

        public List<Marca> Listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)datos.Lector["Id"];
                    marca.Descripcion = datos.Lector["Descripcion"].ToString();
                    lista.Add(marca);
                }
                return lista;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void AgregarMarca(Marca nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string query = @"
                    INSERT INTO MARCAS (Descripcion)
                    VALUES (@descripcion)";

                datos.SetearConsulta(query);
                datos.SetearParametro("@descripcion", nueva.Descripcion);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

        }

        public void EliminarMarca(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string query = "DELETE FROM MARCAS WHERE Id = @id";
                datos.SetearConsulta(query);
                datos.SetearParametro("@id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
