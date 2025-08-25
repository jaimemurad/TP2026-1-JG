//Sistema para una agencia de autos. Representar un Auto que puede acelerar

public class Auto : Vehiculo
{
    //Constructor

    public Auto(string marca, string modelo) : base(marca, modelo)
    {
       
    }
    public override void MostrarInfo()
    {
        //base.MostrarInfo();
        Console.WriteLine($"Auto: {Marca}, {Modelo}, Velocidad Actual: {VelocidadActual} km/h");
    }
   
}