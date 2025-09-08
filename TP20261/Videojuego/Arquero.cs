public class Arquero : Guerrero 
{
    //Constructor
    public Arquero(string nombre) : base(nombre, 90, 15) { }
    //Override del método Atacar
    public override void Atacar(Guerrero enemigo) 
    {
        int probabilidad = new Random().Next(0, 100);
       if(probabilidad < 30) // 30% de probabilidad de ataque doble
        {
            Console.WriteLine($"{Nombre} (Arquero) dispara y falla");

        }
       else 
       {
            Console.WriteLine($"{Nombre} (Arquero) dispara una flecha!");
            base.Atacar(enemigo);
       }
            
      
    }
}