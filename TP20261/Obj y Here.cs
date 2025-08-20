// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");

Console.WriteLine("Ingresa el nombre de la persona");
    string nombre = Console.ReadLine()??"";
Console.WriteLine("Ingresa la edad");
int edad = int.Parse(Console.ReadLine());

// Mostrar datos
Console.WriteLine("Los datos de la persona son");
Console.WriteLine($"Nombre:{nombre}");
Console.WriteLine($"Edad : {edad}");

//Programa orientado a objetos
//Crear objeto de tipo de persona
Persona.Pais = "Tierra";
Persona unEnteAlien = new Persona("Alien", 580);
//Ejeutar el metodo de Persona
unEnteAlien.MostrarDatos();
//unEnteAlien.MostrarPais();

Persona humano = new Persona("Juan", 20);
humano.MostrarDatos();
Persona.MostrarPais();
//humano.MostrarPais();
//unEnteAlien.MostrarPais();
*/
//Mi clase cuadrado


/*
Rectangulo mi_rectangulo = new Rectangulo(7, 5);

mi_rectangulo.MostrarBase();
mi_rectangulo.MostrarAltura();
mi_rectangulo.Area();
double area = mi_rectangulo.Area();
Console.WriteLine($"El Area del rectangulo: {area}");
mi_rectangulo.Perimetro();
double perimetro = mi_rectangulo.Perimetro();
Console.WriteLine($"El perimetro del rectangulo: {perimetro}");
*/
Cuadrado cuadrado = new Cuadrado(9);
Console.WriteLine($"Lado del cuadrado: {cuadrado.BaseRectangulo}");
Console.WriteLine($"Altura del cuadrado; {cuadrado.Altura}");
Console.WriteLine($"Area cuadrado : {cuadrado.Area()}");
Console.WriteLine($"Perimetro cuadrado: {cuadrado.Perimetro()}");