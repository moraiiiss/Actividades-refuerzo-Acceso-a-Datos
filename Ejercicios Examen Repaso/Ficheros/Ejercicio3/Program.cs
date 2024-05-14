namespace Ejercicio3
{
    internal class Program
    {
        /*
        Crea un programa que pida al usuario el nombre de un fichero de texto y
        una frase a buscar, y que muestre en pantalla todas las líneas de ese fichero
        que contengan esa frase. Cada frase se debe preceder del número de línea
        (la primera línea del fichero será la 1, la segunda será la 2, y así sucesivamente)
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Dame el fichero de texto que quieras buscar:");
            string ficheroDeseado = Console.ReadLine();

            Console.WriteLine("Dame la frase que quieras buscar en el fichero " + ficheroDeseado + ":");
            string fraseBuscada = Console.ReadLine();

            if (File.Exists(ficheroDeseado))
            {
                using (StreamReader fichero = new StreamReader(ficheroDeseado))
                {
                    string linea;
                    int numeroLinea = 1;
                    while ((linea = fichero.ReadLine()) != null)
                    {
                        if (linea.Contains(fraseBuscada))
                        {
                            Console.WriteLine($"Línea {numeroLinea}: {linea}");
                        }
                        numeroLinea++;
                    }
                }
            }
            else
            {
                Console.WriteLine("El archivo especificado no existe.");
            }
        }
    }
}
