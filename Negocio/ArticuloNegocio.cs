using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo> ();
            AccesoDatos datos = new AccesoDatos ();

            try
            {
                datos.setearConsulta("select Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, M.Descripcion as Marca, C.Descripcion as Categoria from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca and C.Id = A.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo ();
                    aux.CodigoArticulo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if(!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }
                    aux.Precio = Math.Round((decimal)datos.Lector["Precio"], 2);
                    aux.Marca= new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
            
            }

            public void agregar(Articulo nuevoArt)
            {
                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values(@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @UrlImagen, @Precio)");
                    datos.setearParametro("@Codigo", nuevoArt.CodigoArticulo);
                    datos.setearParametro("@Nombre", nuevoArt.Nombre);
                    datos.setearParametro("@Descripcion", nuevoArt.Descripcion);
                    datos.setearParametro("@IdMarca", nuevoArt.Marca.Id);
                    datos.setearParametro("@IdCategoria", nuevoArt.Categoria.Id);
                    datos.setearParametro("@UrlImagen", nuevoArt.UrlImagen);
                    datos.setearParametro("@Precio", nuevoArt.Precio);
                    datos.ejecutarAccion();

                }
                catch (Exception ex)
                {

                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }

        }
    }
}
