//Programa principal

//Instancias libreria

Libreria libreria = new Libreria();

try {
    int operaciones = int.Parse(Console.ReadLine() ?? "");

    for (int i = 0; i < operaciones; i++) {
        string[] entrada = (Console.ReadLine() ?? "").Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string comando = entrada[0];

        switch (comando) 
        {
            case "LIBRO":
                if (entrada.Length < 4)
                    throw new ArgumentException("Faltan datos para agregar el libro.");
                libreria.AgregarLibro(entrada[1], entrada[2], entrada[3]);
                break;
            case "CALIFICAR":
                if (entrada.Length >= 3) 
                {
                    if (!int.TryParse(entrada[2], out int nota))
                        throw new ArgumentException("La nota debe ser un número entero.");
                    
                    if (entrada.Length == 3)
                    {
                        libreria.CalificarLibro(entrada[1], nota);
                    }
                    else
                    {
                        // El comentario puede tener espacios
                        string comentario = string.Join(' ', entrada.Skip(3));
                        libreria.CalificarLibro(entrada[1], nota, comentario);
                    }
                }
                else
                {
                    throw new ArgumentException("Faltan datos para calificar el libro.");
                }
                break;
            case "MEJOR":
                
                libreria.MostrarMejorLibro(entrada[1]);
                break;
            case "CRITERIO":
               
                libreria.CambiarCriterio(entrada[1]);
                break;
            default:
                throw new InvalidOperationException("Comando no valido");

        }
    }

} 

catch (Exception ex) 
{
    Console.WriteLine($"Error: {ex.Message}");

 }




public class Libro 
{
    //Atributos
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string Genero { get; set; }

    protected List<int> Calificaciones;

    //Constructor
    public Libro(string titulo, string autor, string genero) 
    {
        Titulo = titulo;
        Autor = autor;
        Genero = genero;
        Calificaciones = new List<int>();
    }

    //Metodos
    public void Calificar(int nota) 
    {
        if (nota < 1 || nota > 5) 
        {
            throw new ArgumentException("La calificación debe estar entre 1 y 5.");
        }
        Calificaciones.Add(nota);
    }

    //Sobrecarga
    public void Calificar(int nota, string comentario) 
    {
        Console.WriteLine($"Comentario recibido: {comentario}");
        Calificar(nota);
    }

    public double ObtenerPromedio() 
    {
        if (Calificaciones.Count == 0) 
        { 
            return 0; 
        }
        
       double suma = 0;

        foreach (var calificacion in Calificaciones) 
         {
              suma += calificacion;
        }

        return suma / Calificaciones.Count;
    }

    public int ObtenerCantidadVotos() 
    {
        return Calificaciones.Count;
    }

    

}

//Subclases para las diferentes categorias de libros

public class LibroFiccion : Libro {
    public LibroFiccion(string titulo, string autor, string genero) : base(titulo, autor, genero) { }
}

public class LibroTecnico : Libro {
    public LibroTecnico(string titulo, string autor, string genero) : base(titulo, autor, genero) { }
}

//Interfaz para la seleccion de estrategia de recomendacion

interface IRecomendable {
    Libro ObtenerMejorLibro(List<Libro> libros);
}

//Estrategias basada en el promedio de calificaciones

public class RecomendacionPorPromedio : IRecomendable {
    public Libro ObtenerMejorLibro(List<Libro> libros) 
    {
       Libro mejorLibro = null;
        double mejorPromedio = -1;

        foreach (Libro libro in libros) 
        {
            double promedio = libro.ObtenerPromedio();
            if (promedio > mejorPromedio) 
            {
                mejorPromedio = promedio;
                mejorLibro = libro;
            }
        }
        return mejorLibro;
    }
}

//Estrategias basada en la cantidad de votos

public class RecomendacionPorVotos : IRecomendable 
 {
    public Libro ObtenerMejorLibro(List<Libro> libros) 
    {
        Libro mejorLibro = null;
        int maxVotos = -1;

        foreach (var Libro in libros) 
        {
            int votos = Libro.ObtenerCantidadVotos();
            if (votos > maxVotos) 
            {
                maxVotos = votos;
                mejorLibro = Libro;
            }
        }
        return mejorLibro;
    }
}

//Clase para libreria

public class Libreria 
{
    private List<Libro> libros = new List<Libro>();
    private IRecomendable estrategiaRecomendacion = new RecomendacionPorPromedio();

    private readonly string[] generosFiccion = {"Ciencia Ficción", "Fantasia", "Misterio", "Romance", "Terror","Novela"};
    private readonly string[] generosTecnicos = { "Programacion", "ED", "Termodinamica", "MecanicaFluidos", "Diccionario", "AnalisisNumerico" };

    //Metodos de mi libreria
    public void AgregarLibro(string titulo, string autor, string genero) 
    {
        if (generosFiccion.Contains(genero)) {
            libros.Add(new LibroFiccion(titulo, autor, genero));
        } else if (generosTecnicos.Contains(genero)) {
            libros.Add(new LibroTecnico(titulo, autor, genero));
        } else 
        { 
            throw new ArgumentException("Género no reconocido. Por favor, elija un género válido.");
        }
    }

    public void CalificarLibro(string titulo, int nota) 
    {
        Libro libroEncontrado = null;

        foreach (var libro in libros) //Busco en todos los libros de la libreria
        {
            if (libro.Titulo == titulo) 
            {
                libroEncontrado = libro;
                break;
            }
            
        }

        if (libroEncontrado == null) 
        {
            throw new KeyNotFoundException("Libro no encontrado en la librería.");
        }
        
        else if(libroEncontrado != null) 
        { 
            libroEncontrado.Calificar(nota);
        }
    }
    //Sobrecarga de calificar libro con comentario
    public void CalificarLibro(string titulo, int nota, string comentario) 
    {
        Libro libroEncontrado = null;

        foreach (var libro in libros) //Busco en todos los libros de la libreria
        {
            if (libro.Titulo == titulo) {
                libroEncontrado = libro;
                break;
            }

        }

        if (libroEncontrado == null) {
            throw new KeyNotFoundException("Libro no encontrado en la librería.");
        } else if (libroEncontrado != null) {
            libroEncontrado.Calificar(nota, comentario);
        }
    }

    //Criterio de calificacion

    public void CambiarCriterio(string criterio) 
    {
        if (criterio == "Promedio") 
        {
            estrategiaRecomendacion = new RecomendacionPorPromedio();
        } 
        else if (criterio == "Votos") 
        {
            estrategiaRecomendacion = new RecomendacionPorVotos();
        } 
        else 
        {
            throw new ArgumentException("Criterio no reconocido.");
        }
    }

    //Mejor libro

    public void MostrarMejorLibro(string genero) 
    {
        List<Libro> librosGenero = new List<Libro>();

        foreach (var libro in libros) 
        {
            if (libro.Genero == genero) 
                
            {
              librosGenero.Add(libro);
            }
        }

        var mejorLibro = estrategiaRecomendacion.ObtenerMejorLibro(librosGenero);

        if (mejorLibro != null) 
        {
            Console.WriteLine(mejorLibro.Titulo);
        } 
        else 
        {
            Console.WriteLine("Ninguno");
        }
    }
}