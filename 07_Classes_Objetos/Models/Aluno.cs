//o namespace é um nome em que usaremos para fazer referência quando usarmos
namespace Sesi.Model
{
    //Declarando a classe Aluno
    public class Aluno
    {
        //Declarando os atributos (propriedades) da classe Aluno
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }

        //Declarando um atributo privado
        private int nrFaltas { get; set; }


        //criando um método
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos e estudo na turma do {turma}, e tenho {nrFaltas} faltas.");
        }

        public void AdicionarFaltas(int nr)
        {
            Console.WriteLine($"O aluno {nome} faltou hoje e somou {nrFaltas} faltas.");
            nrFaltas = nrFaltas + nr;
        }
        public void ResumoFaltas()
        {
            Console.WriteLine($"O aluno {nome} tem um total de {nrFaltas} faltas.");
        }

    }
}