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
    public class Cliente
    {
        public int id { get; set; }
        public string cedula { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public int idCategoria { get; set; }
        public Cliente() { }
        public Cliente(int id, string cedula, string nombre, string direccion, string telefono, int idCategoria)
        {
            this.id = id;
            this.cedula = cedula;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.idCategoria = idCategoria;
        }
    }
}