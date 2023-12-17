using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadPOO
{
    public class profesor:Facultadmiembro
    {
        private string departamento;
        public profesor(string departamento, string nombre, string apellidos, int id, 
            string Civilestado, string tipo):base(nombre, apellidos,Civilestado, id, tipo) 
        {
            this.departamento = departamento;
        }

        public void cambioDepart(string departamento) 
        {
            this.departamento = departamento;
        }
        public override string ToString()
        {
            return "Departamento " + departamento;
        }
    }
}
