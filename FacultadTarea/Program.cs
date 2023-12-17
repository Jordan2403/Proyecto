using System;

namespace FacultadPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Facultadmiembro facultad = new Facultadmiembro("Juan", "Valdes", "Soltero", 565, "Desconocido");
            facultad.imprimirMiembro();

            estudiante estudiante = new estudiante("3ro B", "Pedro", "Benitez", 653, "Soltero", "**");
            estudiante.nuevoCurso("4to C");
            estudiante.ToString();

            empleado empleado = new empleado(16, 09564, "Gabriel", "Cortez", 699, "Casado", "Desconocido");
            empleado.reasignarDespacho(5632);
            empleado.ToString();

            personal personal = new personal("Auxiliar", "Nine", "Rodriguez", 56, "Viudo", "Desconocido");
            personal.Seccioncambio("Carga");
            personal.ToString();

            profesor profesor = new profesor("Dep. Desarollo", "Enrique", " Castro", 985, " Casado", " Desconocido");
            profesor.cambioDepart("Dep de Aprendisaje");
            profesor.ToString();
        }
    }
}
