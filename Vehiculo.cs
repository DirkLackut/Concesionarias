using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario_Autos
{
    public class Vehiculo
    {
        public string Modelo { get; set; }
        public double PrecioPorDia { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"El Modelo es: {Modelo},  el Precio por día es: {PrecioPorDia:C}");
        }
    }
}
