using System.Data.SqlClient;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        /*
         * 
         * Crea una aplicación de escritorio que permita consultar un producto por su
         * código. Luego de mostrarlo activar un botón para poder eliminarlo.
         * 
         */

        SqlConnection conexion = new SqlConnection("server=localhost; database=tienda; integrated security=true");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string codigo = textBoxCodigoProducto.Text;

            string cadena = $"SELECT nombre, precio FROM producto WHERE codigo = '{codigo}'";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registro = comando.ExecuteReader();

            while (registro.Read())
            {
                string nombre = registro["nombre"].ToString();
                string precio = registro["precio"].ToString();

                listBoxProducto.Items.Add($"Nombre: {nombre}, Precio: {precio}");
            }

            conexion.Close();

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string codigo = textBoxCodigoProducto.Text;
            string cadena = $"DELETE FROM producto WHERE codigo = '{codigo}'";

            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cantidad = comando.ExecuteNonQuery();

            if ( cantidad == 1 )
            {
                MessageBox.Show("Se ha eliminado de la base de datos correctamente.");
            }


            conexion.Close() ;
        }
    }
}
