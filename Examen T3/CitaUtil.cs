using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_T3
{
    public static class CitaUtil
    {
        public static Cita CrearCita(int numero, int codigo, string nombre, string universidad, string enfermedad, double precio)
        {
            var estudiante = new Estudiante(codigo, nombre, universidad);
            return new Cita(numero, estudiante, enfermedad, precio);
        }
        public static void ListarCitas(Cita[] citas)
        {
            double sumaPrecios = 0;
            foreach (var cita in citas)
            {
                if (cita != null)
                {
                    Console.WriteLine(cita);
                    sumaPrecios += cita.Precio;
                }
            }
            Console.WriteLine($"\nSuma total de precios: {sumaPrecios:C}");
        }

        public static void ModificarUniversidades(Cita[] citas, string textoBuscado, string textoReemplazo)
        {
            foreach (var cita in citas)
            {
                if (cita != null && cita.Estudiante.Universidad.Contains(textoBuscado))
                {
                    cita.Estudiante.Universidad = cita.Estudiante.Universidad.Replace(textoBuscado, textoReemplazo);
                }
            }
        }
    }
}
