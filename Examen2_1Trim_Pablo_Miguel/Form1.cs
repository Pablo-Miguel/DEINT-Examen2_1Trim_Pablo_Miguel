using Examen2_1Trim_Pablo_Miguel.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_1Trim_Pablo_Miguel
{
    public partial class Form1 : Form
    {
        public DataGridView dgTienda;
        private ProductoDLL productoDLL;
        private FabricanteDLL fabricanteDLL;
        public Form1()
        {
            InitializeComponent();
            this.dgTienda = dgTiendaVista;
            productoDLL = new ProductoDLL();
            fabricanteDLL = new FabricanteDLL();
        }

        private void btnAnadirProd_Click(object sender, EventArgs e)
        {
            FormAnadir formAnadir = new FormAnadir(this);
            formAnadir.ShowDialog();
        }

        private void btnMostrarProd_Click(object sender, EventArgs e)
        {
            dgTiendaVista.DataSource = productoDLL.getProductos().Tables[0];
        }

        private void btnEliminarFab_Click(object sender, EventArgs e)
        {
            FormEliminar formEliminar = new FormEliminar(this);
            formEliminar.ShowDialog();
        }

        private void btnMostrarFab_Click(object sender, EventArgs e)
        {
            dgTiendaVista.DataSource = fabricanteDLL.getFabricantes().Tables[0];
        }

        private void btnMostrarProdFab_Click(object sender, EventArgs e)
        {
            FormFab formFab = new FormFab(this);
            formFab.ShowDialog();
        }

        private void btnVentaMayMen_Click(object sender, EventArgs e)
        {
            dgTiendaVista.DataSource = productoDLL.getMayMen().Tables[0];
        }

        private void btnFabSinPrecio_Click(object sender, EventArgs e)
        {
            dgTiendaVista.DataSource = fabricanteDLL.getFabProdSinPrecio().Tables[0];
        }

        private void btnProdOrd_Click(object sender, EventArgs e)
        {
            dgTiendaVista.DataSource = productoDLL.getProductosAsc().Tables[0];
        }
    }
}
