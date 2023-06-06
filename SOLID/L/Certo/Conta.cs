namespace SOLID.L.Certo
{
    public class Conta
    {
        public Conta(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public virtual void Saque()
        {
            Console.WriteLine("Saque na classe Base Conta");
        }
    }
}
