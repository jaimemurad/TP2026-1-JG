public class Guerrero
{
    //Atributos
    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }

    //Constructor
    public Guerrero(string nombre, int vida, int ataque)
    {
        Nombre = nombre;
        Vida = vida;
        Ataque = ataque;
    }
    //Métodos
    public virtual void Atacar(Guerrero enemigo)
    {
        int danio = Ataque + new Random().Next(-3,5);
        enemigo.RecibirDanio(danio);
        System.Console.WriteLine($"{Nombre} ataca a {enemigo.Nombre} y le quita {danio} puntos de salud.");
    }

    public virtual void RecibirDanio(int danio)
    {
        Vida = Math.Max(Vida - danio, 0);
    }
    public static Guerrero operator +(Guerrero g1, Guerrero g2) // Sobrecarga del operador +
    {
        Console.WriteLine($"{g1.Nombre} y {g2.Nombre}  se fusionan en un nuevo guerrero.");
        return new Guerrero($"{g1.Nombre} + {g2.Nombre}", (g1.Vida + g2.Vida) /2, (g1.Ataque + g2.Ataque)/2);
    }

}
