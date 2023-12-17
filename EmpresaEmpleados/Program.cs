using System;

namespace EmpresaEmpleados
{
    class Program
    {
        static void Main(string[] args)
        {
            Trabajadorcito trabajadorcito = new Trabajadorcito(" Juan", " Benitez", " 6632", 19);
            trabajadorcito.ImprimirTrabajador();

            TrabajadorTemp trabajadorTemp = new TrabajadorTemp(16, 26, "Pedro", " Sanchez", " 6890", 20);
            trabajadorTemp.setSueldo(256);
            Console.WriteLine("El sueldo del trabajador temporal es: " + trabajadorTemp.getSueldo());

            FijoTrabajador fijoTrabajador = new FijoTrabajador(16, 500, "Anies", "Benitez", "6963", 35);
            fijoTrabajador.ImprimirFijo();


        
  
        }
    }
}
