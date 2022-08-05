using System;
using System.Collections.Generic;

public class Notas
{
    public List<DetalleNotas> ListaDatosNotas { get; set; }
    public Matricula Estudiante { get; set; }

    public Matricula Asignatura { get; set; }
    public int NotaFinal { get; set; }
         
         
         
    public Notas(Matricula estudiante, Matricula asignatura)
    {
    
        Estudiante = estudiante;
        Asignatura= asignatura;
        ListaDatosNotas = new List<DetalleNotas>();
        

    }
    public void AgregarNotas(int nota1, int nota2, int nota3, int nota4, int notafinal)
{
    DetalleNotas nota= new DetalleNotas(nota1,nota2,nota3,nota4,notafinal);
    ListaDatosNotas.Add(nota);
}

}
