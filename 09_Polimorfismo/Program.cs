//Classe pai que será herdada - SuperClasse
class Animal
{
    public string cor { get; set; }
    public virtual void EmitirSom()
    {
        Console.WriteLine($"Animal da cor {cor} fazendo algum som");
    }
}

//Classe filha que herdará da classe Animal
class Cachorro : Animal
{
    //Sobrescrevendo o método emitir som
    public override void EmitirSom()
    {
        Console.WriteLine($"Cachorro da cor {cor} está latindo");
    }
}

class Gato : Animal 
{
    public override void EmitirSom()
    {
        Console.WriteLine($"Gato da cor {cor} está miando!");
    }

    public void Ronronar()
    {
        Console.WriteLine("O gato está ronronando!");
    }
}

class Program
{
    public static void Main()
    {
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "Preto";
        animalGenerico.EmitirSom();
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "Caramelo";
        meuCachorro.EmitirSom();
        //meuCachorro.Ronronar(); //Não posso chamar este método pois não existe nessa classe
        Gato meuGato = new Gato();
        meuGato.cor = "Cinza";
        meuGato.EmitirSom();
    }
}