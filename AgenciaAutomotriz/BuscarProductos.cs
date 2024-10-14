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
    public partial class BuscarProductos : Form
    {
        ManejadorProductos mp;
        public BuscarProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
        }
        int fila = 0, columna = 0;
        public static int codigoBarras = 0;
        public static string Nombre = "", Marca = "", Descripcion = "";

        private void txtNic_TextChanged(object sender, EventArgs e)
        {
            dtgvProductos.Visible = true;
            mp.Mostrar(dtgvProductos, txtBuscar.Text);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 4:
                    {
                        codigoBarras = int.Parse(dtgvProductos.Rows[fila].Cells[0].Value.ToString());
                        mp.Borrar(codigoBarras, dtgvProductos.Rows[fila].Cells[1].Value.ToString());
                        dtgvProductos.Visible = false;
                        txtBuscar.Focus();
                    }
                    break;

                case 5:
                    {
                        codigoBarras = int.Parse(dtgvProductos.Rows[fila].Cells[0].Value.ToString());
                        Nombre = dtgvProductos.Rows[fila].Cells[1].Value.ToString();
                        Descripcion = dtgvProductos.Rows[fila].Cells[2].Value.ToString();
                        Marca = dtgvProductos.Rows[fila].Cells[3].Value.ToString();
                       
                        AgregarProductos ap = new AgregarProductos();
                        ap.ShowDialog();
                        Limpiar();
                        txtBuscar.Focus();
                    }
                    break;
            }
        }
        void Limpiar()
        {
            dtgvProductos.Visible = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            AgregarProductos ap = new AgregarProductos();
            ap.Show();
        }   
    }
}
