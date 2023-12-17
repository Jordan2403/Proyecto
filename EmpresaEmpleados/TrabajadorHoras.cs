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
    public class TrabajadorHoras: Trabajadorcito
    {
        private double sueldo;
        private static double precioHora;
        private int horasTrabajadas;

        public TrabajadorHoras(double precioHora, int horasTrabajadas,string nombres, string apellidos, string departamento, 
            int edad):base(nombres, apellidos, departamento, edad) 
        {
            this.horasTrabajadas = horasTrabajadas;
        }

        public void setSueldo(double sueldo, double precioHora, int horasTrabajadas) 
        {
            this.sueldo = sueldo;
            this.horasTrabajadas = horasTrabajadas;
            sueldo = precioHora * horasTrabajadas;
        }
        public double getSueldo()
        {
            return sueldo;
        }
    }
}
