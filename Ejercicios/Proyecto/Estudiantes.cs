public class Estudiante: Persona
{
    public double Saldo { get; set; }
    public Estudiante(int codigo, string nombre, string edad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Edad = edad;
    }
}