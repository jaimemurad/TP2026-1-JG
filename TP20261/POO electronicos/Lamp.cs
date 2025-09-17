//Programa principal

List<IDispositivoInteligente> dispositivos = new List<IDispositivoInteligente>
{
    new Lamparas(),
    new Venti(),
    new Altavoz()

};


//ENCENDER TODOS LOS DISPOSITIVOS
Console.WriteLine("Encendiendo todos los dispositivos...");

foreach(var dispositivo in dispositivos) 
{
    dispositivo.Encender();
    dispositivo.MostrarEstado();
}
//Interactuar con los dispositivos
Console.WriteLine("Ajustar configuraciones ...");
((Lamparas)dispositivos[0]).AjustarBrillo(80);
((Venti)dispositivos[1]).AjustarVelocidad(30);
((Altavoz)dispositivos[2]).ReproducirCancion("40y20");

//APAGAR TODOS LOS DISPOSITIVOS
Console.WriteLine("Apagando todos los dispositivos...");
foreach(var dispositivo in dispositivos) 
{
    dispositivo.Apagar();
    dispositivo.MostrarEstado();
}
//Clases
interface IDispositivoInteligente 
{ 
    void Encender();
    void Apagar();
    void MostrarEstado();
}
public class Lamparas : IDispositivoInteligente
{
    //Atributos
    private bool encendida = false;
    private int brillo = 50;

    //Metodos
    public void Encender() 
    {
        encendida = true;
        Console.WriteLine("La lámpara está encendida.");
    }

    public void Apagar() 
    {
        encendida = false;
        Console.WriteLine("La lámpara está apagada.");
    }

    public void MostrarEstado() 
    {
        Console.WriteLine($"Lampara - Estado: {(encendida ? "Encendida" : "Apagada")}, Brillo: {brillo}%");
    }

    public void AjustarBrillo(int nivel) 
    {
        if (nivel < 0 || nivel > 100) {
            Console.WriteLine("Nivel de brillo debe estar entre 0 y 100.");
            return;
        }
        brillo = nivel;
        Console.WriteLine($"Brillo ajustado a {brillo}.");
    }

    }

public class Venti : IDispositivoInteligente 
{ 
 
    //Atributos
    private bool encendida = false;
    private int velocidades = 1;

    //Metodos
    public void Encender() {
        encendida = true;
        Console.WriteLine("el ventilador está encendido.");
    }

    public void Apagar() {
        encendida = false;
        Console.WriteLine("el ventiador está apagado.");
    }

    public void MostrarEstado() 
    {
        Console.WriteLine($"Ventilador - Estado: {(encendida ? "Encendido" : "Apagado")}, velocidad: {velocidades}");
    }

    public void AjustarVelocidad(int nivel) {
        velocidades = Math.Clamp(nivel, 0, 100);
    }

}

public class Altavoz : IDispositivoInteligente 
 {
    //Atributos
    private bool encendida = false;
    private string cancionActual = "Ninguna";
    //Metodos
    public void Encender() {
        encendida = true;
        Console.WriteLine("el altavoz está encendido.");
    }
    public void Apagar() {
        encendida = false;
        Console.WriteLine("el altavoz está apagado.");
    }
    public void MostrarEstado() {
        Console.WriteLine($"altavoz - Estado: {(encendida ? "Encendido" : "Apagado")}, CancionActual: {cancionActual}");
    }
    public void ReproducirCancion(string cancion) 
     {
        cancionActual = cancion;
        Console.WriteLine($"{(encendida ? $"Reproduciendo: {cancionActual}": "Reproduciendo nada:" )}");
    }
}
