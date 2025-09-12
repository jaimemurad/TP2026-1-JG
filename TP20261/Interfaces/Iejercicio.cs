//Progsrama principal

List<IPago> listapagos = new List<IPago>();

Console.WriteLine("ingresa el monto a pagar");
string montoTexto = Console.ReadLine() ?? "";

if(double.TryParse(montoTexto, out double monto))
{
    Console.WriteLine("El pago es con tarjeta? s/n");
    string opcion = Console.ReadLine() ?? "".ToLower();

    if (opcion == "s") 
    { 
        Console.WriteLine("Ingresa el número de tarjeta (16 dígitos)");
        string numTarjeta = Console.ReadLine() ?? "";

        //Crear el objeto pago tarjeta

        IPago pago = new PagoTarjeta(numTarjeta, monto);
        listapagos.Add(pago);
    } 
    
    else 
    {
        //Objeto pago en efectivo
        IPago pago = new PagoEfectivo(monto);
        listapagos.Add(pago);
    }


    foreach (IPago p in listapagos) {
        PagoTarjeta pagoTarjeta = p as PagoTarjeta;

        if (pagoTarjeta != null) {
            Console.WriteLine($"Se pago con tarjeta");
            pagoTarjeta.ProcesarPago();
        }

        //TODO PROCESAR LOS PAGOS CON EFECTIVO
    }


}

//TODO: HACER EL PAGO ITERATIVO HASTA QUE YA NO HAYA PAGOS QUE PROCESAR

interface IPago
{
    //Método para procesar el pago
   public void ProcesarPago();
}



//Clasess que implementan la interfaz IPago

//Clase para pagos en efectivo

public class PagoEfectivo : IPago
{
    //Atributo
    public double Monto { get; set; }
    //Constructor
    public PagoEfectivo(double monto)
    {
        Monto = monto;
    }

    //Metodo de la interfaz
    public void ProcesarPago()
    {
        Console.WriteLine($"Pago en efectvivo de {Monto} procesado");
    }

}

//Clase para pagos con tarjeta

public class PagoTarjeta : IPago 
{
    //Atributo
    public double Monto { get; set; }
    public string NumeroTarjeta { get; set; }
    //Constructor

    public PagoTarjeta(string numeroTarjeta, double monto)
    {
        NumeroTarjeta = numeroTarjeta;
        Monto = monto;
    }

    //Metodo de la interfaz

    public void ProcesarPago()
    {
        if(NumeroTarjeta.Length == 16) //Validación simple
        {
            Console.WriteLine($"Pago con tarjeta {NumeroTarjeta} de {Monto} procesado");
        }
        else
        {
            Console.WriteLine("Número de tarjeta inválido");
        }
    }

}