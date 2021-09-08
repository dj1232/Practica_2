using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiones_ej2
{
    class Program
    {
        //Prototipo del Procedimiento Farenheit
        static void Faren()
        {
            Double cel, far;
            //Aparece en pantalla
            Console.Write("Ingrese los grados Celsius: ");

            //Lectura y conversion a double
            cel = Convert.ToDouble(Console.ReadLine());
            //Proceso de conversion
            far = cel * 9.0 / 5.0 + 32;

            //Impresion de datos
            Console.WriteLine("Los {0} grados Celsius son equivalentes a {1} grados Fahrenheit", cel, far);
        }//fin proceso farenheit

        static void metri()
        {
            Double met, pie;
            //Aparece en Pantalla
            Console.Write("Ingrese los metros: ");

            //Lectura y conversion a double
            met = Convert.ToDouble(Console.ReadLine());
            //Proceso de Conversion
            pie = met * 3.28;

            //Impresion de datos
            Console.WriteLine("Los {0} gmetros son equivalentes a {1} pies", met, pie);
        }//fin proceso fmetri

        static void Kil()
        {
            Double kil, lb;
            //Aparece en pantalla
            Console.Write("Ingrese los grados kilogramos: ");

            //Lectura y conversion a Double
            kil = Convert.ToDouble(Console.ReadLine());
            //proceso de conversion
            lb = kil * 2.2;

            //Impresion de datos
            Console.WriteLine("Los {0} kg son equivalentes a {1} libras", kil, lb);
        }
        static void Main(string[] args)
        {
            string opc;
            Int16 repetir = 1;

            do
            {
                Console.Clear();
                Console.WriteLine("\t \t PROGRAMA PARA CONVERTIR TEMPERATURAS");
                Console.WriteLine("\nElige el tipo de conversion");
                Console.WriteLine("\n\nPresione F si quiere convertir Celsius a Fahrenheit");
                Console.WriteLine("Presione C si quiere convertir metros a pies");
                Console.WriteLine("Presione K si quiere convertir kilogramos a libras");
                Console.WriteLine("\nEscoja F , C ó K: ");

                //Ingreso de datos
                opc = Console.ReadLine();
                opc = opc.ToUpper();

                switch (opc)
                {

                    case "F":
                        Console.WriteLine("\n Conversion a F");
                        //llamando al metodo
                        Faren();
                        Console.ReadKey();
                        Console.WriteLine("Desea volver al menú principal? (1-si / 2-no)");
                        repetir = Convert.ToInt16(Console.ReadLine());
                        while (repetir != 1 & repetir != 2)
                        {
                            Console.WriteLine("Ingrese valores aceptables (1-si / 2-no)");
                            repetir = Convert.ToInt16(Console.ReadLine());
                        }
                        break;

                    case "C":
                        Console.WriteLine("\n Conversion a C");
                        //llamndo al metodo
                        metri();
                        Console.ReadKey();
                        Console.WriteLine("Desea volver al menú principal? (1-si / 2-no)");
                        repetir = Convert.ToInt16(Console.ReadLine());
                        while (repetir != 1 & repetir != 2)
                        {
                            Console.WriteLine("Ingrese valores aceptables (1-si / 2-no)");
                            repetir = Convert.ToInt16(Console.ReadLine());
                        }
                        break;

                    case "K":
                        Console.WriteLine("\n Conversion a K");
                        //llamndo al metodo
                        Kil();
                        Console.ReadKey();
                        Console.WriteLine("Desea volver al menú principal? (1-si / 2-no)");
                        repetir = Convert.ToInt16(Console.ReadLine());
                        while (repetir != 1 & repetir != 2)
                        {
                            Console.WriteLine("Ingrese valores aceptables (1-si / 2-no)");
                            repetir = Convert.ToInt16(Console.ReadLine());
                        }
                        break;

                    default:
                        Console.WriteLine("\n Tipo de conversion no válida");
                        break;

                }
            } while (repetir == 1);
            //espera de una tecla
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Saliendo del Programa, Pase buen día...");
            Console.ReadKey();
        }
    }
}
