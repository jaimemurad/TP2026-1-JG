
//Calculadora basica

Console.WriteLine("Ingrese el primer número a operar:");
double num1 = double.Parse(Console.ReadLine()??"");
Console.WriteLine("Ingrese el segundo número a operar:");
double num2 = double.Parse(Console.ReadLine()??"");

Calculadora calcu1 = new Calculadora(num1, num2);
Calculadora calcu2 = new Calculadora(1, 2);
Calculadora sumaCalcu = calcu1 + calcu2;

Console.WriteLine($"Suma de calculadoras: {sumaCalcu.N1},{sumaCalcu.N2}");
/*
//Seleccion de calculadora
Console.WriteLine("Selecciona la calculadora a utilizar:\n 1-Calculadora basica \n 2- Calculadora cientifica"); 
int opCalcu= int.Parse(Console.ReadLine()??"");

switch (opCalcu)
{
    case 1:
        //Instanciar objeto calculadora
        Calculadora calcuB = new Calculadora(num1, num2);


        //Seleccion de operaciones
        Console.WriteLine("Seleccione la operación a realizar:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");

        int opcion = int.Parse(Console.ReadLine() ?? "");

        switch (opcion)
        {
            case 1:
                calcuB.Sumar();
                break;
            case 2:
                calcuB.Restar();
                break;
            case 3:
                calcuB.Multiplicar();
                break;
            case 4:
                calcuB.Divide();
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una operación válida.");
                break;
        }
        break;
    case 2:
        //Instanciar objeto calculadora cientifica
        CalculadoraCientifica calcuC = new CalculadoraCientifica(num1, num2);

        //Seleccion de operaciones
        Console.WriteLine("Seleccione la operación a realizar:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Factorial");
        Console.WriteLine("6. Raíz Cuadrada");
        Console.WriteLine("7. Logaritmo");
        calcuC.MensajeCalculadora();
        int opcionC = int.Parse(Console.ReadLine() ?? "");

        switch (opcionC)
        {
            case 1:
                calcuC.Sumar();
                break;
            case 2:
                calcuC.Restar();
                break;
            case 3:
                calcuC.Multiplicar();
                break;
            case 4:
                calcuC.Divide();
                break;
            case 5:
                Console.WriteLine($"Resultado:{ calcuC.Factorial()}");

                break;
            case 6:
                Console.WriteLine($"Resultado:{calcuC.RaicCuadrada()}");
                break;
            case 7:
                Console.WriteLine($"Resultado: {calcuC.Logaritmo()}");
                break;

            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una operación válida.");
                break;
        }
        break;
       
    default:
        Console.WriteLine("Opción no válida. Por favor, seleccione una calculadora válida.");
        break; 
}

if(opCalcu==1)
{

}



CalculadoraCientifica calcu2=new CalculadoraCientifica(2, 5);
calcu2.Factorial();

*/