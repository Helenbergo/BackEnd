//Exercício Calculando a média de 3 notas de um aluno

//Receber o nome do aluno e armazenar em uma variável do tipo string
Console.WriteLine("Digite o seu nome");
string nomeAluno = Console.ReadLine();

//Receber a nota 1, converter e armazenar em uma variável int
Console.WriteLine("Digite sua nota 1");
int nota1 = int.Parse(Console.ReadLine());

//Receber a nota 2, converter e armazenar em uma variável int
Console.WriteLine("Digite sua nota 2");
int nota2 = int.Parse(Console.ReadLine());

//Receber a nota 3, converter e armazenar em uma variável int
Console.WriteLine("Digite sua nota 3");
int nota3 = int.Parse(Console.ReadLine());

//Declarar uma variável do tipo int, para receber a média das notas
int media = (nota1 + nota2 + nota3) / 3;

//Exibir mensagem se o aluno está aprovado considerado nota acima de 7
if (media < 7)
{
    Console.WriteLine($"{nomeAluno}, sua média foi {media}. Você reprovou de ano.");
}
else 
{
    Console.WriteLine($"{nomeAluno}, sua média foi {media}. Parabéns! Você passou de ano.");
}

/*
string passou = (media < 7) ? "REPROVADO" : "APROVADO";
Console.WriteLine(passou);
*/