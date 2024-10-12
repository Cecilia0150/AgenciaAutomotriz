using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorHerramientas
    {
        Base b = new Base("localhost", "root", "", "AgenciaAutomotriz");
        public string Guardar( TextBox CodigoHerramienta, TextBox Nombre, TextBox Medida, TextBox Marca, TextBox Descripcion)
        {
            try
            {
                
                return b.comando($"insert into Herramientas values ('{int.Parse(CodigoHerramienta.Text)}','{Nombre.Text}', '{Medida.Text}', '{Marca.Text}','{Descripcion.Text}')");
            }
            catch (Exception)
            {
                return "Error de valor";
            }
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar($"select * from Herramientas where Nombre like '%{filtro}%'", "Herramientas").Tables[0];
            tabla.Columns.Insert(5, Boton("Eliminar", Color.Blue));
            tabla.Columns.Insert(6, Boton("Modificar", Color.Blue));
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

        public void Modificar(int CodigoHerramienta, TextBox Nombre, TextBox Medida, TextBox Marca, TextBox Descripcion)
        {
            b.comando($"Update Herramientas set Nombre='{Nombre.Text}',Medida='{Medida.Text}', Marca='{Marca.Text}', Descripcion='{Descripcion.Text}' where CodigoHerramienta={CodigoHerramienta}");
            MessageBox.Show("Registro Modificado", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(int CodigoHerramienta, string Dato)
        {
            DialogResult rs = MessageBox.Show($"Esta seguro de borrar {Dato}", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.comando($"Delete from Herramientas where CodigoHerramienta={CodigoHerramienta}");
                MessageBox.Show("Registro Eliminado", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

