using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorPermisos
    {
        Base b = new Base("localhost", "root", "", "agenciaautomotriz");

        public string ObtenerNivelPermiso(string nic, string contrasena)
        {
            try
            {
                DataSet ds = b.Consultar($"call p_Validar('{nic}','{contrasena}')", "permisos");
                DataTable dt = ds.Tables[0];

                if (dt.Rows[0]["rs"].ToString().Equals("C0rr3Ct0"))
                {
                    return dt.Rows[0]["Nivel"].ToString();
                }
                return "Error";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intenta nuevamente, ERROR " + ex.Message);
                return "Error";
            }
        }

        public void AplicarPermisos(string nivel, Form formulario)
        {
            if (nivel == "CLIENTE")
            {
                MessageBox.Show("No tienes los permisos suficientes para acceder.\nComunicate con un empleado de la tienda si deseas buscar un producto.\n\nAtte. Refaccionaria Patito");
                Application.Exit();
            }
            foreach (Control control in formulario.Controls)
            {
                if (control is Button btn)
                {
                    if (nivel == "ADMINISTRADOR")
                    {
                    }
                    else if (nivel == "EMPLEADO")
                    {
                        if (btn.Name.Contains("Herramientas") || btn.Name.Contains("Eliminar") || btn.Name.Contains("Herramientas"))
                        {
                            btn.Enabled = false;
                        }
                    }
                }
            }
        }
    }
}
