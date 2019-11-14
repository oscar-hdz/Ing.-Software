using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_proyecto
{
    public partial class V_VENTAS : Form
    {
        public V_VENTAS()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_TIENDADataSet.VVENTAS' Puede moverla o quitarla según sea necesario.
            this.vVENTASTableAdapter.Fill(this.dB_TIENDADataSet.VVENTAS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
