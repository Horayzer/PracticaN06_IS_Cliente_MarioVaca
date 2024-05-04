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
    public class Factura
    {
        public int numero { get; set; }
        public DateTime fecha { get; set; }
        public int idCliente { get; set; }
        public Factura() { }

        public Factura(int numero, DateTime fecha, int idCliente)
        {
            this.numero = numero;
            this.fecha = fecha;
            this.idCliente = idCliente;
        }
    }
}