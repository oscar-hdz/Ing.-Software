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
    public partial class Agregar_Producto : Form
    {
        public Agregar_Producto()
        {
            InitializeComponent();
        }

        private void Agregar_Producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dB_TIENDADataSet.TBL_PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.tBL_PRODUCTOSTableAdapter.Fill(this.dB_TIENDADataSet.TBL_PRODUCTOS);

        }
    }
}
