namespace SOLID.I.Errado
{
    public class Pinguim : IAve
    {
        public void Comer()
        {
            throw new NotImplementedException();
        }

        // Um método que não vai ser utilizado
        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
