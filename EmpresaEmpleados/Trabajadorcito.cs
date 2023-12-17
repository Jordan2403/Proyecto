using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Nombre: Casquete Rodriguez Jean Pier
//Curso: 3rer Nivel Curso C
//Materia: POO
//Fecha: 19/11/2021
   
namespace EmpresaEmpleados
{
    public class Trabajadorcito
    {
        private string apellidos, nombres, departamento;
        private int edad;

        public Trabajadorcito(string nombres, string apellidos, string departamento, int edad)
        {
            this.edad = edad;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.departamento = departamento;
        }

        public string getNombres()
        { return nombres; }
        public void setNombres(string nombres)
        { this.nombres = nombres; }
        public string getApellidos()
        { return apellidos; }
        public void setApellidos(string apellidos)
        { this.apellidos = apellidos; }
        public string getDepartamento()
        { return departamento; }
        public void setDepartamento(string departamento)
        { this.departamento = departamento; }
        public int getEdad()
        { return edad; }
        public void setEdad(int edad)
        { this.edad = edad; }
        
        public void ImprimirTrabajador()
        {
            Console.WriteLine("Nombre: " + nombres
                + "\nApellidos: " + apellidos
                + "\nEdad: " + edad
                + "\nDepartamento: " + departamento);
            
        }
        
    }
}
