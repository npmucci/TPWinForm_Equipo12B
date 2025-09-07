using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            ImagenNegocio imagen = new ImagenNegocio();

            try
            {
                datos.SetearConsulta(@"SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio,
                                       M.Id AS IdMarca, M.Descripcion AS Marca,
                                       C.Id AS IdCategoria, C.Descripcion AS Categoria
                                       FROM dbo.ARTICULOS A
                                       JOIN dbo.MARCAS M ON A.IdMarca = M.Id
                                       JOIN dbo.CATEGORIAS C ON A.IdCategoria = C.Id");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo art = new Articulo
                    {
                        Id = (int)datos.Lector["Id"],
                        Codigo = datos.Lector["Codigo"].ToString(),
                        Nombre = datos.Lector["Nombre"].ToString(),
                        Descripcion = datos.Lector["Descripcion"].ToString(),
                        Precio = (decimal)datos.Lector["Precio"],
                        Marca = new Marca
                        {
                            Id = (int)datos.Lector["IdMarca"],
                            Descripcion = datos.Lector["Marca"].ToString()
                        },
                        Categoria = new Categoria
                        {
                            Id = (int)datos.Lector["IdCategoria"],
                            Descripcion = datos.Lector["Categoria"].ToString()
                        },
                    };
                    art.Imagenes = imagen.ListarImagenes(art.Id);
                    lista.Add(art);
                }

                return lista;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}