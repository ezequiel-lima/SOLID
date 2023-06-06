namespace SOLID.S.Errado
{
    public class Empregado
    {
        public Empregado(string nome)
        {
            Nome = nome;
        }

        /* O problema dessa classe é que ela tem duas responsabilidade
        de tratar as coisas do empregado e também de gerar relatório */
        public string Nome { get; set; }

        public void ExibirNome()
        {
            Console.WriteLine(Nome);
        }

        public void GerarRelatorio()
        {
            Console.WriteLine("Outra reponsabilidade do Empregado " + Nome);
        }
    }
}
