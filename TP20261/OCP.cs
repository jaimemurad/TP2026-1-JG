//Sin usar OCP

public class  CalculadoraPrestamos
{
    public decimal Calcular(Libro libro, string tipoPrestamo)
    {
        if (tipoPrestamo == "Regular")
        {
            return 10.0m;
        }
        else if (tipoPrestamo == "Premium")
        {
            return 5.0m;
        }

        throw new ArgumentException("Tipo de prestamo no valido");
    }

}

//Usando OCP

public interface IPrestamo
{
    decimal CalcularTarifa(LibroSRP libro);
}

public class PrestamoRegular : IPrestamo
{
    public decimal CalcularTarifa(LibroSRP libro)
    {
        return 10.0m;
    }
}

public class PrestamoPremium : IPrestamo
{
    public decimal CalcularTarifa(LibroSRP libro)
    {
        return 5.0m;
    }
}

public class CalculadoraPrestamoOCP
{
    public decimal Calcular(LibroSRP libro, IPrestamo tipoPrestamo)
    { 
        
    }

}