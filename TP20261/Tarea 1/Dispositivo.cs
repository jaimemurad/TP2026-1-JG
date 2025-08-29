
//Clase para representar un dispositivo


public class Dispositivo
{
    private string nombre;
    private bool encendido;
    private int consumo;

    // Propiedad pública solo lectura para Nombre
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    // Propiedad pública solo lectura para Encendido
    public bool Encendido
    {
        get { return encendido; }
        set { encendido = value; }
    }

    // Propiedad pública solo lectura para Consumo (devuelve 0 si está apagado)
    public int Consumo
    {
        get
        {
            if (encendido)
                return consumo;
            else
                return 0;
        }
        set
        {
            consumo = value;
        }
    }

    //Constructor
    public Dispositivo(string nombre, int consumo)
    {
        this.nombre = nombre;
        this.consumo = consumo;
        this.encendido = false;
    }

    // Método público para encender el dispositivo
    public void Encender()
    {
        encendido = true;
    }

    // Método público para apagar el dispositivo
    public void Apagar()
    {
        encendido = false;
    }

    // Sobrecarga de métodos para ajustar el consumo
    public void AjustarConsumo(int nuevoConsumo)
    {
        nuevoConsumo = consumo;
    }

    public void AjustarConsumo()
    {
        consumo = 100;
    }

    // Método virtual para mostrar información del dispositivo
    public virtual void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {nombre}, Encendido: {encendido}, Consumo: {consumo}W");
    }

    // Sobrecarga de operadores para comparar dispositivos por su consumo
    public static bool operator >(Dispositivo d1, Dispositivo d2)
    {
        return d1.Consumo > d2.Consumo;
    }

    public static bool operator <(Dispositivo d1, Dispositivo d2)
    {
        return d1.Consumo < d2.Consumo;
    }

    public static bool operator ==(Dispositivo d1, Dispositivo d2)
    {

        return d1.Consumo == d2.Consumo;
    }

    public static bool operator !=(Dispositivo d1, Dispositivo d2)
    {
        return d1.Consumo != d2.Consumo;
    }


}