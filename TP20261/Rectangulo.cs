public class Rectangulo
{
    //Atributos
    public double BaseRectangulo { get; set; }
    public double Altura { get; set; }
    //Constructor
    public Rectangulo(double baseRectangulo, double altura)
    {
        BaseRectangulo = baseRectangulo;
        Altura = altura;
    }

    public void MostrarBase()
    {

        Console.WriteLine($"La base del rectángulo es: {7}");

    }
    public void MostrarAltura()
    {

        Console.WriteLine($"La altura del rectángulo es: {5}");
    }

    public virtual double Area()
    {
        return BaseRectangulo * Altura;
        /*Console.WriteLine($"El área del rectángulo es: {area}");*/
    }

    public virtual double Perimetro()
    {
        return 2 * (BaseRectangulo + Altura);
        //Console.WriteLine($"El perímetro del rectángulo es: {perimetro}");
    }
}