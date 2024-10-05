using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario_Autos
{
    public static class Reserva
    {
        public static double CalcularReserva(Vehiculo vehiculo, int dias, double porcentajeDescuento)
        {
            double precioConDescuento = Descuento.AplicarDescuento(vehiculo.PrecioPorDia, porcentajeDescuento);
            return precioConDescuento * dias;
        }
    }
}
