using System;

public class PezEspada: Acuaticos
{
    public string Memoria { get; set; }

    public void Predador()
    {
        Console.WriteLine("Me Dicen El Gladiador");
    }

    public void Escamas()
    {
        DientesAfilados();
    }

    private void DientesAfilados()
    {
        Console.WriteLine("");
    }
}