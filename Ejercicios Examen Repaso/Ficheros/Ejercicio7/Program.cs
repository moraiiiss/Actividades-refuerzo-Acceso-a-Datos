namespace Ejercicio7
{
    internal class Program
    {
        /*
         * Hacer un programa que liste el contenido del directorio actual y de los
         * directorios que cuelgan de él, mostrando nombre y tipo de cada fichero o
         * directorio.
         */

        static void Main(string[] args)
        {
            var ficheros = Directory.EnumerateFileSystemEntries(Directory.GetCurrentDirectory());
            Console.WriteLine("El contenido del directorio actual es: ");
            foreach (string item in ficheros)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
