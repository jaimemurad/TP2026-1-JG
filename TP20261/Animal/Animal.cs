//Programa principal de animales

Perro miPerro = new Perro();
miPerro.Respirar(); //Heredado del animal
miPerro.HacerSonido(); //sobreescrito en perro


public class Animal
{
  //Metodos del padre
    
    public void Respirar()
    {
        Console.WriteLine("El animal está respirando");
    }

    //Metodos del padre

    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}

//Clases hijas

public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra");
    }
}
public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El gato maulla");
    }
}