namespace Ejercicio8
{
    internal class Program
    {
        /*
         * Realiza un programa que cree la estructura de directorios y ficheros siguiente:
         * <D:\Home>
           <d1>
                |-------- f11.txt
           <d2>
                |-------- f21.txt
         */
        static void Main(string[] args)
        {
            const string DIRECTORIO_RAIZ = @"c:\HOME";

            Directory.CreateDirectory(DIRECTORIO_RAIZ);
            Directory.SetCurrentDirectory(DIRECTORIO_RAIZ);
            Directory.CreateDirectory("d1");
            Directory.CreateDirectory("d2");
            Directory.SetCurrentDirectory("d1");
            File.CreateText("f11.txt");
            Directory.SetCurrentDirectory(@"..\d2");
            File.CreateText("f21.txt");
            Console.WriteLine("Los directorios y ficheros han sido creados correctamente");
            Console.ReadKey();
        }
    }
}
