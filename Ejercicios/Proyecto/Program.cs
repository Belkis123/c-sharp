using System;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosdePrueba datos = new DatosdePrueba();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Sistema de Notas Escolares");
                Console.WriteLine("--------------------------");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Estudiantes");
                Console.WriteLine("2 - Matricular");
                Console.WriteLine("3 - Lista de Clases Disponibles");
                Console.WriteLine("4 - Acumulados");
                Console.WriteLine("5 - Notas Finales");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarEstudiantes();
                        break;
                    case "2":
                        datos.CrearMatricula();
                        break;
                    case "3":
                        datos.ListarClases();
                        break;
                    case "4":
                        datos.ListarAcumulados();
                        break;      
                    case "5":
                        datos.ListarNotasFinales();
                        break;                                          
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}