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
    public class Categoria
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Categoria() { }

        public Categoria(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
    }
}