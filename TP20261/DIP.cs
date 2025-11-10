
//Sin aplicar DIP

public class  Vampiro
{
    public void Asustar()
            {
        Console.WriteLine("El vampiro asusta en la noche.");
    }

}

public class OrganizadorFiesta()
{
    private Vampiro vampiro = new Vampiro();
    
    public void IniciarFiesta()
    {
        Console.WriteLine("La fiesta ha comenzado!");
        vampiro.Asustar();
    }
}

//Aplicando DIP

public interface IAsustadorDIP
{
    void Asustar();
}

class FantasmaDIP : IAsustadorDIP
{
    public void Asustar()
    {
        Console.WriteLine("El fantasma asusta en la noche.");
    }
}

public class VampiroDIP : IAsustadorDIP
{
    public void Asustar()
    {
        Console.WriteLine("El vampiro asusta en la noche.");
    }
}

public class  OrganizadorFiestaDIP
{
    private readonly IAsustadorDIP asustador; //No hay dependencia directa

    public OrganizadorFiestaDIP(IAsustadorDIP asustador)

    {
        this.asustador = asustador;
    }

    public void IniciarFiesta()
    {
        Console.WriteLine("La fiesta ha comenzado!");
        asustador.Asustar();
    }
}