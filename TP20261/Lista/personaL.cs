public class PersonaL
{
    //Atributos
    public string nombre {get; set; }
    public int edad {get; set; }
    //Constructor
    public PersonaL(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    //Metodo
    public void MostrarInfoPersona()
    {
        Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
    }
}


//Programa lista de Personas


