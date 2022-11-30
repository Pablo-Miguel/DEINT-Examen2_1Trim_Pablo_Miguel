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
    public partial class FormFab : Form
    {
        private Form1 frm;
        private ProductoDLL productoDLL;
        private FabricanteDLL fabricanteDLL;
        public FormFab(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
            productoDLL = new ProductoDLL();
            fabricanteDLL = new FabricanteDLL();
            cbFabricante.ValueMember = "codigo";
            cbFabricante.DisplayMember = "nombre";
            cbFabricante.DataSource = fabricanteDLL.getFabricantes().Tables[0];
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frm.dgTienda.DataSource = productoDLL.getProductosFab(Int32.Parse(cbFabricante.SelectedValue.ToString())).Tables[0];
            this.Close();
        }
    }
}
