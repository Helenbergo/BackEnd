using Sesi.Model;

class Program
{
    public static void Main()
    {
        //criando uma variável aluno1 e instanciando da classe Aluno
        //criando nosso objeto
        var aluno1 = new Aluno();
        aluno1.nome = "Helen";
        aluno1.idade = 16;
        aluno1.turma = "2º EM";

        //Chamando o método da classe Aluno
        aluno1.Apresentar();

        Aluno aluno2 = new Aluno();
        aluno2.nome = "Ricardo";
        aluno2.idade = 33;
        aluno2.turma = "3º EM";

        aluno2.Apresentar();
        aluno2.AdicionarFaltas(10);
        aluno2.Apresentar();

        aluno2.ResumoFaltas();
    }
}