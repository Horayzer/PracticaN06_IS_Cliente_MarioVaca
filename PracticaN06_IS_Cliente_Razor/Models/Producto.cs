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
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio_unitario { get; set; }
        public byte iva { get; set; }

        public Producto() { }

        public Producto(int id, string nombre, decimal precio_unitario, byte iva)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio_unitario = precio_unitario;
            this.iva = iva;
        }
    }
}