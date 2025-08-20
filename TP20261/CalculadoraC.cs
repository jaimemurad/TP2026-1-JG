
public class CalculadoraCientifica : Calculadora
{
    //Atributos
    //Constructor
    public CalculadoraCientifica(double num1, double num2) : base(num1, num2)
    { }
    //Métodos
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
}
