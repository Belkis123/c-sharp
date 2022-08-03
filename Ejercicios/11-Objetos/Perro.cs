using System;
public class Perro: Mamifero
{
    public string Amamanta{ get; set; }
    public bool HacenGuau { get; set; }

    public Perro() // Polimorfismo
    {
        HacenGuau = true;
    }

    public Perro(bool hacenGuau) // Polimorfismo
    {
        HacenGuau= hacenGuau;
    }
    public void Ladran()
    {
        Console.WriteLine("Mi Perrito es Bonito...");

    }

}