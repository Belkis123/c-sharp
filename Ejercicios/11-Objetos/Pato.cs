using System;

public class Pato: Metazoos
{
    public string Domestico { get; set; }
    public string Nadan { get; set; }

    public void Parlotean()
    {
        Console.WriteLine("Parlotean e imitan  y hacen sonidos");
    }

    public void Plumaje()
    {
        DescribirPlumaje();
    }

    private void DescribirPlumaje() //  Abstraccion
    {
        Console.WriteLine("Sus Plumas son pequeñas y rizadas en su cola");
    }

}