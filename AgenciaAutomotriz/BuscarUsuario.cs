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
    public partial class BuscarUsuario : Form
    {
        ManejadorUsuario mu;
        int fila = 0, columna = 0;
        public static int idPermiso = 0;
        public static string Nic = "", Contrasena = "", Nivel = "";

        public void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Close();
            AgregarUsuario au = new AgregarUsuario();
            au.Show();
        }

      

        public void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void BtnAgregarUsuario_Click_1(object sender, EventArgs e)
        {
            AgregarUsuario ag = new AgregarUsuario();
            ag.Show();
        }

        private void txtNic_TextChanged(object sender, EventArgs e)
        {
            dtgvUsuarios.Visible = true;
            mu.Mostrar(dtgvUsuarios, txtNic.Text);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 5:
                    {
                        idPermiso = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                        mu.Borrar(idPermiso, dtgvUsuarios.Rows[fila].Cells[1].Value.ToString());
                        dtgvUsuarios.Visible = false;
                        txtNic.Focus();
                    }
                    break;

                case 6:
                    {
                        idPermiso = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                        Nivel = dtgvUsuarios.Rows[fila].Cells[1].Value.ToString();
                        Nic = dtgvUsuarios.Rows[fila].Cells[2].Value.ToString();
                        Contrasena = dtgvUsuarios.Rows[fila].Cells[3].Value.ToString();
                        AgregarUsuario dm = new AgregarUsuario();
                        dm.ShowDialog();
                        Limpiar();
                        txtNic.Focus();
                    }
                    break;
            }
        }

 
        void Limpiar()
        {
            dtgvUsuarios.Visible = false;
        }




        public BuscarUsuario()
        {
            InitializeComponent();
            mu = new ManejadorUsuario();

        }


    }
}
