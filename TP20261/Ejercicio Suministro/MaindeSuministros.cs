//Programa principal del Inventario Mision Orion X

//Instanciar Inventario

Inventario inventario = new Inventario();
bool salir = false;
do
{

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Menu de suministros de la nave Orion X:");
    Console.WriteLine("1. Agregar suministro ");
    Console.WriteLine("2. Buscar Suministro");
    Console.WriteLine("3. Eliminar Suministro");
    Console.WriteLine("4. Mostrar inventario");
    Console.WriteLine("5. Limpiar Suministros");
    Console.WriteLine("6. Salir");

    int opcion = int.Parse(Console.ReadLine()??"");

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Escribe el nombre del suministro a agregar:");
            string nombre = Console.ReadLine()??"";
            if (nombre != "")
            {
                Console.WriteLine("Quieres asignar cantidad y prioridad?");
                Console.WriteLine("1. SI \n 2.- NO");
                int opA = int.Parse(Console.ReadLine()??"");

                switch (opA)
                {
                    case 1:
                        Console.WriteLine("Escribe la cantidad del suministro:");
                        int cantidad = int.Parse(Console.ReadLine()??"");

                        Console.WriteLine("Escribe la prioridad del suministro (1- Alta, 2- Media, 3- Baja):");
                        int prioridad = int.Parse(Console.ReadLine()??"");

                        inventario.AgregarSuministro(nombre, cantidad, prioridad);
                        break;
                    case 2:
                        inventario.AgregarSuministro(nombre);
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
            else
            {
                Console.WriteLine("nombre no valido.");
            }
            break;
        case 2:
            Console.WriteLine("Escribe el nombre del suministro a buscar:");
            string nombreB = Console.ReadLine()??"";
            inventario.BuscarSuministro(nombreB);

            break;
        case 3:
            Console.WriteLine("Escribe el nombre del suministro a eliminar:");
            string nombreE = Console.ReadLine()??"";
            inventario.EliminarSuministro(nombreE);

            break;
        case 4:
            inventario.MostrarSuministros();

            break;
        case 5:
            
            inventario.VaciarInventario();
            break;
        case 6:
            salir = true;
            break;
        default:
            Console.WriteLine("Opción no válida, intente de nuevo.");
            break;
    }
} while (!salir);