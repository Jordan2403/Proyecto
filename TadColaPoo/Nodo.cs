using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadColaPoo
{
    class Nodo
    {
        private int dato;
        private Nodo siguiente;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
       

    }
}
