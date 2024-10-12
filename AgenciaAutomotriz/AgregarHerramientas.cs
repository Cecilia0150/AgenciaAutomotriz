using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores;

namespace AgenciaAutomotriz
{
    public partial class AgregarHerramientas : Form
    {
        ManejadorHerramientas mh;
        public AgregarHerramientas()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
            if (BuscarHerramientas.codigoherramienta > 0)
            {
                txtCodigo.Text =BuscarHerramientas.codigoherramienta.ToString();
                txtNombre.Text = BuscarHerramientas.Nombre.ToString();
                txtMedida.Text = BuscarHerramientas.Medida.ToString();
                txtMarca.Text = BuscarHerramientas.Marca.ToString();
                txtDescripcion.Text = BuscarHerramientas.Descripcion.ToString();

            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (BuscarHerramientas.codigoherramienta > 0)
            {
                if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtMedida.Text) || string.IsNullOrEmpty(txtMarca.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Completa todos los datos", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mh.Modificar(BuscarHerramientas.codigoherramienta, txtNombre, txtMedida, txtMarca, txtDescripcion);
                    Close();
                    BuscarHerramientas bh = new BuscarHerramientas();
                    bh.Show();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtMedida.Text) || string.IsNullOrEmpty(txtMarca.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Complete todos los datos");

                }
                else
                {
                    MessageBox.Show(mh.Guardar(txtCodigo,txtNombre, txtMedida, txtMarca, txtDescripcion), "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
