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
using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;

namespace Proyecto_Final_Base_De_Datos
{
    public partial class F_Cliente : Form
    {

        string Rutaconexion = null;
        SqlConnection Conexion;
        string consulta = null;



        public F_Cliente()
        {
            InitializeComponent();

            Rutaconexion = @"Data Source=DESKTOP-JORLE;Initial Catalog=SISTEMA_VENTAS;User ID=sa;Password=123456;";
            LoadData();



            Conexion = new SqlConnection(Rutaconexion);


        }

        private void btn_Principal_Click(object sender, EventArgs e)
        {

            F_Principal f_Principal = new F_Principal();
            f_Principal.Show();
        }

        private void F_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_Selet_Click(object sender, EventArgs e)
        {



            SqlCommand comando = new SqlCommand("Select * From clientes where id_cliente = " + "'" + txt_Id_Cliente.Text + "'", Conexion);
            Conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();



            if (registro.Read())
            {
                txt_Nombre_Cliente.Text = registro["nombre"].ToString();
                txt_Apellido_Cliente.Text = registro["apellido"].ToString();
                txt_Cedula_Cliente.Text = registro["cedula"].ToString();
            }
            Conexion.Close();

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-JORLE ; database=SISTEMA_VENTAS ; integrated security = true");
            conexion.Open();
            string nombre = txt_Nombre_Cliente.Text;
            string apellido = txt_Apellido_Cliente.Text;
            string cedula = txt_Cedula_Cliente.Text;






            string cadena = "insert into clientes(nombre, apellido, cedula) values ('" + nombre + "','" + apellido + "', '" + cedula + "')";


            SqlCommand comando = new SqlCommand(cadena, conexion); comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");

            txt_Nombre_Cliente.Text = "";
            txt_Apellido_Cliente.Text = "";
            txt_Cedula_Cliente.Text = "";


            conexion.Close();

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            // Aquí deberías obtener el identificador del registro que deseas eliminar.
            // Puede ser un ID obtenido de un TextBox, por ejemplo.
            int idAEliminar = Convert.ToInt32(txt_Id_Cliente.Text); // Asegúrate de tener un TextBox con el ID del registro

            // Obtén la cadena de conexión desde el archivo de configuración


            // Define la consulta SQL para eliminar el registro
            string query = "DELETE FROM clientes WHERE id_cliente = @id_cliente";

            // Usa un bloque using para asegurarte de que los recursos sean liberados correctamente
            using (SqlCommand command = new SqlCommand(query, Conexion))
            {
                command.Parameters.AddWithValue("@id_cliente", idAEliminar);

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

                        txt_Id_Cliente.Text = "";
                    }
                }
            }
        }




        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {
            // Obtiene los valores de los campos de texto
            string nombre = txt_Nombre_Cliente.Text;
            string apellido = txt_Apellido_Cliente.Text;
            string cedula = txt_Cedula_Cliente.Text;



            // Asumiendo que el producto tiene un identificador único
            if (int.TryParse(txt_Id_Cliente.Text, out int id_cliente))
            {
                // Define la consulta SQL para actualizar el registro
                string query = "UPDATE clientes SET " +
                                   "nombre = @nombre, " +
                                   "apellido = @apellido, " +
                                   "cedula = @cedula " +
                                  "WHERE id_cliente = @id_cliente";



                // Usa un bloque using para asegurarte de que los recursos sean liberados correctamente
                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    // Añade los parámetros a la consulta
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@id_cliente", id_cliente);


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
            dgv_principal.Columns[1].HeaderText = "NOMBRE";
            dgv_principal.Columns[2].Width = 250;
            dgv_principal.Columns[2].HeaderText = "APELLIDO";
            dgv_principal.Columns[3].Width = 250;
            dgv_principal.Columns[3].HeaderText = "CEDULA";

        }


        private void LoadData()
        {
            // Define la cadena de conexión (ajústala según tu entorno)
            string connectionString = "Data Source=DESKTOP-JORLE;Initial Catalog=SISTEMA_VENTAS;User ID=sa;Password=123456;";

            // Define la consulta SQL
            string query = "SELECT * FROM clientes";

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
                txt_Id_Cliente.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[0].Value);
                txt_Nombre_Cliente.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[1].Value);
                txt_Apellido_Cliente.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[2].Value);
                txt_Cedula_Cliente.Text = Convert.ToString(dgv_principal.CurrentRow.Cells[3].Value);





            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_Id_Cliente.Text = dgv_principal.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre_Cliente.Text = dgv_principal.CurrentRow.Cells[1].Value.ToString();
            txt_Apellido_Cliente.Text = dgv_principal.CurrentRow.Cells[2].Value.ToString();
            txt_Cedula_Cliente.Text = dgv_principal.CurrentRow.Cells[3].Value.ToString();

        }

        private void btn_Principal_Click_1(object sender, EventArgs e)
        {
            F_Principal f_Principal = new F_Principal();
            f_Principal.Show();
        }
    }
}


