namespace Ejercicio1
{
    internal class Ejercicio1
    {
        //Escribe un programa que cree un fichero de texto “CiclosMontecastelo.txt” y
        //escriba algo en él
        static void Main(string[] args)
        {
            StreamWriter fichero = new StreamWriter("CiclosMontecastelo.txt");
            fichero.WriteLine("Ciclos Montecastelo es la excelencia en preparacion academica");
            fichero.Close();

        }
    }
}
