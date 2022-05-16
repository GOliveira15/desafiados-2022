int A, B;
int divisao;
double modularizacao;

Console.Write("Informe um número: ");
A = int.Parse(Console.ReadLine());

Console.Write("Informe outro número: ");
B = int.Parse(Console.ReadLine());

if (B == 0)
{
    Console.WriteLine("\nImpossível dividir por 0");
}
else
{
    divisao = A / B;
    modularizacao = A % B;

    Console.WriteLine("\nO resto da divisão é {0}",modularizacao);
}
