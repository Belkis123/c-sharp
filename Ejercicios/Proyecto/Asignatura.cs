using System;
using System.Collections.Generic;
public class Asignaturas
{
    public int CodigoAsignatura { get; set; }
     public string NombreAsignatura { get; set; }
   
    public int Nota1 { get; set; }
    
    public int Nota2 { get; set; }

    public int Nota3 { get; set; }

    public int Nota4 { get; set; }

    public double NotaFinal { get; set; }
    
    public Asignaturas(int codigoAsignatura,string nombreAsignatura)
    
    {
         
      CodigoAsignatura= codigoAsignatura;
      NombreAsignatura=nombreAsignatura;

      
    }
    public void Calificar ()
    {
        Nota1=0;
        Nota2=0;
        Nota3=0;
        Nota4=0;

        NotaFinal=(Nota1 + Nota2 + Nota3 + Nota4)/4;

    }
}
 