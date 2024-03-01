Random random = new Random();
int nSecreto = random.Next(1, 100);

Console.WriteLine("¡Bienvenido al juego de adivinar el número secreto!");

int intentos = 0;

while (true)
{
    Console.Write("Ingrese un número entre 1 y 100: ");

    if (!int.TryParse(Console.ReadLine(), out int intentoUsuario) || intentoUsuario < 1 || intentoUsuario > 100)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido entre 1 y 100.");
        continue;
    }

    intentos++;

    if (intentos == nSecreto)
    {
        Console.WriteLine($"¡Felicidades! Adivinaste el número secreto {nSecreto} en {intentos} intentos.");
        break;
    }
    else if (intentoUsuario < nSecreto)
    {
        Console.WriteLine("El número secreto es mayor. ¡Sigue intentando!");
    }
    else
    {
        Console.WriteLine("El número secreto es menor. ¡Sigue intentando!");
    }
}

Console.WriteLine("¡Gracias por jugar!");
