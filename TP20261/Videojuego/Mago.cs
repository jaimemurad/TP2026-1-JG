public class Mago : Guerrero
{
    //Constructor
    public Mago(string nombre) : base(nombre, 80, 25)
    { }
    //Override del método Atacar
    public override void Atacar(Guerrero enemigo)
    {
        Console.WriteLine($"{Nombre} (Mago) lanza un hechizo de fuego!");
        base.Atacar(enemigo);
    }
}