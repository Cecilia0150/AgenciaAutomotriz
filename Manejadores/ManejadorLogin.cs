using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejadores
{
    public class ManejadorLogin
    {
        Base b = new Base("localhost", "root", "", "agenciaautomotriz");

        public string Validar(TextBox Nic, TextBox Contrasena)
        {
            try
            {
                DataSet ds = b.Consultar($"call p_Validar('{Nic.Text}','{Contrasena.Text}')", "permisos");
                DataTable dt = ds.Tables[0];
                if (dt.Rows[0]["rs"].ToString().Equals("C0rr3Ct0"))
                {
                    return dt.Rows[0]["Nivel"].ToString();
                }
                else
                {
                    return "Error";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al validar: " + ex.Message);
                return "Error";
            }
        }
        public static string Sha1(string texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}

