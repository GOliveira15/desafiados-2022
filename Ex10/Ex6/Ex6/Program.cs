double h;

Console.Write("Informe a altura: ");
h = double.Parse(Console.ReadLine());

double pesoIdeal = (72.7 * h) - 58;

Console.WriteLine("\nO peso ideal para essa altura é: {0}", pesoIdeal);
