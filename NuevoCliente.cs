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
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        private void refresh()
        { 
            TBNombres.Text = "";
            TBApellidoP.Text = "";
            TBApellidoMaterno.Text = "";
            TBEmail.Text = "";
            TBTelefono.Text = "";
        }

        private void Agregar(string tipo)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                string resultado;
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SPD_NUEVO_" + tipo.ToUpper(), conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vcNombres", TBNombres.Text);
                cmd.Parameters.AddWithValue("@vcApellidoP", TBApellidoP.Text);
                cmd.Parameters.AddWithValue("@vcApellidoM", TBApellidoMaterno.Text);
                cmd.Parameters.AddWithValue("@vcTelefono", TBTelefono.Text);
                if(tipo.ToUpper() == "CLIENTE")
                {
                    cmd.Parameters.AddWithValue("@vcEmail", TBEmail.Text);
                }
                cmd.Parameters.Add("@RESULTADO", SqlDbType.VarChar, 70).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                resultado = Convert.ToString(cmd.Parameters["@RESULTADO"].Value);

                MessageBox.Show(resultado);
                conn.Close();
                refresh();
                this.Close();
            }
        }

        private void BotónAgregar_Click(object sender, EventArgs e)
        {
            if (BoxClase.Text == "" || (BoxClase.SelectedIndex != 1 && BoxClase.SelectedIndex != 0))
            {
                MessageBox.Show("Por favor seleccione una opción válida para la clase del individuo a insertar.");
            }
            else if (TBNombres.Text == "" || TBApellidoP.Text == "")
            {
                MessageBox.Show("El campo de nombre y apellido paterno no pueden estar vacíos");
            }
            else if (TBTelefono.Text.Length < 8 || TBTelefono.Text.Length > 10)
            {
                MessageBox.Show("Ingrese un teléfono entre 8 y 10 números.");
            }
            else
            {
                Agregar(BoxClase.Text);
            }
        }

        private void BotónCancelar_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void BoxClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(BoxClase.SelectedIndex == 1)
            {
                TBEmail.Enabled = false;
            }
            else
            {
                TBEmail.Enabled = true;
            }
        }

        private void BoxClase_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (BoxClase.Text == "")
            {
                BoxClase.SelectedIndex = 0;
            }
        }
    }
}
