public class Estudiante: Persona
{
    public double Registro{ get; set; }
    public Estudiante(int codigo, string nombres, string edad)
    {
        Codigo = codigo;
        Nombres = nombres;
        Edad = edad;
    }
    public void EnviarNotificacion()
    {
         Console.WriteLine("Correo enviado a: " + Nombres);
    }


}