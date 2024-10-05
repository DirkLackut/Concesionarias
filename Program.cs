using Concesionario_Autos;
using System;
using System.Collections.Generic;

namespace Concesionario_Autos
{
    class Program
    {
         public static void Main(string[] args)
        {

            List<Vehiculo> vehiculos = new List<Vehiculo>
            {
                new Vehiculo { Modelo = "Toyota Supra 1994", PrecioPorDia = 150.0 },
                new Vehiculo { Modelo = "Mazda RX-7 1995", PrecioPorDia = 130.0 },
                new Vehiculo { Modelo = "Honda Civic 1993", PrecioPorDia = 90.0 },
                new Vehiculo { Modelo = "Nissan Skyline GT-R R34", PrecioPorDia = 200.0 },
                new Vehiculo { Modelo = "Dodge Charger 1970", PrecioPorDia = 180.0 }
            };

            Console.WriteLine("***** Bienvenido al Concesionario de Vehiculos de la Vieja Epoca *****.");
            Console.WriteLine();

            Console.WriteLine("Elige un vehículo para la reserva:");
            Console.WriteLine();


            for (int i = 0; i < vehiculos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {vehiculos[i].Modelo} - Precio por día: {vehiculos[i].PrecioPorDia:C}");
                Console.WriteLine();

            }

            Console.Write("Introduce el número del vehículo que deseas reservar: ");
            Console.WriteLine();

            int seleccion = int.Parse(Console.ReadLine()) - 1;

            if (seleccion < 0 || seleccion >= vehiculos.Count)
            {
                Console.WriteLine("Selección no válida.");
                return;
            }

            Vehiculo vehiculoSeleccionado = vehiculos[seleccion];

            Console.Write("¿Por cuántos días deseas reservar el vehículo?: ");
            int diasReserva = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Introduce el porcentaje de descuento (si no hay, introduce 0): ");
            double porcentajeDescuento = double.Parse(Console.ReadLine());
            Console.WriteLine();


            double totalReserva = Reserva.CalcularReserva(vehiculoSeleccionado, diasReserva, porcentajeDescuento);

            vehiculoSeleccionado.MostrarInformacion();
            Console.WriteLine($"Total por {diasReserva} días con {porcentajeDescuento}% de descuento: {totalReserva:C}");

            Console.WriteLine(";-; bu");
        }
    }
}
