using System.Text;

// Operador +
string cadena1 = "Hola soy Leonel.";
string cadena2 = "Soy Futbolista";
string resultado1 = cadena1 + " " + cadena2;
Console.WriteLine(resultado1);

// Operador .Concat
string cadena3 = "Hola soy Leonel.";
string cadena4 = "Soy Futbolista";
string resultado2 = string.Concat(cadena3, " ", cadena4);

//Interpolación de Cadenas
string cadena5 = "Hola soy Leonel.";
string cadena6 = "Soy Futbolista";
string resultado3 = $"{cadena5}{" "}{cadena6}";

//Método .Join
string[] cadena7 = { "Hola soy Leonel.", " ", "Soy Futbolista" };
string resultado4 = string.Join(" ", cadena7);

StringBuilder sb = new StringBuilder();
sb.Append("Hola");
sb.Append(" ");
sb.Append("soy");
sb.Append(" ");
sb.Append("Leonel");
string resultado = sb.ToString();

//Al momento de imprimir las cadenas solo sale 1, porque como expliqué en el video: 
//Estas se almacenan en una sola instancia.













