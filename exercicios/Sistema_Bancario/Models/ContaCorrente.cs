namespace Models
{
    public class ContaCorrente
    {
        //Atributo
        public string titular { get; set; }
        private decimal saldo { get; set; }

        //Método construtor
        public ContaCorrente (string titular)
        {
            this.titular = titular;
        }

        //Métodos
        public void ConsultarSaldo()
        {
            Console.WriteLine($"Bem-vindo a sua conta {titular}. Seu saldo atual é: R$ {saldo}");
        }
        public void Depositar(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Você depositou R$ {valor} e seu saldo atual é R$ {saldo}");
        }
        public void Sacar(decimal valor)
        {

            if (valor <= 0 || valor > saldo)
            {
                Console.WriteLine("Não é possível sacar esse valor. Tente novamente");
            } 
            else
            {
                Console.WriteLine($"Seu saldo atual é R$ {saldo - valor}");
            }

            saldo -= valor;
            
        }


    }
}