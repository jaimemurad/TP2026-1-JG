//Listas

//Crear una lista

List<int> numeros = new List<int>();
List<string> nombres = new List<string>();

//Agregar elementos a la lista

numeros.Add(10);
numeros.Add(20);
numeros.Add(30);

//Aceder a elementos de la lista

int primerNumero = numeros[0];
Console.WriteLine(primerNumero);

numeros.Remove(10); //Elimina el numero 10 de la lista
numeros.RemoveAt(0); //Elimina el elemento en la posicion 1

//Recorrer la lista

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}