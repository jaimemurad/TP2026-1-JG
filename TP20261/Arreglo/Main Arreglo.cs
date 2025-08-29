//Arreglos
//Inicialización

int [] numeros = new int [3];

//Asignar valores a elementos
numeros[0] = 1;
numeros[1] = 2;
numeros[2] = 3;

/*for (int i = 0;i<=2;i++)
{
    Console.WriteLine(numeros[0]);
}*/
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

if (numeros[1] == 2)
{
    Console.WriteLine("Es un 2");
}

//Obtener la longitud del arreglo

Console.WriteLine(numeros.Length);

//Definicion implicia
int[] numeros2 = new int[10] {4,5,6,7,8,9,1,2,3,11};

char[] vocales = new char[] {'a','e','i','o','u'};

foreach (char vocal in vocales)
{
    Console.WriteLine(vocal);
}

bool[] estados = new bool[3];
estados[0] = true;
estados[1] = false;
estados[2] = true;

if (estados[0])
{
    Console.WriteLine("Aqui hay un verdadero");
}

//Ordenamiento de menor a mayor

Console.WriteLine("Arreglo desordenado");

foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}

Array.Sort(numeros2);

Console.WriteLine("Arreglo ordenado");

foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}

//Arreglo ordenado de mayor a menor
//Necesario mi arreglo ya previamente ordenado de menor a mayor

Array.Reverse(numeros2);

Console.WriteLine("Arreglo ordenado de mayor a menor");
foreach (int numero2 in numeros2)
{
    Console.WriteLine(numero2);
}

//Busqueda por valor

Console.WriteLine(Array.BinarySearch(numeros2,7));