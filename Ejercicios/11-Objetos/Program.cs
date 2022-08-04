using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Leon l = new Leon();
            Console.WriteLine(    "        ************              ");
            Console.WriteLine(    "            LEON                  ");
            Console.WriteLine(    "        ************              ");
            l.Nombre = " Nombre: Panthera Leo ";
            l.Patas = 4;
            l.Pelaje = " Pelaje: Su pelaje es corto, y áspero";
            l.Raza = " Raza: Meridional de África";
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
            Console.WriteLine("             **********              ");
            Console.WriteLine("               PERRO                 ");
            Console.WriteLine("             *********"              );
            p.Nombre = " Nombre: Perrito Pinki ";
            p.Patas = 4;
            p.Comer();
            p.HacenGuau= true;
            p.Caminar();
            

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);
            


            Console.WriteLine();

            Gato g = new Gato();
            Console.WriteLine("            **********"         );
            Console.WriteLine("               GATO "           );
            Console.WriteLine("            **********"         );
            g.Nombre = " Nombre:Gatito Lotty";
            g.Patas = 4;
            g.Pelaje = "Pelaje: Sirve para protegerse de las altas y bajas temperaturas";
            g.Maullar();
            g.Comer();
            

            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);
            Console.WriteLine(g.Pelaje);

            Console.WriteLine();

            Pato P = new Pato();
            Console.WriteLine("             **********           ");
            Console.WriteLine("                PATO              ");
            Console.WriteLine("            ***********           ");
            Pato L = new Pato();
            P.Nombre = "Nombre: Patito Juan";
            P.Plumaje();       
            

            Console.WriteLine(P.Nombre);
            Console.WriteLine(P.Nadan);

            Console.WriteLine();

            PezEspada pe = new PezEspada();
            Console.WriteLine("           **************           ");
            Console.WriteLine("             PEZ ESPADA             ");
            Console.WriteLine("           **************           ");
            pe.Nombre = " Nombre: Lucky ";
            pe.NumeroAletas = 2;
            pe.Comer();
            pe.Nadar();
            pe.Predador();
            pe.Escamas();
            pe.Color = " Color: Color Azul  con pico largo y aplanado ";

            Console.WriteLine(pe.Nombre);
            Console.WriteLine(pe.NumeroAletas);
            Console.WriteLine(pe.Color);

            Tiburon t = new Tiburon();
            Console.WriteLine("          **************    ");
            Console.WriteLine("-            TIBURON        ");
            Console.WriteLine("          **************    ");
            t.Nombre = "Nombre: Tiburoncitoo bebe ";
            t.NumeroAletas = 2;
            t.Comer();
            t.Nadar();
            t.Color = "Color: Gris con Blanco o negro";
 
            Console.WriteLine(t.Nombre);
            Console.WriteLine(t.NumeroAletas);
            Console.WriteLine(t.Color);

            }
        }
}