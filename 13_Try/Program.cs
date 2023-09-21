public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o nº {numero}");
        }
        catch (OverflowException)
        {
            Console.WriteLine("O número digitado é maior que o limite aceito");
        }
        //Tratando exceção
        catch (FormatException)
        {
            Console.WriteLine("Digite um número inteiro");
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro genérico: {erro.Message}");
        }
        finally
        {
            Console.WriteLine("No bloco finally o programa entra independentemente de exeção");
        }
    }
}