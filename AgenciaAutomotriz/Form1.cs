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
    public partial class Form1 : Form
    {
        ManejadorPermisos mp;

        public Form1()
        {
            InitializeComponent();
            mp = new ManejadorPermisos();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nivelPermiso = mp.ObtenerNivelPermiso(txtNic.Text, txtContrasena.Text);

            if (!nivelPermiso.Equals("Error"))
            {
                this.Hide();
                Administrador adminForm = new Administrador(nivelPermiso);
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Información Incorrecta");
            }
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
