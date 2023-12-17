using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nombre: Jean Pier Casquete
//Curso: 3er Nivel ''C''
//Materia: POO
//Fecha: 19/11/2021

namespace EmpresaEmpleados

{
    public class FijoTrabajador: Trabajadorcito
    {
        private double sueldo, BaseAnual;
        private int servicioaños;
        public FijoTrabajador(int servicioaños, double baseAnual, string nombres, string apellidos, string departamento, 
            int edad):base(nombres, apellidos, departamento, edad) 
        {
            this.servicioaños=servicioaños;
            this.BaseAnual = BaseAnual;
        }

        public void setSueldo(double sueldo, int servicioaños, double BaseAnual)
        {
            this.sueldo = sueldo;
            this.servicioaños = servicioaños;
            this.BaseAnual = BaseAnual;
            sueldo = sueldo + (servicioaños * BaseAnual);
        }
        public double getSueldo() 
        {
            return sueldo;
        } 
          public void ImprimirFijo()
        {
            Console.WriteLine("Años de Servicio: " + servicioaños
                + "\nBase Anual" + BaseAnual
                + "\nSueldo Total " + getSueldo());

        }
    }
}
