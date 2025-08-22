
public class Calculadora

{
    //Atributos
    public double N1 { get; set; }
    public double N2 { get; set; }

    //Atributo privado
    private double Resultado;
    private string Mensaje = "Mensaje privado";
    //Constructor

    public Calculadora(double num1, double num2)
    {
        //Inicializar los atributos
        N1 = num1;
        N2 = num2;
    }


    //Metodos

    public virtual double Sumar()
    {
        double resultado = N1 + N2;
        Console.WriteLine($"La suma de {N1} y {N2} es: {resultado}");
        return resultado;
    }
    //Sobrecarga de funcion sumar
    public double Sumar(double num3)
    {
        Resultado = N1 + N2 + num3;
        Console.WriteLine($"Lasuma es:{Resultado}");
        return Resultado;
    }

    //sobrecarga del operador +

    public static Calculadora operator + (Calculadora c1, Calculadora c2)
    {
        return new Calculadora(c1.N1+c2.N1,c1.N2+c2.N2);
    }
    public void Restar()
    {
        double resultado = N1 - N2;
        Console.WriteLine($"La resta de {N1} y {N2} es: {resultado}");
    }

    public void Multiplicar()
    {
        double resultado = N1 * N2;
        Console.WriteLine($"La multiplicación de {N1} y {N2} es: {resultado}");
    }

    public void Divide() 
    {
      double resultado = N1 / N2;
        if (N2 == 0)
        {
            Console.WriteLine("Error: División por cero no permitida.");
            return;
        }
            Console.WriteLine($"La división de {N1} y {N2} es: {resultado}");
    }

    //Metodo privado
    protected string MostrarMensaje()
    {
        Console.WriteLine(Mensaje);
        return Mensaje;
    }
}
