namespace Ejercicio4
{
    internal class Program
    {
        /*
         * Crea un programa que pida al usuario pares de números enteros y escriba
         * su resta (con el formato "20 - 10 = 10") en pantalla y en un fichero llamado
         * "restas.txt", que se encontrará en un subdirectorio llamado "resultados".
         * Cada vez que se ejecute el programa, deberá añadir los nuevos resultados a
         * continuación de los resultados de las ejecuciones anteriores.
         * 
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número par para hacer su resta: ");
            int numeroPedido = int.Parse(Console.ReadLine());

            do
            {
                if (numeroPedido % 2 == 0)
                {
                    Console.WriteLine("El número introduccido es par.Bien Hecho!!");
                    Console.WriteLine("Introducce el siguiente numero par para realizar la resta.");
                    int numeropedido2 = int.Parse(Console.ReadLine());

                    if (numeropedido2 % 2 == 0)
                    {
                        Console.WriteLine("El número introduccido es par. Procedemos hacer la resta de " + numeroPedido + " - " + numeropedido2);
                        int resultado = numeroPedido - numeropedido2;
                        string formato = numeroPedido + " - " + numeropedido2 + " = " + resultado;
                        Console.WriteLine(formato);

                        string directorio = @"C:\Users\morai\OneDrive\Escritorio\Ejercicios Examen Repaso\resultados";
                        string archivo = "restas.txt";

                        String rutaCompleta = Path.Combine(directorio, archivo);


                        Directory.CreateDirectory(directorio);

                        using (StreamWriter fichero = new StreamWriter(rutaCompleta, true))
                        {

                            fichero.WriteLine(formato);
                            Console.WriteLine("Se ha guardo el registro.");

                        }
                    }
                }
                else
                {
                    Console.WriteLine("El numero introduccido no es par. vuelve a intentarlo.");
                    break;

                }
            } while (numeroPedido % 2 == 0);
        }
    }
}
