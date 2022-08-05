public class Clases
{
    public int Codigo { get; set; }
    public string Descripcion { get; set; }
    public double NotaClase { get; set; }

    public Clases(int codigo, string descripcion, double notaclase)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        NotaClase = notaclase;
    }
}