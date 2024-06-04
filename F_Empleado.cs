using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Base_De_Datos
{
    public partial class F_Empleado : Form
    {
        string Rutaconexion1 = null;
        SqlConnection conexion;
        string consultas = null;

        private void Formato()
        {
            dgv_Empleado.Columns[0].Width = 100;
            dgv_Empleado.Columns[0].HeaderText = "CODIGO";
            dgv_Empleado.Columns[1].Width = 250;
            dgv_Empleado.Columns[1].HeaderText = "NOMBRE";
            dgv_Empleado.Columns[2].Width = 250;
            dgv_Empleado.Columns[2].HeaderText = "APELLIDO";
            dgv_Empleado.Columns[3].Width = 250;
            dgv_Empleado.Columns[3].HeaderText = "EDAD";
            dgv_Empleado.Columns[4].Width = 250;
            dgv_Empleado.Columns[4].HeaderText = "CEDULA";
            dgv_Empleado.Columns[5].Width = 250;
            dgv_Empleado.Columns[5].HeaderText = "TELEFONO";
            dgv_Empleado.Columns[6].Width = 250;
            dgv_Empleado.Columns[6].HeaderText = "DIRECCION";
            dgv_Empleado.Columns[7].Width = 250;
            dgv_Empleado.Columns[7].HeaderText = "CARGO";
            dgv_Empleado.Columns[8].Width = 250;
            dgv_Empleado.Columns[8].HeaderText = "SUELDO";


        }

        private void Load()
        {
            // Define la cadena de conexión (ajústala según tu entorno)
            string connectionString = "Data Source=DESKTOP-JORLE;Initial Catalog=SISTEMA_VENTAS;User ID=sa;Password=123456;";

            // Define la consulta SQL
            string query = "SELECT * FROM empleados";

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
                    dgv_Empleado.DataSource = dataTable;
                    this.Formato_cat();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
        }

        private void seleccionar()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_Empleado.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("No se tiene informacion para Visualizar",
                    "Aviso del Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                txt_Id_Empleado.Text = Convert.ToString(dgv_Empleado.CurrentRow.Cells[0].Value);
                txt_Nombre_Empleado.Text = Convert.ToString(dgv_Empleado.CurrentRow.Cells[1].Value);
                txt_Apellido_Empleado.Text = Convert.ToString(dgv_Empleado.CurrentRow.Cells[2].Value);
                txt_Edad_Empleado.Text = Convert.ToString(dgv_Empleado.CurrentRow.Cells[3].Value);
                txt_Cedula_Empleado.Text = Convert.ToString(dgv_Empleado.CurrentRow.Cells[4].Value);
                txt_Telefono_Empleado.Text = Convert.ToString(dgv_Empleado.CurrentRow.Cells[5].Value);
                txt_Direccion_Empleado.Text = Convert.ToString(dgv_Empleado.CurrentRow.Cells[6].Value);
                txt_Cargo_Empleado.Text = Convert.ToString(dgv_Empleado.CurrentRow.Cells[7].Value);
                txt_Sueldo_Empleado.Text = Convert.ToString(dgv_Empleado.CurrentRow.Cells[8].Value);

            }
        }



        private void F_Empleado_Load_1(object sender, EventArgs e)
        {

        }

        private void dgv_Empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_Id_Empleado.Text = dgv_Empleado.CurrentRow.Cells[0].Value.ToString();
            txt_Nombre_Empleado.Text = dgv_Empleado.CurrentRow.Cells[1].Value.ToString();
            txt_Apellido_Empleado.Text = dgv_Empleado.CurrentRow.Cells[2].Value.ToString();
            txt_Edad_Empleado.Text = dgv_Empleado.CurrentRow.Cells[3].Value.ToString();
            txt_Cedula_Empleado.Text = dgv_Empleado.CurrentRow.Cells[4].Value.ToString();
            txt_Telefono_Empleado.Text = dgv_Empleado.CurrentRow.Cells[5].Value.ToString();
            txt_Direccion_Empleado.Text = dgv_Empleado.CurrentRow.Cells[6].Value.ToString();
            txt_Cargo_Empleado.Text = dgv_Empleado.CurrentRow.Cells[7].Value.ToString();
            txt_Sueldo_Empleado.Text = dgv_Empleado.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_Selet_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            // Obtiene los valores de los campos de texto
            string nombre = txt_Nombre_Empleado.Text;
            string apellido = txt_Apellido_Empleado.Text;
            int edad = Convert.ToInt32(txt_Edad_Empleado.Text);
            string cedula = txt_Cedula_Empleado.Text;
            string direccion = txt_Direccion_Empleado.Text;
            string cargo = txt_Cargo_Empleado.Text;
            string telefono = txt_Telefono_Empleado.Text;
            string sueldo = txt_Sueldo_Empleado.Text;



            // Asumiendo que el producto tiene un identificador único
            if (int.TryParse(txt_Id_Empleado.Text, out int id_empleados))
            {
                // Define la consulta SQL para actualizar el registro
                string query = "UPDATE empleados SET " +
                                   "nombre = @nombre, " +
                                   "apellido = @apellido, " +
                                   "edad = @edad, " +
                                   "cedula = @cedula, " +
                                   "direccion = @direccion, " +
                                   "cargo = @cargo, " +
                                   "telefono = @telefono, " +
                                    "sueldo = @sueldo " +
                                   "WHERE id_empleados = @id_empleados";



                // Usa un bloque using para asegurarte de que los recursos sean liberados correctamente
                using (SqlCommand command = new SqlCommand(query, Conexion))
                {
                    // Añade los parámetros a la consulta
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@edad", edad);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@cargo", cargo);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@sueldo", sueldo);
                    command.Parameters.AddWithValue("@id_empleados", id_empleados);


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


    }
}


