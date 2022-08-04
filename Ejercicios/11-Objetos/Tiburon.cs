using System;

public class Tiburon: Acuaticos
{
    public string Muerde { get; set; }

    public void Ataque()
    {
        Console.WriteLine("Existen 400 especies distintas de tiburon");
    }

    public void Tiburoncitoo()
    {
        Porras();
    }

    private void Porras() // Abstraccion
    {
        Console.WriteLine("Cuerpo alargado que está soportado por cartílago y recubierto de piel");
    }
}