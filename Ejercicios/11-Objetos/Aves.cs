using System;

public abstract class Animals: Metazoos
{
    public int Patas { get; set; }
    public string DescribirPlumaje { get; set; }

    public void Volar()
    {
        Console.WriteLine("Vuela vuelaaa, no te haaace falta equipaje, vuelaaa...");
    }
}