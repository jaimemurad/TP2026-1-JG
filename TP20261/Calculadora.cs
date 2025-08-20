
public class Calculadora

{
    //Atributos
    public double N1 { get; set; }
    public double N2 { get; set; }

  
    //Constructor

    public Calculadora(double num1, double num2)
    {
        //Inicializar los atributos
        N1 = num1;
        N2 = num2;
    }


    //Metodos

    public void Sumar()
    {
        double resultado = N1 + N2;
        Console.WriteLine($"La suma de {N1} y {N2} es: {resultado}");
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
}
