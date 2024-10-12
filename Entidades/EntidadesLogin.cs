using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadesLogin
    {
        public EntidadesLogin(int idPermiso, string nic, string contrasena)
        {
            this.idPermiso = idPermiso;
            Nic = nic;
            Contrasena = contrasena;
        }

        public int idPermiso { get; set; }

        public string Nic { get; set; }

        public string Contrasena { get; set; }
    }
}
