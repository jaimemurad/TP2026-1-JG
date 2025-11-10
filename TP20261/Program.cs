
using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;

Console.WriteLine("Sistema de Gestión de Gimnasio");
//Crear el usuario

Console.WriteLine("Ingresa el nombre del usuario:");
string nombreUsuario = Console.ReadLine()??"";

Console.WriteLine("Ingresa la edad del usuario:");
int edadUsuario = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Ingresa el objetivo del usuario (Fuerza, Resistencia, Musculo, etc):");
string objetivoUsuario = Console.ReadLine() ?? "";

Usuario usuario = new Usuario(nombreUsuario, edadUsuario, objetivoUsuario);

//Crear entrenador

Console.WriteLine("Ingresa el nombre del entrenador:");
string nombreEntrenador = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la especialidad del entrenador:");
string especialidadEntrenador = Console.ReadLine() ?? "";

Entrenador entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);

//Crear rutina

Console.WriteLine("Ingresa el nombre de la rutina:");
string nombreRutina = Console.ReadLine() ?? "";

Console.WriteLine("Ingresa la duracion de la rutina:");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");

Rutina rutina = new Rutina(nombreRutina, duracionRutina);

//Agregar ejercicios a la rutina

Console.WriteLine("¿Cuántos ejercicios tendrá la rutina?");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");
int contadorEjercicios = 0;

while (numEjercicios > 0)
{
    contadorEjercicios++;

    Console.WriteLine($"Ejercicio #{contadorEjercicios}:");
    Console.WriteLine("Ingresa el nombre del ejercicio:");
    string nombreEjercicio = Console.ReadLine() ?? "";

    Console.WriteLine("Ingresa las repeticiones del ejercicio:");
    int repeticiones = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Numero de series:");
    int series = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Tiempo de descanso:");
    int descanso = int.Parse(Console.ReadLine() ?? "");

    Ejercicio ejercicio = new Ejercicio(nombreEjercicio, repeticiones, series, descanso);
    rutina.AgregarEjercicio(ejercicio);

    numEjercicios--;
}

//Asignar rutina y entrenador

AsignadorRutinas asignador = new AsignadorRutinas();
asignador.AsignarRutinaAUsuario(usuario, rutina);
asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

//Mostrar resumen

Console.WriteLine($"\nResumen de la asignación del usuario: {usuario.Nombre}");
Console.WriteLine($"Objetivo: {usuario.Objetivo}, Rutina: {usuario.RutinaAsignada.Nombre}, Duración: {usuario.RutinaAsignada.Duracion} minutos");

Console.WriteLine("Ejercicios en la rutina:");
foreach (Ejercicio e in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.WriteLine($"{e.Nombre}: {e.Series} series X {e.Repeticiones} repeticiones, Descanso: {e.Descanso}");
}

Console.WriteLine($"Entrenador asignado: {entrenador.Nombre} {entrenador.Especialidad}");