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
    public class ManejadorUsuario
    {
        Base b = new Base("localhost", "root", "", "AgenciaAutomotriz");
        public string Guardar(TextBox Nivel, TextBox Nic, TextBox Contrasena)
        {
            try
            {
                //Cambiar el ultimo null para que de los datos de usuarios
                return b.comando($"insert into Permisos values (null,'{Nivel.Text}', '{Nic.Text}', '{Contrasena.Text}', null)");
            }
            catch (Exception)
            {
                return "Error de valor";
            }
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = b.Consultar($"select * from Permisos where Nic like '%{filtro}%'", "Permisos").Tables[0];
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

        public void Modificar(int idPermiso, TextBox Nivel, TextBox Nic, TextBox Contrasena)
        {
            b.comando($"Update Permisos set Nivel='{Nivel.Text}',Nic='{Nic.Text}', Contrasena='{Contrasena.Text}' where idPermiso={idPermiso}");
            MessageBox.Show("Registro Modificado", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(int idPermiso, string Dato)
        {
            DialogResult rs = MessageBox.Show($"Esta seguro de borrar {Dato}", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                b.comando($"Delete from Permisos where idPermiso={idPermiso}");
                MessageBox.Show("Registro Eliminado", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

