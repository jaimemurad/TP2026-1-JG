//Solid BR

//Ejemplo que viola SR
public class Libro
{
    //Atributos
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Paginas {get; set; }

    //Responsabilidad almacenar datos
    public void GuardaBD()
    { 
        //Codigo para la BD
        Console.WriteLine("Guardando libro en la base de datos...");

    }

    public void GenerarReporte(double calificacion)
    {
        //Codigo para generar reporte
        Console.WriteLine($" Reporte para {Titulo} por {Autor}, {calificacion}");
    }
}

//Ejemplo que cumple SR
public class LibroSRP
{
    //Atributos
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Paginas { get; set; }

}

public class RepositorioLibro()
{

    //Responsabilidad almacenar datos

    public void SccesoBD()
    {
        //Codigo para la BD
        Console.WriteLine("Guardando libro en la base de datos...");

    }
    public void CrearRegistro()
    {
        //Codigo para la BD
        Console.WriteLine("Guardando libro en la base de datos...");

    }
    public void LecturaRegistro()
    {
        //Codigo para la BD
        Console.WriteLine("Guardando libro en la base de datos...");

    }


}


public class GeneradorDeReporte()
{
    //Atributos
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Paginas { get; set; }

    public void GenerarReporte(double calificacion)
    {
        //Codigo para generar reporte
        Console.WriteLine($" Reporte para {Titulo} por {Autor}, {calificacion}");
    }
}