using System.Xml.Linq;

public class Cuadrado
{
    //Atributos (lados)
    public float Lado { get; set; }
    //Constructor (asignar valor del lado)
    public Cuadrado(float lado)
       
    {
        Lado = lado;
    }

    //Metodos (mostrar perimetro y el area)
    public void Perimetro()
    {
        float perimetro = 4 * Lado;
        Console.Write($"Perimetro: {perimetro}");

    }
    public void Area()
    {
        float Area = Lado * Lado;
        Console.Write($"Area: {Area}");
    }