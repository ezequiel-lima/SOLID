namespace SOLID.L.Certo
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int id) : base(id)
        {
        }

        public override void Saque()
        {
            Console.WriteLine("Saque na classe derivada Conta Poupança");
        }
    }
}
