//Programa principal de casteos

//Conversion implicita
int numero = 42;
double numDouble = numero;

Console.WriteLine(numDouble);

//Conversion explicita

double numDouble2 = 42.75;
int numEntero2 = (int)numDouble; //Conversion explicita de double a int

Console.WriteLine(numEntero2);

//Con metodos
string texto = "123";
int numero3 = Convert.ToInt32(texto);
Console.WriteLine(numero3); 

//parse
string texto2 = "3.1416";
double numDouble3 = double.Parse(texto2);
Console.WriteLine(numDouble3);

//Try para evitar errores
string texto3 = "abc";
int resultado;
bool exito = int.TryParse(texto3, out resultado);
Console.WriteLine(exito);
Console.WriteLine(resultado);

//Casteo entre objetos y clases
Animal miAnimal = new Animal();
miAnimal.HacerSonido();

//Down casting Padre ---> Hijo
Orangutan miOrangutan = (Orangutan)miAnimal; //Error en tiempo de ejecucion
miOrangutan.SonidoOrangutan();

//Up casting
Animal otroAnimal = new Animal();
Orangutan otroOrangutan = (Orangutan)otroAnimal; //Error en tiempo de ejecucion

otroOrangutan.SonidoOrangutan();

//Conversion por tipos de referencia
object obj = "Hola, mundo!";
string cadena = obj as string;
Console.WriteLine(cadena);
public class Animal
{
    //Metodo
    public void HacerSonido()
    {
        Console.WriteLine("Sonido de animal");
    }
}

public class Orangutan : Animal
{
    //Metodo
    public void SonidoOrangutan()
    {
        Console.WriteLine("AH-AH-AH");
    }
}