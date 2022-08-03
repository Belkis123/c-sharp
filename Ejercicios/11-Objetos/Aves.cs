using System;

public abstract class Ave: Animals
{
    public int Alas { get; set; }
    public string ColorPlumaje { get; set; }

    public void Volar()
    {
        Console.WriteLine("Vuela muy alto, y vuela hasta que seas libre");

    }
    public void Comer()
    {
        Console.WriteLine("Comiendo");
    }
}


