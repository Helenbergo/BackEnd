using Models;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("Digite o nome do titular");
        string nomeTitular = Console.ReadLine();
        Console.WriteLine($"Bem-vindo ao sistem {nomeTitular}");
        ContaCorrente titular = new ContaCorrente(nomeTitular);
        titular.titular = nomeTitular;
     

        string opcao = "";

        do
        {
            Console.WriteLine("-------- M E N U --------");
            Console.WriteLine("1 - Para consultar saldo");
            Console.WriteLine("2 - Para depositar");
            Console.WriteLine("3 - Para sacar");
            Console.WriteLine("0 - Para fechar sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, volte sempre!!!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    titular.ConsultarSaldo();
                    break;
                case "2":
                    Console.WriteLine("Informe o valor a ser depositado:");
                    decimal valor = decimal.Parse(Console.ReadLine());
                    titular.Depositar(valor);
                    break;
                case "3":
                    Console.WriteLine("Informe o valor a ser sacado:");
                    titular.Sacar(decimal.Parse(Console.ReadLine()));
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        } while (opcao != "0");


    }
}