namespace Ejercicio11
{
    internal class Program
    {
        /*
         * 
         * Realiza un programa que cree una estructura de directorios como la siguiente,
         * donde fx son ficheros y dx son directorios:
         * 
         */

        static void Main(string[] args)
        {
            const string DIRECTORIO_RAIZ = @"c:/home";

            Directory.CreateDirectory(DIRECTORIO_RAIZ);
            Directory.SetCurrentDirectory(DIRECTORIO_RAIZ);
            Directory.CreateDirectory("usr1");
            Directory.CreateDirectory("usr2");
            Directory.SetCurrentDirectory("usr1");
            File.CreateText("f1.txt");
            Directory.SetCurrentDirectory(@"../usr2");
            Directory.CreateDirectory("d1");
            Directory.CreateDirectory("d2");
            Directory.SetCurrentDirectory("d1");
            File.CreateText("f2.txt");
            Directory.SetCurrentDirectory(@"../d2");
            File.CreateText("f3.txt");
            File.CreateText("f4.txt");
            Directory.CreateDirectory("d3");
            Console.WriteLine("Se ha generado correctamente los directorios y ficheros de la estructura deseada. ;)");

        }
    }
}
