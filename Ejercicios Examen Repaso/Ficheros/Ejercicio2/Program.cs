namespace Ejercicio2
{
    internal class Program
    {
        /*
        Crea un programa que vaya leyendo las frases que el usuario teclea y las guarde
        en un fichero de texto llamado "registroDeUsuario.txt". Terminará cuando la
        frase introducida sea "fin" (esa frase no deberá guardarse en el fichero)
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe lo que quieras que aparezca en el documento y para finalizar pon \"fin\"");

            using (StreamWriter fichero = new StreamWriter("registroUsuario.txt"))
            {
                for (int i = 0; ; i++)
                {
                    string respuestaCliente = Console.ReadLine();

                    if (respuestaCliente == "fin" || respuestaCliente == "Fin")
                    {
                        break;
                        Environment.Exit(0);
                    }
                    else
                    {
                        fichero.WriteLine(respuestaCliente);
                    }
                }
                Console.WriteLine("Programa finalizado. Las frases han sido guardadas en registroDeUsuario.txt");
            }
        }
    }
}
