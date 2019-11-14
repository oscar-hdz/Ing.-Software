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

namespace Prueba_proyecto
{
    public partial class V_MENU : Form
    {
        public V_MENU()
        {
            InitializeComponent();
        }

        private string Apellido_Materno()
        {
            if (OpcionesApellidoMaterno.Text != "")
            {
                return " and lower(CAPELLIDO_MATERNO) = @vcApellidoM";
            }
            else
            {
                return " and CAPELLIDO_MATERNO = NULL";
            }
        }

        private string Get_ID_Seleccion()
        {

            string id_cliente = "No se encontró al cliente...";
            string queryString = "SELECT NID_CLIENTE FROM CAT_CLIENTES WHERE lower(CNOMBRES) = @vcNombre and lower(CAPELLIDO_PATERNO) = @vcApellido";
            queryString += Apellido_Materno();
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Parameters.AddWithValue("@vcNombre", OpcionesNombres.Text.ToLower());
                cmd.Parameters.AddWithValue("@vcApellido", OpcionesApellidos.Text.ToLower());
                if (OpcionesApellidoMaterno.Text != "")
                {
                    cmd.Parameters.AddWithValue("@vcApellidoM", OpcionesApellidoMaterno.Text.ToLower());
                }
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        MessageBox.Show(reader["NID_CLIENTE"].ToString());
                        id_cliente = reader["NID_CLIENTE"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                    conn.Close();
                }

            }
            return id_cliente;
        }

        private int validar_id_cliente(int ID)
        {
            string funcion = "SELECT dbo.FN_VALIDAR_ID_CLIENTE(" + ID.ToString() + ")";
            Int32 validacion = 0;
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(funcion, conn);
                Int32.TryParse(cmd.ExecuteScalar().ToString(), out validacion);
            }
            return validacion;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            V_DEUDORES form = new V_DEUDORES();
            form.Show();
        }

        private void BotónVentas_Click(object sender, EventArgs e)
        {
            V_VENTAS form = new V_VENTAS();
            form.Show();
        }

        private void V_MENU_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_TIENDADataSet.TBL_PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.tBL_PRODUCTOSTableAdapter.Fill(this.dB_TIENDADataSet.TBL_PRODUCTOS);
            // TODO: esta línea de código carga datos en la tabla 'dB_TIENDADataSet.CAT_CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cAT_CLIENTESTableAdapter.Fill(this.dB_TIENDADataSet.CAT_CLIENTES);

        }

        private void BotónDeudaCliente_Click(object sender, EventArgs e)
        {
            string id_cliente = "No se encontró al cliente...";
            if (RBDatos.Checked)
            {
                id_cliente = Get_ID_Seleccion();
                MessageBox.Show("Se encontró el ID: " + id_cliente);
            }
            else
            {
                id_cliente = OpcionesID.Text;
            }
            if (Int32.TryParse(id_cliente, out int ID))
            {
                if (validar_id_cliente(ID) == 1)
                {
                    Deudas_Cliente_Seleccionado form = new Deudas_Cliente_Seleccionado(id_cliente);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró un cliente con el ID proporcionado...");
                }
            }
            else
            {
                MessageBox.Show(id_cliente + " no es un candidato válido para ID.");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BotónNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente form = new NuevoCliente();
            form.Show();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if(SearchBox.Text != "" || SearchBox.Text.ToLower() != "todo")
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
                {
                    conn.Open();
                    string list = "select * from tbl_productos where bhabilitado = 1 and lower(cproducto) like '" + SearchBox.Text.ToLower() + "%'";
                    SqlDataAdapter dataadapter = new SqlDataAdapter(list, conn);
                    DataSet ds = new DataSet();
                    dataadapter.Fill(ds);
                    GridInventario.DataSource = ds.Tables[0];
                }
            }
            else if(SearchBox.Text.ToLower() == "todo")
            {

            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBDatos_CheckedChanged(object sender, EventArgs e)
        {
            OpcionesID.Enabled = !OpcionesID.Enabled;
            OpcionesNombres.Enabled = !OpcionesNombres.Enabled;
            OpcionesApellidos.Enabled = !OpcionesApellidos.Enabled;
            OpcionesApellidoMaterno.Enabled = !OpcionesApellidoMaterno.Enabled;
        }

        private void BotonAgregarProducto_Click(object sender, EventArgs e)
        {
            Agregar_Producto form = new Agregar_Producto();
            form.Show();
        }
    }
}
