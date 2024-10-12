using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorProductos
    {
        Base b = new Base("localhost", "root", "", "AgenciaAutomotriz");
        public string Guardar(TextBox CodigoBarras, TextBox Nombre, TextBox Descripcion, TextBox Marca)
        {
            try
            {

                return b.comando($"insert into Productos values ('{int.Parse(CodigoBarras.Text)}','{Nombre.Text}','{Descripcion.Text}', '{Marca.Text}')");
            }
            catch (Exception)
            {
                return "Error de valor";
            }
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar($"select * from Productos where Nombre like '%{filtro}%'", "Productos").Tables[0];
            tabla.Columns.Insert(4, Boton("Eliminar", Color.Blue));
            tabla.Columns.Insert(5, Boton("Modificar", Color.Blue));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
        DataGridViewButtonColumn Boton(string t, Color f)
        {
            DataGridViewButtonColumn x = new DataGridViewButtonColumn();
            x.Text = t;
            x.UseColumnTextForButtonValue = true;
            x.FlatStyle = FlatStyle.Popup;
            x.DefaultCellStyle.ForeColor = Color.White;
            x.DefaultCellStyle.BackColor = f;
            return x;
        }

        public void Modificar(int CodigoBarras, TextBox Nombre, TextBox Descripcion, TextBox Marca )
        {
            b.comando($"Update Productos set Nombre='{Nombre.Text}',Medida='{Descripcion.Text}', Marca='{Marca.Text}' where CodigoBarras={CodigoBarras}");
            MessageBox.Show("Registro Modificado", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(int CodigoBarras, string Dato)
        {
            DialogResult rs = MessageBox.Show($"Esta seguro de borrar {Dato}", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.comando($"Delete from Productos where CodigoBarras={CodigoBarras}");
                MessageBox.Show("Registro Eliminado", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

}
