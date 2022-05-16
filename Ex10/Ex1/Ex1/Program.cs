float idadeMinima, idadeMaxima;

Console.Write("Informe a idade do aluno mais novo: ");
idadeMinima = float.Parse(Console.ReadLine());

Console.Write("Informe a idade do aluno mais velho: ");
idadeMaxima = float.Parse(Console.ReadLine());

float mediaAluno = (idadeMinima + idadeMaxima) / 2;

Console.WriteLine("\nA idade média entre os alunos é {0}", mediaAluno);
