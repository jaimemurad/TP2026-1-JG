//Lista enlazada
//Cada elemento tiene un valor y un puntero al siguiente elemento
// scanf ("%i", &nombre);

//List<T>(Memoriacontigua)[10][20][30][40][50]
  //  LinkedList<T>(enlazada)[10]->[20]->[30]->[40]->[50]


LinkedList<string> frutas = new LinkedList<string>();

//Agregar nodos
frutas.AddLast("Manzana");
frutas.AddLast("Fresa");
frutas.AddFirst("Plátano");

//Recorrer mostrando conexiones

Console.WriteLine("Frutas en la lista enlazada:");   
LinkedListNode<string>? actual = frutas.First;

while (actual != null)
{
    string anterior = actual.Previous?.Value ?? "null";
    string siguiente = actual.Next?.Value ?? "null";
    Console.WriteLine($"Anterior: {anterior}, Actual: {actual.Value}, Siguiente: {siguiente}");
    actual = actual.Next;
}

//Insertar elemento
LinkedListNode<string> nodoPlátano = frutas.Find("Plátano");
frutas.AddBefore(nodoPlátano,"Sandía");
frutas.AddAfter(frutas.First,"Tuna");

//Eliminar un nodo 
frutas.Remove("Manzana");

Console.WriteLine("Lista modificada:");
LinkedListNode<string>? actual2 = frutas.First;

while (actual2 != null)
{
    string anterior = actual2.Previous?.Value ?? "null";
    string siguiente = actual2.Next?.Value ?? "null";
    Console.WriteLine($"Anterior: {anterior}, Actual: {actual2.Value}, Siguiente: {siguiente}");
    actual2 = actual2.Next;
}
