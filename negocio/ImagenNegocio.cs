using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace negocio
{
 public class ImagenNegocio
    {
        public List<Imagen> ListarImagenes(int idArticulo)
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();
            //imagenes.setearConsulta("select ImagenUrl from Imagenes where IdArticulo = " + idArticulo + ";");
            datos.SetearConsulta("select Id,ImagenUrl from Imagenes where IdArticulo = @IdArticulo;");
            datos.SetearParametro("IdArticulo", idArticulo);
            datos.EjecutarLectura();
            try
            {
               
                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Url = (string)datos.Lector["ImagenUrl"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void AgregarImagenes(List<Imagen> urls, int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                foreach (var img in urls)
                {
                    string query = "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @url)";
                    datos.SetearConsulta(query);
                    datos.SetearParametro("@idArticulo", idArticulo);
                    datos.SetearParametro("@url", img.Url);
                    datos.EjecutarAccion();
                }
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
        //elimino todas las imagenes de un articulo para despues agregar las nuevas
        public void EliminarImagen(int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string query = "DELETE FROM IMAGENES WHERE IdArticulo = @idArticulo"; 
                datos.SetearConsulta(query);
                datos.SetearParametro("@idArticulo", idArticulo); 
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

        public void ModificarImagenes(List<Imagen> urls, int idArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Eliminar las imágenes existentes para el artículo asi no se duplican
                EliminarImagen(idArticulo);
                // Insertar las nuevas imágenes
                foreach (var img in urls)
                {
                    string insertQuery = "INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @url)";
                    datos.SetearConsulta(insertQuery);
                    datos.SetearParametro("@idArticulo", idArticulo);
                    datos.SetearParametro("@url", img.Url);
                    datos.EjecutarAccion();
                }
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
