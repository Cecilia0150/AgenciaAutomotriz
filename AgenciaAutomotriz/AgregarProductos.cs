using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace AgenciaAutomotriz
{
    public partial class AgregarProductos : Form
    {
        ManejadorProductos mp;
        public AgregarProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            if (BuscarProductos.codigoBarras > 0)
            {
                txtCodigo.Text = BuscarHerramientas.codigoherramienta.ToString();
                txtNombre.Text = BuscarHerramientas.Nombre.ToString();
                txtDescripcion.Text = BuscarHerramientas.Descripcion.ToString();
                txtMarca.Text = BuscarHerramientas.Marca.ToString();
                
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (BuscarProductos.codigoBarras > 0)
            {
                if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtMarca.Text))  
                {
                    MessageBox.Show("Completa todos los datos", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mp.Modificar(BuscarHerramientas.codigoherramienta, txtNombre, txtDescripcion, txtMarca);
                    Close();
                    BuscarHerramientas bh = new BuscarHerramientas();
                    bh.Show();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text)|| string.IsNullOrEmpty(txtMarca.Text)) 
                {
                    MessageBox.Show("Complete todos los datos");

                }
                else
                {
                    MessageBox.Show(mp.Guardar(txtCodigo, txtNombre, txtDescripcion, txtMarca), "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            Close();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

