using BibliotecaDeLibros;
using ExtensionesBiblioteca;
using ValidacionesBiblioeca;
GestorLibros gestorLibros = new GestorLibros();

// Agregar libro

gestorLibros.AgregarLibro(new Libro("Cien Años de Soledad", "Gabriel García Márquez", 1915));
gestorLibros.AgregarLibro(new Libro("Don Quijote de la Mancha", "Miguel de Cervantes", 1605));
gestorLibros.AgregarLibro(new Libro("La Sombra del Viento", "Carlos Ruiz Zafón", 2001));
gestorLibros.AgregarLibro(new Libro("El Amor en los Tiempos del Cólera", "Gabriel García Márquez", 1985));
gestorLibros.AgregarLibro(new Libro("La Ciudad y los Perros", "Mario Vargas Llosa", 1963));

//Mostrar todos los libros

Console.WriteLine("Todos los libros:");
gestorLibros.MostrarLibros();

//Eliminar
Console.WriteLine("Escribe el titlo del libro a eliminar:");
string titulo = Console.ReadLine() ?? "";

gestorLibros.EliminarLibro(titulo);

//Buscar libros por autor
Console.WriteLine("Escribe el autor a buscar:");
string autor = Console.ReadLine() ?? "";



List<Libro> librosAutor = gestorLibros.BuscarLibrosAutor(autor);
foreach (var libro in librosAutor) {
    Console.WriteLine(libro.Titulo);
}

Console.WriteLine("Libros disponibles");
gestorLibros.MostrarLibros();

//Usar metodos de extension
var libroN = gestorLibros.BuscarLibrosAutor(autor)[0];
Console.WriteLine("Informacion del libro:");
Console.WriteLine(libroN.InformacionLibro());

Console.WriteLine("Es libro clasico: " + libroN.EsLibroClasico());

//Metodos de validacion

Console.WriteLine("Validaciones");
Console.WriteLine("Es un año valido: " + Validaciones.EsAnioValido(libroN.AnioPublicacion));
Console.WriteLine("Es un titulo valido: " + Validaciones.EsTituloValido(libroN.Titulo));