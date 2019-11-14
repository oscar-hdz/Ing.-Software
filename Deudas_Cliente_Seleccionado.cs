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
    public partial class Deudas_Cliente_Seleccionado : Form
    {
        private string ID_cliente;

        public Deudas_Cliente_Seleccionado(string id_cliente)
        {

            InitializeComponent();
            Init(id_cliente);
            Asociar_ID();
        }    

        
        private void Init(string id_cliente)
        {
            ID_cliente = id_cliente;
            label1.Text = "Deudas del cliente: ";
        }

        private void Asociar_ID()
        { 
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                string list = "select * from tbl_ventas where bdeuda = 1 and nid_cliente = " + ID_cliente;
                SqlDataAdapter dataadapter = new SqlDataAdapter(list, conn);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
