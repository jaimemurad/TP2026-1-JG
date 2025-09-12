//Herencia con interfaces

interface IAnimal
{
  void HacerSonido();
}

interface IVolador 
{ 
    void Volar();
}

public class Pajaro : Animal, IAnimal, IVolador
{
    public void HacerSonido()
    {
        Console.WriteLine("El pájaro canta");
    }
    public void Volar()
    {
        Console.WriteLine("El pájaro está volando");
    }
}
