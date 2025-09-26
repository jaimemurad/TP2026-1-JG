using BibliotecaDeLibros;

namespace ExtensionesBiblioteca
 {
    public static class LibroExtensiones {

        public static string InformacionLibro(this Libro libro) {
            return $"Título: {libro.Titulo}, Autor: {libro.Autor}, Año de Publicación: {libro.AnioPublicacion}";
        }

        public static bool EsLibroClasico(this Libro libro) {
            return (DateTime.Now.Year - libro.AnioPublicacion) > 50;
        }

    }
}