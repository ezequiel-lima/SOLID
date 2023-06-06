namespace SOLID.S.Certo
{
    public class Empregado : Relatorio
    {
        public Empregado(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }

        public void ExibirNome()
        {
            Console.WriteLine(Nome);
        }
    }
}
