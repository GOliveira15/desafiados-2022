double media;

Console.Write("Informe a média do aluno: ");
media = double.Parse(Console.ReadLine());

var status = media > 7 ? "Aprovado" : "Reprovado";

//var status = (media >= 8 ? "Aprovado" : ((media < 8 && media >= 5) ? "Recuperação" : "Reprovado"));

Console.Write(status);