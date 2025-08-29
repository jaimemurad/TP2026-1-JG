
public class Lampara : Dispositivo
{
    private int intensidad;

    // Constructor
    public Lampara(string nombre, int consumo, int intensidad) : base(nombre, consumo)
    {
        this.intensidad = intensidad;
    }

    // Sobrescribir el método MostrarInfo para incluir la intensidad
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($" Intensidad: {intensidad}");
    }

  
}