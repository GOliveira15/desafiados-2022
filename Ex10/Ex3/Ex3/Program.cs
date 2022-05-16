float totalVenda;
float valorComissao;

Console.Write("Informe o valor total das vendas do mês: ");
totalVenda = float.Parse(Console.ReadLine());

Console.Write("Informe o valor da comissão: ");
valorComissao = float.Parse(Console.ReadLine());

double valorComissaoF = valorComissao / 100;
double totalComissao = totalVenda * valorComissaoF;

Console.WriteLine("\nEle receberá de comissão: {0}",totalComissao);