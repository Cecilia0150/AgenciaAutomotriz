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
    public partial class BuscarHerramientas : Form
    {
        int fila = 0, columna = 0;
        public static int codigoherramienta = 0;
        public static string Nombre = "", Marca = "", Descripcion = "", Medida="";
        ManejadorHerramientas mh;
        public BuscarHerramientas()
        {
            InitializeComponent();
            mh = new ManejadorHerramientas();
        }
        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Close();
            AgregarHerramientas ah = new AgregarHerramientas();
            ah.Show();
        }

        private void dtgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 4:
                    {
                        codigoherramienta = int.Parse(dtgvHerramientas.Rows[fila].Cells[0].Value.ToString());
                        mh.Borrar(codigoherramienta, dtgvHerramientas.Rows[fila].Cells[1].Value.ToString());
                        dtgvHerramientas.Visible = false;
                        txtBuscar.Focus();
                    }
                    break;

                case 5:
                    {
                        codigoherramienta = int.Parse(dtgvHerramientas.Rows[fila].Cells[0].Value.ToString());
                        Nombre = dtgvHerramientas.Rows[fila].Cells[1].Value.ToString();
                        Medida = dtgvHerramientas.Rows[fila].Cells[2].Value.ToString();
                        Marca = dtgvHerramientas.Rows[fila].Cells[3].Value.ToString();
                        Descripcion = dtgvHerramientas.Rows[fila].Cells[4].Value.ToString();

                        AgregarHerramientas ah = new AgregarHerramientas();
                        ah.ShowDialog();
                        Limpiar();
                        txtBuscar.Focus();
                    }
                    break;

                    void Limpiar()
                    {
                        dtgvHerramientas.Visible = false;
                    }
            }
        }

        public void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNic_TextChanged_1(object sender, EventArgs e)
        {
            dtgvHerramientas.Visible = true;
            mh.Mostrar(dtgvHerramientas, txtBuscar.Text);
        }
    }
}
