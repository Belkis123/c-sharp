public class Estudiante: Persona
{
    
    public int CodigoEstudiante { get; set; }
    
    public Estudiante (int codigoEstudiante,string nombre, string apellido)
{
    CodigoEstudiante= codigoEstudiante;
    Nombre= nombre;
    Apellido=apellido;
   

}
}
