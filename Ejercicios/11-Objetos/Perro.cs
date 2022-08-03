using System;
public class Perro: Mamifero
{
    public string Amamanta{ get; set; }
    public bool Ladran { get; set; }

    public Perro() // Polimorfismo
    {
        Ladran = true;
    }

    public Perro(bool ladran) // Polimorfismo
    {
        Ladran = ladran;
    }
    public void Ladran()
    {
        Console.WriteLine("Mi Perrito es Bonito...");

    }

}