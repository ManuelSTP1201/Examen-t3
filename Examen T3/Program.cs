string opcion;

void MostrarOpciones()
{
    Console.WriteLine("a)*Crear*\n");
    Console.WriteLine("b)-Listar-\n");
    Console.WriteLine("c)-Modificar Masivo-\n");
    Console.WriteLine("d)-Fin-\n");
    Console.WriteLine("Seleccione una opción: ");
}

bool ContinuarProgam=true;
while (ContinuarProgam)
{
    MostrarOpciones();
    opcion=Console.ReadLine();

    switch (opcion)
    {
        case "a":
            Console.WriteLine("\nIngrese su número: ");
            break;
    }
}
