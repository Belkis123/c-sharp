using System;

public abstract class Acuaticos: Animales
{
    public int NumeroAletas { get; set; }
    public string Color { get; set; }

    public void Nadar()
    {
        Console.WriteLine("Nadare y Nadare hasta encontrarte y te Mordere");
    }
}