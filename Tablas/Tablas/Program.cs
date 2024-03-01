Console.Write("Ingrese un número para obtener su tabla de multiplicar: ");
    if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
    return;
        }

        Console.WriteLine($"Tabla de multiplicar del {numero}:");

    for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    

