using System;
using System.Collections.Generic;
public class DatosNotas
{
    public List<Estudiante> ListadeEstudiantes { get; set; }
    public List<ClasesDisponibles> ListadeClasesDisponibles { get; set; }
    public List<Acumulados> ListadeAcumulados { get; set; }
    public List<NotasFinales> ListadeNotasFinales{ get; set; }
    


    public DatosNotas()
    {
        ListadeEstudiantes= new List<Estudiante>();
        cargarEstudiantes();

        ListadeClasesDisponibles = new List<ClasesDisponibles>();
        cargarClases();

        ListadeAcumulados = new List<Acumulados>();
        cargarAcumulados();

        ListadeNotasFinales = new List<NotasFinales>();
        cargarNotasFinales();

        
    }

    private void cargarEstudiantes()
    {
        Estudiante e1 = new Estudiante(001, "Belkis Paola Tejada Melchor", 23);
        ListadeEstudiantes.Add(e1);

        Estudiante e2 = new Estudiante(002, "Karen Dalila Navas Romero", 25);
        ListadeEstudiantes.Add(e2);

        Estudiante e3 = new Estudiante(003, "Sara Elibeth Rosales Mejia", 30);
        ListadeEstudiantes.Add(e3);

        Estudiante e4 = new Estudiante(004, "David Alonso Cuevas Leon", 20);
        ListadeEstudiantes.Add(e4);

        Estudiante e5 = new Estudiante(005, "Javier Edgardo Rodriguez Paz", 19);
        ListadeEstudiantes.Add(e5);

        Estudiante e6 = new Estudiante(006 "Maria Guadalupe Lopez Zamora", 27);
        ListadeEstudiantes.Add(e6);

        Estudiante e7 = new Estudiante(007, "Kimberly Gabriell Antunez", 29);
        ListadeEstudiantes.Add(e7);

        Estudiante e8 = new Estudiante(008, "Josue Caballero Valle", 39);
        ListadeEstudiantes.Add(e8);

        Estudiante e9 = new Estudiante(009, "Alejandra Paola Mejia", 33);
        ListadeEstudiantes.Add(e9);

        Estudiante e10 = new Estudiante(010, "Antony Gibran Perez Chinchilla", 26);
        ListadeEstudiantes.Add(e10);
    }

    private void cargarClases()
    {
        Clase c1 = new Clase(01, "Quimica", "66666");
        ListadeClasesDisponibles.Add(c1);

        Clase c2 = new Clase(02, "Espanol", "99999");
        ListadeClasesDisponibles.Add(c2);
        
        Clase c3 = new Clase(03, "Sociologia", "88888");
        ListadeClasesDisponibles.Add(c2);

        Clase c4 = new Clase(04, "Historia", "33333");
        ListadeClasesDisponibles.Add(c2);

        Clase c5 = new Clase(05, "Analisis", "55555");
        ListadeClasesDisponibles.Add(c2);
    }

    private void cargarAcumulados()
    {
        Vendedor v1 = new Vendedor(1, "Jose", "V001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Pablo", "V002");
        ListadeVendedores.Add(v2);
    }

    public void ListarEstudiantes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Estudiantes");
        Console.WriteLine("==================");
        Console.WriteLine("");
        
        foreach (var estudiante in ListadeEstudiantes)
        {
            Console.WriteLine(estudiante.Codigo + " | " + estudiante.Nombre + " | " + estudiante.Precio);
        }

        Console.ReadLine();
    }

    public void ListarClases()
    {
        Console.Clear();
        Console.WriteLine("Lista de Clases");
        Console.WriteLine("=================");
        Console.WriteLine("");
        
        foreach (var Clases in ListadeClasesDisponibles)
        {
            Console.WriteLine(clases.Codigo + " | " + clases.Nombre + " | " + clases.Telefono);
        }

        Console.ReadLine();
    }

    public void ListarAcumulados()
    {
        Console.Clear();
        Console.WriteLine("Lista de Acumulados");
        Console.WriteLine("===================");
        Console.WriteLine("");
        
        foreach (var acumulados in ListarAcumulados)
        {
            Console.WriteLine(acumulados.CodigoEstudiante + " | " + acumulados.NombreEstudiante + " | " + acumulados.CodigoEstudiante);
        }

        Console.ReadLine();
    }

    public void IngresarNotas()
    {
        Console.WriteLine("INGRESANDO NOTAS");
        Console.WriteLine("=============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del Estudiante: ");
        string codigoCliente = Console.ReadLine();

        Estudiante estudiante = ListadeEstudiantes.Find(c => c.Codigo.ToString() == CodigoEstudiante);        
        if (cliente == null)
        {
            Console.WriteLine("Estudiante no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Estudiante: " + estudiante.NombreEstudiante);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo de la Clase: ");
        string codigoClase = Console.ReadLine();

        Clase clases = ListadeClasesDisponibles.Find(v => v.Codigo.ToString() == codigoClase);
        if (clases == null) 
        {
            Console.WriteLine("Clase  no encontrada");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Clase: " + clases.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListadeClasesDisponibles.Count + 1;

        Notas nuevaOrden = new Notas(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Total de la orden es de: " + nuevaOrden.Total);
        Console.ReadLine();
    }

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Ordenes");
        Console.WriteLine("================");
        Console.WriteLine("");  
        Console.WriteLine("Codigo | Fecha | Subtotal | Impuesto | Total");
        Console.WriteLine("Cliente | Vendedor");
        Console.WriteLine("======================");
        Console.WriteLine("");  

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine(orden.Codigo + " | " + orden.Fecha + " | " + orden.SubTotal  + " | " + orden.Impuesto + " | " + orden.Total);
            Console.WriteLine(orden.Cliente.Nombre + " | " + orden.Vendedor.Nombre);
            
            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }

            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}