using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Leon l = new Leon();
            Console.WriteLine("************");
            Console.WriteLine("Leon");
            Console.WriteLine("************");
            l.Nombre = "Panthera Leo";
            l.Patas = 4;
            l.Pelaje = "Su pelaje es corto, y áspero";
            l.Raza = " Meridional de África";
            l.Comer();
            l.Caminar();
            l.Rugir();
            l.EsFeroz = true;

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Patas);
            Console.WriteLine(l.Pelaje);
            Console.WriteLine(l.Raza);         

            Console.WriteLine();

            Perro p = new Perro();
            Console.WriteLine("*********");
            Console.WriteLine("   Perro  ");
            Console.WriteLine("*********");
            p.Nombre = "Perrito Pinki";
            p.Patas = 4;
            p.Comer();
            p.HacenGuau= true;
            p.Caminar();
            

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);
            


            Console.WriteLine();

            Gato g = new Gato();
            Console.WriteLine("**********");
            Console.WriteLine("    Gato  ");
            Console.WriteLine("**********");
            g.Nombre = "Gatito";
            g.Patas = 2;
            g.Pelaje = "Sirve para protegerse de las altas y bajas temperaturas";
            g.Maullar();
            g.Comer();
            

            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);
            Console.WriteLine(g.Pelaje);

            Console.WriteLine();

            Pato P = new Pato();
            Console.WriteLine("************");
            Console.WriteLine("     Pato   ");
            Console.WriteLine("*************");
            Pato L = new Pato();
            P.Nombre = "Patito Juan";
            P.Plumaje();       
            

            Console.WriteLine(P.Nombre);
            Console.WriteLine(P.Nadan);

            Console.WriteLine();

           PezEspada pe = new PezEspada();
            Console.WriteLine("************");
            Console.WriteLine(" Pez Espada  ");
            Console.WriteLine("************");
            pe.Nombre = " Lucky";
            pe.NumeroAletas = 2;
            pe.Comer();
            pe.Nadar();
            pe.Color = "Azul con rayas negras";
            pe.Predador();
            pe.Escamas();
            pe.Color = "Color Azul  con pico largo y aplanado,";

            Console.WriteLine(pe.Nombre);
            Console.WriteLine(pe.NumeroAletas);
            Console.WriteLine(pe.Color);

            Tiburon t = new Tiburon();
            Console.WriteLine("**************");
            Console.WriteLine("- Tiburonsin -");
            Console.WriteLine("**************");
            t.Nombre = "Tiburoncitoo bebe";
            t.NumeroAletas = 2;
            t.Comer();
            t.Nadar();
            t.Color = "Gris con Blanco o negro";
 
            Console.WriteLine(t.Nombre);
            Console.WriteLine(t.NumeroAletas);
            Console.WriteLine(t.Color);

            }
        }
}