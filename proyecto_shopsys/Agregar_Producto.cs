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

namespace proyecto_shopsys
{
    public partial class Agregar_Producto : Form
    {
        public Agregar_Producto()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonNuevoProveedor_Click(object sender, EventArgs e)
        {
            NuevoCliente form = new NuevoCliente();
            form.Show();
        }

        private void refresh()
        {
            TBProducto.Text = "";
            numericPrecioCompra.Value = 0;
            numericPrecioVenta.Value = 0;
            numericProveedor.Value = 0;
            ComboMarca.Text = "";
            ComboPres.Text = "";
        }

        private void BotónCancelar_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void BotónAgregar_Click(object sender, EventArgs e)
        {
            int idMarca, idTipoProducto;
            idMarca = setIDMarca();
            if (idMarca == 0)
            {
                MessageBox.Show("No se encontró el ID de la marca, intente de nuevo");
                return;
            }
            idTipoProducto = setIDProducto();
            if (idTipoProducto == 0)
            {
                MessageBox.Show("No se encontró el ID del producto, intente de nuevo");
                return;
            }
            Agregar(idMarca, idTipoProducto);
        }

        private void Agregar(int marca, int tipoProducto)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                string resultado;
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SPD_NUEVO_PRODUCTO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vcProducto", TBProducto.Text);
                cmd.Parameters.AddWithValue("@vcPrecioCompra", numericPrecioCompra.Text);
                cmd.Parameters.AddWithValue("@vcPrecioVenta", numericPrecioVenta.Text);
                cmd.Parameters.AddWithValue("@vnCantidad", 0);
                cmd.Parameters.AddWithValue("@vnIDMarca", marca);
                cmd.Parameters.AddWithValue("@vnIDTipoProducto", tipoProducto);
                cmd.Parameters.AddWithValue("@vnIDProveedor", numericProveedor.Value);
                cmd.Parameters.Add("@RESULTADO", SqlDbType.VarChar, 70).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                resultado = Convert.ToString(cmd.Parameters["@RESULTADO"].Value);

                MessageBox.Show(resultado);
                conn.Close();
                if (resultado.Substring(0, 5) != "Error")
                {
                    DialogResult result = MessageBox.Show("¿Desea agregar otro producto?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        refresh();
                    }
                    else
                    {
                        Close();
                    }
                }

            }
        }

        private int nuevaMarca()
        {
            int id;
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                string resultado;
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SPD_NUEVA_MARCA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vcCMarca", ComboMarca.Text);
                cmd.Parameters.Add("@RESULTADO", SqlDbType.VarChar, 70).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                resultado = Convert.ToString(cmd.Parameters["@RESULTADO"].Value);
                if (!Int32.TryParse(resultado, out id))
                {
                    MessageBox.Show(resultado);
                }
                else if (id != 0)
                {
                    MessageBox.Show("Se agregó la marca al catálogo");
                }

                conn.Close();
            }
            return id;
        }

        private int getIDMarca()
        {
            int id;
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT dbo.FN_GET_ID_MARCA(@vcMarca)", conn);
                cmd.Parameters.AddWithValue("@vcMarca", ComboMarca.Text);
                Int32.TryParse(cmd.ExecuteScalar().ToString(), out id);
                conn.Close();
            }
            return id;
        }

        private int setIDMarca()
        {
            if (checkBoxMarca.Checked)
            {
                return nuevaMarca();
            }
            else
            {
                return getIDMarca();
            }
        }

        private int setIDProducto()
        {
            if (checkBoxPres.Checked)
            {
                return nuevoTipoProducto();
            }
            else
            {
                return getIDTipoProducto();
            }
        }

        private int nuevoTipoProducto()
        {
            int id;
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                string resultado;
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SPD_NUEVO_TIPO_PRODUCTO", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vcCTipo_Producto", ComboPres.Text);
                cmd.Parameters.Add("@RESULTADO", SqlDbType.VarChar, 70).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                resultado = Convert.ToString(cmd.Parameters["@RESULTADO"].Value);
                if (!Int32.TryParse(resultado, out id))
                {
                    MessageBox.Show(resultado);
                }
                else if (id != 0)
                {
                    MessageBox.Show("Se agregó la nueva presentación al catálogo");
                }
                conn.Close();
            }
            return id;
        }

        private int getIDTipoProducto()
        {
            int id;
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT dbo.FN_GET_ID_TIPO_PRODUCTO(@vcTipoProducto)", conn);
                cmd.Parameters.AddWithValue("@vcTipoProducto", ComboPres.Text);
                Int32.TryParse(cmd.ExecuteScalar().ToString(), out id);
                conn.Close();
            }
            return id;
        }

        private void Agregar_Producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_TIENDADataSet.CAT_TIPO_PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.cAT_TIPO_PRODUCTOSTableAdapter.Fill(this.dB_TIENDADataSet.CAT_TIPO_PRODUCTOS);
            // TODO: esta línea de código carga datos en la tabla 'dB_TIENDADataSet.TBL_MARCAS' Puede moverla o quitarla según sea necesario.
            this.tBL_MARCASTableAdapter.Fill(this.dB_TIENDADataSet.TBL_MARCAS);

        }
    }
}
