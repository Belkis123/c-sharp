using System;

public abstract class Animals: Animales
{
    public int Patas { get; set; }
    public string ColoPlumaje { get; set; }

    public void Volar()
    {
        Console.WriteLine("Vuela vuelaaa, no te haaace falta equipaje, vuelaaa...");
    }
}