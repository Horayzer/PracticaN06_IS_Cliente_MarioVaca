// NOMBRE APELLIDOS: MARIO ANDRÉS VACA MORA
// PARALELO: 3228
// SI – INTEGRACIÓN DE SISTEMAS 
// FECHA: 04/05/2024
// PRÁCTICA No. # 06

namespace PracticaN06_IS_Cliente_Razor.Models
{
    public class StoreProcedure
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public byte IVA { get; set; }
        public decimal Subtotal { get; set; }
        public StoreProcedure() { }

        public StoreProcedure(string producto, int cantidad, decimal precioUnitario, byte iVA, decimal subtotal)
        {
            Producto = producto;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            IVA = iVA;
            Subtotal = subtotal;
        }
    }
}