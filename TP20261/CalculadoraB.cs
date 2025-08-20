/*
//Calculadora basica

Console.WriteLine("Ingrese el primer número a operar:");
double num1 = double.Parse(Console.ReadLine()??"");
Console.WriteLine("Ingrese el segundo número a operar:");
double num2 = double.Parse(Console.ReadLine()??"");

//Instanciar objeto calculadora

Calculadora calcu = new Calculadora(num1, num2);

//Seleccion de operaciones
Console.WriteLine("Seleccione la operación a realizar:");
Console.WriteLine("1. Sumar");  
Console.WriteLine("2. Restar");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");

int opcion= int.Parse(Console.ReadLine()??"");

switch (opcion)
{
    case 1:
        calcu.Sumar();
        break;
    case 2:
        calcu.Restar();
        break;
    case 3:
        calcu.Multiplicar();
        break;
    case 4:
        calcu.Divide();
        break;
    default:
        Console.WriteLine("Opción no válida. Por favor, seleccione una operación válida.");
        break;
}
*/

CalculadoraCientifica calcu2=new CalculadoraCientifica(2, 5);
calcu2.Factorial();