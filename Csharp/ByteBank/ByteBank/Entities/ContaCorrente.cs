

namespace ByteBank.Entities
{
    public class ContaCorrente
    {
        //Propriedades
        public Cliente Titular;//titular é uma variável que armazena dados da classe Cliente.
        public string Conta { get; set; } //Auto propriedade
        public int NumeroAgencia { get; set; }
        public string NomeAgencia { get; set; }

        private double _saldo;

        //Métodos Gettes and Setters

     
        public double Saldo
        {
            get { return _saldo; }
            set 
            {
                if (value < 0)
                {
                    return; //só deixa setar valor se o valor for >0
                }
                _saldo = value; 
            }
        }

        //Métodos
        public bool Sacar(double valor)
        {
            if (Saldo < valor)
            {
                return false;
            }
            else if (valor < 0)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (Saldo < valor)
            {
                return false;
            }
            else if (valor < 0)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                destino.Saldo += valor;
                return true;
            }
        }
        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular :" + Titular.Nome);
            Console.WriteLine("Conta :" + Conta);
            Console.WriteLine("Número Agência :" + NumeroAgencia);
            Console.WriteLine("Nome Agência :" + NomeAgencia);
            Console.WriteLine("Saldo: " + Saldo);
        }

    }
}
