using System;

namespace TadColaPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cola c = new Cola();
            c.InsertarNodo();
            c.InsertarNodo();
            c.InsertarNodo();
            c.InsertarNodo();
            Console.WriteLine("\n Cola Ingresada\n ");
            c.DesplegarCola();


        }
    }
}
