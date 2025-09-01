//Programa principal del banco

Banco banco = new Banco();

try
{
    Console.WriteLine("Ingrese el numero de cuenta:");
    string numCuenta = Console.ReadLine()??"";

    CuentaBancaria cuentaOrigen = banco.BuscarCuenta(numCuenta);

    //Depositar
    Console.WriteLine("Ingresa la cantidad a depositar:");

    double num= double.Parse(Console.ReadLine()??"");

    cuentaOrigen.Depositar((decimal)num);

    //Transferir

    Console.WriteLine("Ingresa el numero de cuenta destino:");
    string numCuentaDestino = Console.ReadLine()??"";

    CuentaBancaria cuentaDestino = banco.BuscarCuenta(numCuentaDestino);

    Console.WriteLine("Ingresa la cantidad a transferir:");

    double numTrans= double.Parse(Console.ReadLine()??"");

    cuentaOrigen.Transferir(cuentaDestino, (decimal)numTrans);

    //Retirar
    
    Console.WriteLine("Ingresa la cantidad a retirar:");

    double numRetiro = double.Parse(Console.ReadLine()??"");

    cuentaOrigen.Retirar((decimal)numRetiro);

}

catch (SaldoInsuficienteException e)
{
    Console.WriteLine(e.Message);
}

catch (CuentaNoEncontradaException e)
{
    Console.WriteLine(e.Message);
}

catch (DepositoInvalidoException e)
{
    Console.WriteLine(e.Message);
}