/*Escreva um programa que receba uma placa e informe qual é o dia de rodízio no transito de SP 
(Considerando final 1 e 2 na segunda, 3 e 4 na terça, 5 e 6 na quarta, 7 e 8 na quinta, 9 e 0 na sexta)
Ex.: ABC1B34 Ler apenas o último caractere no caso 4*/

Console.WriteLine("Digite sua placa:");
string placa = Console.ReadLine();

string final = placa.Substring(placa.Length -1, 1);

Console.WriteLine(final);

if (final == "1" || final == "2") {
    Console.WriteLine("Voçê não poder sair em São Paulo na segunda-feira");
} else if (final =="3" || final =="4") {
    Console.WriteLine("Você não pode sair em São Paulo na terça-feira");
} else if (final =="4" || final =="5") {
    Console.WriteLine("Você não pode sair em São Paulo na quarta-feira");
} else if (final =="3" || final =="4") {
    Console.WriteLine("Você não pode sair em São Paulo na quinta-feira");
} else if (final =="5" || final =="6") {
    Console.WriteLine("Você não pode sair em São Paulo na sexta-feira");
}