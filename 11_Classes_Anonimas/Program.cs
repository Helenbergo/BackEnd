public class Program 
{
    public static void Main()
    {
        var pessoa1 = new {nome = "João", idade = 20};
        var pessoa2 = new {nome = "Maria", idade = 17};
        Console.WriteLine($"A Pessoa 1 se chama {pessoa1.nome} e a Pessoa 2 {pessoa2.nome}");

        Console.WriteLine("Digite a marca do carro:");
        string marcaDigitada = Console.ReadLine();
        Console.WriteLine("Digite o modelo do carro:");
        string modeloDigitado = Console.ReadLine();
        Console.WriteLine("Digite o ano do carro:");
        string anoDigitado = Console.ReadLine();
        var carro1 = new {
            marca = marcaDigitada,
            modelo = modeloDigitado,
            ano = anoDigitado
        };
        Console.WriteLine($"Marca: {carro1.marca} -> modelo: {carro1.modelo} -> ano: {carro1.ano}");
    }
}