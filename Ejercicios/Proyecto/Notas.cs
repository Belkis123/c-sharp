using System;
using System.Collections.Generic;

public class Notas
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodeOrdendeClase { get; set; }
    public Estudiante Estudiante{ get; set; }
    public Acumulados Acumulados { get; set; }
    public List<DatosNotas> ListaDatosNotas { get; set; }
    public double TotalFinal { get; set; }
    

    public Notas(int codigo, DateTime fecha, string numeroOrden, Estudiante estudiante, Acumulados acumulados)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeOrdendeClase = numeroOrden;
        Estudiante = estudiante;
        Acumulados= acumulados;
        ListaDatosNotas = new List<DatosNotas>();
        

    }

    public void AgregarNota(Notas nota)
    {
        int nuevoCodigo = ListaDatosNotas.Count + 1;
        int cantidad = 1;

        DatosNotas o = new DatosNotas(nuevoCodigo, 1, nota);
        ListaDatosNotas.Add(o);


        NotaFinal +=cantidad / nota;
        
    }

    }
