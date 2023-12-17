using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadColaPoo
{
    class Cola
    {
        private Nodo primero = new Nodo();
        private Nodo Ultimo = new Nodo();

       public Cola()
        {
            primero = null;
            Ultimo = null;
        }
        public void InsertarNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.WriteLine("Ingresa el dato que guardara el nuevo nodo");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            if (primero == null)
            {
                primero = Nuevo;
                primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }
            Console.WriteLine("Nodo ingreso corractamente");
        
       }

        public void DesplegarCola()

        {
            Nodo Actual = new Nodo();
            Actual = primero;
            if (primero != null)
            {
                while (Actual != null)
                {
                    Console.WriteLine(" " + Actual.Dato);
                    Actual = Actual.Siguiente;
                }
            }
             else
            {
                Console.WriteLine("La Consola se encuentra vacia");
            }
        } 

    }

}
