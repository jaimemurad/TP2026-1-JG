public class Ventilador : Dispositivo
{
    private int velocidad;

    // Constructor
    public Ventilador(string nombre, int consumo, int velocidad) : base(nombre, consumo)
    {
        this.velocidad = velocidad;
    }

    // Sobrescribir el método MostrarInfo para incluir la velocidad
    public override void MostrarInfo()
    {
        base.MostrarInfo();
        Console.WriteLine($"Velocidad: {velocidad}");
      
    }
}