using System;
using System.Collections.Generic;

public class Notas
{
    public List<Estudiante> ListadeEstudiantes{ get; set; }
    public List <Asignaturas> ListadeAsignaturas{ get; set; }

    public Notas ()

    {
        ListadeEstudiantes = new List<Estudiante>();
        cargarEstudiantes();
        ListadeAsignaturas = new List<Asignaturas>();
        cargarAsignaturas();
        
    }
    private void cargarEstudiantes ()
    {
        Estudiante e1 = new Estudiante(1, "Belkis Paola" , "Tejada Melchor");
        ListadeEstudiantes.Add(e1);

        Estudiante e2 = new Estudiante(2, "Karen Dalila" , "Navas Romero" );
        ListadeEstudiantes.Add(e2);

        Estudiante e3 = new Estudiante(3, "Sara Elibeth " , "Rosales Mejia");
        ListadeEstudiantes.Add(e3);

        Estudiante e4 = new Estudiante(4, "David Alonso " , "Cuevas Leon");
        ListadeEstudiantes.Add(e4);

        Estudiante e5 = new Estudiante(5, "Javier Edgardo " , "Rodriguez Paz");
        ListadeEstudiantes.Add(e5);

        Estudiante e6 = new Estudiante(6,"Maria Guadalupe" , " Lopez Zamora");
        ListadeEstudiantes.Add(e6);

        Estudiante e7 = new Estudiante(7, "Kimberly Gabriell" , " Antunez");
        ListadeEstudiantes.Add(e7);

        Estudiante e8 = new Estudiante(8, "Josue Caballero" , "Valle");
        ListadeEstudiantes.Add(e8);

        Estudiante e9 = new Estudiante(9, "Alejandra Paola" , " Mejia" );
        ListadeEstudiantes.Add(e9);

        Estudiante e10 = new Estudiante(010, "Antony Gibran " , "Perez Chinchilla");
        ListadeEstudiantes.Add(e10);


    }
    private void cargarAsignaturas ()
    {
        Asignaturas a1 = new Asignaturas(01, "Ciencias Naturales");
        ListadeAsignaturas.Add(a1);

        Asignaturas a2 = new Asignaturas(02, "Ciencias Sociales");
        ListadeAsignaturas.Add(a2);
        
        Asignaturas a3 = new Asignaturas(03, "Espanol");
        ListadeAsignaturas.Add(a3);

        Asignaturas a4 = new Asignaturas(04, "Matematicas");
        ListadeAsignaturas.Add(a4);

        Asignaturas a5 = new Asignaturas(05, "Computacion");
        ListadeAsignaturas.Add(a5);

        Asignaturas a6 = new Asignaturas(06, "Artistica");
        ListadeAsignaturas.Add(a6);

       
    }
    public void listarEstudiantes ()
    {
        
        Console.Clear();
         Console.WriteLine("***************************************************************************************************************************");
        Console.WriteLine("                                                          LISTA DE ESTUDIANTES                                                      ");
        Console.WriteLine("***************************************************************************************************************************");
        Console.WriteLine("");

        foreach (var estudiante in ListadeEstudiantes)
        {
            Console.WriteLine (estudiante.CodigoEstudiante + " | " + estudiante.Nombre + " | " + estudiante.Apellido);
        }
       Console.ReadLine();

    }
    public void listarAsignaturas ()
    {
        
        Console.Clear();
        Console.WriteLine("******************************************************************************************************************************");
        Console.WriteLine("                                                          LISTA DE CLASES DISPONIBLES                                        ");
        Console.WriteLine("******************************************************************************************************************************");
        Console.WriteLine("");

         foreach (var asignatura in ListadeAsignaturas)
        {
            Console.WriteLine (asignatura.CodigoAsignatura + " | " + asignatura.NombreAsignatura);
        }

       Console.ReadLine();
 
    }
    public void ingresarAcumulados()
    {
        
        Console.Clear();
         Console.WriteLine("*******************************************************************************************************************************");
        Console.WriteLine("                                                             NOTAS ACUMULADAS                                                  ");
        Console.WriteLine("*******************************************************************************************************************************");
        Console.WriteLine("");

     Console.WriteLine("Ingresar el Codigo del Estudiante:");
     string codigoEstudiante=Console.ReadLine();

     Estudiante estudiante=ListadeEstudiantes.Find(e => e.CodigoEstudiante.ToString()== codigoEstudiante);

     if (estudiante==null)
     {
        Console.WriteLine("Estudiante no se encuentra en la base");
        Console.ReadLine();
        return;

     }
     else
     {
        Console.WriteLine("");
        Console.WriteLine("Estudinte:"+ estudiante.Nombre+ " "+ estudiante.Apellido);
        Console.WriteLine("");
        Console.WriteLine("");

     }
     foreach( var asignatura in ListadeAsignaturas)
     
     {
        Console.WriteLine("");

        Console.WriteLine("Asignatura:"+ asignatura.NombreAsignatura);
        Console.WriteLine("");
        Console.WriteLine("Ingresar las Notas Parciales");
        
    
        Console.Write("Nota1: ");
        asignatura.Nota1= Int32.Parse(Console.ReadLine());

        if (asignatura.Nota1 >=100 || asignatura.Nota1 <= 0)
        {
            Console.WriteLine("Ingrese numero entre 1 a 100");
            asignatura.Nota1=Int32.Parse(Console.ReadLine());
        }
        Console.Write("Nota2: ");
        asignatura.Nota2= Int32.Parse(Console.ReadLine());

         if (asignatura.Nota2 >=100 || asignatura.Nota2 <= 0)
        {
            Console.WriteLine("Ingrese numero entre 1 a 100");
            asignatura.Nota2=Int32.Parse(Console.ReadLine());
        }
   
        Console.Write("Nota3: ");
        asignatura.Nota3= Int32.Parse(Console.ReadLine());

        if (asignatura.Nota3 >=100 || asignatura.Nota3 <= 0)
        {
            Console.WriteLine("Ingrese numero entre 1 a 100");
            asignatura.Nota3=Int32.Parse(Console.ReadLine());

        }
        Console.Write("Nota4: ");
        asignatura.Nota4= Int32.Parse(Console.ReadLine ());

        if (asignatura.Nota4 >=100 || asignatura.Nota4 <= 0)
        {
            Console.WriteLine("Ingrese numero entre 1 a 100");
            asignatura.Nota4=Int32.Parse(Console.ReadLine());
            
        }
        
        asignatura.NotaFinal=(asignatura.Nota1+ asignatura.Nota2+ asignatura.Nota3+ asignatura.Nota4)/4;
       
         

     }
     foreach (var nota in ListadeAsignaturas)
     {
        Console.WriteLine("Su Nota Final es de : " + nota.NotaFinal + "en : " + nota.NombreAsignatura);
     }
       Console.ReadLine ();
     }
     public void notasFinales()
     {
        Console.Clear();
        Console.WriteLine("*******************************************************************************************************************************");
        Console.WriteLine("                                                        NOTAS FINALES                                                        ");
        Console.WriteLine("*******************************************************************************************************************************");
        Console.WriteLine("");
        Console.WriteLine("");


        Console.WriteLine("Ingrese el Codigo del Estudiante: ");
        string codigoEstudiante= Console.ReadLine();

        Estudiante estudiante= ListadeEstudiantes.Find(e => e.CodigoEstudiante.ToString()== codigoEstudiante);

        if (estudiante== null)
        {
            Console.WriteLine("Estudiante no se encuentra en la base");
            Console.ReadLine();
        return;
        }
        else
        {   
            Console.WriteLine("");
            Console.WriteLine("Estudiante: " + estudiante.Nombre + " " + estudiante.Apellido);
            Console.WriteLine("");
            Console.WriteLine("");

            
        }
        foreach( var nota in ListadeAsignaturas)
        {
            Console.WriteLine( "SU NOTA FINAL ES DE: " + nota.NotaFinal + " en  " + nota.NombreAsignatura);
        
            Console.ReadLine();


        
         }
     
     }
        

}  
    
