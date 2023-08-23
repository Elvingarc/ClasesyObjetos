using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjBoletasVentas
{
    public class Boletas
    {
        public int NumeroBoleta { get; set; }
        public string NombreCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string CedulaClienta { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string DescipcionProducto { get; set; }
        public int CantidadCompra { get; set; }

        public double DeterminaPrecio()
        {
          
                switch(DescipcionProducto)
            {
                case "  PS5 + 1 MANDO DS5": return 500;
                case "PS4(1TB) + 1 MANDO DS4": return 610;
                case "MANDO PS5": return 69;
                case "MANDO PS4": return 60;
            }
            return 0;
        }

        public double calcularImporte()
        {
            return CantidadCompra = DeterminaPrecio();
        }

    }
}
