using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;

namespace CapaDatos
{
    public class D_producto2
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_producto2> ListarProducto(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARPRODUCTO2", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_producto2> listar = new List<E_producto2>();

            while (LeerFilas.Read())
            {
                listar.Add(new E_producto2
                {
                    IdProducto = LeerFilas.GetInt32(0),
                    NombreProducto1 = LeerFilas.GetString(1),
                    CodigoBarras1 = LeerFilas.GetInt32(2),
                    CantidadProducto1 = LeerFilas.GetInt32(3),
                    PrecioProducto1 = LeerFilas.GetDecimal(4)
                });

            }

            conexion.Close();
            LeerFilas.Close();

            return listar;

        }

        public List<E_producto2> ListarProductos2(string buscar)
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARPRODUCTO2", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            LeerFilas = cmd.ExecuteReader();

            List<E_producto2> listar = new List<E_producto2>();

            while (LeerFilas.Read())
            {
                listar.Add(new E_producto2
                {
                    IdProducto = LeerFilas.GetInt32(0),
                    NombreProducto1 = LeerFilas.GetString(1),
                    CodigoBarras1 = LeerFilas.GetInt32(2),
                    CantidadProducto1 = LeerFilas.GetInt32(3),
                    PrecioProducto1 = LeerFilas.GetDecimal(4)
                });

            }

            conexion.Close();
            LeerFilas.Close();

            return listar;

        }

        public void InsertarProducto(E_producto2 Producto)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARPRODUCTO2", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", Producto.NombreProducto1);
            cmd.Parameters.AddWithValue("@CODIGO", Producto.CodigoBarras1);
            cmd.Parameters.AddWithValue("@CANTIDAD", Producto.CantidadProducto1);
            cmd.Parameters.AddWithValue("@PRECIO", Producto.PrecioProducto1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarProducto(E_producto2 Producto)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARPRODUCTO2", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDPRODUCTO", Producto.IdProducto);
            cmd.Parameters.AddWithValue("@NOMBRE", Producto.NombreProducto1);
            cmd.Parameters.AddWithValue("@CODIGO", Producto.CodigoBarras1);
            cmd.Parameters.AddWithValue("@CANTIDAD", Producto.CantidadProducto1);
            cmd.Parameters.AddWithValue("@PRECIO", Producto.PrecioProducto1);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarProducto(E_producto2 Producto)
        {
            SqlCommand cmd = new SqlCommand("SP_EMINIMARPRODUCTO2", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDPRODUCTO", Producto.IdProducto);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
