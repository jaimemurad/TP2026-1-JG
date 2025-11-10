//Pilas
//LIFO (Last In First Out)
//*Solo puedes acceder al elemento superior
//No permite busquedas

//Crear

Stack<string> pila = new Stack<string>();

//Apilar (push)
pila.Push("Primero");
pila.Push("Segundo");
pila.Push("Tercero");

foreach(string s in pila)
{
    Console.WriteLine(s);
}
//Desapilo (PoP)

string superior = pila.Peek(); //Devuelve el valor y elimina de la pila

Console.WriteLine("Peek del ultimo elemento");

