
//IF

Console.WriteLine("Ingrese el numero :");
int f= int.Parse(Console.ReadLine()??"");


 if(f > 1)
{

    for (int i = f-1; i>=1; i--)
    {
        f = f * i;
    }
    Console.WriteLine($"Factorial es: {f}");
}
else if (f==1 || f==0)
{
    Console.WriteLine("El factorial es 1");
}
else
{
    Console.WriteLine("No se puede calcular el factorial de un numero negativo");
}




