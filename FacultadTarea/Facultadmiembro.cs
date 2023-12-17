using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultadPOO
{
    public class Facultadmiembro
    {
        private string nombres, apellidos, Civilestado, tipo;
        private int id;
        
        public Facultadmiembro(string nombre, string apellidos,string Civilestado, int id, string tipo)
        {
           
            this.nombres = nombre;
            this.apellidos = apellidos;
            this.id = id;
            this.Civilestado = Civilestado;
            this.tipo = tipo;
        }

        public void cambioestaCivil(string Civilestado) 
        {
            this.Civilestado = Civilestado;        
        }
        
        public void imprimirMiembro() 
        {
            Console.WriteLine("Nombre: " + nombres
                + "\nApellidos: " + apellidos
                + "\nID: " + id
                + "\nEstado Civil: " + Civilestado
                + "\nTipo: " + tipo);
        }
    }
}
