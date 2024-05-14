namespace Ejercicio9
{
    /*
     * 
     * Cambia después el nombre de f11.txt por f12.txt, mueve el fichero f21.txt al
     * directorio d1 y eliminando después el directorio d2. 
     * 
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(@"c:\HOME\d1");
            if (File.Exists("f11.txt"))
            {
                File.Move("f11.txt", "f12.txt");
            }
            Directory.SetCurrentDirectory(@"c:\HOME\d2");
            if (File.Exists("f21.txt"))
            {
                File.Move("f21.txt", @"c:\HOME\d1\f21.txt");
            }
            Directory.Delete("d2");

        }
    }
}
