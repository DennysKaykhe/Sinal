Console.Clear();

double numero;

Console.Write("Digite um número: ");
numero = Convert.ToDouble(Console.ReadLine());

if (numero > 0)
{
 Console.ForegroundColor = ConsoleColor.Green;
 Console.WriteLine("Positivo");
}
if (numero < 0)
{
Console.ForegroundColor = ConsoleColor.Red;
 Console.WriteLine("Negativo");
}
if (numero == 0)
{
Console.ForegroundColor = ConsoleColor.Green;
 Console.WriteLine("Zero");
}

Console.ResetColor();