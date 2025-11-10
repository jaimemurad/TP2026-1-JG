//Tupla
//No son estructuras, son una forma de agrupar datos heterogeneos
// Tamaño es fijo
//Inmutables
//Limitados a 8 elementos

//Tupla sin nombres

(string, int) persona1=("Ana", 25);

//Tupla con nombres

(string Nombre, int Edad) persona2 = ("Juan", 30);

//Acceso a elementos

Console.WriteLine(persona1.Item1);
Console.WriteLine(persona2.Nombre);

//Devolver tupla (metodo)

static (int, int) Dividir(int dividendo, int divisor)
{
    return (dividendo / divisor, dividendo % divisor);
}

var resultado = Dividir(10, 3);
Console.WriteLine($"Cociente: {resultado.Item1}, Residuo: {resultado.Item2}");