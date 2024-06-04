using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;

namespace Proyecto_Final_Base_De_Datos
{
    public partial class F_Inventario : Form
    {
        string Rutaconexion = null;
        SqlConnection Conexion;
        string consulta = null;

        public F_Inventario()
        {
            InitializeComponent();

            Rutaconexion = @"Data Source=DESKTOP-JORLE;Initial Catalog=SISTEMA_VENTAS;User ID=sa;Password=123456; ";
            Conexion = new SqlConnection(Rutaconexion);
            LoadData();

        }

        private void btn_Principal_Click(object sender, EventArgs e)
        {

            F_Principal f_Principal = new F_Principal();
            f_Principal.Show();
        }

        private void F_Inventario_Load(object sender, EventArgs e)
        {

        }

        private void btn_Selet_Click(object sender, EventArgs e)
        {

            SqlCommand comando = new SqlCommand("Select * From inventario_3 where id_inventario = " + "'" + txt_Id_Inventario.Text + "'", Conexion);
            Conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();



            if (registro.Read())
            {
                txt_Producto_Inventario.Text = registro["producto"].ToString();
                txt_Descripcion_Inventario.Text = registro["descripcion"].ToString();
                txt_Stock_Inicial_Inventario.Text = registro["stock_inicial"].ToString();
                txt_Entrada_Producto_Inventario.Text = registro["entrada_producto"].ToString();
                txt_Salida_Producto_Inventario.Text = registro["salida_producto"].ToString();
                txt_Precio_Inventario.Text = registro["precio"].ToString();
                txt_Fecha_Entrada_Inventario.Text = registro["fecha_entrada"].ToString();
                txt_Fecha_Salida_Inventario.Text = registro["fecha_salida"].ToString();
                txt_Stock_Total_Inventario.Text = registro["stock_total"].ToString();



            }
            Conexion.Close();

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-JORLE ; database=SISTEMA_VENTAS ; integrated security = true");
            conexion.Open();
            string producto = txt_Producto_Inventario.Text;
            string descripcion = txt_Descripcion_Inventario.Text;
            string stock_inicial = txt_Stock_Inicial_Inventario.Text;
            string entrada_producto = txt_Entrada_Producto_Inventario.Text;
            string salida_producto = txt_Salida_Producto_Inventario.Text;
            string precio = txt_Precio_Inventario.Text;
            string fecha_entrada = txt_Fecha_Entrada_Inventario.Text;
            string fecha_salida = txt_Fecha_Salida_Inventario.Text;



            string cadena = "insert into inventario_3(producto, descripcion, stock_inicial, entrada_producto, salida_producto, precio, fecha_entrada, fecha_salida) values ('" + producto + "','" + descripcion + "', " + stock_inicial + ", " + entrada_producto + ", " + salida_producto + ", " + precio + ", '" + fecha_entrada + "', '" + fecha_salida + "')";







            SqlCommand comando = new SqlCommand(cadena, conexion); comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");

            txt_Producto_Inventario.Text = "";
            txt_Descripcion_Inventario.Text = "";
            txt_Stock_Inicial_Inventario.Text = "";
            txt_Entrada_Producto_Inventario.Text = "";
            txt_Salida_Producto_Inventario.Text = "";
            txt_Precio_Inventario.Text = "";
            txt_Fecha_Entrada_Inventario.Text = "";
            txt_Fecha_Salida_Inventario.Text = "";


            conexion.Close();

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            // Aquí deberías obtener el identificador del registro que deseas eliminar.
            // Puede ser un ID obtenido de un TextBox, por ejemplo.
            int idAEliminar = Convert.ToInt32(txt_Id_Inventario.Text); // Asegúrate de tener un TextBox con el ID del registro

            // Obtén la cadena de conexión desde el archivo de configuración


            // Define la consulta SQL para eliminar el registro
            string query = "DELETE FROM inventario_3 WHERE id_inventario = @id_inventario";

            // Usa un bloque using para asegurarte de que los recursos sean liberados correctamente
            using (SqlCommand command = new SqlCommand(query, Conexion))
            {
                command.Parameters.AddWithValue("@id_inventario", idAEliminar);

                try
                {
                    // Abre la conexión si está cerrada
                    if (Conexion.State == System.Data.ConnectionState.Closed)
                    {
                        Conexion.Open();
                    }

                    // Ejecuta la consulta
                    int filasAfectadas = command.ExecuteNonQuery();

                    // Opcional: Muestra un mensaje indicando si se eliminó el registro
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro eliminado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro con el ID especificado.");
                    }
                }
                catch (Exception ex)
                {
                    // Maneja cualquier excepción que ocurra
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
                finally
                {
                    // Cierra la conexión
                    if (Conexion.State == System.Data.ConnectionState.Open)
                    {
                        Conexion.Close();

                        txt_Id_Inventario.Text = "";
                    }
                }
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {        // Obtiene los valores de los campos de texto
            string producto = txt_Producto_Inventario.Text;
            string descripcion = txt_Descripcion_Inventario.Text;
            string stock_inicial = txt_Stock_Inicial_Inventario.Text;
            string entrada_producto = txt_Entrada_Producto_Inventario.Text;
            string salida_producto = txt_Salida_Producto_Inventario.Text;
            string precio = txt_Precio_Inventario.Text;
            string fecha_entrada = txt_Fecha_Entrada_Inventario.Text;
            string fecha_salida = txt_Fecha_Salida_Inventario.Text;

            // Asumiendo que el producto tiene un identificador único
            if (int.TryParse(txt_Id_Inventario.Text, out int Id_inventario))
            {
                // Define la consulta SQL para actualizar el registro
                string query = "UPDATE inventario_3 SET " +
                               "producto = @producto, " +
                               "descripcion = @descripcion, " +
                               "stock_inicial = @stock_inicial, " +
                               "entrada_producto = @entrada_producto, " +
                               "salida_producto = @salida_producto, " +
                               "precio = @precio, " +
                               "fecha_entrada = @fecha_entrada, " +
                               "fecha_salida = @fecha_salida " +
                               "WHERE Id_inventario = @Id_inventario";

                // Usa un bloque using para asegurarte de que los recursos sean liberados correctamente
                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    // Añade los parámetros a la consulta
                    command.Parameters.AddWithValue("@producto", producto);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@stock_inicial", stock_inicial);
                    command.Parameters.AddWithValue("@entrada_producto", entrada_producto);
                    command.Parameters.AddWithValue("@salida_producto", salida_producto);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@fecha_entrada", fecha_entrada);
                    command.Parameters.AddWithValue("@fecha_salida", fecha_salida);
                    command.Parameters.AddWithValue("@Id_Inventario", Id_inventario);

                    try
                    {
                        // Abre la conexión si está cerrada
                        if (Conexion.State == System.Data.ConnectionState.Closed)
                        {
                            Conexion.Open();
                        }

                        // Ejecuta la consulta
                        int filasAfectadas = command.ExecuteNonQuery();

                        // Opcional: Muestra un mensaje indicando si se actualizó el registro
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Registro actualizado correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro con el ID especificado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Maneja cualquier excepción que ocurra
                        MessageBox.Show("Ocurrió un error: " + ex.Message);
                    }
                    finally
                    {
                        // Cierra la conexión
                        if (Conexion.State == System.Data.ConnectionState.Open)
                        {
                            Conexion.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce un ID de producto válido.");
            }
        }


        private void Formato_cat()
        {
            dgv_principal.Columns[0].Width = 100;
            dgv_principal.Columns[0].HeaderText = "CODIGO";
            dgv_principal.Columns[1].Width = 250;
            dgv_principal.Columns[1].HeaderText = "PRODUCTO";
            dgv_principal.Columns[2].Width = 250;
            dgv_principal.Columns[2].HeaderText = "DESCRIPCION";
            dgv_principal.Columns[3].Width = 250;
            dgv_principal.Columns[3].HeaderText = "STOCK_INICIAL";
            dgv_principal.Columns[4].Width = 250;
            dgv_principal.Columns[4].HeaderText = "ENTRADA_PRODUCTO";
            dgv_principal.Columns[5].Width = 250;
            dgv_principal.Columns[5].HeaderText = "SALIDA_PRODUCTO";
            dgv_principal.Columns[6].Width = 250;
            dgv_principal.Columns[6].HeaderText = "PRECIO";
            dgv_principal.Columns[7].Width = 250;
            dgv_principal.Columns[7].HeaderText = "FECHA_ENTRADA";
            dgv_principal.Columns[8].Width = 250;
            dgv_principal.Columns[8].HeaderText = "FECHA_SALIDA";
            dgv_principal.Columns[9].Width = 250;
            dgv_principal.Columns[9].HeaderText = "STOCK_TOTAL";



        }

        private void LoadData()
        {
            // Define la cadena de conexión (ajústala según tu entorno)
            string connectionString = "Data Source=DESKTOP-JORLE;Initial Catalog=SISTEMA_VENTAS;User ID=sa;Password=123456;";

            // Define la consulta SQL
            string query = "SELECT * FROM inventario_3";

            // Crear un objeto de conexión
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear un adaptador de datos
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                    // Crear y llenar un DataTable
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Vincular el DataTable al DataGridView
                    dgv_principal.DataSource = dataTable;
                    this.Formato_cat();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
        }


        private void Selecciona_item_pr()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("No se tiene informacion para Visualizar",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txt_Id_Inventario.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value);
                txt_Producto_Inventario.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[1].Value);
                txt_Descripcion_Inventario.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[2].Value);
                txt_Stock_Inicial_Inventario.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[3].Value);
                txt_Entrada_Producto_Inventario.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[4].Value);
                txt_Salida_Producto_Inventario.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[5].Value);
                txt_Precio_Inventario.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[6].Value);
                txt_Fecha_Entrada_Inventario.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[7].Value);
                txt_Fecha_Salida_Inventario.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[8].Value);
                txt_Stock_Total_Inventario.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[9].Value);











            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id_Inventario.Text = dgv_principal.CurrentRow.Cells[0].Value.ToString();
            txt_Producto_Inventario.Text = dgv_principal.CurrentRow.Cells[1].Value.ToString();
            txt_Descripcion_Inventario.Text = dgv_principal.CurrentRow.Cells[2].Value.ToString();
            txt_Stock_Inicial_Inventario.Text = dgv_principal.CurrentRow.Cells[3].Value.ToString();
            txt_Entrada_Producto_Inventario.Text = dgv_principal.CurrentRow.Cells[4].Value.ToString();
            txt_Salida_Producto_Inventario.Text = dgv_principal.CurrentRow.Cells[5].Value.ToString();
            txt_Precio_Inventario.Text = dgv_principal.CurrentRow.Cells[6].Value.ToString();
            txt_Fecha_Entrada_Inventario.Text = dgv_principal.CurrentRow.Cells[7].Value.ToString();
            txt_Fecha_Salida_Inventario.Text = dgv_principal.CurrentRow.Cells[8].Value.ToString();
            txt_Stock_Total_Inventario.Text = dgv_principal.CurrentRow.Cells[9].Value.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}




