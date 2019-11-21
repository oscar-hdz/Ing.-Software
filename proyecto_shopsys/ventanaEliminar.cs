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
    public partial class ventanaEliminar : Form
    {
        public ventanaEliminar()
        {
            InitializeComponent();
        }

        private List<string> info = new List<string>();

        private void refreshInfo()
        {
            info.Clear();
        }

        private void refreshWindow()
        {
            numericID.Value = 0;
            RBProducto.Checked = true;
            refreshInfo();
        }

        public int validarID(int ID, string tipo)
        {
            string funcion = $"SELECT dbo.FN_VALIDAR_ID_{tipo}({ID})";
            Int32 validacion = 0;
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(funcion, conn);
                Int32.TryParse(cmd.ExecuteScalar().ToString(), out validacion);
                conn.Close();
            }
            return validacion;
        }

        public void eliminar(string tipo, string tipoTabla)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                string list = $"update {tipoTabla}_{tipo}s set bhabilitado=0 where nid_{tipo}={numericID.Value}";
                SqlCommand cmd = new SqlCommand(list, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void getRBInfo()
        {
            if (RBProducto.Checked == true)
            {
                info.Add(RBProducto.Text);
                info.Add(RBProducto.Tag.ToString());
            }
            else if (RBProveedor.Checked == true)
            {
                info.Add(RBProveedor.Text);
                info.Add(RBProveedor.Tag.ToString());
            }
            else
            {
                info.Add(RBCliente.Text);
                info.Add(RBCliente.Tag.ToString());
            }
        }

        private void BotónEliminar_Click(object sender, EventArgs e)
        {
            getRBInfo();
            if (validarID(int.Parse(numericID.Value.ToString()), info[0]) == 1)
            {
                string mensaje = "Una vez eliminada la información, no se puede recuperar, ¿Seguro que quieres continuar?";
                DialogResult result = MessageBox.Show(mensaje, "Alto!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    eliminar(info[0], info[1]);
                    result = MessageBox.Show("¿Eliminar otro elemento de la base de datos?", "", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show($"El ID proporcionado no le corresponde a ningún {info[0].ToLower()}.");
            }
            refreshWindow();
        }
    }
}
