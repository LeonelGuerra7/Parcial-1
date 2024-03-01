string cadena = "Hola soy Leonel";

List<string> listaDeCadenas = new List<string> { cadena };
if (((ICollection<String>)listaDeCadenas).IsReadOnly)
{
    Console.WriteLine($"La lista es solo lectura");
}
else
{
    Console.WriteLine($"La lista no es solo lectura");
}

cadena = cadena.Trim();
int longitud = cadena.Length;
string mayusculas = cadena.ToUpper();
string minusculas = cadena.ToLower();

Console.WriteLine($"La Longitud de la cadena \"{cadena}\" es: {longitud}");
Console.WriteLine($"La cadena \"{cadena}\" en mayúsculas es: {mayusculas}");
Console.WriteLine($"La cadena \"{cadena}\" en minúsculas es: {minusculas}");

char Buscar = 'l';
int primero = cadena.IndexOf(Buscar);
int ultimo = cadena.LastIndexOf(Buscar);

Console.WriteLine($"El primer caracter 'l' está en la posición: {primero}");
Console.WriteLine($"El último caracter 'l' está en la posición: {ultimo}");

if (cadena.StartsWith("Hola"))
{
    Console.WriteLine($"La cadena comienza con 'Hola'.");
}
else
{
    Console.WriteLine($"La cadena no comienza con 'Hola'.");
}

if (cadena.EndsWith("Leonel"))
{
    Console.WriteLine($"La cadena termina con 'Leonel'.");
}
else
{
    Console.WriteLine($"La cadena no termina con 'Leonel'.");
}

if (primero !=-1)
{
    string subCadena = cadena.Substring(primero, Math.Min(20, longitud - primero));
    Console.WriteLine($" Subcadena a partir de la primera ocurrencia: {subCadena}");
    string cadenaRemplazo = cadena.Replace(subCadena, "Soy Futbolista");
    Console.WriteLine($"Cadena con Remplazo es: {cadenaRemplazo}");
}
else
{
    Console.WriteLine($" '{Buscar}' no se encuentra en la cadena original");
}

string CadenaNueva = "Estudio Ingeniería en Sistemas";
string CadenasUnidas = cadena + " " + CadenaNueva;
Console.WriteLine($"Cadena Concatenada: {CadenasUnidas}");


















