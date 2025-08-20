
public class Persona
{
    // propiedades / atributos

    public string Name { get; set; }
    //public string _nombre;
    public int Edad { get; set; }

    public static string Pais { get; set; }

    //Constructor
    public Persona(string nombre, int edad)//,string pais)
    {
        Name = nombre;
        Edad = edad;
        //Pais = pais;
    }

    //Metodos
    public void MostrarDatos()
    {
        Console.Write("Nombre: ");
        Console.WriteLine(Name);
        Console.Write("Edad: ");
        Console.WriteLine(Edad);
     
    }

    public static void MostrarPais()
    {
        Console.WriteLine($"Pais: {Pais}");
    }
}