using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRE_FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            double auto1, auto2, auto3;
            auto1 = 1000;
            auto2 = 1500;
            auto3 = 1750;

            bool seguro, AA;
            int seleccion = 0;
            double subTotal = 0;
            double total = 0;
            seguro = false;
            AA = false;

            int opcion = 0;
            int dias = 0;

            Console.WriteLine("Bienvenido a la agencia de autos");
            Console.WriteLine("Presione enter para continuar: ");
            Console.ReadKey();
            Console.Clear();

            while (opcion != 2)
            {
                Console.WriteLine("Seleccione una opcion de vehiculo:");
                Console.WriteLine($"1- Auto 2 puertas por dia a ${auto1}");
                Console.WriteLine($"2- Auto 5 puertas por dia a ${auto2}");
                Console.WriteLine($"3- Camioneta familiar por dia a ${auto3}");
                seleccion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Ingrese la cantidad de días (numeros)");
                dias = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (seleccion == 1)
                {
                    Console.WriteLine("Este vehiculo puede no tener aire acondicionado");
                    Console.WriteLine("Escriba 1 para si desea agregar o 2 si no (25% descuento en caso de no querer)");
                    if (Console.ReadLine() == "1")
                    {
                        AA = true;
                    }
                    else
                    {
                        AA = false;
                    }
                }
                Console.Clear();
                Console.WriteLine("Desea agregar un seguro? (10% sobre el monto inicial) 1- Si / 2- No");

                if (Console.ReadLine() == "1")
                {
                    seguro = true;
                }
                Console.Clear();
                switch (seleccion)
                {
                    case 1:
                        subTotal += auto1;
                        break;
                    case 2:
                        subTotal += auto2;
                        break;
                    case 3:
                        subTotal += auto3;
                        break;
                }
                if (AA == false & seleccion == 1)
                {

                    subTotal += subTotal * 0.75;
                }
                if (seguro == true)
                {
                    subTotal += subTotal * 1.10;
                }

                Console.Write("Desea Agregar otro vehiculo? \n1- Si\n2- No\n");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            total = subTotal * dias;
            Console.WriteLine($"Total = {total}");
            Console.ReadKey();
        }
    }
}
