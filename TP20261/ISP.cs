//Segregacion de interfaces
//
//Ninguna clase debe verse obligada a implementar interfaces que no necesita

//Sin aplicar ISP
Fantasma fantama = new Fantasma();
//fantasma.LanzarHechizo();

//Aplicando ISP
FantasmaISP fantasmaISP = new FantasmaISP();
fantasmaISP.Asustar();
BrujaISP brujaISP = new BrujaISP();
brujaISP.LanzarHechizo();

interface IMounstro
    {
    void Asustar();
    void Volar();
    void LanzarHechizo();
}

public class Fantasma : IMounstro
{
    public void Asustar()
    {
        Console.WriteLine("Buuuu!");
    }
    public void Volar()
    {
        Console.WriteLine("El fantasma vuela por el aire.");
    }
    public void LanzarHechizo()
    {
        throw new NotImplementedException("El fantasma no puede lanzar hechizos.");
    }
}

//Aplicando ISP

interface IAsustador
{
    void Asustar();
}

interface IVuela
{
    void Volar();
}

interface IHechicero
{
    void LanzarHechizo();
}

public class FantasmaISP : IAsustador, IVuela
{
    public void Asustar()
    {
        Console.WriteLine("Buuuu!");
    }
    public void Volar()
    {
        Console.WriteLine("El fantasma vuela por el aire.");
    }
}

public class BrujaISP : IAsustador, IVuela, IHechicero
{
    public void Asustar()
    {
        Console.WriteLine("¡Te asustaré con mi magia!");
    }
    public void Volar()
    {
        Console.WriteLine("La bruja vuela en su escoba.");
    }
    public void LanzarHechizo()
    {
        Console.WriteLine("La bruja lanza un hechizo poderoso.");
    }
}
