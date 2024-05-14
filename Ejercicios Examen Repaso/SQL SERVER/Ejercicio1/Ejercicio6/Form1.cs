using System.Data.SqlClient;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        /*
         * 
         * Crea una aplicación de escritorio que permita consultar un producto por su
         * código. Tras mostrarlo, activar un botón que permita eliminarlo. Utiliza
         * parámetros tanto para la consulta como para el borrado.
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
            string cadena = "SELECT nombre FROM producto WHERE codigo = @codigo";
            SqlCommand comando = new SqlCommand(cadena, conexion);

            comando.Parameters.AddWithValue("@codigo", codigo);

            SqlDataReader registros = comando.ExecuteReader();

            if (registros.Read())
            {
                string nombre = registros["nombre"].ToString();
                listBoxProductoBuscado.Items.Add(nombre);
            }

            conexion.Close();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            conexion.Open();


            string codigo = textBoxCodigoProducto.Text;
            string cadena = "DELETE FROM producto WHERE codigo = @codigo";
            SqlCommand comando = new SqlCommand(cadena, conexion);


            comando.Parameters.AddWithValue("@codigo", codigo);
            int registros = comando.ExecuteNonQuery();

            if (registros == 1)
            {
                MessageBox.Show("Se ha eliminado el producto correctamente!!");
            }
            conexion.Close();
        }
    }
}
