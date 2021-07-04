using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_producto
    {
        private int idProducto;
        private string NombreProducto;
        private int CodigoBarras;
        private int CantidadProducto;
        private decimal PrecioProducto;
        private int VentaCantidad;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto1 { get => NombreProducto; set => NombreProducto = value; }
        public int CodigoBarras1 { get => CodigoBarras; set => CodigoBarras = value; }
        public int CantidadProducto1 { get => CantidadProducto; set => CantidadProducto = value; }
        public decimal PrecioProducto1 { get => PrecioProducto; set => PrecioProducto = value; }
        public int VentaCantidad1 { get => VentaCantidad; set => VentaCantidad = value; }
    }
}
