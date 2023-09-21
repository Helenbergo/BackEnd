using Models;

public class Program
{
    public static void Main()
    {
        //Criar um objeto da classe Pessoa
        //var pessoa1 = new Pessoa()
        /*
        //Instanciando objeto sem método construtor 
        Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Adalberto";
        pessoa1.idade = 16;

        //Alternativa de um objeto instanciando sem construtor
        Pessoa pessoa1 = new Pessoa {
            nome = "Douglas",
            idade = 28
        }
        */

        //Instanciando um objeto com o método construtor
        Pessoa pessoa1 = new Pessoa("Alberto Roberto", 16);

        //Chamando método Cantar da classe Pessoa
        pessoa1.Cantar();

        Pessoa pessoa2 = new Pessoa("Helen", 16);
        pessoa2.Dormir();

        Pessoa pessoa3 = new Pessoa("Gabi", 27);
        pessoa3.Estudar();
    }
}