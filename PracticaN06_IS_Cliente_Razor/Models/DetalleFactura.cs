// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 06

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticaN06_IS_Cliente_Razor.Models
{
    public class DetalleFactura
    {
        public int id { get; set; }
        public int idFactura { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public DetalleFactura() { }

        public DetalleFactura(int id, int idFactura, int idProducto, int cantidad, decimal precio)
        {
            this.id = id;
            this.idFactura = idFactura;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.precio = precio;
        }
    }
}