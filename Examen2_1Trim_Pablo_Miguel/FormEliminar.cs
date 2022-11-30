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
    public partial class FormEliminar : Form
    {
        private Form1 frm;
        private ProductoDLL productoDLL;
        private FabricanteDLL fabricanteDLL;
        public FormEliminar(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
            productoDLL = new ProductoDLL();
            fabricanteDLL = new FabricanteDLL();
            cbFabricante.ValueMember = "codigo";
            cbFabricante.DisplayMember = "nombre";
            cbFabricante.DataSource = fabricanteDLL.getFabricantes().Tables[0];
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (fabricanteDLL.eliminarFab(Int32.Parse(cbFabricante.SelectedValue.ToString())))
            {
                MessageBox.Show("Se ha borrado el fabricante correctamente");
                frm.dgTienda.DataSource = fabricanteDLL.getFabricantes().Tables[0];
                this.Close();
            }
            else
            {
                MessageBox.Show("El fabricante está siendo usado en la DB");
            }
        }

    }
}
