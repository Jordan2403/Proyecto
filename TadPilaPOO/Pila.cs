using System;
using System.Collections;

namespace TadPilaPOO
{
    class Pila
    {
        private Nodo Primero = new Nodo();

        public Pila()
        {
            Primero = null;

        }
        public void InsertarNodo()
        {
            Nodo Nuevo = new Nodo();
            Console.WriteLine("Ingrese el dato que contendra el nuevo nodo: ");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            Nuevo.Siguiente = Primero;
            Primero = Nuevo;

            Console.WriteLine("\n Nodo Ingresado\n");

        }
        public void DesplegarPila()
        {
            Nodo Actual = new Nodo();
            Actual = Primero;

            if(Primero != null)
            {
                while (Actual !=null)
                {
                    Console.WriteLine(" " + Actual.Dato);
                    Actual = Actual.Siguiente;

                }
            }
            else
            {
                Console.WriteLine("\n La Pila se encuentra vacia\n");
            }
        }

    }

}
