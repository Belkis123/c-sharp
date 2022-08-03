using System;
public class Gato: Mamifero
{
    public string Pelaje { get; set; }
    public string Raza { get; set; }
    public bool EsLindo { get; set; }

    public Gato() // Polimorfismo
    {
        EsLindo = true;
    }

    public Gato(bool esLindo) // Polimorfismo
    {
        EsLindo= esLindo;
    }
    public void Maullar()
    {
        Console.WriteLine("Los Gatitos hacen Miauuu Miauuu ");

    }

}