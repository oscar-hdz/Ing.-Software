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
    public partial class Deudas_Cliente_Seleccionado : Form
    {

        private int ID_cliente;

        public Deudas_Cliente_Seleccionado(int id_cliente)
        {

            InitializeComponent();
            Init(id_cliente);
            Asociar_ID();
        }


        private void Init(int id_cliente)
        {
            ID_cliente = id_cliente;
        }

        private void Asociar_ID()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                string list = $"select PRODUCTO, PRESENTACIÓN, CANTIDAD, TOTAL, FECHA from VDEUDAS where [ID CLIENTE] = {ID_cliente}";
                SqlDataAdapter dataadapter = new SqlDataAdapter(list, conn);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void BotónSaldarDeuda_Click(object sender, EventArgs e)
        {
            if (checarDeuda())
            {
                saldarDeuda();
            }
        }

        private void saldarDeuda()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                string resultado;
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SPD_SALDAR_DEUDA", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vnIDCLiente", ID_cliente);
                cmd.Parameters.Add("@vcResultado", SqlDbType.VarChar, 70).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                resultado = Convert.ToString(cmd.Parameters["@vcResultado"].Value);
                MessageBox.Show(resultado);
                if (resultado == "Deuda saldada")
                {
                    Close();
                }
                conn.Close();
            }
        }

        private bool checarDeuda()
        {
            string resultado;
            float deuda;
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SPD_VER_DEUDA_CLIENTE", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vnIDCLiente", ID_cliente);
                cmd.Parameters.Add("@vcResultado", SqlDbType.VarChar, 70).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();

                resultado = Convert.ToString(cmd.Parameters["@vcResultado"].Value);
                conn.Close();
            }
            if (float.TryParse(resultado, out deuda))
            {
                string mensaje = "La deuda es de $" + resultado + ". ¿Saldar la deuda?";
                DialogResult result = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    return true;
                }
            }
            else
            {

                MessageBox.Show(resultado);
            }
            return false;
        }
    }
}
