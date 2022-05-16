double n1, n2, n3, n4;

Console.Write("Informe a primeira nota: ");
n1 = double.Parse(Console.ReadLine());

Console.Write("Informe a segunda nota: ");
n2 = double.Parse(Console.ReadLine());

Console.Write("Informe a terceira nota: ");
n3 = double.Parse(Console.ReadLine());

Console.Write("Informe a quarta nota: ");
n4 = double.Parse(Console.ReadLine());

double media = (n1 + n2 + n3 + n4) / 4;

if(media > 7)
{
    Console.WriteLine("\nMédia = {0}.\nO aluno foi APROVADO!",media);
}
else
{
    Console.WriteLine("\nMédia = {0}.\nO aluno foi REPROVADO!", media);
}
