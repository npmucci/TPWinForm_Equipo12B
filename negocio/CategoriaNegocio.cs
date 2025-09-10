using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class CategoriaNegocio
    {
        

        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)datos.Lector["Id"];
                    categoria.Descripcion = datos.Lector["Descripcion"].ToString();
                    lista.Add(categoria);
                }
                return lista;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void AgregarCategoria(Categoria nueva)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string query = @"
                    INSERT INTO CATEGORIAS (Descripcion)
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

        public void EliminarCategoria(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string query = "DELETE FROM CATEGORIAS WHERE Id = @id";
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
