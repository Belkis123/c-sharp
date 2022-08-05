using System;

public class Matricula
{

public Estudiante Estudiante { get; set; }

public Clases Asignatura { get; set; }

public int CodigoMatricula { get; set; }

public DateTime Fecha { get; set; }


public Matricula(int codigoMatricula, DateTime fecha, Estudiante estudiante,Clases asignatura)
{
    Fecha= fecha;
    Estudiante= estudiante;
    Asignatura=asignatura;
    CodigoMatricula= codigoMatricula;
}

}


