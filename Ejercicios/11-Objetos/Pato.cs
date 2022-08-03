using System;

public class Pato: Animals
{
    public string Orden { get; set; }
    public string Familia { get; set; }

    public void Parlotean()
    {
        Console.WriteLine("Parlotean e imitan  y hacen sonidos");
    }

    public void Plumaje()
    {
        DescribirPlumaje();
    }

    private void DescribirPlumaje()
    {
        Console.WriteLine("Sus Plumas son pequeñas y rizadas en su cola");
    }

}