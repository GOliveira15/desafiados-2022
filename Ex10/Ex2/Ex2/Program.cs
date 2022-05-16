double cotacaoEuro;
float valorEuro;

Console.Write("Informe a cotação atual do Euro: ");
cotacaoEuro = double.Parse(Console.ReadLine());

Console.Write("Informe o valor da compra em Euros a ser convertida: ");
valorEuro= float.Parse(Console.ReadLine());

double conversaoReal = valorEuro * cotacaoEuro;

Console.WriteLine("\nA compra de {0} em Euros covertida para real é igual a {1}", valorEuro, conversaoReal);

