using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DEL_PRIMER_PARCIAL__BIEN_HECHO_
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            int continuar = 0;
            int mat1, mat2, mat3, mat4;
            mat1 = 3500;
            mat2 = 2800;
            mat3 = 1600;
            mat4 = 1700;
            double subTotal = 0;
            double total = 0;
            bool descuento = false;


            while (continuar != 2)
            {
                continuar = 0;
                opcion = 0;
                subTotal = 0;
                total = 0;
                descuento = false;
                
                while (continuar != 2)
                {
                    Console.WriteLine("Seleccione la materia en la que desea incribirse: ");
                    Console.WriteLine($"1- Programación Orientada a Objetos ${mat1}");
                    Console.WriteLine($"2- Programación Visual ${mat2}");
                    Console.WriteLine($"3- Sistemas Operativos ${mat3}");
                    Console.WriteLine($"4- Teleinformática ${mat4}");
                    opcion = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("Seleccion Exitosa");
                    Console.ReadKey();
                    Console.Clear();

                    switch (opcion)
                    {
                        case 1:
                            subTotal += mat1;
                            break;
                        case 2:
                            subTotal += mat2;
                            break;
                        case 3:
                            subTotal += mat3;
                            break;
                        case 4:
                            subTotal += mat4;
                            break;
                    }

                    Console.WriteLine("Desea inscribirse en mas materias?");
                    Console.WriteLine("1- Si");
                    Console.WriteLine("2- No");
                    continuar = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                }

                Console.WriteLine("Seleccione modo de pago: ");
                Console.WriteLine("1- Un solo pago (15% de Descuento)");
                Console.WriteLine("2- En 5 cuotas");

                if (Console.ReadLine() == "1")
                {
                    descuento = true;
                }
                else
                {
                    descuento = false;
                }

                Console.Clear();

                if (descuento == true)
                {
                    total = subTotal * 5 * 0.85;
                    Console.WriteLine($"Usted paga en un solo pago: {total} (Descuento ya aplicado)");
                }
                else
                {
                    total = subTotal * 5;
                    Console.WriteLine($"Usted paga 5 cuotas de ${subTotal} que hacen un total de ${total} al finalizar el cuatrimestre");
                }
                Console.ReadKey();
                Console.Clear();
                
                Console.WriteLine("1- Volver al menu principal");
                Console.WriteLine("2- Salir");
                continuar = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
                
            }
            Console.WriteLine("Hasta luego!");
            Console.ReadKey();











        }
    }
}
