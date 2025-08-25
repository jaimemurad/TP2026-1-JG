public class Moto : Vehiculo
{
   //Constructor

    public Moto(string marca, string modelo) : base(marca, modelo)
    {
       
    }

    public override void MostrarInfo()
    {
        //base.MostrarInfo();
        Console.WriteLine($"Moto: {Marca}, {Modelo}, Velocidad: {VelocidadActual} km/h");
    }
}
