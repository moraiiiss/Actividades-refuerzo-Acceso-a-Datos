using System.Data.SqlClient;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        /*
         * 
         * Crea una aplicación de escritorio que permita el alta o carga de registros en la
         * tabla fabricante. 
         * 
         */

        SqlConnection conexion = new SqlConnection("server=localhost; database=tienda; integrated security=true");

        public Form1()
        {
            InitializeComponent();

        }

        private void btnAñadirFabricante_Click(object sender, EventArgs e)
        {
            string nombreFabricante = textBoxNombreFabricante.Text;
            string codigoFabricante = textBoxCodigoFabricante.Text;

            conexion.Open();

            string cadena = $"INSERT INTO fabricante values ('{codigoFabricante}','{nombreFabricante}')";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cantidad = comando.ExecuteNonQuery();

            if (cantidad == 1)
            {
                MessageBox.Show("Se ha añadido el nuevo fabricante a la base de datos Tienda.");
            }
            else
            {
                MessageBox.Show("No se han agregado ningun fabricante nuevo.");

            }

            Thread.Sleep(2000);

            textBoxCodigoFabricante.Clear();
            textBoxNombreFabricante.Clear();

            conexion.Close();
        }

        private void btnMostrarFabricantes_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string cadena = $"SELECT * FROM fabricante";
            SqlCommand comando = new SqlCommand(cadena, conexion);

            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                // Obtener el valor de las columnas "codigo" y "nombre"
                string codigo = registros["codigo"].ToString();
                string nombre = registros["nombre"].ToString();

                // Agregar el valor al ListBox
                listBoxFabricantes.Items.Add($"Código: {codigo}\n\r" +
                    $" Nombre: {nombre}");
            }
            conexion.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listBoxFabricantes.Items.Clear();
        }
    }
}
