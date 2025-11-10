//Listas
//Son dinamicas
List<int> numeros = new List<int>(); //declaracion y creacion
List<string> palabras = new List<string>() { "Hola", "mundo", "adios" }; //declaracion, creacion e inicializacion

//Agregar elementos
numeros.Add(10);
numeros.AddRange(new int[] {30, 40, 50 });

//Acceso indice
int primerNumero = numeros[0]; //Acceder al primer elemento
Console.WriteLine(primerNumero);
Console.WriteLine(numeros[1]);

//Insertar
numeros.Insert(1, 20); //Insertar 20 en la posicion 1
Console.WriteLine(numeros[1]);
Console.WriteLine(numeros[2]);

//Eliminar
numeros.Remove(20); //Eliminar el elemento con valor 20
numeros.RemoveAt(3); //Eliminar el elemento en la posicion 3

//Buscar
bool existe = numeros.Contains(30); //Buscar si existe el valor 30
int indice = numeros.IndexOf(40); //Obtener el indice del valor 40
int mayor25 = numeros.Find(x => x > 25); //Buscar el primer elemento mayor a 25