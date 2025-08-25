
//Programa principal de Auto

Auto auto1 = new Auto("Honda", "Civic");

auto1.MostrarInfo();

auto1.Acelerar(100);

Console.WriteLine($"El auto aceleró: {auto1.VelocidadActual} km/h");

auto1.Acelerar();

Console.WriteLine($"El auto aceleró: {auto1.VelocidadActual} km/h");

auto1.Frenar(500);

Console.WriteLine($"El auto frenó: {auto1.VelocidadActual} km/h");

Moto moto1 = new Moto("Yamaha", "MT-07");

moto1.MostrarInfo();


moto1.Acelerar(50);

Console.WriteLine($"La moto aceleró: {moto1.VelocidadActual} km/h");

moto1.Frenar(500);

Console.WriteLine($"La moto frenó: {moto1.VelocidadActual} km/h"); 


if (auto1 > moto1)
{
    Console.WriteLine($"El numero {auto1} es mayor {moto1}");
}
else if (auto1 < moto1)
{
    Console.WriteLine($"El numero {auto1} es menor {moto1}");
}
else if (auto1 == moto1)
{
    Console.WriteLine($"El numero {auto1} es igual {moto1}");
}