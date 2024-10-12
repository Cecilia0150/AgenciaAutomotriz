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
    public partial class Administrador : Form
    {
        private string nivelPermiso;
        private ManejadorPermisos mp;

        public Administrador(string nivelPermiso)
        {
            InitializeComponent();
            this.nivelPermiso = nivelPermiso;
            mp = new ManejadorPermisos();
            mp.AplicarPermisos(nivelPermiso, this);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            BuscarUsuario bu = new BuscarUsuario();
            bu.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            BuscarProductos bp = new BuscarProductos();
            bp.Show();
        }

        private void btnHerramientas_Click(object sender, EventArgs e)
        {
            BuscarHerramientas bh = new BuscarHerramientas();
            bh.Show();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdminUsers_Click(object sender, EventArgs e)
        {
            AgregarUsuario au = new AgregarUsuario();
            au.Show();
        }

        private void btnAdminProd_Click(object sender, EventArgs e)
        {
            AgregarProductos ap = new AgregarProductos();
            ap.Show();
        }

        private void btnAdminHerramientas_Click(object sender, EventArgs e)
        {
            AgregarHerramientas ah = new AgregarHerramientas();
            ah.Show();
        }
    }
}
