using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadPOO
{
    public class empleado : Facultadmiembro
    {
        private int fechaEntr;
        private short Despachonume;
        public empleado(int fechaEntr, short Despachonume, string nombre, string apellidos, int id, string Civilestado, 
            string tipo) : base(nombre, apellidos,Civilestado,id, tipo) 
        {
            this.fechaEntr = fechaEntr;
            this.Despachonume = Despachonume;
        }

        public void reasignarDespacho(short Despachonume) 
        {
            this.Despachonume = Despachonume;
        }
        public override string ToString()
        {
            return "Fecha de ingreso: " + fechaEntr +
                "\nDespacho: " + Despachonume;
        }
    }
}
