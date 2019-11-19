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
    public partial class Menu : Form
    {
        private Compra compra;
        public Menu()
        {
            InitializeComponent();
        }

        private void searchTable(string table, string extraQuery, DataGridView grid)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                string list = "select * from " + table + " where bhabilitado = 1 " + extraQuery;
                SqlDataAdapter dataadapter = new SqlDataAdapter(list, conn);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds);
                grid.DataSource = ds.Tables[0];
                conn.Close();
            }
        }

        private void searchView(string view, string whereQuery, DataGridView grid)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                string list =  $"select * from {view} {whereQuery}";
                SqlDataAdapter dataadapter = new SqlDataAdapter(list, conn);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds);
                grid.DataSource = ds.Tables[0];
                conn.Close();
            }
        }

        private void searchView(string view, string selectQuery, string whereQuery, DataGridView grid)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                string list = $"select {selectQuery} from {view} {whereQuery}";
                SqlDataAdapter dataadapter = new SqlDataAdapter(list, conn);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds);
                grid.DataSource = ds.Tables[0];
                conn.Close();
            }
        }

        private void refreshView(string view, DataGridView grid)
        {
            searchView(view, "", grid);
        }

        private int validar_id_persona(int ID, string persona)
        {
            string funcion = $"SELECT dbo.FN_VALIDAR_ID_{persona}({ID.ToString()})";
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_TIENDADataSet.VCLIENTES' Puede moverla o quitarla según sea necesario.
            this.vCLIENTESTableAdapter.Fill(this.dB_TIENDADataSet.VCLIENTES);
            // TODO: esta línea de código carga datos en la tabla 'dB_TIENDADataSet.TBL_VENTAS' Puede moverla o quitarla según sea necesario.
            this.tBL_VENTASTableAdapter.Fill(this.dB_TIENDADataSet.TBL_VENTAS);
            // TODO: esta línea de código carga datos en la tabla 'dB_TIENDADataSet.VPROVEEDORES' Puede moverla o quitarla según sea necesario.
            this.vPROVEEDORESTableAdapter.Fill(this.dB_TIENDADataSet.VPROVEEDORES);
            // TODO: esta línea de código carga datos en la tabla 'dB_TIENDADataSet1.VINVENTARIO' Puede moverla o quitarla según sea necesario.
            this.vINVENTARIOTableAdapter.Fill(this.dB_TIENDADataSet1.VINVENTARIO);
            // TODO: esta línea de código carga datos en la tabla 'dB_TIENDADataSet.VINVENTARIO' Puede moverla o quitarla según sea necesario.
            this.vINVENTARIOTableAdapter.Fill(this.dB_TIENDADataSet.VINVENTARIO);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Agregar_Producto formulario = new Agregar_Producto();
            formulario.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float total, totalRecibido, cambio;
            try
            {
                total = float.Parse(TBTotal.Text.Substring(1));
                totalRecibido = float.Parse(TBPagoRecibido.Text);
                cambio = totalRecibido - total;
                Lcambio.Text = "$" + cambio.ToString();
                BotónFinalizarVenta.Enabled = true;
            }
            catch (FormatException error)
            {
                Form3 formulario = new Form3();
                formulario.Show();
            }

        }

        private void tabControl1_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void BotónAgregarProducto_Click(object sender, EventArgs e)
        {
            agregarProducto(numericCantidad, numericIDVenta, TBProductos, TBCantidad, TBSubtotal, "VENTA");
            actualizarTotal(TBTotal);
            refreshNumeric(numericIDVenta, numericCantidad);
        }

        private float GetSubTotalProducto(int ID, int cantidad, string tipo)
        {
            float precio;
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT dbo.FN_GET_PRECIO_{tipo}(@vnIDProducto)", conn);
                cmd.Parameters.AddWithValue("@vnIDProducto", ID);
                float.TryParse(cmd.ExecuteScalar().ToString(), out precio);
                conn.Close();
            }
            return precio * cantidad;
        }

        private string GetInfoProducto(int ID)
        {
            string resultado = "No se encontró la base de datos...";
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT dbo.FN_GET_INFO_PRODUCTO(@vnIDProducto)", conn);
                cmd.Parameters.AddWithValue("@vnIDProducto", ID);
                resultado = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
            return resultado;
        }

        private int GetCantidadProducto(int ID)
        {
            int cantidad;
            using (SqlConnection conn = new SqlConnection("Data Source=LENOVO-ELISEO\\SQLEXPRESS;Initial Catalog=DB_TIENDA;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT dbo.FN_GET_CANTIDAD_PRODUCTO(@vnIDProducto)", conn);
                cmd.Parameters.AddWithValue("@vnIDProducto", ID);
                int.TryParse(cmd.ExecuteScalar().ToString(), out cantidad);
                conn.Close();
            }
            return cantidad;
        }

        private void BotónNuevaCompra_Click(object sender, EventArgs e)
        {
            numericCantidad.Enabled = true;
            numericIDVenta.Enabled = true;
            TBPagoRecibido.Enabled = true;
            BotónAgregarProducto.Enabled = true;
            checkBoxOpCliente.Enabled = true;
            BotónCalcularCambio.Enabled = true;
            BotónCancelarVenta.Enabled = true;
            compra = new Compra();
        }

        private void actualizarTotal(TextBox textBox)
        {
            textBox.Text = $"${String.Format("{0:0.00}", compra.getTotal())}";
        }

        private void actualizarTotal(Label label)
        {
            label.Text = $"${String.Format("{0:0.00}", compra.getTotal())}";
        }

        private void BotónFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (checkBoxOpCliente.Checked)
            {
                if (validar_id_persona(compra.getID(), "CLIENTE") == 1)
                {
                    compra.realizarVentaID();
                }
                else
                {
                    MessageBox.Show("Seleccionar un ID válido...");
                }

            }
            else
            {
                compra.realizarTransaccion("VENTA");
            }
            refreshVenta();
        }

        private void refreshVenta()
        {
            BotónFinalizarVenta.Enabled = false;
            BotónAgregarProducto.Enabled = false;
            TBPagoRecibido.Enabled = false;
            checkBoxDeuda.Enabled = false;
            numericCantidad.Value = 1;
            numericCantidad.Enabled = false;
            numericIDCliente.Value = 0;
            numericIDCliente.Enabled = false;
            numericIDVenta.Value = 0;
            numericIDVenta.Enabled = false;
            TBCantidad.Text = "";
            TBProductos.Text = "";
            TBSubtotal.Text = "";
            checkBoxOpCliente.Enabled = false;
            TBTotal.Text = "";
            checkBoxDeuda.Checked = false;
            checkBoxOpCliente.Checked = false;
            BotónCalcularCambio.Enabled = false;
            Lcambio.Text = "$0.00";
            TBPagoRecibido.Text = "";
            BotónCancelarVenta.Enabled = false;
            refreshView("VINVENTARIO", dataGridView1);

        }

        private void checkBoxOpCliente_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxDeuda.Enabled = !checkBoxDeuda.Enabled;
            numericIDCliente.Enabled = !numericIDCliente.Enabled;
        }

        private void checkBoxDeuda_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDeuda.Checked)
            {
                compra.setDeuda(1);
            }
            else
            {
                compra.setDeuda(0);
            }
        }

        private void numericIDCliente_ValueChanged(object sender, EventArgs e)
        {
            compra.setCliente(int.Parse(numericIDCliente.Value.ToString()));
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text != "")
            {
                string extraQuery = $"where lower(cproducto) like '{SearchBox.Text.ToLower()}%'";
                searchView("VINVENTARIO", extraQuery, gridInventario);
            }
        }

        private void BotonAgregarProducto_Click(object sender, EventArgs e)
        {
            Agregar_Producto form = new Agregar_Producto();
            form.Show();
        }

        private void BotónRefrescar_Click(object sender, EventArgs e)
        {
            refreshView("VINVENTARIO", gridInventario);
            SearchBox.Text = "";
        }

        private void BotónBuscarProveedores_Click(object sender, EventArgs e)
        {
            if (SearchBoxProveedores.Text != "")
            {
                string extraQuery = $"where lower(proveedores) like '{SearchBoxProveedores.Text.ToLower()}%'";
                searchView("VPROVEEDORES", extraQuery, gridProveedores);
            }
        }

        private void BotónRefrescarProveedores_Click(object sender, EventArgs e)
        {
            refreshView("VPROVEEDORES", gridProveedores);
            SearchBoxProveedores.Text = "";
        }

        private void BotónBuscarCliente_Click(object sender, EventArgs e)
        {
            string query = $"where lower(clientes) like '{SearchBoxClientes.Text.ToLower()}%'";
            string view;
            if(checkBoxOpDuedores.Checked)
            {
                view = "VDEUDORES_SOLOS";
            }
            else
            {
                view = "VCLIENTES";
            }
            if (SearchBoxClientes.Text != "")
            {
                searchView(view, query, gridClientes);
            }
        }

        private void BotónRefrescarCliente_Click(object sender, EventArgs e)
        {
            if(checkBoxOpDuedores.Checked)
            {
                refreshView("VDEUDORES_SOLOS", gridClientes);
            }
            else
            {
                refreshView("VCLIENTES", gridClientes);
            }
            SearchBoxClientes.Text = "";
        }

        private void BotónDeudaCliente_Click(object sender, EventArgs e)
        {
            int id_cliente = int.Parse(numericIDClienteDeuda.Value.ToString());
            if (validar_id_persona(id_cliente, "CLIENTE") == 1)
            {
            Deudas_Cliente_Seleccionado form = new Deudas_Cliente_Seleccionado(id_cliente);
            form.Show();
            }
            else
            {
                MessageBox.Show("No se encontró un cliente con el ID proporcionado...");
            }
        }

        private void BotónProductosPorProveedor_Click(object sender, EventArgs e)
        {
            int id_proveedor = int.Parse(numericIDProveedor.Value.ToString());
            if (validar_id_persona(id_proveedor, "PROVEEDOR") == 1)
            {
                string selectQuery = "ID, PRODUCTO, PRESENTACIÓN, CANTIDAD, [PRECIO DE COMPRA]";
                string whereQuery = $"where (ID_PROVEEDOR) = {id_proveedor}";
                searchView("VPRODUCTOS_POR_PROVEEDOR", selectQuery, whereQuery, gridProductoPorProveedor);
            }
            else
            {
                MessageBox.Show("No se encontró un cliente con el ID proporcionado...");
            }
        }

        public void refreshNumeric(NumericUpDown IDProducto, NumericUpDown cantidad)
        {
            IDProducto.Value = 0;
            cantidad.Value = 1;
        }

        private void refreshCompra()
        {
            refreshNumeric(numericIDCompra, numericCantidadCompra);
            TBCantidadCompra.Text = "";
            TBProductosCompra.Text = "";
            TBSubtotalCompra.Text = "";
            TBTotalCompra.Text = "";
        }

        private void disableCompra()
        {
            numericIDCompra.Enabled = false;
            numericCantidadCompra.Enabled = false;
            BotónAgregarProductoCompra.Enabled = false;
            BotónCancelarCompra.Enabled = false;
            BotónFinalizarCompra.Enabled = false;
        }

        private void BotónCancelarCompra_Click(object sender, EventArgs e)
        {
            refreshCompra();
            disableCompra();
        }

        private void BotónNuevaCompra_Click_1(object sender, EventArgs e)
        {
            numericIDCompra.Enabled = true;
            numericCantidadCompra.Enabled = true;
            BotónAgregarProductoCompra.Enabled = true;
            BotónCancelarCompra.Enabled = true;
            BotónFinalizarCompra.Enabled = true;
            refreshCompra();
            compra = new Compra();
        }

        private void BotónAgregarProductoCompra_Click(object sender, EventArgs e)
        {
            agregarProducto(numericCantidadCompra, numericIDCompra, TBProductosCompra, TBCantidadCompra, TBSubtotalCompra, "COMPRA");
            actualizarTotal(TBTotalCompra);
            refreshNumeric(numericIDCompra, numericCantidadCompra);
        }

        private void agregarProducto(NumericUpDown nCantidad, NumericUpDown nIDProducto, TextBox tbProductos, TextBox tbCantidad, TextBox tbSubtotal, string tipo)
        {
            int cantidad = int.Parse(nCantidad.Value.ToString());
            int IDProducto = int.Parse(nIDProducto.Value.ToString());
            string producto = GetInfoProducto(IDProducto);
            float subtotal = GetSubTotalProducto(IDProducto, cantidad, tipo);
            if (producto.Substring(0, 5) == "Error")
            {
                MessageBox.Show(producto);
                return;
            }
            else if (GetCantidadProducto(IDProducto) < cantidad && tipo == "VENTA")
            {
                MessageBox.Show("No hay suficientes elementos en el inventario...");
                return;
            }
            compra.actualizarLista(IDProducto, subtotal, cantidad);
            tbProductos.Text += $"{GetInfoProducto(IDProducto)}{Environment.NewLine}";
            tbCantidad.Text += $"{cantidad}{Environment.NewLine}";
            tbSubtotal.Text += $"${String.Format("{0:0.00}", subtotal)}{Environment.NewLine}";
        }

        private void BotónFinalizarCompra_Click_1(object sender, EventArgs e)
        {
            compra.realizarTransaccion("COMPRA");
            refreshCompra();
            disableCompra();
        }

        private void BotónCancelarVenta_Click(object sender, EventArgs e)
        {
            refreshVenta();
        }

        private void BotónAgregarClientePersona_Click(object sender, EventArgs e)
        {
            NuevoCliente form = new NuevoCliente();
            form.Show();
        }
    }
}
