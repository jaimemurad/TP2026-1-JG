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

    private readonly string[] generosFiccion = {"Ciencia Ficción", "Fantasía", "Misterio", "Romance", "Terror","Novela"};
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

    public void CalificarLibro(string titulo, int nota, string comentario) 
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
            libroEncontrado.Calificar(nota,comentario);
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

}