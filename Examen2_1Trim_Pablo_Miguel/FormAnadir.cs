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
    public partial class FormAnadir : Form
    {
        private Form1 frm;
        private FabricanteDLL fabricanteDLL;
        private ProductoDLL productoDLL;
        public FormAnadir(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
            fabricanteDLL = new FabricanteDLL();
            productoDLL = new ProductoDLL();
            cbFabricante.ValueMember = "codigo";
            cbFabricante.DisplayMember = "nombre";
            cbFabricante.DataSource = fabricanteDLL.getFabricantes().Tables[0];
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (productoDLL.anadirProducto(txtNombre.Text.ToString(), Double.Parse(txtPrecio.Text), Int32.Parse(cbFabricante.SelectedValue.ToString())))
            {
                MessageBox.Show("Se ha añadido el producto correctamente");
                frm.dgTienda.DataSource = productoDLL.getProductos().Tables[0];
                this.Close();
            }
            else {
                MessageBox.Show("Algo ha ido mal");
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }
    }
}
