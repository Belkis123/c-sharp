using System;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Notas notas= new Notas ();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Sistema de Notas Escolares");
                Console.WriteLine("--------------------------");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Estudiantes");
                Console.WriteLine("2 - Lista de Clases Disponibles");
                Console.WriteLine("3 - Acumulados");
                Console.WriteLine("4 - Notas Finales");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("");
                Console.Write ("Ingrese una opcion");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        notas.listarEstudiantes();
                        break;
                     case "2":
                        notas.listarAsignaturas();
                        break;
                    case "3":
                        notas.ingresarAcumulados();
                        break;      
                    case "4":
                        notas.notasFinales();
                        break;                                          
                    default:
                        break;
                }

                if (opcion == "0")
                  Console.Clear();                 {
                    break;
                }
            }
        }
    }
}