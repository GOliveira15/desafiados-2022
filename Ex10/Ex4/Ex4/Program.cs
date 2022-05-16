int c;
int f;

Console.Write("Informe a temperatura em ºC: ");
c = int.Parse(Console.ReadLine());

f = ((9 * c) + 160) / 5;

Console.WriteLine("\nA conversão da temperatura em graus Celsius para Fahrenheit é {0}",f);
