using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Producto2
    {
        D_producto2 objDato = new D_producto2();

        public List<E_producto2> ListandoProducto(string buscar)
        {
            return objDato.ListarProducto(buscar);

        }
        public List<E_producto2> ListarProductos2(string buscar)
        {
            return objDato.ListarProductos2(buscar);

        }
        public void InsertandoProducto(E_producto2 Producto)
        {
            objDato.InsertarProducto(Producto);
        }
        public void EditandoProducto(E_producto2 Producto)
        {
            objDato.EditarProducto(Producto);
        }
        public void EliminarProducto(E_producto2 Producto)
        {
            objDato.EliminarProducto(Producto);
        }
    }
}
