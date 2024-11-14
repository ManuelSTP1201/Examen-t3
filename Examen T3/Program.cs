using Examen_T3;

public class Program
{
    private static Cita[] citas = new Cita[100];
    private static int contadorCitas = 0;

    public static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Crear Cita");
            Console.WriteLine("2. Listar Citas");
            Console.WriteLine("3. Modificar Universidades");
            Console.WriteLine("4. Fin");
            Console.Write("Seleccione una opción: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción no válida, ingrese un número.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    CrearCita();
                    break;
                case 2:
                    CitaUtil.ListarCitas(citas);
                    break;
                case 3:
                    ModificarUniversidades();
                    break;
                case 4:
                    Console.WriteLine("Programa finalizado.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        } while (opcion != 4);
    }

    private static void CrearCita()
    {
        try
        {
            Console.Write("Ingrese el número de la cita: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el código del estudiante: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese la universidad del estudiante: ");
            string universidad = Console.ReadLine();

            Console.Write("Ingrese la enfermedad: ");
            string enfermedad = Console.ReadLine();

            Console.Write("Ingrese el precio de la cita: ");
            double precio = double.Parse(Console.ReadLine());

            citas[contadorCitas++] = CitaUtil.CrearCita(numero, codigo, nombre, universidad, enfermedad, precio);
            Console.WriteLine("Cita creada exitosamente.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Formato de entrada incorrecto. Asegúrese de ingresar valores válidos.");
        }
    }

    private static void ModificarUniversidades()
    {
        Console.Write("Ingrese el texto a buscar en las universidades: ");
        string textoBuscado = Console.ReadLine();

        Console.Write("Ingrese el texto de reemplazo: ");
        string textoReemplazo = Console.ReadLine();

        CitaUtil.ModificarUniversidades(citas, textoBuscado, textoReemplazo);
        Console.WriteLine("Modificación realizada.");
    }
}
