//Programa principal 

 Iejemplo algo = new EjemploClase();
algo.HacerAlgo();
algo.HacerAlgoMas();

EjemploClase otroEjemplo = new EjemploClase();

otroEjemplo.HacerAlgo();
//Interfaz

public interface Iejemplo
{
    //Metodo de contrato

    void HacerAlgo();

    //Metodo ya definido

    void HacerAlgoMas()
    {
        Console.WriteLine("Haciendo algo más...");
    }
}

//Clase que implementa la interfaz

public class EjemploClase : Iejemplo
{ 
    public void HacerAlgo()
    {
        Console.WriteLine("Haciendo algo...");
    }

}