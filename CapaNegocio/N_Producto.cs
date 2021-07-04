using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Producto
    {
        D_producto objDato = new D_producto();

        public List<E_producto>ListandoProducto(string buscar)
        {
            return objDato.ListarProducto(buscar);

        }
        public List<E_producto> ListarProductos(string buscar)
        {
            return objDato.ListarProducto(buscar);

        }
        public void CantidadVenta(E_producto Producto)
        {
            objDato.VenderProducto(Producto);
        }
        public void InsertandoProducto(E_producto Producto)
        {
            objDato.InsertarProducto(Producto);
        }
        public void EditandoProducto(E_producto Producto)
        {
            objDato.EditarProducto(Producto);
        }
        public void EliminarProducto(E_producto Producto)
        {
            objDato.EliminarProducto(Producto);
        }
    }
}
