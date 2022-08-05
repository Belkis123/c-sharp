using System;
public class Persona
{
    public int Codigo { get; set; }
    public string Nombres{ get; set; }
    public string Edad { get; set; }

    public void EnviarNotificacion()
    {
        Console.WriteLine("Correo enviado a: " + Nombres);
    }
}