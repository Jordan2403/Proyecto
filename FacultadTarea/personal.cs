using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadPOO
{
    public class personal:Facultadmiembro
    {
        private string seccion;
        public personal(string seccion, string nombre, string apellidos, int id, 
            string Civilestado, string tipo):base(nombre, apellidos,Civilestado,id, tipo) 
        {
            this.seccion = seccion;
        }

        public void Seccioncambio(string seccion) 
        {
            this.seccion = seccion;
        }
        public override string ToString()
        {
            return "Seccion " + seccion;
        }
    }
}
