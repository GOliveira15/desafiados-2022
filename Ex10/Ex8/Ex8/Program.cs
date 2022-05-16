int A, B;

Console.Write("Informe um número: ");
A = int.Parse(Console.ReadLine());

Console.Write("Informe outro número: ");
B = int.Parse(Console.ReadLine());

int subtracao = A - B;

if(subtracao < 0)
{
    Console.WriteLine("\nA subtração resulta em {0}, sendo um valor NEGATIVO", subtracao);
}
else
{
    Console.WriteLine("\nA subtração resulta em {0}, sendo um valor POSITIVO", subtracao);
}
