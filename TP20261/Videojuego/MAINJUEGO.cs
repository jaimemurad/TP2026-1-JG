//Programa principal del juego


try {
    Console.WriteLine("Bienvenido al combate de guerreros!");
    //Obtener nombre del guerrero
    string nombrejugador = ObtenerNombre();

    //Seleccionar clase del guerrero

    Guerrero jugador = SeleccionarClase(nombrejugador);
    Guerrero enemigo = GenerarEnemigo();

    Console.WriteLine($"Te enfrentaras contra {enemigo.Nombre}");

    while (jugador.Vida > 0 && enemigo.Vida > 0) {
        MostrarEstado(jugador, enemigo);
        int opcion = ObtenerOpcion();
        if (opcion == 1) {
            jugador.Atacar(enemigo);

        } else if (opcion == 2) {
            int probabilidad = new Random().Next(0, 100);
            if (probabilidad < 50) {
                Console.WriteLine($"la fusion falló y perdiste vida");
                jugador.RecibirDanio((int)(jugador.Vida * 0.1f));
            } else {

                jugador = jugador + enemigo;
                Console.WriteLine($"la fusion salio bien eres un nuevo guerrero {jugador.Nombre}");
            }

        } else 
        {
            throw new ArgumentException("Opción inválida. Debe ser 1 o 2");
        }

        if (enemigo.Vida > 0) 
        {
            enemigo.Atacar(jugador);
        }
    }

    Console.WriteLine(jugador.Vida > 0 ? " Has ganado el combate." : "Perdiste...");

} catch (Exception ex) {
    Console.WriteLine($"Error inesperado: {ex.Message}");
} 
finally 
{ 
    Console.WriteLine("Gracias por jugar!");
}

static string ObtenerNombre() 
{
    while (true) 
    { 
        try 
        {
            Console.Write("Ingresa el nombre del guerrero: ");
            string nombre = Console.ReadLine()??"".Trim();

            if (string.IsNullOrEmpty(nombre)) 
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

//Funcion mostrar el estado

static void MostrarEstado(Guerrero jugador, Guerrero enemigo) 
{
   Console.WriteLine($"Tu vida : {jugador.Vida} | La vida del enemigo {enemigo.Vida}");
    Console.WriteLine("1. Atacar");
    Console.WriteLine("2. Fusionarse con el enemigo ");
}