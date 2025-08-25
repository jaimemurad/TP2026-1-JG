public class Vehiculo
{
    //Atributos
    /* public string Marca { get; set; }
     public string Modelo { get; set; }
     public int VelocidadActual { get; set; }
     */

    //Atributosprivados (No se modifican desde fuera de la clase)

    protected string marca;
    protected string modelo;
    protected int velocidadActual;

    //Propiedades publicas con control

    public string Marca
    {
        get { return marca; }
        set { marca = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public int VelocidadActual
    {
        get { return velocidadActual; }
        private set
        {
            if (velocidadActual < 0)
            {
                velocidadActual = 0;
            }
            else
            {
                velocidadActual = value; // La velocidad no puede ser negativa
            }
        }
    }
    //Constructor

    public Vehiculo(string marca, string modelo)
    {
       this.marca = marca;
       this.modelo = modelo;
        this.velocidadActual = 0; // Inicialmente el auto está detenido

    }
    

    public void Acelerar(int incremento)
    {
        //VelocidadActual += incremento;
        VelocidadActual = VelocidadActual + incremento;
   
    }
    //Sobrecarga del metodo sin parametros
    public void Acelerar()
    {
        VelocidadActual = VelocidadActual + 10; // Acelera en 10 km/h por defecto
    }
    public void Frenar(int decremento)
    {
        VelocidadActual -= decremento;
        
    }
    public void Frenar()
    {
        VelocidadActual -= 10;

    }

    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Velocidad Actual: {velocidadActual} km/h");
    }

    //Sobrecarga de operadores

    public static bool operator > (Vehiculo v1, Vehiculo v2)
    {
        return v1.VelocidadActual > v2.VelocidadActual;
    }
    public static bool operator <(Vehiculo v1, Vehiculo v2)
    {
        return v1.VelocidadActual < v2.VelocidadActual;
    }
    public static bool operator == (Vehiculo v1, Vehiculo v2)
    {
        return v1.VelocidadActual == v2.VelocidadActual;
    }
    public static bool operator !=(Vehiculo v1, Vehiculo v2)
    {
        return v1.VelocidadActual != v2.VelocidadActual;
    }
}
