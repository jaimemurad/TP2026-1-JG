public class Suministro
{ 
    //Atributos
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public int Prioidad { get; set; }

    //Constructor

    public Suministro(string nombre, int cantidad, int prioidad)
    {
        Nombre = nombre;
        Cantidad = cantidad;
        Prioidad = prioidad;
    }
    //Sobrecarga del constructor

    public Suministro(string nombre)
    {
        Nombre = nombre;
        Cantidad = 1;
        Prioidad = 2;
    }
    //Metodos
    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}, Cantidad: {Cantidad}, Prioridad: {Prioidad}");
    }
}