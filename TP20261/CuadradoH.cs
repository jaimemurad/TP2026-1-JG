
//Cuadrado hereda de rectangulo
public class Cuadrado : Rectangulo
{
    //lado es tanto la base como la altura
    //Constructor propio para el cuadrado

    public Cuadrado(double lado) : base(lado,lado)
    {
    }

    //Metodos, sobreescribir los heredados del rectangulo
    public override double Area()
    {
        return BaseRectangulo * BaseRectangulo;
    }

    public override double Perimetro()
    {
        return 4 * BaseRectangulo;
       
    }
    

}