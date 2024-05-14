namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * Programa que muestra todas las entradas del directorio "c:\\windows".
            */

            var fichero = string.Empty;
            var rutaFichero= string.Empty;

            using (OpenFileDialog abrirFichero = new OpenFileDialog())
            {
                abrirFichero.InitialDirectory = "c://";
                
                if(abrirFichero.ShowDialog() == DialogResult.OK)
                {
                    rutaFichero = abrirFichero.FileName;

                    var fileStream =abrirFichero.OpenFile();

                    using (StreamReader sr = new StreamReader(fileStream))
                    {
                        fichero = sr.ReadToEnd();
                    }

                }

            }

        }
    }
}
