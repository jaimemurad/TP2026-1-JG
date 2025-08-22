
public class CalculadoraCientifica : Calculadora
{
    //Atributos
    //Constructor
    public CalculadoraCientifica(double num1, double num2) : base(num1, num2)
    { }
    //Métodos

    public override double Sumar()
    {
        double suma = base.Sumar();
        Console.WriteLine($"La suma es {suma*2}");
        return suma;
    }
    public int Factorial()
    {
        int f = 1;


        if (N1 < 0)
        {
            Console.WriteLine("No se puede calcular el factorial de un numero negativo");
            return 0;
        }
       for (int i = 1; i <= N1; i++)
        {
            f =f * i;
        }

        return f;
    }

    public double RaicCuadrada()
    {
       return Math.Sqrt(N1);
    }

    public double Logaritmo()
    { 
     return Math.Log(N1);
    }

    //Metodo publico para acceder a metodo protegido

    public void MensajeCalculadora()
    {
        Console.WriteLine(MostrarMensaje());
    }
}
