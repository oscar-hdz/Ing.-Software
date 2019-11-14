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
    public partial class V_DEUDORES : Form
    {
        public V_DEUDORES()
        {
            InitializeComponent();
        }

        private void V_DEUDORES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_TIENDADataSet.VDEUDORES' Puede moverla o quitarla según sea necesario.
            this.vDEUDORESTableAdapter.Fill(this.dB_TIENDADataSet.VDEUDORES);

        }
    }
}
