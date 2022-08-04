using System;
public class Leon: Mamifero
{
    public string Pelaje { get; set; }
    public string Raza { get; set; }
    public bool EsFeroz { get; set; }

    public Leon() // Polimorfismo
    {
        EsFeroz = true;
    }

    public Leon(bool esFeroz) // Polimorfismo
    {
        EsFeroz = esFeroz;
    }
    public void Rugir()
    {
        Console.WriteLine("No se preocupa por opinion de las ovejas ");

    }

}