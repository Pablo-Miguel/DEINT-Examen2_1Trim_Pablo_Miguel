using Ejercicio1_Examen.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Ejercicio1_Examen
{
    public partial class Form1 : Form
    {
        
        private List<string> listaDir;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool entrar = false;
            string extension = "";
            if (!txtDir.Text.Equals(""))
            {
                if (Directory.Exists(txtDir.Text))
                {
                    if (!txtExtension.Text.Equals("")) {
                        if (Regex.IsMatch(txtExtension.Text.ToString(), @"^\.{1}[a-zA-Z]+$")) {
                            extension = txtExtension.Text;
                            entrar = true;
                        } else
                        {
                            MessageBox.Show("La extensión debe comenzar por punto y luego letras");
                            txtDir.Clear();
                            txtExtension.Clear();
                            rbAscendente.Checked = true;
                            rbDescendente.Checked = false;
                            listaDir = null;
                            lista.Items.Clear();
                        }                        
                    } else {
                        extension = "";
                        entrar = true;
                    }
                }
                else
                {
                    MessageBox.Show("El direcctorio no existe");
                    txtDir.Clear();
                    txtExtension.Clear();
                    rbAscendente.Checked = true;
                    rbDescendente.Checked = false;
                    listaDir = null;
                    lista.Items.Clear();
                }
            }
            else {
                MessageBox.Show("El direcctorio no puede estar vacío");
                txtDir.Clear();
                txtExtension.Clear();
                rbAscendente.Checked = true;
                rbDescendente.Checked = false;
                listaDir = null;
                lista.Items.Clear();
            }

            if (entrar) {
                listaDir = Directory.EnumerateFiles(txtDir.Text, $"*{extension}", SearchOption.AllDirectories).ToList();
                if (rbAscendente.Checked) {
                    ascendente();
                } else if (rbDescendente.Checked) {
                    descendente();
                }
            }

        }

        private void ascendente() {

            if (listaDir != null) {
                lista.Items.Clear();
                listaDir.Sort();
                foreach (string fichero in listaDir)
                {
                    lista.Items.Add(fichero);
                }
            }

        }

        private void descendente()
        {

            if (listaDir != null)
            {
                lista.Items.Clear();
                listaDir.Sort();
                listaDir.Reverse();
                foreach (string fichero in listaDir)
                {
                    lista.Items.Add(fichero);
                }
            }

        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ascendente();
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            descendente();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            if (listaDir != null && !txtDir.Text.Equals(""))
            {
                Directorio listaFich = new Directorio();
                listaFich.directorio = txtDir.Text;
                listaFich.listaFicheros = listaDir;
                XmlSerializer serializer = new XmlSerializer(typeof(Directorio));
                using (var stream = new FileStream("ficheros.xml", FileMode.Create))
                {
                    serializer.Serialize(stream, listaFich);
                }
                MessageBox.Show("Se ha serializado correctamente");
            }
            else {
                MessageBox.Show("Busque un direcctorio con una extensión para serializar la lista");
                txtDir.Clear();
                txtExtension.Clear();
                rbAscendente.Checked = true;
                rbDescendente.Checked = false;
                listaDir = null;
                lista.Items.Clear();
            }
        }
    }
}
