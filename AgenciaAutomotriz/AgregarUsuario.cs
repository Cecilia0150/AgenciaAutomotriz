using Manejadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaAutomotriz
{
    public partial class AgregarUsuario : Form
    {
        ManejadorUsuario mu;
        public AgregarUsuario()
        {
            InitializeComponent();
            mu = new ManejadorUsuario();
            if (BuscarUsuario.idPermiso > 0)
            {
                txtNivel.Text = BuscarUsuario.Nivel.ToString();
                txtNic.Text = BuscarUsuario.Nic.ToString();
                txtContrasena.Text = BuscarUsuario.Contrasena.ToString();

            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (BuscarUsuario.idPermiso > 0)
            {
                if (string.IsNullOrEmpty(txtNivel.Text) || string.IsNullOrEmpty(txtNic.Text) || string.IsNullOrEmpty(txtContrasena.Text))
                {
                    MessageBox.Show("Completa todos los datos", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    mu.Modificar(BuscarUsuario.idPermiso, txtNivel, txtNic, txtContrasena);
                    Close();
                    BuscarUsuario bu = new BuscarUsuario();
                    bu.Show();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtNivel.Text) || string.IsNullOrEmpty(txtNic.Text) || string.IsNullOrEmpty(txtContrasena.Text))
                {
                    MessageBox.Show("Complete todos los datos");

                }
                else
                {
                    MessageBox.Show(mu.Guardar(txtNivel, txtNic, txtContrasena), "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

