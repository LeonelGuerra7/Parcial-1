int numero;

do
{
    Console.Write("Ingrese un número entero positivo (Click a 0 para salir): ");
    string input = Console.ReadLine();

    if (!int.TryParse(input, out numero))
    {
        Console.WriteLine("Por favor, ingrese un número entero válido.");
        continue;
    }

    if (numero <= 0)
    {
        if (numero < 0)
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo.");
        }
        else
        {
            Console.WriteLine("Saliendo del programa.");
        }
    }
    else
    {
        MostrarMenu(numero);
    }

    if (numero != 0)
    {
        Console.WriteLine("Presione Enter para continuar...");
        Console.ReadLine();
    }

} while (numero != 0);
    
    static void MostrarMenu(int numero)
{
    int opcion;

    do
    {
        Console.WriteLine("\nMenú:");
        Console.WriteLine("1. Calcular el factorial del número.");
        Console.WriteLine("2. Calcular la raíz cuadrada del número.");
        Console.WriteLine("3. Salir del programa.");
        Console.Write("Seleccione una opción: ");

        if (!int.TryParse(Console.ReadLine(), out opcion))
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
            continue;
        }

        switch (opcion)
        {
            case 1:
                Console.WriteLine($"El factorial de {numero} es: {CalcularFactorial(numero)}");
                break;
            case 2:
                Console.WriteLine($"La raíz cuadrada de {numero} es: {Math.Sqrt(numero)}");
                break;
            case 3:
                Console.WriteLine("Saliendo del menú.");
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                break;
        }

    } while (opcion != 3);
}

static long CalcularFactorial(int n)
{
    if (n == 0 || n == 1)
    {
        return 1;
    }
    else
    {
        return n * CalcularFactorial(n - 1);
    }
}
