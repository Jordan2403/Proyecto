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
    public class TrabajadorTemp:Trabajadorcito
    {
        private double sueldo;
        private double entrada, salida;

        public TrabajadorTemp(Double entrada, Double salida, string nombres, string apellidos, string departamento, 
            int edad):base(nombres, apellidos, departamento, edad) 
        {
            this.entrada = entrada;
            this.salida = salida;
        }

        public void setSueldo(double sueldo)
        {
            this.sueldo = sueldo;
        }
        
        public double getSueldo()
        {
            return sueldo;
        }
    }
}
