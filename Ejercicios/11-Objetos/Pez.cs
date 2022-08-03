using System;

public class PezEspada: Acuaticos
{
    public string Memoria { get; set; }

    public void rapidez()
    {
        Console.WriteLine("Hons toy?Que hacia?A donde iba?");
    }

    public void MemoryLost()
    {
        Velocidad();
    }

    private void Velocidad()
    {
        Console.WriteLine("Nadaremos Nadaharemos Nadaharemos...");
    }
}