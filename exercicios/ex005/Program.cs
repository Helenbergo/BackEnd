class Program
{
    public static void Main()
    {
        ListaChurrasco();
        SonhosDeConsumo();
    }

    public static void ListaChurrasco()
    {
        string[] produtos = new string[6];
        for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine("Informe o produto:");
            string produto = Console.ReadLine();
            produtos[i] = produto;
        }
        Array.Sort(produtos);
        /*for (int i = 0; i < produtos.Length; i++)
        {
            Console.WriteLine(produtos[i]);
        }*/
        foreach (string item in produtos)//Utilizando foreach
        {
            Console.WriteLine($"{item}");
        }
    }

    public static void SonhosDeConsumo()
    {
        string[] listaSonhos = new string[3];
        int[] valorSonhos = new int[3];
        int soma = 0;

        for (int i = 0; i < listaSonhos.Length; i++)
        {
            Console.Write("Informeo sonho:");
            string sonho =  Console.ReadLine();
            listaSonhos[i] = sonho;

            Console.WriteLine("Informe o valor:");
            int valor = Console.ReadLine();
            valorSonhos[i] = valor;
        }

        foreach (int item in listaSonhos)
        {
            soma += item;
            Console.WriteLine ($"Seus sonhos custarão R$ {soma}");
        }
    }
}