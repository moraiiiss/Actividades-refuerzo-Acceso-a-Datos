using System.Data.SqlClient;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        /*
         * 
         * Crea una aplicaci�n de escritorio que permita imprimir por pantalla todos los
         * registros contenidos en la tabla producto.
         * 
         */

        SqlConnection conecxion = new SqlConnection("server=localhost; database=tienda; integrated security=true");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            conecxion.Open();

            string cadena = "SELECT * FROM producto";

            SqlCommand comando = new SqlCommand(cadena, conecxion);
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                string codigo = registro["codigo"].ToString();
                string nombre = registro["nombre"].ToString();
                string precio = registro["precio"].ToString();
                string codigoFabricante = registro["codigo_fabricante"].ToString();

                listBoxProductos.Items.Add($"C�digo: {codigo}, Nombre: {nombre}, Precio: {precio}, Codigo_Fabricante: {codigoFabricante}\n\r");
            }
            conecxion.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listBoxProductos.Items.Clear();
        }
    }
}
