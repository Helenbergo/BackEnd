using System.Collections.Generic;
using Sesi.Models;
public class Program
{
    public static void Main()
    {
        //Criando uma lista de números inteiros
        List<int> listaNumeros = new List<int>();

        //Adicionando elementos à lista
        listaNumeros.Add(10); //posição [0]
        listaNumeros.Add(20); //posição [1]
        listaNumeros.Add(45); //posição [2]

        //Contando a quantidade de elementos em nossa lista
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números.");

        //Acessando os dados da lista pelo índice
        Console.WriteLine(listaNumeros[1]);

        listaNumeros.Add(6); //posição 3
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} números.");

        Console.WriteLine("--------------------------");

        //Criando uma nova lista de nomes, adicionando alguns nomes e exibindo 
        //a quantidade de nomes que cotém nessa lista

        List<string> listaNomes = new List<string>();

        listaNomes.Add("Helen");
        listaNomes.Add("Gabi");
        listaNomes.Add("Elizabete");

        foreach (string item in listaNomes)
        {
        Console.WriteLine(item);
        }

        Console.WriteLine("--------------------------");

        //Criando uma lista já atribuindo valores
        List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
        numeros.Add(10);
        
        //Interando sobre todos os itens da lista
        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        numeros.Remove(2); //Remove o elemento buscando pelo conteúdo
        numeros.RemoveAt(4); //Remove o elemento pela posição (pelo índice)
        numeros.RemoveRange(2, 2); //Remove o elemento da posição 2 e os próximos 2 elementos

        foreach (int item in numeros)
        {
            Console.WriteLine(item);
        }

        //Criando uma nova list com objetos da classe Aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //Adicionando um novo aluno à listaAlunos
        Aluno novoAluno = new Aluno("Marcos", 15);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("César", 17));
        listaAlunos.Add(new Aluno("Patrícia", 19));
        listaAlunos.Add(new Aluno("Carlos", 20));
        listaAlunos.Add(new Aluno("Alice", 12));

        foreach (Aluno item in listaAlunos)
        {
            Console.WriteLine($"Nome -> {item.nome},  Idade -> {item.idade} anos");
        }

        //Criando uma nova lista, filtrando e ordenando por nome
        //LINQ utilizando Sintaxe de consulta
        var consulta = from aluno in listaAlunos
                        where aluno.idade > 18
                        orderby aluno.nome 
                        select aluno;

        Console.WriteLine("Lista de alunos maiores de 18 anos");

        foreach (var item in consulta)
        {
            Console.WriteLine($"Nome -> {item.nome},  Idade -> {item.idade} anos");
        }

        //LINQ utilizando Sintaxe de método
        var metodo = listaAlunos 
                            .Where(aluno => aluno.idade < 18)
                            .OrderBy(aluno => aluno.nome);

        Console.WriteLine("Lista de alunos menores de 18 anos");
        foreach (var item in metodo)
        {
            Console.WriteLine($"Nome -> {item.nome},  Idade -> {item.idade} anos");
        }
    }
}