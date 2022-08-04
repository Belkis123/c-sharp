using System;
public abstract class Mamifero: Metazoos 
{
    public int Patas { get; set; }

    public void Caminar()
    {
        Console.WriteLine(" Tenemos glándulas mamarias productoras de leche mediante las que alimentamos a nuestras crías"); 
    }

}