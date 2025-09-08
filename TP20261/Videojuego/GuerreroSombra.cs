public class GuerreroSombra : Guerrero 
 {
    // Constructor con vida y ataque establecidos
    public GuerreroSombra(string nombre) : base(nombre, 110, 22) { }

    // Override del método Atacar
    public override void Atacar(Guerrero enemigo) 
    {
        Console.WriteLine($"{Nombre} (Guerrero Sombra) usa las sombras!");
        base.Atacar(enemigo);
    }

    // Método para esquivar ataques con 20% de probabilidad
    public override void RecibirDanio(int danio) 
    {
        int probabilidad = new Random().Next(0, 100);
        if (probabilidad < 20) // 20% de probabilidad de esquivar
        {
            Console.WriteLine($"{Nombre} (Guerrero Sombra) ha esquivado el ataque.");
        } 
        else 
        {
            base.RecibirDanio(danio);
        }
    }
}
