//Programa principal del juego

try 
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Bienvenido al combate de guerreros!");
}

catch {

}

static string ObtenerNombre() 
{
    while (true) 
    { 
        try 
        {
            Console.Write("Ingresa el nombre del guerrero: ");
            string nombre = Console.ReadLine()??"".Trim();

            if (!string.IsNullOrEmpty(nombre)) 
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
                //Tarea evitar que la cadena sea un numero
            } 
            return nombre;
 
        }

        catch (Exception ex) 
        {
            Console.WriteLine($"Error al recibir el nombre: {ex.Message}");
        }
    }
}

//Funciones para obtener seleccion de menu

static int ObtenerOpcion()
{
    while (true) {
        try {
            Console.WriteLine("Ingresa tu opción");
            int opcion = int.Parse(Console.ReadLine() ?? "");
            if (opcion != 1 && opcion != 2) 
            {
                throw new ArgumentOutOfRangeException("Opción inválida. Debe ser 1 o 2");
            }
            return opcion;
        } 
      catch (Exception ex)
      { 
        Console.WriteLine($"Error al seleccionar opción: {ex.Message}");
        }
    
    
    }
}

//Funcion para seleccion de la clase

static Guerrero SeleccionarClase(string nombre) 
{
    while (true) 
    {

        try {
            Console.WriteLine("Selecciona la clase de tu guerrero:");
            Console.WriteLine("1. Caballero (Vida: 120, Ataque: 20 ");
            Console.WriteLine("2. Mago (Vida: 80, Ataque: 25)");
            Console.WriteLine("3. Arquero (Vida: 100, Ataque: 18), 30% de probabilidad de ataque doble");
            Console.WriteLine("4. Guerrero Sombra (Vida: 110, Ataque: 22, Habilidad especial: 20% de probabilidad de esquivar ataques)");

            
            int opcion = int.Parse(Console.ReadLine() ?? "");
           return opcion switch 
            {
                1 => new Caballero(nombre),
                2 => new Mago(nombre),
                3 => new Arquero(nombre),
                4 => new GuerreroSombra(nombre),
                _ => throw new ArgumentOutOfRangeException("Opción inválida. Debe ser entre 1 y 4"),
            };

        } 
         catch (Exception ex) 
         {
            Console.WriteLine($"Error al seleccionar clase: {ex.Message}");
         }
    }
}

//Funcion para generar al enemigo

static Guerrero GenerarEnemigo() 
{
    string[] nombres = { "Orco", "Troll", "Goblin", "Esqueleto", "lanzarrocas" };
    string nombre = nombres[new Random().Next(nombres.Length)];
    int[] vidas = { 90, 100, 200, 150, 1000 }; // Vida entre 80 y 150
    int vida = vidas[new Random().Next(vidas.Length)];
    int[] ataques = { 15, 27, 22, 30, 35 }; // Ataque entre 15 y 25
    int ataque = ataques[new Random().Next(ataques.Length)];
    return new Guerrero(nombre, vida, ataque);
}