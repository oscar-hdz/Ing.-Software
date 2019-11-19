using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace proyecto_shopsys
{
    class Compra
    {
        private int IDCliente;
        private int deuda;
        private float total;
        private List<List<int>> info;

        public Compra()
        {
            inicializarLista();
        }

        private void inicializarLista()
        {
            IDCliente = 0;
            deuda = 0;
            total = 0;
            info = new List<List<int>>();
        }

        public void actualizarLista(int ID, float precio, int cantidad)
        {
            total += precio;
            agregarInfo(info, ID, cantidad);
        }

        public float getTotal()
        {
            return total;
        }

        public void setCliente(int id)
        {
            IDCliente = id;
        }

        public void setDeuda(int bit)
        {
            deuda = bit;
        }

        public int getID()
        {
            return IDCliente;
        }

        private void agregarInfo(List<List<int>> info, int ID, int cantidad)
        {
            List<int> aux = new List<int>();
            aux.Add(ID);
            aux.Add(cantidad);
            info.Add(aux);
        }

        public void realizarTransaccion(string tipo)
        {
            string resultado;
            foreach (List<int> dupla in info)
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand($"dbo.SPD_{tipo}", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vnIDProducto", dupla[0]);
                    cmd.Parameters.AddWithValue("@vnCantidad", dupla[1]);
                    cmd.Parameters.Add("@vcResultado", SqlDbType.VarChar, 70).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToString(cmd.Parameters["@vcResultado"].Value);
                    conn.Close();
                }
                if (resultado.Substring(0, 5) == "Error")
                {
                    MessageBox.Show($"{resultado}. En el producto {dupla[0]}");
                }
            }
            MessageBox.Show("Venta concretada con éxito.");
            refresh();
        }

        public void realizarVentaID()
        {
            string resultado;
            foreach (List<int> dupla in info)
            {
                using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand("dbo.SPD_VENTA_CLIENTE", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@vnIDProducto", dupla[0]);
                    cmd.Parameters.AddWithValue("@vnIDCliente", IDCliente);
                    cmd.Parameters.AddWithValue("@vnCantidad", dupla[1]);
                    cmd.Parameters.AddWithValue("@vbDeuda", deuda);
                    cmd.Parameters.Add("@vcResultado", SqlDbType.VarChar, 70).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToString(cmd.Parameters["@vcResultado"].Value);
                    conn.Close();
                }
                if (resultado.Substring(0, 5) == "Error")
                {
                    MessageBox.Show($"{resultado}. En el producto {dupla[0]}");
                }
            }
            MessageBox.Show("Venta concretada con éxito.");
            refresh();
        }

        private void refresh()
        {
            inicializarLista();
        }
    }
}
