using System;
using System.Collections;
using System.Collections.Generic;

namespace TadPilaPOO

{
    class Program
    {
        public static void Main()
        {
            Pila p = new Pila();
            p.InsertarNodo();
            p.InsertarNodo();
            p.InsertarNodo();
            p.InsertarNodo();

            Console.WriteLine("\n La Pila ingreso correctamente");
            p.DesplegarPila();
        }



    }
    
}
