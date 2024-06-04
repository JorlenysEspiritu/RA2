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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final_Base_De_Datos
{
    public partial class F_Factura : Form
    {

        string Rutaconexion = null;
        SqlConnection Conexion;
        string consulta = null;
        public F_Factura()
        {
            InitializeComponent();

                    Rutaconexion = @"Data Source=DESKTOP-JORLE;Initial Catalog=SISTEMA_VENTAS;User ID=sa;Password=123456";
            Conexion = new SqlConnection(Rutaconexion);
            LoadData();

        }



        private void btn_Principal_Click(object sender, EventArgs e)
        {

            F_Principal f_Principal = new F_Principal();
            f_Principal.Show();
        }

        private void F_Factura_Load(object sender, EventArgs e)
        {

        }

        private void btn_Selet_Click(object sender, EventArgs e)
        {

            SqlCommand comando = new SqlCommand("Select * From factura_2 where id_factura = " + "'" + txt_Id_Factura.Text + "'", Conexion);
            Conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();



            if (registro.Read())
            {
                txt_Producto_Factura.Text = registro["producto"].ToString();
                txt_Precio_Factura.Text = registro["precio"].ToString();
                txt_Cantidad_Factura.Text = registro["cantidad"].ToString();
                txt_Cliente_Factura.Text = registro["cliente"].ToString();
                txt_Empleado_Factura.Text = registro["empleado"].ToString();
                txt_Total_Factura.Text = registro["total"].ToString();
                txt_Fecha_Factura.Text = registro["fecha_factura"].ToString();



            }
            Conexion.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            SqlConnection conexion = new SqlConnection("server=DESKTOP-JORLE ; database=SISTEMA_VENTAS ; integrated security = true");
            conexion.Open();

            string producto = txt_Producto_Factura.Text;
            string precio = txt_Precio_Factura.Text;
            string cantidad = txt_Cantidad_Factura.Text;
            string cliente = txt_Cliente_Factura.Text;
            string empleado = txt_Empleado_Factura.Text;
            string fecha_factura = txt_Fecha_Factura.Text;









            string cadena = "insert into factura_2(producto, precio, cantidad, cliente, empleado, fecha_factura) values ('" + producto + "', " + precio + ", " + cantidad + ", '" + cliente + "', '" + empleado + "', '" + fecha_factura + "' )";


            SqlCommand comando = new SqlCommand(cadena, conexion); comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");


            txt_Producto_Factura.Text = "";
            txt_Precio_Factura.Text = "";
            txt_Cantidad_Factura.Text = "";
            txt_Cliente_Factura.Text = "";
            txt_Empleado_Factura.Text = "";
            txt_Fecha_Factura.Text = "";

            conexion.Close();

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            // Aquí deberías obtener el identificador del registro que deseas eliminar.
            // Puede ser un ID obtenido de un TextBox, por ejemplo.
            int idAEliminar = Convert.ToInt32(txt_Id_Factura.Text); // Asegúrate de tener un TextBox con el ID del registro

            // Obtén la cadena de conexión desde el archivo de configuración


            // Define la consulta SQL para eliminar el registro
            string query = "DELETE FROM factura_2 WHERE id_factura = @id_factura";

            // Usa un bloque using para asegurarte de que los recursos sean liberados correctamente
            using (SqlCommand command = new SqlCommand(query, Conexion))
            {
                command.Parameters.AddWithValue("@id_factura", idAEliminar);

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

                        txt_Id_Factura.Text = "";
                    }
                }
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            // Obtiene los valores de los campos de texto
            string producto = txt_Producto_Factura.Text;
            int precio = Convert.ToInt32(txt_Precio_Factura.Text);
            int cantidad = Convert.ToInt32(txt_Cantidad_Factura.Text);
            string cliente = txt_Cliente_Factura.Text;
            string empleado = txt_Empleado_Factura.Text;
            string fecha_factura = txt_Fecha_Factura.Text;



            // Asumiendo que el producto tiene un identificador único
            if (int.TryParse(txt_Id_Factura.Text, out int id_factura))
            {
                // Define la consulta SQL para actualizar el registro
                string query = "UPDATE factura_2 SET " +
                                   "producto = @producto, " +
                                   "precio = @precio, " +
                                   "cantidad = @cantidad, " +
                                   "cliente = @cliente, " +
                                   "empleado = @empleado, " +
                                   "fecha_factura = @fecha_factura " +
                                   "WHERE id_factura = @id_factura";



                // Usa un bloque using para asegurarte de que los recursos sean liberados correctamente
                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    // Añade los parámetros a la consulta
                    command.Parameters.AddWithValue("@producto", producto);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@cliente", cliente);
                    command.Parameters.AddWithValue("@empleado", empleado);
                    command.Parameters.AddWithValue("@fecha_factura", fecha_factura);
                    command.Parameters.AddWithValue("@id_factura", id_factura);


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
            dgv_principal.Columns[2].HeaderText = "PRECIO";
            dgv_principal.Columns[3].Width = 250;
            dgv_principal.Columns[3].HeaderText = "CANTIDAD";
            dgv_principal.Columns[4].Width = 250;
            dgv_principal.Columns[4].HeaderText = "CLIENTE";
            dgv_principal.Columns[5].Width = 250;
            dgv_principal.Columns[5].HeaderText = "EMPLEADO";
            dgv_principal.Columns[6].Width = 250;
            dgv_principal.Columns[6].HeaderText = "TOTAL";
            dgv_principal.Columns[7].Width = 250;
            dgv_principal.Columns[7].HeaderText = "FECHA";


        }


        private void LoadData()
        {
            // Define la cadena de conexión (ajústala según tu entorno)
            string connectionString = "Data Source=DESKTOP-JORLE;Initial Catalog=SISTEMA_VENTAS;User ID=sa;Password=123456;";

            // Define la consulta SQL
            string query = "SELECT * FROM factura_2";

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
                txt_Id_Factura.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value);
                txt_Producto_Factura.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[1].Value);
                txt_Precio_Factura.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[2].Value);
                txt_Cantidad_Factura.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[3].Value);
                txt_Cliente_Factura.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[4].Value);
                txt_Empleado_Factura.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[5].Value);
                txt_Total_Factura.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[6].Value);
                txt_Fecha_Factura.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[7].Value);











            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id_Factura.Text= dgv_principal.CurrentRow.Cells[0].Value.ToString();
            txt_Producto_Factura.Text= dgv_principal.CurrentRow.Cells[1].Value.ToString();
            txt_Precio_Factura.Text= dgv_principal.CurrentRow.Cells[2].Value.ToString();
            txt_Cantidad_Factura.Text= dgv_principal.CurrentRow.Cells[3].Value.ToString();
            txt_Cliente_Factura.Text= dgv_principal.CurrentRow.Cells[4].Value.ToString();
            txt_Empleado_Factura.Text= dgv_principal.CurrentRow.Cells[5].Value.ToString();
            txt_Total_Factura.Text= dgv_principal.CurrentRow.Cells[6].Value.ToString();
            txt_Fecha_Factura.Text= dgv_principal.CurrentRow.Cells[7].Value.ToString();

        }
    }
}



