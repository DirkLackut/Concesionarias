using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario_Autos
{
    public class Descuento
    {
        public static double AplicarDescuento(double precio, double porcentaje)
        {
            return precio - (precio * (porcentaje / 100));
        }
    }
}
