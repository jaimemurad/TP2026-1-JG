//Principio LSP

//Si una clase B es hija de una clase A, entonces deberia ser posible sustituir A por B sin que el programa se vea afectado.
//Un upercasting debe ser posible

//Tratando de hacer el upercasting

Rectangulo rectangulo = new Cuadrado();

rectangulo.Ancho = 4;
rectangulo.Alto = 5;

Console.WriteLine($"Area del rectangulo: {rectangulo.CalcularArea()}");

//Usando las clases con LSP

Forma rectanguloLSP = new RectanguloLSP() { Ancho = 4, Alto = 5 };
Forma cuadradoLSP = new CuadradoLSP() { Lado = 2 };

ImprimirArea(rectanguloLSP);
ImprimirArea(cuadradoLSP);

static void ImprimirArea(Forma forma)
{
    Console.WriteLine($"El Area es: {forma.CalcularArea()}");
}

//Clase rectangulo

public class Rectangulo
{
    public virtual int Ancho { get; set; }
    public virtual int Alto { get; set; }

    public int CalcularArea()
    {
        return Ancho * Alto;
    }
}
public class Cuadrado : Rectangulo
{
    public override int Ancho { set { base.Ancho = base.Alto = value; } }
    public override int Alto { set { base.Alto = base.Ancho = value; } }

}

//Respetando el principio LSP

public abstract class Forma
{
    public abstract int CalcularArea();
}

public class RectanguloLSP : Forma
{
    public int Ancho { get; set; }
    public int Alto { get; set; }
    public override int CalcularArea()
    {
        return Ancho * Alto;
    }
}

public class CuadradoLSP : Forma
{
    public int Lado { get; set; }
    public override int CalcularArea()
    {
        return Lado * Lado;
    }
}

