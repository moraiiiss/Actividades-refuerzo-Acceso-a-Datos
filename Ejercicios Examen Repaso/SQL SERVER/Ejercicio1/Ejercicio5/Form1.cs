using System.Data.SqlClient;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        /*
         * 
         * Crea una aplicación de escritorio que permita consultar un producto por su
         * código. Luego mostrar en dos TextBox el nombre y el precio actual. Permite
         * modificar el nombre y precio dejando registrado dicho cambio en la tabla de la
         * base de datos al presionar un botón.
         * 
         */

        SqlConnection conexion = new SqlConnection("server=localhost; database=tienda; integrated security= true");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string codigo = textBoxCodigo.Text;
            string cadena = $"SELECT nombre, precio FROM producto WHERE codigo = '{codigo}'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataReader registros = comando.ExecuteReader();

            if (registros.Read())
            {
                string nombre = registros["nombre"].ToString();
                string precio = registros["precio"].ToString();

                textBoxNombreProducto.Text = nombre;
                textBoxPrecioProducto.Text = precio;

            }


            conexion.Close();
        }

        private void btnModificarPrecio_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string codigo = textBoxCodigo.Text;
            string nombre = textBoxNombreProducto.Text;
            string precio = textBoxPrecioProducto.Text;

            string cadena = "UPDATE producto SET nombre = @nombre, precio = @precio WHERE codigo = @codigo";
            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@codigo", codigo);

            int registro = comando.ExecuteNonQuery();

            if (registro == 1)
            {
                MessageBox.Show("Se ha modificado correctamente el precio y el nombre en la base de datos Tienda");
            }

            conexion.Close();
        }
    }
}
