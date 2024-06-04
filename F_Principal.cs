using System.Net.NetworkInformation;

using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Windows.Forms;



namespace Proyecto_Final_Base_De_Datos
{
    public partial class F_Principal : Form
    {
        private void btn_Cliente_Click_1(object sender, EventArgs e)
        {
            F_Cliente f_Cliente = new F_Cliente();
            f_Cliente.Show();
        }

        private void btn_Empleado_Click_1(object sender, EventArgs e)
        {
            F_Empleado f_Empleado = new F_Empleado();
            f_Empleado.Show();
        }

        private void btn_Inventario_Click_1(object sender, EventArgs e)
        {
            F_Inventario f_Inventario = new F_Inventario();
            f_Inventario.Show();
        }

        private void btn_Factura_Click_1(object sender, EventArgs e)
        {
            F_Factura f_Factura = new F_Factura();
            f_Factura.Show();
        }
    }
}