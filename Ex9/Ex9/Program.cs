int A = 724, B = 50;
int divisao;
double modularizacao;

if (B == 0)
{
    Console.WriteLine("Impossível dividir por 0");
}
else
{
    divisao = A / B;
    modularizacao = A % B;

    Console.WriteLine("O resto da divisão é {0}",modularizacao);
}
