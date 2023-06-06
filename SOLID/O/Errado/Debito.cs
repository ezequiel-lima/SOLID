namespace SOLID.O.Errado
{
    public class Debito
    {
        public void Debitar(int valor, TipoDebito tipo)
        {
            if (tipo == TipoDebito.Poupanca)
            {
                // Debita Poupanca
            }
            if (tipo == TipoDebito.ContaCorrente)
            {
                // Debita ContaCorrente
            }
        }
    }
}
