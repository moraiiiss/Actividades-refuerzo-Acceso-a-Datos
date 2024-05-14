using System.Data.SqlClient;
namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        /*
         * 
         * Crea una aplicación de escritorio que permita ingresar por teclado el código y
         * recupere el nombre y el precio de la tabla producto.
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
    }
}
