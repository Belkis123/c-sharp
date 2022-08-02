public class Acumulados: Estudiante
{
    public string CodigoEstudiante{ get; set; }

    public Estudiante(int codigo, string nombreEstudiante, string codigoestudiante)
    {
        Codigo = codigo;
        NombreEstudiante = nombreEstudiante;
        CodigoEstudiante = codigoestudiante;
    }
}