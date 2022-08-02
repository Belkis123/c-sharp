using System;
using System.Collections.Generic;

public class IngresarNotas
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodeOrdendeClase { get; set; }
    public Estudiante Estudiante{ get; set; }
    public Acumulados acumulados { get; set; }
    public List<OrdenDatosNotas> ListaDatosNotas { get; set; }
    public double Total { get; set; }
    

    public Orden(int codigo, DateTime fecha, string numeroOrden, Estudiante estudiante, Acumulados acumulados)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeOrdendeClase = numeroOrden;
        Estudiante = estudiante;
        Acumulados= acumulados;
        ListaDatosNotas = new List<DatosNotas>();
        

    }

    public void AgregarNota(Notas notas)
    {
        int nuevoCodigo = ListaDatosNotas.Count + 1;
        int cantidad = 1;

        OrdenDatosNotas o = new DatosNotas(nuevoCodigo, 1, notas);
        ListaDatosNotas.Add(o);


        NotaFinal +=cantidad / notas;
        
    }

    }