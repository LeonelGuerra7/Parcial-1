Console.Write("Ingrese el primer número entero: ");
if (!int.TryParse(Console.ReadLine(), out int n1))
{
    Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
    return;
}

Console.Write("Ingrese el segundo número entero: ");
if (!int.TryParse(Console.ReadLine(), out int n2))
{
    Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
    return;
}

Console.Write("Ingrese el operador matemático (+, -, *, /): ");
char operador = Console.ReadKey().KeyChar;
Console.WriteLine();

switch (operador)
{
    case '+':
        Console.WriteLine($"Resultado: {n1} + {n2} = {n1 + n2}");
        break;
    case '-':
        Console.WriteLine($"Resultado: {n1} - {n2} = {n1 - n2}");
        break;
    case '*':
        Console.WriteLine($"Resultado: {n1} * {n2} = {n1 * n2}");
        break;
    case '/':
        if (n2 != 0)
        {
            Console.WriteLine($"Resultado: {n1} / {n2} = {((double)n1 / n2)}");
        }
        else
        {
            Console.WriteLine("No es posible dividir por cero.");
        }
        break;
    default:
        Console.WriteLine("Operador no válido. Por favor, ingrese un operador válido.");
        break;
}

