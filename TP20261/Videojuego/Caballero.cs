public class Caballero : Guerrero
{
    //Constructor
    public Caballero(string nombre) : base(nombre, 120, 20)
    { }
    //Override del método Atacar
    public override void Atacar(Guerrero enemigo)
    {
       Console.WriteLine($"{Nombre} (Caballero) usa un golpe critico!");
        base.Atacar(enemigo);
    }

}
