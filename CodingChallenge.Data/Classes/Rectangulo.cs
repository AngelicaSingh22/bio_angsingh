namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : IFormaRectanguloOperation
    {
        public decimal CalcularArea(decimal b, decimal h)
        {
            return b * h;
        }

        public decimal CalcularPerimetro(decimal a, decimal b, decimal c, decimal d)
        {
            return a + b + c + d;
        }
    }
}
