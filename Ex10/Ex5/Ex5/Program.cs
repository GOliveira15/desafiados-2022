int f;
int c;

Console.Write("Informe a temperatura em ºF: ");
f = int.Parse(Console.ReadLine());

c = ((f - 32) * 5) / 9;

Console.WriteLine("A conversão da temperatura em Fahrenheit para graus Celsius é {0}", c);

