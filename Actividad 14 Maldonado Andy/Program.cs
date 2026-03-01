// Simular un menú que se repita hasta que el usuario elija salir.

int opcion = 0;
while (opcion != 3)
{
    Console.WriteLine("Elegir: 1 para saludar, 2 para despedirse o 3 para salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Hola, saludos estimado");
                break;
        case 2:
            Console.WriteLine("Adios, nos vemos pronto");
            break;
        case 3:
        default:
            Console.WriteLine("saliendo...");
            break;
    }
}
